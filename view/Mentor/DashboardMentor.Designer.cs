namespace mentoring_system.view
{
    partial class DashboardMentor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMentor));
            NavBar = new Panel();
            button1 = new Button();
            LogOutBtn = new Button();
            YourClassBtn = new Button();
            Dropdown = new Panel();
            RequestsBtn = new Button();
            ScheduleBtn = new Button();
            AppointmentBtn = new Button();
            HomeBtn = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            userName = new Label();
            mentorSchedule2 = new Mentor.MentorSchedule();
            panel4 = new Panel();
            requests1 = new Mentor.Requests();
            NavBar.SuspendLayout();
            Dropdown.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // NavBar
            // 
            NavBar.AutoScroll = true;
            NavBar.BackColor = SystemColors.ActiveBorder;
            NavBar.Controls.Add(button1);
            NavBar.Controls.Add(LogOutBtn);
            NavBar.Controls.Add(YourClassBtn);
            NavBar.Controls.Add(Dropdown);
            NavBar.Controls.Add(AppointmentBtn);
            NavBar.Controls.Add(HomeBtn);
            NavBar.Controls.Add(panel2);
            NavBar.Dock = DockStyle.Left;
            NavBar.Location = new Point(0, 0);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(273, 653);
            NavBar.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 337);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(273, 48);
            button1.TabIndex = 6;
            button1.Text = "Your Profile";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Dock = DockStyle.Bottom;
            LogOutBtn.FlatAppearance.BorderSize = 0;
            LogOutBtn.FlatAppearance.MouseOverBackColor = Color.Aqua;
            LogOutBtn.FlatStyle = FlatStyle.Flat;
            LogOutBtn.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            LogOutBtn.ForeColor = Color.Crimson;
            LogOutBtn.Location = new Point(0, 605);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Padding = new Padding(15, 0, 0, 0);
            LogOutBtn.Size = new Size(273, 48);
            LogOutBtn.TabIndex = 5;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // YourClassBtn
            // 
            YourClassBtn.Dock = DockStyle.Top;
            YourClassBtn.FlatAppearance.BorderSize = 0;
            YourClassBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            YourClassBtn.FlatStyle = FlatStyle.Flat;
            YourClassBtn.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            YourClassBtn.ForeColor = SystemColors.Control;
            YourClassBtn.Location = new Point(0, 289);
            YourClassBtn.Name = "YourClassBtn";
            YourClassBtn.Padding = new Padding(15, 0, 0, 0);
            YourClassBtn.Size = new Size(273, 48);
            YourClassBtn.TabIndex = 3;
            YourClassBtn.Text = "Your Class";
            YourClassBtn.TextAlign = ContentAlignment.MiddleLeft;
            YourClassBtn.UseVisualStyleBackColor = true;
            // 
            // Dropdown
            // 
            Dropdown.BackColor = SystemColors.ButtonHighlight;
            Dropdown.Controls.Add(RequestsBtn);
            Dropdown.Controls.Add(ScheduleBtn);
            Dropdown.Dock = DockStyle.Top;
            Dropdown.Location = new Point(0, 196);
            Dropdown.Name = "Dropdown";
            Dropdown.Size = new Size(273, 93);
            Dropdown.TabIndex = 4;
            // 
            // RequestsBtn
            // 
            RequestsBtn.Dock = DockStyle.Top;
            RequestsBtn.FlatAppearance.BorderSize = 0;
            RequestsBtn.FlatStyle = FlatStyle.Flat;
            RequestsBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            RequestsBtn.ForeColor = SystemColors.Control;
            RequestsBtn.Location = new Point(0, 45);
            RequestsBtn.Name = "RequestsBtn";
            RequestsBtn.Padding = new Padding(35, 0, 0, 0);
            RequestsBtn.Size = new Size(273, 45);
            RequestsBtn.TabIndex = 1;
            RequestsBtn.Text = "Requests";
            RequestsBtn.TextAlign = ContentAlignment.MiddleLeft;
            RequestsBtn.UseVisualStyleBackColor = true;
            RequestsBtn.Click += RequestsBtn_Click;
            // 
            // ScheduleBtn
            // 
            ScheduleBtn.Dock = DockStyle.Top;
            ScheduleBtn.FlatAppearance.BorderSize = 0;
            ScheduleBtn.FlatStyle = FlatStyle.Flat;
            ScheduleBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ScheduleBtn.ForeColor = SystemColors.Control;
            ScheduleBtn.Location = new Point(0, 0);
            ScheduleBtn.Name = "ScheduleBtn";
            ScheduleBtn.Padding = new Padding(35, 0, 0, 0);
            ScheduleBtn.Size = new Size(273, 45);
            ScheduleBtn.TabIndex = 0;
            ScheduleBtn.Text = "Schedule";
            ScheduleBtn.TextAlign = ContentAlignment.MiddleLeft;
            ScheduleBtn.UseVisualStyleBackColor = true;
            ScheduleBtn.Click += button1_Click;
            // 
            // AppointmentBtn
            // 
            AppointmentBtn.Dock = DockStyle.Top;
            AppointmentBtn.FlatAppearance.BorderSize = 0;
            AppointmentBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            AppointmentBtn.FlatStyle = FlatStyle.Flat;
            AppointmentBtn.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            AppointmentBtn.ForeColor = SystemColors.Control;
            AppointmentBtn.Location = new Point(0, 148);
            AppointmentBtn.Name = "AppointmentBtn";
            AppointmentBtn.Padding = new Padding(15, 0, 0, 0);
            AppointmentBtn.Size = new Size(273, 48);
            AppointmentBtn.TabIndex = 2;
            AppointmentBtn.Text = "Appointment";
            AppointmentBtn.TextAlign = ContentAlignment.MiddleLeft;
            AppointmentBtn.UseVisualStyleBackColor = true;
            AppointmentBtn.Click += AppointmentBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Dock = DockStyle.Top;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            HomeBtn.ForeColor = SystemColors.Control;
            HomeBtn.Location = new Point(0, 100);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Padding = new Padding(15, 0, 0, 0);
            HomeBtn.Size = new Size(273, 48);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.TextAlign = ContentAlignment.MiddleLeft;
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 100);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveBorder;
            label6.Location = new Point(291, 303);
            label6.Name = "label6";
            label6.Size = new Size(207, 45);
            label6.TabIndex = 7;
            label6.Text = "Notifications";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 1);
            label7.Margin = new Padding(10, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(448, 62);
            label7.TabIndex = 0;
            label7.Text = "User 1 has booked the Programming Algorithm course";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = SystemColors.InactiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 2);
            tableLayoutPanel1.Location = new Point(294, 367);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1231, 192);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(4, 64);
            label8.Name = "label8";
            label8.Padding = new Padding(10, 0, 3, 0);
            label8.Size = new Size(360, 62);
            label8.TabIndex = 1;
            label8.Text = "Your UI/UX Design class will start in 1 hour";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(4, 127);
            label9.Name = "label9";
            label9.Padding = new Padding(10, 0, 3, 0);
            label9.Size = new Size(451, 64);
            label9.TabIndex = 2;
            label9.Text = "2 pending requests for Programming Algorithm Class";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 13);
            label2.Name = "label2";
            label2.Size = new Size(234, 28);
            label2.TabIndex = 5;
            label2.Text = "Programming Algorithm";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(89, 44);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 6;
            label4.Text = "16.00 - 17.00";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(291, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 87);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(291, 115);
            label1.Name = "label1";
            label1.Size = new Size(210, 45);
            label1.TabIndex = 1;
            label1.Text = "Today's Class";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(641, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 87);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(89, 44);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 6;
            label3.Text = "10.00 - 12.00";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(89, 13);
            label5.Name = "label5";
            label5.Size = new Size(135, 28);
            label5.TabIndex = 5;
            label5.Text = "UI/UX Design";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label5_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.InactiveCaption;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold, GraphicsUnit.Point);
            userName.ForeColor = Color.DodgerBlue;
            userName.Location = new Point(291, 45);
            userName.Name = "userName";
            userName.Size = new Size(123, 45);
            userName.TabIndex = 10;
            userName.Text = "{name}";
            userName.Click += userName_Click;
            // 
            // mentorSchedule2
            // 
            mentorSchedule2.Location = new Point(279, 0);
            mentorSchedule2.Margin = new Padding(3, 4, 3, 4);
            mentorSchedule2.Name = "mentorSchedule2";
            mentorSchedule2.Size = new Size(702, 653);
            mentorSchedule2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(280, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(701, 653);
            panel4.TabIndex = 12;
            // 
            // requests1
            // 
            requests1.Location = new Point(279, 0);
            requests1.Name = "requests1";
            requests1.Size = new Size(702, 653);
            requests1.TabIndex = 0;
            // 
            // DashboardMentor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(982, 653);
            Controls.Add(userName);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(NavBar);
            Controls.Add(panel4);
            Controls.Add(mentorSchedule2);
            Controls.Add(requests1);
            MinimumSize = new Size(800, 498);
            Name = "DashboardMentor";
            Text = "Homepage";
            Load += DashboardMentor_Load;
            NavBar.ResumeLayout(false);
            Dropdown.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NavBar;
        private Panel Dropdown;
        private Button YourClassBtn;
        private Button AppointmentBtn;
        private Button HomeBtn;
        private Button RequestsBtn;
        private Button LogOutBtn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label9;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox2;
        private Label userName;
        private System.CodeDom.CodeTypeReference schedule1;
        private Mentor.MentorSchedule mentorSchedule1;
        private Panel panel2;
        private Mentor.MentorSchedule mentorSchedule2;
        private Panel panel4;
        private Button button1;
        private Button ScheduleBtn;
        private Mentor.Requests requests1;
    }
}