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
            label7 = new Label();
            FullNameTB = new TextBox();
            label8 = new Label();
            PhoneTB = new TextBox();
            EmailTB = new TextBox();
            label9 = new Label();
            label10 = new Label();
            PaymentTypeCB = new ComboBox();
            label11 = new Label();
            BookRoomBtn = new Button();
            LoginTB = new TextBox();
            PasswordTB = new TextBox();
            LogInBtn = new Button();
            FindUserTB = new TextBox();
            label12 = new Label();
            FindUserLB = new ListBox();
            FIndUserBtn = new Button();
            UserDescriptionTB = new TextBox();
            label13 = new Label();
            InfantsAmountNUD = new NumericUpDown();
            AdditionalInfoTB = new TextBox();
            label14 = new Label();
            label15 = new Label();
            SaveUserDescriptionBtn = new Button();
            AvailableRoomsLB = new ListBox();
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
            BookFromDTP.Size = new Size(200, 23);
            BookFromDTP.TabIndex = 0;
            BookFromDTP.ValueChanged += BookFromDTP_ValueChanged;
            // 
            // BookToDTP
            // 
            BookToDTP.Location = new Point(318, 68);
            BookToDTP.Name = "BookToDTP";
            BookToDTP.Size = new Size(200, 23);
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
            AdultsAmountNUD.Location = new Point(221, 136);
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
            ChildrensAmountNUD.Location = new Point(342, 136);
            ChildrensAmountNUD.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            ChildrensAmountNUD.Name = "ChildrensAmountNUD";
            ChildrensAmountNUD.Size = new Size(94, 23);
            ChildrensAmountNUD.TabIndex = 4;
            // 
            // RoomCategoryCB
            // 
            RoomCategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            RoomCategoryCB.FormattingEnabled = true;
            RoomCategoryCB.Location = new Point(579, 68);
            RoomCategoryCB.Name = "RoomCategoryCB";
            RoomCategoryCB.Size = new Size(130, 23);
            RoomCategoryCB.TabIndex = 5;
            // 
            // ViewAvailableRoomsBtn
            // 
            ViewAvailableRoomsBtn.Location = new Point(579, 125);
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
            label2.Location = new Point(318, 36);
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
            label5.Location = new Point(221, 108);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Adults:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(342, 108);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 12;
            label6.Text = "Childrens (4-17):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 200);
            label7.Name = "label7";
            label7.Size = new Size(183, 15);
            label7.TabIndex = 13;
            label7.Text = "No available rooms for this dates.";
            label7.Visible = false;
            // 
            // FullNameTB
            // 
            FullNameTB.Enabled = false;
            FullNameTB.Location = new Point(57, 422);
            FullNameTB.Name = "FullNameTB";
            FullNameTB.Size = new Size(652, 23);
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
            EmailTB.Size = new Size(276, 23);
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
            // PaymentTypeCB
            // 
            PaymentTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentTypeCB.Enabled = false;
            PaymentTypeCB.FormattingEnabled = true;
            PaymentTypeCB.Location = new Point(57, 533);
            PaymentTypeCB.Name = "PaymentTypeCB";
            PaymentTypeCB.Size = new Size(169, 23);
            PaymentTypeCB.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(57, 515);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 21;
            label11.Text = "Payment type:";
            // 
            // BookRoomBtn
            // 
            BookRoomBtn.Enabled = false;
            BookRoomBtn.Location = new Point(570, 532);
            BookRoomBtn.Name = "BookRoomBtn";
            BookRoomBtn.Size = new Size(130, 23);
            BookRoomBtn.TabIndex = 22;
            BookRoomBtn.Text = "Book room";
            BookRoomBtn.UseVisualStyleBackColor = true;
            // 
            // LoginTB
            // 
            LoginTB.Location = new Point(992, 28);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(181, 23);
            LoginTB.TabIndex = 23;
            LoginTB.Text = "login";
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(992, 71);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(181, 23);
            PasswordTB.TabIndex = 24;
            PasswordTB.Text = "password";
            // 
            // LogInBtn
            // 
            LogInBtn.Location = new Point(1098, 108);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(75, 23);
            LogInBtn.TabIndex = 25;
            LogInBtn.Text = "Log in";
            LogInBtn.UseVisualStyleBackColor = true;
            // 
            // FindUserTB
            // 
            FindUserTB.Location = new Point(842, 172);
            FindUserTB.Name = "FindUserTB";
            FindUserTB.Size = new Size(331, 23);
            FindUserTB.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(842, 144);
            label12.Name = "label12";
            label12.Size = new Size(107, 15);
            label12.TabIndex = 27;
            label12.Text = "Find user by name:";
            // 
            // FindUserLB
            // 
            FindUserLB.FormattingEnabled = true;
            FindUserLB.HorizontalScrollbar = true;
            FindUserLB.ItemHeight = 15;
            FindUserLB.Location = new Point(842, 230);
            FindUserLB.Name = "FindUserLB";
            FindUserLB.ScrollAlwaysVisible = true;
            FindUserLB.Size = new Size(331, 94);
            FindUserLB.TabIndex = 28;
            // 
            // FIndUserBtn
            // 
            FIndUserBtn.Location = new Point(1058, 201);
            FIndUserBtn.Name = "FIndUserBtn";
            FIndUserBtn.Size = new Size(115, 23);
            FIndUserBtn.TabIndex = 29;
            FIndUserBtn.Text = "Find";
            FIndUserBtn.UseVisualStyleBackColor = true;
            // 
            // UserDescriptionTB
            // 
            UserDescriptionTB.Location = new Point(842, 365);
            UserDescriptionTB.Multiline = true;
            UserDescriptionTB.Name = "UserDescriptionTB";
            UserDescriptionTB.ScrollBars = ScrollBars.Vertical;
            UserDescriptionTB.Size = new Size(331, 304);
            UserDescriptionTB.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(461, 108);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 32;
            label13.Text = "Infants (0-3):";
            // 
            // InfantsAmountNUD
            // 
            InfantsAmountNUD.Location = new Point(461, 136);
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
            AdditionalInfoTB.Size = new Size(652, 105);
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
            label15.Location = new Point(842, 335);
            label15.Name = "label15";
            label15.Size = new Size(95, 15);
            label15.TabIndex = 35;
            label15.Text = "User description:";
            // 
            // SaveUserDescriptionBtn
            // 
            SaveUserDescriptionBtn.Location = new Point(1098, 678);
            SaveUserDescriptionBtn.Name = "SaveUserDescriptionBtn";
            SaveUserDescriptionBtn.Size = new Size(75, 23);
            SaveUserDescriptionBtn.TabIndex = 36;
            SaveUserDescriptionBtn.Text = "Save";
            SaveUserDescriptionBtn.UseVisualStyleBackColor = true;
            // 
            // AvailableRoomsLB
            // 
            AvailableRoomsLB.Enabled = false;
            AvailableRoomsLB.FormattingEnabled = true;
            AvailableRoomsLB.ItemHeight = 15;
            AvailableRoomsLB.Location = new Point(57, 230);
            AvailableRoomsLB.Name = "AvailableRoomsLB";
            AvailableRoomsLB.Size = new Size(643, 154);
            AvailableRoomsLB.TabIndex = 37;
            // 
            // RoomBookingApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 743);
            Controls.Add(AvailableRoomsLB);
            Controls.Add(SaveUserDescriptionBtn);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(AdditionalInfoTB);
            Controls.Add(label13);
            Controls.Add(InfantsAmountNUD);
            Controls.Add(UserDescriptionTB);
            Controls.Add(FIndUserBtn);
            Controls.Add(FindUserLB);
            Controls.Add(label12);
            Controls.Add(FindUserTB);
            Controls.Add(LogInBtn);
            Controls.Add(PasswordTB);
            Controls.Add(LoginTB);
            Controls.Add(BookRoomBtn);
            Controls.Add(label11);
            Controls.Add(PaymentTypeCB);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(EmailTB);
            Controls.Add(PhoneTB);
            Controls.Add(label8);
            Controls.Add(FullNameTB);
            Controls.Add(label7);
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
        private Label label7;
        private TextBox FullNameTB;
        private Label label8;
        private TextBox PhoneTB;
        private TextBox EmailTB;
        private Label label9;
        private Label label10;
        private ComboBox PaymentTypeCB;
        private Label label11;
        private Button BookRoomBtn;
        private TextBox LoginTB;
        private TextBox PasswordTB;
        private Button LogInBtn;
        private TextBox FindUserTB;
        private Label label12;
        private ListBox FindUserLB;
        private Button FIndUserBtn;
        private TextBox UserDescriptionTB;
        private Label label13;
        private NumericUpDown InfantsAmountNUD;
        private TextBox AdditionalInfoTB;
        private Label label14;
        private Label label15;
        private Button SaveUserDescriptionBtn;
        private ListBox AvailableRoomsLB;
    }
}