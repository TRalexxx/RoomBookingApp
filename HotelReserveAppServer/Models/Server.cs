using HotelReserveAppServer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HotelReserveAppServer.Models
{
    public class Server
    {
        private IPEndPoint _ipEndp { get; set; }
        private Socket _socket { get; set; }

        ApplicationDbContext _context { get; set; }

        public Server(string addresStr, int port)
        {
            _ipEndp = new IPEndPoint(IPAddress.Parse(addresStr), port);

            _context = new ApplicationDbContext();
        }

        void MyAcceptCallbackFunction(IAsyncResult ia)
        {
            try
            {
                Socket ns = (Socket)ia.AsyncState;
                Socket clientSocket = ns.EndAccept(ia);
                Console.WriteLine(ns.LocalEndPoint.ToString());
                while (true)
                {

                    byte[] bytes = new byte[1024];

                    int l = clientSocket.Receive(bytes);
                    Console.WriteLine($"Request recieved from {ns.LocalEndPoint}");


                    if (l > 0)
                    {
                        string recieveStr = Encoding.Unicode.GetString(bytes, 0, l);
                        var recieveRequest = JsonSerializer.Deserialize<Request>(recieveStr);

                        if (recieveRequest != null && recieveRequest.RequestType == Enums.RequestType.CheckFreeRooms)
                        {
                            if (recieveRequest.Parameters != null)
                            {
                                var rooms = CheckAvailableRooms(recieveRequest.Parameters);

                                var sendRequest = new Request
                                {
                                    RequestType = Enums.RequestType.CheckFreeRooms,

                                    Rooms = rooms,
                                };

                                string sendStr = JsonSerializer.Serialize(sendRequest);


                                clientSocket.Send(Encoding.Unicode.GetBytes(sendStr));
                                Console.WriteLine($"Data sended to {ns.LocalEndPoint}");

                                
                            }
                            else
                            {
                                Console.WriteLine("Wrong request!");
                            }
                        }
                        if(recieveRequest != null && recieveRequest.RequestType == Enums.RequestType.CloseApp)
                        {
                            clientSocket.Shutdown(SocketShutdown.Both);
                            clientSocket.Close();

                            break;
                        }

                    }

                    ns.BeginAccept(new AsyncCallback(MyAcceptCallbackFunction), ns);

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw;
            }
            

        }

        public void StartServer()
        {
            if (_socket != null)
            {
                return;
            }

            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _socket.Bind(_ipEndp);
            _socket.Listen(10);

            Console.WriteLine("Server started");

            _socket.BeginAccept(new AsyncCallback(MyAcceptCallbackFunction), _socket);
        }

        private List<Room> CheckAvailableRooms(RoomRequestParameters roomParams)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<Room> rooms = context.Rooms.Where(x => x.MaxAmountOfPeople >= roomParams.AmountofPeople && x.Class.Equals(roomParams.Category)).ToList();

                List<Room> availabeRooms = new List<Room>();

                bool isFree = false;

                if (rooms.Count > 0 && rooms != null)
                {
                    foreach (Room room in rooms)
                    {
                        if (room.ReservedDates != null && room.ReservedDates.Count > 0)
                        {
                            isFree = true;

                            foreach (var item in room.ReservedDates)
                            {
                                if ((roomParams.ReserveFrom >= item.StartBookDate && roomParams.ReserveFrom <= item.EndBookDate) ||
                                    (roomParams.ReserveTo >= item.StartBookDate && roomParams.ReserveTo <= item.EndBookDate))
                                {
                                    isFree = false;
                                    break;
                                }

                            }
                            if (isFree) availabeRooms.Add(room);

                        }
                        else
                        {
                            availabeRooms.Add(room);
                        }

                    }
                }
                return availabeRooms;
            }
        }

    }
}
