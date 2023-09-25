using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using HotelReserveAppWF.Models;
using HotelReserveAppWF.Enums;

namespace HotelReserveAppWF
{
    public partial class RoomBookingApp : Form
    {

        const int PORT = 4444;
        const string IP = "127.0.0.1";
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        List<Room> Rooms = new List<Room>();
        List<ReserveDateInterval> Reserves = new List<ReserveDateInterval>();
        List<User> Users = new List<User>();

        public RoomBookingApp()
        {
            InitializeComponent();

            BookFromDTP.MinDate = DateTime.Now;
            BookToDTP.MinDate = DateTime.Now.AddDays(1);
            BookFromDTP.MaxDate = DateTime.Now.AddMonths(2);
            BookToDTP.MaxDate = DateTime.Now.AddMonths(3);

            foreach (var item in Enum.GetValues(typeof(RoomCategory)))
            {
                RoomCategoryCB.Items.Add(item);
            }
            RoomCategoryCB.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(PaymentType)))
            {
                PaymentTypeCB.Items.Add(item);
            }
            PaymentTypeCB.SelectedIndex = 0;
        }

        private void BookFromDTP_ValueChanged(object sender, EventArgs e)
        {
            BookToDTP.MinDate = BookFromDTP.Value.AddDays(1);
        }

        private async void ViewAvailableRoomsBtn_Click(object sender, EventArgs e)
        {
            var roomParams = new RoomRequestParameters
            {
                AmountofPeople = (int)TotalPeopleAmountNUD.Value,
                Category = (RoomCategory)Enum.Parse(typeof(RoomCategory), RoomCategoryCB.SelectedItem.ToString()),
                ReserveFrom = BookFromDTP.Value,
                ReserveTo = BookToDTP.Value,
            };

            var request = new Request
            {
                RequestType = RequestType.CheckFreeRooms,

                Parameters = roomParams
            };

            try
            {


                var requestStr = JsonSerializer.Serialize(request);

                socket.Send(Encoding.Unicode.GetBytes(requestStr));

                byte[] buffer = new byte[1024];
                string data = "";

                do
                {
                    int l = await socket.ReceiveAsync(buffer, SocketFlags.None);
                    data += Encoding.Unicode.GetString(buffer, 0, l);

                    if (l < 1024)
                        break;
                }
                while (true);

                if (data.Length > 0)
                {

                    var requestRecieve = JsonSerializer.Deserialize<Request>(data);

                    if (requestRecieve != null && requestRecieve.Rooms != null && requestRecieve.Rooms.Count > 0)
                    {
                        MessageBox.Show($"You can reserve room", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FullNameTB.Enabled = true;
                        PhoneTB.Enabled = true;
                        EmailTB.Enabled = true;
                        AdditionalInfoTB.Enabled = true;
                        PaymentTypeCB.Enabled = true;
                        AvailableRoomsLB.Enabled = true;

                        AvailableRoomsLB.Items.Clear();
                        foreach (var room in requestRecieve.Rooms)
                        {
                            AvailableRoomsLB.Items.Add($"{room.Number}\t{room.Class}\t{room.MaxAmountOfPeople}\t{room.Description}");
                        }

                        Rooms = requestRecieve.Rooms.ToList();
                    }                    

                }
                else
                {
                    MessageBox.Show($"Something goes wrong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //socket.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //socket.Close();
            }
        }

        private void TotalPeopleAmountNUD_ValueChanged(object sender, EventArgs e)
        {
            AdultsAmountNUD.Maximum = TotalPeopleAmountNUD.Value;
            ChildrensAmountNUD.Maximum = TotalPeopleAmountNUD.Value - AdultsAmountNUD.Value;
            ChildrensAmountNUD.Value = 0;
        }

        private void AdultsAmountNUD_ValueChanged(object sender, EventArgs e)
        {
            ChildrensAmountNUD.Maximum = TotalPeopleAmountNUD.Value - AdultsAmountNUD.Value;
            if (ChildrensAmountNUD.Value > ChildrensAmountNUD.Maximum)
            {
                ChildrensAmountNUD.Value = ChildrensAmountNUD.Maximum;
            }
        }


        private async void RoomBookingApp_Load(object sender, EventArgs e)
        {
            await socket.ConnectAsync(IP, PORT);

            
        }

        private void RoomBookingApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            var request = new Request
            {
                RequestType = RequestType.CloseApp
            };
            string requestStr = JsonSerializer.Serialize(request);

            socket.Send(Encoding.Unicode.GetBytes(requestStr));

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}