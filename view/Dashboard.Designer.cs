namespace mentoring_system.view
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            logoutButton = new Button();
            logoutIcon = new Button();
            lessonButton = new Button();
            lessonIcon = new Button();
            scheduleButton = new Button();
            scheduleIcon = new Button();
            bookButton = new Button();
            bookIcon = new Button();
            panel2 = new Panel();
            messageButton = new Button();
            profileButton = new Button();
            dashBoardLabel = new Label();
            greetingLabel = new Label();
            LessonLearnedPanel = new Panel();
            newLeasonLearnedLabel = new Label();
            lessonLearnedQuantitativeLabel = new Label();
            lessonLearnedLabel = new Label();
            panel3 = new Panel();
            newAppointmentBookedLabel = new Label();
            AppointmentBookedQuantitativeLabel = new Label();
            appointmentBookedLabel = new Label();
            panel4 = new Panel();
            MilestoneCongratulationsLabel = new Label();
            MilestoneQuantitativeLabel = new Label();
            MilestonePassedLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            LessonLearnedPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(logoutIcon);
            panel1.Controls.Add(lessonButton);
            panel1.Controls.Add(lessonIcon);
            panel1.Controls.Add(scheduleButton);
            panel1.Controls.Add(scheduleIcon);
            panel1.Controls.Add(bookButton);
            panel1.Controls.Add(bookIcon);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 632);
            panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.SaddleBrown;
            logoutButton.Location = new Point(80, 319);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(74, 28);
            logoutButton.TabIndex = 8;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // logoutIcon
            // 
            logoutIcon.BackgroundImage = (Image)resources.GetObject("logoutIcon.BackgroundImage");
            logoutIcon.BackgroundImageLayout = ImageLayout.Stretch;
            logoutIcon.FlatAppearance.BorderSize = 0;
            logoutIcon.FlatStyle = FlatStyle.Flat;
            logoutIcon.Location = new Point(32, 311);
            logoutIcon.Name = "logoutIcon";
            logoutIcon.Size = new Size(45, 45);
            logoutIcon.TabIndex = 7;
            logoutIcon.UseVisualStyleBackColor = true;
            // 
            // lessonButton
            // 
            lessonButton.FlatAppearance.BorderSize = 0;
            lessonButton.FlatStyle = FlatStyle.Flat;
            lessonButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lessonButton.ForeColor = Color.SaddleBrown;
            lessonButton.Location = new Point(72, 252);
            lessonButton.Name = "lessonButton";
            lessonButton.Size = new Size(103, 28);
            lessonButton.TabIndex = 6;
            lessonButton.Text = "My Lesson";
            lessonButton.UseVisualStyleBackColor = true;
            // 
            // lessonIcon
            // 
            lessonIcon.BackgroundImage = (Image)resources.GetObject("lessonIcon.BackgroundImage");
            lessonIcon.BackgroundImageLayout = ImageLayout.Stretch;
            lessonIcon.FlatAppearance.BorderSize = 0;
            lessonIcon.FlatStyle = FlatStyle.Flat;
            lessonIcon.Location = new Point(29, 244);
            lessonIcon.Name = "lessonIcon";
            lessonIcon.Size = new Size(45, 45);
            lessonIcon.TabIndex = 5;
            lessonIcon.UseVisualStyleBackColor = true;
            // 
            // scheduleButton
            // 
            scheduleButton.FlatAppearance.BorderSize = 0;
            scheduleButton.FlatStyle = FlatStyle.Flat;
            scheduleButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            scheduleButton.ForeColor = Color.SaddleBrown;
            scheduleButton.Location = new Point(74, 179);
            scheduleButton.Name = "scheduleButton";
            scheduleButton.Size = new Size(112, 28);
            scheduleButton.TabIndex = 4;
            scheduleButton.Text = "My Schedule";
            scheduleButton.UseVisualStyleBackColor = true;
            // 
            // scheduleIcon
            // 
            scheduleIcon.BackgroundImage = (Image)resources.GetObject("scheduleIcon.BackgroundImage");
            scheduleIcon.BackgroundImageLayout = ImageLayout.Stretch;
            scheduleIcon.FlatAppearance.BorderSize = 0;
            scheduleIcon.FlatStyle = FlatStyle.Flat;
            scheduleIcon.Location = new Point(27, 171);
            scheduleIcon.Name = "scheduleIcon";
            scheduleIcon.Size = new Size(50, 45);
            scheduleIcon.TabIndex = 3;
            scheduleIcon.UseVisualStyleBackColor = true;
            // 
            // bookButton
            // 
            bookButton.FlatAppearance.BorderSize = 0;
            bookButton.FlatStyle = FlatStyle.Flat;
            bookButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bookButton.ForeColor = Color.SaddleBrown;
            bookButton.Location = new Point(72, 108);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(118, 28);
            bookButton.TabIndex = 2;
            bookButton.Text = "Book a mentor";
            bookButton.UseVisualStyleBackColor = true;
            // 
            // bookIcon
            // 
            bookIcon.BackgroundImage = (Image)resources.GetObject("bookIcon.BackgroundImage");
            bookIcon.BackgroundImageLayout = ImageLayout.Stretch;
            bookIcon.FlatAppearance.BorderSize = 0;
            bookIcon.FlatStyle = FlatStyle.Flat;
            bookIcon.Location = new Point(27, 100);
            bookIcon.Name = "bookIcon";
            bookIcon.Size = new Size(50, 45);
            bookIcon.TabIndex = 1;
            bookIcon.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(messageButton);
            panel2.Controls.Add(profileButton);
            panel2.Controls.Add(dashBoardLabel);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 48);
            panel2.TabIndex = 1;
            // 
            // messageButton
            // 
            messageButton.BackgroundImage = (Image)resources.GetObject("messageButton.BackgroundImage");
            messageButton.BackgroundImageLayout = ImageLayout.Stretch;
            messageButton.FlatAppearance.BorderSize = 0;
            messageButton.FlatStyle = FlatStyle.Flat;
            messageButton.Location = new Point(810, 4);
            messageButton.Name = "messageButton";
            messageButton.Size = new Size(52, 42);
            messageButton.TabIndex = 2;
            messageButton.UseVisualStyleBackColor = true;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.PeachPuff;
            profileButton.BackgroundImage = (Image)resources.GetObject("profileButton.BackgroundImage");
            profileButton.BackgroundImageLayout = ImageLayout.Stretch;
            profileButton.FlatAppearance.BorderColor = Color.Moccasin;
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatAppearance.MouseDownBackColor = Color.Moccasin;
            profileButton.FlatAppearance.MouseOverBackColor = Color.White;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Location = new Point(868, 6);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(35, 35);
            profileButton.TabIndex = 1;
            profileButton.UseVisualStyleBackColor = false;
            // 
            // dashBoardLabel
            // 
            dashBoardLabel.AutoSize = true;
            dashBoardLabel.BackColor = Color.PeachPuff;
            dashBoardLabel.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dashBoardLabel.ForeColor = Color.SaddleBrown;
            dashBoardLabel.Location = new Point(12, 6);
            dashBoardLabel.Name = "dashBoardLabel";
            dashBoardLabel.Size = new Size(135, 31);
            dashBoardLabel.TabIndex = 0;
            dashBoardLabel.Text = "Dashboard";
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI Historic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            greetingLabel.ForeColor = Color.SaddleBrown;
            greetingLabel.Location = new Point(567, 76);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(341, 46);
            greetingLabel.TabIndex = 2;
            greetingLabel.Text = "Hi, Have a Nice Day!";
            // 
            // LessonLearnedPanel
            // 
            LessonLearnedPanel.BackColor = Color.SandyBrown;
            LessonLearnedPanel.Controls.Add(newLeasonLearnedLabel);
            LessonLearnedPanel.Controls.Add(lessonLearnedQuantitativeLabel);
            LessonLearnedPanel.Controls.Add(lessonLearnedLabel);
            LessonLearnedPanel.Location = new Point(236, 162);
            LessonLearnedPanel.Name = "LessonLearnedPanel";
            LessonLearnedPanel.Size = new Size(187, 127);
            LessonLearnedPanel.TabIndex = 3;
            // 
            // newLeasonLearnedLabel
            // 
            newLeasonLearnedLabel.AutoSize = true;
            newLeasonLearnedLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newLeasonLearnedLabel.ForeColor = SystemColors.ButtonHighlight;
            newLeasonLearnedLabel.Location = new Point(13, 88);
            newLeasonLearnedLabel.Name = "newLeasonLearnedLabel";
            newLeasonLearnedLabel.Size = new Size(101, 20);
            newLeasonLearnedLabel.TabIndex = 2;
            newLeasonLearnedLabel.Text = "3 new lessons";
            // 
            // lessonLearnedQuantitativeLabel
            // 
            lessonLearnedQuantitativeLabel.AutoSize = true;
            lessonLearnedQuantitativeLabel.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            lessonLearnedQuantitativeLabel.ForeColor = SystemColors.ButtonHighlight;
            lessonLearnedQuantitativeLabel.Location = new Point(13, 31);
            lessonLearnedQuantitativeLabel.Name = "lessonLearnedQuantitativeLabel";
            lessonLearnedQuantitativeLabel.Size = new Size(73, 57);
            lessonLearnedQuantitativeLabel.TabIndex = 1;
            lessonLearnedQuantitativeLabel.Text = "12";
            // 
            // lessonLearnedLabel
            // 
            lessonLearnedLabel.AutoSize = true;
            lessonLearnedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lessonLearnedLabel.ForeColor = SystemColors.ButtonHighlight;
            lessonLearnedLabel.Location = new Point(13, 11);
            lessonLearnedLabel.Name = "lessonLearnedLabel";
            lessonLearnedLabel.Size = new Size(117, 20);
            lessonLearnedLabel.TabIndex = 0;
            lessonLearnedLabel.Text = "Lesson Learned";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(newAppointmentBookedLabel);
            panel3.Controls.Add(AppointmentBookedQuantitativeLabel);
            panel3.Controls.Add(appointmentBookedLabel);
            panel3.Location = new Point(459, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 125);
            panel3.TabIndex = 4;
            // 
            // newAppointmentBookedLabel
            // 
            newAppointmentBookedLabel.AutoSize = true;
            newAppointmentBookedLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newAppointmentBookedLabel.ForeColor = SystemColors.ButtonHighlight;
            newAppointmentBookedLabel.Location = new Point(16, 88);
            newAppointmentBookedLabel.Name = "newAppointmentBookedLabel";
            newAppointmentBookedLabel.Size = new Size(139, 20);
            newAppointmentBookedLabel.TabIndex = 3;
            newAppointmentBookedLabel.Text = "1 new appointment";
            // 
            // AppointmentBookedQuantitativeLabel
            // 
            AppointmentBookedQuantitativeLabel.AutoSize = true;
            AppointmentBookedQuantitativeLabel.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            AppointmentBookedQuantitativeLabel.ForeColor = SystemColors.ButtonHighlight;
            AppointmentBookedQuantitativeLabel.Location = new Point(16, 31);
            AppointmentBookedQuantitativeLabel.Name = "AppointmentBookedQuantitativeLabel";
            AppointmentBookedQuantitativeLabel.Size = new Size(49, 57);
            AppointmentBookedQuantitativeLabel.TabIndex = 3;
            AppointmentBookedQuantitativeLabel.Text = "3";
            // 
            // appointmentBookedLabel
            // 
            appointmentBookedLabel.AutoSize = true;
            appointmentBookedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            appointmentBookedLabel.ForeColor = SystemColors.ButtonHighlight;
            appointmentBookedLabel.Location = new Point(16, 11);
            appointmentBookedLabel.Name = "appointmentBookedLabel";
            appointmentBookedLabel.Size = new Size(160, 20);
            appointmentBookedLabel.TabIndex = 3;
            appointmentBookedLabel.Text = "Appointment Booked";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSeaGreen;
            panel4.Controls.Add(MilestoneCongratulationsLabel);
            panel4.Controls.Add(MilestoneQuantitativeLabel);
            panel4.Controls.Add(MilestonePassedLabel);
            panel4.Location = new Point(715, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 125);
            panel4.TabIndex = 5;
            // 
            // MilestoneCongratulationsLabel
            // 
            MilestoneCongratulationsLabel.AutoSize = true;
            MilestoneCongratulationsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MilestoneCongratulationsLabel.ForeColor = SystemColors.ButtonHighlight;
            MilestoneCongratulationsLabel.Location = new Point(3, 90);
            MilestoneCongratulationsLabel.Name = "MilestoneCongratulationsLabel";
            MilestoneCongratulationsLabel.Size = new Size(168, 20);
            MilestoneCongratulationsLabel.TabIndex = 4;
            MilestoneCongratulationsLabel.Text = "Congrats! You passed it";
            // 
            // MilestoneQuantitativeLabel
            // 
            MilestoneQuantitativeLabel.AutoSize = true;
            MilestoneQuantitativeLabel.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            MilestoneQuantitativeLabel.ForeColor = SystemColors.ButtonHighlight;
            MilestoneQuantitativeLabel.Location = new Point(15, 33);
            MilestoneQuantitativeLabel.Name = "MilestoneQuantitativeLabel";
            MilestoneQuantitativeLabel.Size = new Size(49, 57);
            MilestoneQuantitativeLabel.TabIndex = 4;
            MilestoneQuantitativeLabel.Text = "1";
            // 
            // MilestonePassedLabel
            // 
            MilestonePassedLabel.AutoSize = true;
            MilestonePassedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MilestonePassedLabel.ForeColor = SystemColors.ButtonHighlight;
            MilestonePassedLabel.Location = new Point(3, 9);
            MilestonePassedLabel.Name = "MilestonePassedLabel";
            MilestonePassedLabel.Size = new Size(130, 20);
            MilestonePassedLabel.TabIndex = 4;
            MilestonePassedLabel.Text = "Milestone Passed";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 629);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(LessonLearnedPanel);
            Controls.Add(greetingLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            LessonLearnedPanel.ResumeLayout(false);
            LessonLearnedPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label dashBoardLabel;
        private Button messageButton;
        private Button profileButton;
        private Button bookButton;
        private Button bookIcon;
        private Button lessonButton;
        private Button lessonIcon;
        private Button scheduleButton;
        private Button scheduleIcon;
        private Label greetingLabel;
        private Panel LessonLearnedPanel;
        private Label newLeasonLearnedLabel;
        private Label lessonLearnedQuantitativeLabel;
        private Label lessonLearnedLabel;
        private Button logoutButton;
        private Button logoutIcon;
        private Panel panel3;
        private Label newAppointmentBookedLabel;
        private Label AppointmentBookedQuantitativeLabel;
        private Label appointmentBookedLabel;
        private Panel panel4;
        private Label MilestonePassedLabel;
        private Label MilestoneCongratulationsLabel;
        private Label MilestoneQuantitativeLabel;
    }
}