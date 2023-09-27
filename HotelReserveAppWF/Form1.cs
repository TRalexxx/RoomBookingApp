using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using HotelReserveAppWF.Models;
using HotelReserveAppWF.Enums;
using Bogus;
using Newtonsoft.Json;
using Bogus.DataSets;

namespace HotelReserveAppWF
{
    public partial class RoomBookingApp : Form
    {

        const int PORT = 4444;
        const string IP = "127.0.0.1";
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        List<Room> _rooms = new List<Room>();
        List<RoomReserve> _reserves = new List<RoomReserve>();
        List<User> _users = new List<User>();

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

                var requestStr = JsonConvert.SerializeObject(request);

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

                    var requestRecieve = JsonConvert.DeserializeObject<Request>(data);

                    if (requestRecieve != null && requestRecieve.Rooms != null && requestRecieve.Rooms.Count > 0)
                    {
                        MessageBox.Show($"You can reserve room", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FullNameTB.Enabled = true;
                        PhoneTB.Enabled = true;
                        EmailTB.Enabled = true;
                        AdditionalInfoTB.Enabled = true;
                        AvailableRoomsLB.Enabled = true;
                        BookRoomBtn.Enabled = true;

                        AvailableRoomsLB.Items.Clear();
                        foreach (var room in requestRecieve.Rooms)
                        {
                            AvailableRoomsLB.Items.Add($"{room.Number}\t{room.Class}\t{room.MaxAmountOfPeople}\t{room.Description}");
                        }
                        AvailableRoomsLB.SelectedIndex = 0;
                        _rooms = requestRecieve.Rooms.ToList();
                    }

                }
                else
                {
                    MessageBox.Show($"No rooms available", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string requestStr = JsonConvert.SerializeObject(request);

            socket.Send(Encoding.Unicode.GetBytes(requestStr));

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private async void BookRoomBtn_Click(object sender, EventArgs e)
        {
            var faker = new Faker();
            var room = new Room();
            if (AvailableRoomsLB.SelectedItem != null)
            {
                room = _rooms.FirstOrDefault(x => x.Number.ToString().Equals(AvailableRoomsLB.SelectedItem.ToString().Substring(0, 3)));
            }
            else
            {
                MessageBox.Show($"You need to select room", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var user = new User();
            if (FullNameTB.Text.Trim().Length > 5 && PhoneTB.Text.Trim().Length > 5)
            {
                user.Id = faker.Random.Guid();
                user.Name = FullNameTB.Text;
                user.Email = EmailTB.Text;
                user.Phone = PhoneTB.Text;
            }
            else
            {
                MessageBox.Show($"You need to enter user's name and phone", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var reserve = new RoomReserve();
            if (room != null && room.Id > 0 && user.Name.Length > 5)
            {
                reserve.ReserveNumber = faker.Random.Number(100000000, 999999999);
                reserve.RoomId = room.Id;
                reserve.UserId = user.Id;
                reserve.AdditionalInfo = AdditionalInfoTB.Text;
                reserve.StartBookDate = BookFromDTP.Value;
                reserve.EndBookDate = BookToDTP.Value;

            }
            else
            {
                MessageBox.Show($"You need to select room and enter user's name and phone", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var request = new Request
            {
                RequestType = RequestType.BookRoom,
                Users = new List<User>() { user },
                Reserves = new List<RoomReserve>() { reserve }
            };

            try
            {
                var requestStr = JsonConvert.SerializeObject(request);

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

                    var requestRecieve = JsonConvert.DeserializeObject<Request>(data);

                    if (requestRecieve != null && requestRecieve.RequestType == RequestType.RoomReserved)
                    {
                        MessageBox.Show($"You reserved room\nReserve details:\nReserve number: {reserve.ReserveNumber}\nReserve dates: {reserve.StartBookDate.Date} - {reserve.EndBookDate.Date}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FullNameTB.Enabled = false;
                        FullNameTB.Text = string.Empty;

                        PhoneTB.Enabled = false;
                        PhoneTB.Text = string.Empty;

                        EmailTB.Enabled = false;
                        EmailTB.Text = string.Empty;

                        AdditionalInfoTB.Enabled = false;
                        AdditionalInfoTB.Text = string.Empty;

                        AvailableRoomsLB.Enabled = false;
                        AvailableRoomsLB.Items.Clear();

                        BookRoomBtn.Enabled = false;

                    }
                    else if (requestRecieve != null && requestRecieve.RequestType == RequestType.ServerError)
                    {
                        MessageBox.Show($"Server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show($"{ex.Message}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //socket.Close();
            }
        }

        private async void FIndByUserBtn_Click(object sender, EventArgs e)
        {
            var faker = new Faker();

            var user = new User();
            if (FindByUserTB.Text.Trim().Length > 5)
            {
                user.Id = faker.Random.Guid();
                user.Name = FindByUserTB.Text;
            }
            else
            {
                MessageBox.Show($"You need to enter user's name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var request = new Request
            {
                RequestType = RequestType.FindOrderByUser,
                Users = new List<User>() { user },
            };

            try
            {
                var requestStr = JsonConvert.SerializeObject(request);

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

                    var requestRecieve = JsonConvert.DeserializeObject<Request>(data);

                    if (requestRecieve != null && requestRecieve.RequestType == RequestType.FindOrderByUser)
                    {
                        if (requestRecieve.Reserves != null && requestRecieve.Reserves.Count > 0)
                        {
                            FindReservesLB.Items.Clear();
                            _reserves.Clear();

                            foreach (var reserve in requestRecieve.Reserves)
                            {
                                if (reserve.User != null)
                                    FindReservesLB.Items.Add($"{reserve.ReserveNumber} - {reserve.User.Name} ({reserve.StartBookDate.ToShortDateString()} - {reserve.EndBookDate.ToShortDateString()})");
                                else
                                    FindReservesLB.Items.Add($"{reserve.ReserveNumber} ({reserve.StartBookDate.Date} - {reserve.EndBookDate.Date}");
                                
                                _reserves.Add(reserve);
                            }


                            FindReservesLB.SelectedIndex = 0;
                        }
                    }
                    else if (requestRecieve != null && requestRecieve.RequestType == RequestType.UserNotFound)
                    {
                        MessageBox.Show($"User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (requestRecieve != null && requestRecieve.RequestType == RequestType.ReservesNotFound)
                    {
                        MessageBox.Show($"Reserves not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (requestRecieve != null && requestRecieve.RequestType == RequestType.ServerError)
                    {
                        MessageBox.Show($"Server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show($"{ex.Message}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //socket.Close();
            }
        }

        private async void FindByOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var findReserve = new RoomReserve
                {
                    ReserveNumber = (int)FindByOrderNumberNUD.Value,
                };

                var request = new Request
                {
                    RequestType = RequestType.FindOrderByNumber,

                    Reserves = new List<RoomReserve> { findReserve }
                };

                var requestStr = JsonConvert.SerializeObject(request);

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

                    var requestRecieve = JsonConvert.DeserializeObject<Request>(data);

                    if (requestRecieve != null && requestRecieve.RequestType == RequestType.FindOrderByNumber)
                    {
                        if (requestRecieve.Reserves != null && requestRecieve.Reserves.Count > 0)
                        {
                            FindReservesLB.Items.Clear();
                            _reserves.Clear();

                            foreach (var reserve in requestRecieve.Reserves)
                            {
                                if (reserve.User != null)
                                    FindReservesLB.Items.Add($"{reserve.ReserveNumber} - {reserve.User.Name} ({reserve.StartBookDate.ToShortDateString()} - {reserve.EndBookDate.ToShortDateString()})");
                                else
                                    FindReservesLB.Items.Add($"{reserve.ReserveNumber} ({reserve.StartBookDate.Date} - {reserve.EndBookDate.Date}");

                                _reserves.Add(reserve);
                            }

                            FindReservesLB.SelectedIndex = 0;
                        }
                    }
                    else if (requestRecieve != null && requestRecieve.RequestType == RequestType.ReservesNotFound)
                    {
                        MessageBox.Show($"Reserve not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (requestRecieve != null && requestRecieve.RequestType == RequestType.ServerError)
                    {
                        MessageBox.Show($"Server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show($"{ex.Message}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //socket.Close();
            }
        }

        private void FindReservesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderDescriptionTB.Text = string.Empty;
            var reserve = new RoomReserve();
            if (FindReservesLB.SelectedItem != null)
            {
                reserve = _reserves.FirstOrDefault(x => x.ReserveNumber.Equals(Int32.Parse(FindReservesLB.SelectedItem.ToString().Substring(0, 9))));
            }
            if(reserve != null && reserve.User != null && reserve.Room != null)
            {
                OrderDescriptionTB.AppendText($"Order number: {reserve.ReserveNumber}");
                OrderDescriptionTB.AppendText(Environment.NewLine);
                OrderDescriptionTB.AppendText($"Room: {reserve.Room.Number}");
                OrderDescriptionTB.AppendText(Environment.NewLine);
                OrderDescriptionTB.AppendText($"Room class: {reserve.Room.Class}");
                OrderDescriptionTB.AppendText(Environment.NewLine);
                OrderDescriptionTB.AppendText($"Book from: {reserve.StartBookDate.ToShortDateString()}");
                OrderDescriptionTB.AppendText(Environment.NewLine);
                OrderDescriptionTB.AppendText($"Book to: {reserve.EndBookDate.ToShortDateString()}");
                OrderDescriptionTB.AppendText(Environment.NewLine);
                OrderDescriptionTB.AppendText($"User name: {reserve.User.Name}");
                OrderDescriptionTB.AppendText(Environment.NewLine);
                OrderDescriptionTB.AppendText($"User phone: {reserve.User.Phone}");
                OrderDescriptionTB.AppendText(Environment.NewLine);
                OrderDescriptionTB.AppendText($"User email: {reserve.User.Email}");
                OrderDescriptionTB.AppendText(Environment.NewLine);
                OrderDescriptionTB.AppendText($"Additional info: {reserve.AdditionalInfo}");

            }
        }
    }
}