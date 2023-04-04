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
            NavBar = new Panel();
            LogOutBtn = new Button();
            YourClassBtn = new Button();
            Dropdown = new Panel();
            RequestsBtn = new Button();
            ScheduleBtn = new Button();
            AppointmentBtn = new Button();
            HomeBtn = new Button();
            panel2 = new Panel();
            NavBar.SuspendLayout();
            Dropdown.SuspendLayout();
            SuspendLayout();
            // 
            // NavBar
            // 
            NavBar.AutoScroll = true;
            NavBar.BackColor = SystemColors.ActiveBorder;
            NavBar.Controls.Add(LogOutBtn);
            NavBar.Controls.Add(YourClassBtn);
            NavBar.Controls.Add(Dropdown);
            NavBar.Controls.Add(AppointmentBtn);
            NavBar.Controls.Add(HomeBtn);
            NavBar.Controls.Add(panel2);
            NavBar.Dock = DockStyle.Left;
            NavBar.Location = new Point(0, 0);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(250, 653);
            NavBar.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Dock = DockStyle.Top;
            LogOutBtn.FlatAppearance.BorderSize = 0;
            LogOutBtn.FlatAppearance.MouseOverBackColor = Color.Aqua;
            LogOutBtn.FlatStyle = FlatStyle.Flat;
            LogOutBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LogOutBtn.ForeColor = Color.Crimson;
            LogOutBtn.Location = new Point(0, 334);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Padding = new Padding(15, 0, 0, 0);
            LogOutBtn.Size = new Size(250, 48);
            LogOutBtn.TabIndex = 5;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogOutBtn.UseVisualStyleBackColor = true;
            // 
            // YourClassBtn
            // 
            YourClassBtn.Dock = DockStyle.Top;
            YourClassBtn.FlatAppearance.BorderSize = 0;
            YourClassBtn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            YourClassBtn.FlatStyle = FlatStyle.Flat;
            YourClassBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            YourClassBtn.ForeColor = SystemColors.Control;
            YourClassBtn.Location = new Point(0, 286);
            YourClassBtn.Name = "YourClassBtn";
            YourClassBtn.Padding = new Padding(15, 0, 0, 0);
            YourClassBtn.Size = new Size(250, 48);
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
            Dropdown.Size = new Size(250, 90);
            Dropdown.TabIndex = 4;
            // 
            // RequestsBtn
            // 
            RequestsBtn.Dock = DockStyle.Top;
            RequestsBtn.FlatAppearance.BorderSize = 0;
            RequestsBtn.FlatStyle = FlatStyle.Flat;
            RequestsBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RequestsBtn.ForeColor = SystemColors.Control;
            RequestsBtn.Location = new Point(0, 45);
            RequestsBtn.Name = "RequestsBtn";
            RequestsBtn.Padding = new Padding(35, 0, 0, 0);
            RequestsBtn.Size = new Size(250, 45);
            RequestsBtn.TabIndex = 1;
            RequestsBtn.Text = "Requests";
            RequestsBtn.TextAlign = ContentAlignment.MiddleLeft;
            RequestsBtn.UseVisualStyleBackColor = true;
            // 
            // ScheduleBtn
            // 
            ScheduleBtn.Dock = DockStyle.Top;
            ScheduleBtn.FlatAppearance.BorderSize = 0;
            ScheduleBtn.FlatStyle = FlatStyle.Flat;
            ScheduleBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ScheduleBtn.ForeColor = SystemColors.Control;
            ScheduleBtn.Location = new Point(0, 0);
            ScheduleBtn.Name = "ScheduleBtn";
            ScheduleBtn.Padding = new Padding(35, 0, 0, 0);
            ScheduleBtn.Size = new Size(250, 45);
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
            AppointmentBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AppointmentBtn.ForeColor = SystemColors.Control;
            AppointmentBtn.Location = new Point(0, 148);
            AppointmentBtn.Name = "AppointmentBtn";
            AppointmentBtn.Padding = new Padding(15, 0, 0, 0);
            AppointmentBtn.Size = new Size(250, 48);
            AppointmentBtn.TabIndex = 2;
            AppointmentBtn.Text = "{Appointment}";
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
            HomeBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            HomeBtn.ForeColor = SystemColors.Control;
            HomeBtn.Location = new Point(0, 100);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Padding = new Padding(15, 0, 0, 0);
            HomeBtn.Size = new Size(250, 48);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.TextAlign = ContentAlignment.MiddleLeft;
            HomeBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 100);
            panel2.TabIndex = 0;
            // 
            // DashboardMentor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(NavBar);
            MinimumSize = new Size(800, 500);
            Name = "DashboardMentor";
            Text = "DashboardMentor";
            NavBar.ResumeLayout(false);
            Dropdown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NavBar;
        private Panel Dropdown;
        private Button ScheduleBtn;
        private Button YourClassBtn;
        private Button AppointmentBtn;
        private Button HomeBtn;
        private Panel panel2;
        private Button RequestsBtn;
        private Button LogOutBtn;
    }
}