namespace HotelReserveAppWF
{
    partial class RoomBookingApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BookFromDTP = new DateTimePicker();
            BookToDTP = new DateTimePicker();
            TotalPeopleAmountNUD = new NumericUpDown();
            AdultsAmountNUD = new NumericUpDown();
            ChildrensAmountNUD = new NumericUpDown();
            RoomCategoryCB = new ComboBox();
            ViewAvailableRoomsBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FullNameTB = new TextBox();
            label8 = new Label();
            PhoneTB = new TextBox();
            EmailTB = new TextBox();
            label9 = new Label();
            label10 = new Label();
            BookRoomBtn = new Button();
            FindByUserTB = new TextBox();
            label12 = new Label();
            FindReserveByUserLB = new ListBox();
            FIndByUserBtn = new Button();
            UserDescriptionTB = new TextBox();
            label13 = new Label();
            InfantsAmountNUD = new NumericUpDown();
            AdditionalInfoTB = new TextBox();
            label14 = new Label();
            label15 = new Label();
            CancelOrderBtn = new Button();
            AvailableRoomsLB = new ListBox();
            FindByOrderBtn = new Button();
            FindReserveByOrderNumberLB = new ListBox();
            label16 = new Label();
            FindByOrderNumberTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)TotalPeopleAmountNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdultsAmountNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChildrensAmountNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfantsAmountNUD).BeginInit();
            SuspendLayout();
            // 
            // BookFromDTP
            // 
            BookFromDTP.Location = new Point(57, 68);
            BookFromDTP.MinDate = new DateTime(2023, 9, 20, 0, 0, 0, 0);
            BookFromDTP.Name = "BookFromDTP";
            BookFromDTP.Size = new Size(236, 23);
            BookFromDTP.TabIndex = 0;
            BookFromDTP.ValueChanged += BookFromDTP_ValueChanged;
            // 
            // BookToDTP
            // 
            BookToDTP.Location = new Point(342, 68);
            BookToDTP.Name = "BookToDTP";
            BookToDTP.Size = new Size(217, 23);
            BookToDTP.TabIndex = 1;
            // 
            // TotalPeopleAmountNUD
            // 
            TotalPeopleAmountNUD.Location = new Point(57, 136);
            TotalPeopleAmountNUD.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            TotalPeopleAmountNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TotalPeopleAmountNUD.Name = "TotalPeopleAmountNUD";
            TotalPeopleAmountNUD.Size = new Size(120, 23);
            TotalPeopleAmountNUD.TabIndex = 2;
            TotalPeopleAmountNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            TotalPeopleAmountNUD.ValueChanged += TotalPeopleAmountNUD_ValueChanged;
            // 
            // AdultsAmountNUD
            // 
            AdultsAmountNUD.Location = new Point(231, 136);
            AdultsAmountNUD.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            AdultsAmountNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AdultsAmountNUD.Name = "AdultsAmountNUD";
            AdultsAmountNUD.Size = new Size(98, 23);
            AdultsAmountNUD.TabIndex = 3;
            AdultsAmountNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            AdultsAmountNUD.ValueChanged += AdultsAmountNUD_ValueChanged;
            // 
            // ChildrensAmountNUD
            // 
            ChildrensAmountNUD.Location = new Point(367, 136);
            ChildrensAmountNUD.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            ChildrensAmountNUD.Name = "ChildrensAmountNUD";
            ChildrensAmountNUD.Size = new Size(94, 23);
            ChildrensAmountNUD.TabIndex = 4;
            // 
            // RoomCategoryCB
            // 
            RoomCategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            RoomCategoryCB.FormattingEnabled = true;
            RoomCategoryCB.Location = new Point(616, 68);
            RoomCategoryCB.Name = "RoomCategoryCB";
            RoomCategoryCB.Size = new Size(130, 23);
            RoomCategoryCB.TabIndex = 5;
            // 
            // ViewAvailableRoomsBtn
            // 
            ViewAvailableRoomsBtn.Location = new Point(625, 125);
            ViewAvailableRoomsBtn.Name = "ViewAvailableRoomsBtn";
            ViewAvailableRoomsBtn.Size = new Size(121, 40);
            ViewAvailableRoomsBtn.TabIndex = 6;
            ViewAvailableRoomsBtn.Text = "View available rooms";
            ViewAvailableRoomsBtn.UseVisualStyleBackColor = true;
            ViewAvailableRoomsBtn.Click += ViewAvailableRoomsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 7;
            label1.Text = "Book from:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 36);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Book to:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 36);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 9;
            label3.Text = "Room category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 108);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 10;
            label4.Text = "Amount of people:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 108);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Adults:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 108);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 12;
            label6.Text = "Childrens (4-17):";
            // 
            // FullNameTB
            // 
            FullNameTB.Enabled = false;
            FullNameTB.Location = new Point(57, 422);
            FullNameTB.Name = "FullNameTB";
            FullNameTB.Size = new Size(689, 23);
            FullNameTB.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 404);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 15;
            label8.Text = "Full Name:";
            // 
            // PhoneTB
            // 
            PhoneTB.Enabled = false;
            PhoneTB.Location = new Point(57, 478);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.Size = new Size(272, 23);
            PhoneTB.TabIndex = 16;
            // 
            // EmailTB
            // 
            EmailTB.Enabled = false;
            EmailTB.Location = new Point(433, 478);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(313, 23);
            EmailTB.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 460);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 18;
            label9.Text = "Phone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(433, 460);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 19;
            label10.Text = "Email";
            // 
            // BookRoomBtn
            // 
            BookRoomBtn.Enabled = false;
            BookRoomBtn.Location = new Point(616, 525);
            BookRoomBtn.Name = "BookRoomBtn";
            BookRoomBtn.Size = new Size(130, 23);
            BookRoomBtn.TabIndex = 22;
            BookRoomBtn.Text = "Book room";
            BookRoomBtn.UseVisualStyleBackColor = true;
            BookRoomBtn.Click += BookRoomBtn_Click;
            // 
            // FindByUserTB
            // 
            FindByUserTB.Location = new Point(790, 68);
            FindByUserTB.Name = "FindByUserTB";
            FindByUserTB.Size = new Size(383, 23);
            FindByUserTB.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(790, 36);
            label12.Name = "label12";
            label12.Size = new Size(155, 15);
            label12.TabIndex = 27;
            label12.Text = "Find reserve by user's name:";
            // 
            // FindReserveByUserLB
            // 
            FindReserveByUserLB.FormattingEnabled = true;
            FindReserveByUserLB.HorizontalScrollbar = true;
            FindReserveByUserLB.ItemHeight = 15;
            FindReserveByUserLB.Location = new Point(790, 151);
            FindReserveByUserLB.Name = "FindReserveByUserLB";
            FindReserveByUserLB.ScrollAlwaysVisible = true;
            FindReserveByUserLB.Size = new Size(383, 64);
            FindReserveByUserLB.TabIndex = 28;
            // 
            // FIndByUserBtn
            // 
            FIndByUserBtn.Location = new Point(1058, 104);
            FIndByUserBtn.Name = "FIndByUserBtn";
            FIndByUserBtn.Size = new Size(115, 23);
            FIndByUserBtn.TabIndex = 29;
            FIndByUserBtn.Text = "Find";
            FIndByUserBtn.UseVisualStyleBackColor = true;
            FIndByUserBtn.Click += FIndByUserBtn_Click;
            // 
            // UserDescriptionTB
            // 
            UserDescriptionTB.Location = new Point(790, 478);
            UserDescriptionTB.Multiline = true;
            UserDescriptionTB.Name = "UserDescriptionTB";
            UserDescriptionTB.ScrollBars = ScrollBars.Vertical;
            UserDescriptionTB.Size = new Size(383, 191);
            UserDescriptionTB.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(485, 108);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 32;
            label13.Text = "Infants (0-3):";
            // 
            // InfantsAmountNUD
            // 
            InfantsAmountNUD.Location = new Point(487, 136);
            InfantsAmountNUD.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            InfantsAmountNUD.Name = "InfantsAmountNUD";
            InfantsAmountNUD.Size = new Size(94, 23);
            InfantsAmountNUD.TabIndex = 31;
            // 
            // AdditionalInfoTB
            // 
            AdditionalInfoTB.Enabled = false;
            AdditionalInfoTB.Location = new Point(57, 596);
            AdditionalInfoTB.Multiline = true;
            AdditionalInfoTB.Name = "AdditionalInfoTB";
            AdditionalInfoTB.Size = new Size(689, 105);
            AdditionalInfoTB.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(57, 569);
            label14.Name = "label14";
            label14.Size = new Size(149, 15);
            label14.TabIndex = 34;
            label14.Text = "Additional info (if needed):";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(790, 451);
            label15.Name = "label15";
            label15.Size = new Size(102, 15);
            label15.TabIndex = 35;
            label15.Text = "Order description:";
            // 
            // CancelOrderBtn
            // 
            CancelOrderBtn.Location = new Point(1058, 678);
            CancelOrderBtn.Name = "CancelOrderBtn";
            CancelOrderBtn.Size = new Size(115, 23);
            CancelOrderBtn.TabIndex = 36;
            CancelOrderBtn.Text = "Cancel order";
            CancelOrderBtn.UseVisualStyleBackColor = true;
            // 
            // AvailableRoomsLB
            // 
            AvailableRoomsLB.Enabled = false;
            AvailableRoomsLB.FormattingEnabled = true;
            AvailableRoomsLB.HorizontalScrollbar = true;
            AvailableRoomsLB.ImeMode = ImeMode.Off;
            AvailableRoomsLB.ItemHeight = 15;
            AvailableRoomsLB.Location = new Point(57, 185);
            AvailableRoomsLB.Name = "AvailableRoomsLB";
            AvailableRoomsLB.Size = new Size(689, 199);
            AvailableRoomsLB.Sorted = true;
            AvailableRoomsLB.TabIndex = 37;
            // 
            // FindByOrderBtn
            // 
            FindByOrderBtn.Location = new Point(1058, 298);
            FindByOrderBtn.Name = "FindByOrderBtn";
            FindByOrderBtn.Size = new Size(115, 23);
            FindByOrderBtn.TabIndex = 41;
            FindByOrderBtn.Text = "Find";
            FindByOrderBtn.UseVisualStyleBackColor = true;
            // 
            // FindReserveByOrderNumberLB
            // 
            FindReserveByOrderNumberLB.FormattingEnabled = true;
            FindReserveByOrderNumberLB.HorizontalScrollbar = true;
            FindReserveByOrderNumberLB.ItemHeight = 15;
            FindReserveByOrderNumberLB.Location = new Point(790, 345);
            FindReserveByOrderNumberLB.Name = "FindReserveByOrderNumberLB";
            FindReserveByOrderNumberLB.ScrollAlwaysVisible = true;
            FindReserveByOrderNumberLB.Size = new Size(383, 64);
            FindReserveByOrderNumberLB.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(790, 230);
            label16.Name = "label16";
            label16.Size = new Size(165, 15);
            label16.TabIndex = 39;
            label16.Text = "Find reserve by order number:";
            // 
            // FindByOrderNumberTB
            // 
            FindByOrderNumberTB.Location = new Point(790, 262);
            FindByOrderNumberTB.Name = "FindByOrderNumberTB";
            FindByOrderNumberTB.Size = new Size(383, 23);
            FindByOrderNumberTB.TabIndex = 38;
            // 
            // RoomBookingApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 743);
            Controls.Add(FindByOrderBtn);
            Controls.Add(FindReserveByOrderNumberLB);
            Controls.Add(label16);
            Controls.Add(FindByOrderNumberTB);
            Controls.Add(AvailableRoomsLB);
            Controls.Add(CancelOrderBtn);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(AdditionalInfoTB);
            Controls.Add(label13);
            Controls.Add(InfantsAmountNUD);
            Controls.Add(UserDescriptionTB);
            Controls.Add(FIndByUserBtn);
            Controls.Add(FindReserveByUserLB);
            Controls.Add(label12);
            Controls.Add(FindByUserTB);
            Controls.Add(BookRoomBtn);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(EmailTB);
            Controls.Add(PhoneTB);
            Controls.Add(label8);
            Controls.Add(FullNameTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ViewAvailableRoomsBtn);
            Controls.Add(RoomCategoryCB);
            Controls.Add(ChildrensAmountNUD);
            Controls.Add(AdultsAmountNUD);
            Controls.Add(TotalPeopleAmountNUD);
            Controls.Add(BookToDTP);
            Controls.Add(BookFromDTP);
            MinimumSize = new Size(1201, 782);
            Name = "RoomBookingApp";
            Text = "Form1";
            FormClosing += RoomBookingApp_FormClosing;
            Load += RoomBookingApp_Load;
            ((System.ComponentModel.ISupportInitialize)TotalPeopleAmountNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdultsAmountNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChildrensAmountNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfantsAmountNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker BookFromDTP;
        private DateTimePicker BookToDTP;
        private NumericUpDown TotalPeopleAmountNUD;
        private NumericUpDown AdultsAmountNUD;
        private NumericUpDown ChildrensAmountNUD;
        private ComboBox RoomCategoryCB;
        private Button ViewAvailableRoomsBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox FullNameTB;
        private Label label8;
        private TextBox PhoneTB;
        private TextBox EmailTB;
        private Label label9;
        private Label label10;
        private Button BookRoomBtn;
        private TextBox FindByUserTB;
        private Label label12;
        private ListBox FindReserveByUserLB;
        private Button FIndByUserBtn;
        private TextBox UserDescriptionTB;
        private Label label13;
        private NumericUpDown InfantsAmountNUD;
        private TextBox AdditionalInfoTB;
        private Label label14;
        private Label label15;
        private Button CancelOrderBtn;
        private ListBox AvailableRoomsLB;
        private Button FindByOrderBtn;
        private ListBox FindReserveByOrderNumberLB;
        private Label label16;
        private TextBox FindByOrderNumberTB;
    }
}