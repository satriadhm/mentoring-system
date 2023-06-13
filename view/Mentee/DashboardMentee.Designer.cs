using mentoring_system.view.Mentee;

namespace mentoring_system.view
{
    partial class DashboardMentee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMentee));
            panelNavbar = new Panel();
            logoutButton = new Button();
            logoutIcon = new Button();
            lessonButton = new Button();
            lessonIcon = new Button();
            scheduleButton = new Button();
            scheduleIcon = new Button();
            bookButton = new Button();
            bookIcon = new Button();
            panelHeader = new Panel();
            messageButton = new Button();
            profileButton = new Button();
            dashBoardLabel = new Label();
            greetingLabel = new Label();
            LessonLearnedPanel = new Panel();
            newLeasonLearnedLabel = new Label();
            lessonLearnedQuantitativeLabel = new Label();
            lessonLearnedLabel = new Label();
            appoinmentDoneLabel = new Panel();
            label2 = new Label();
            newAppointmentBookedLabel = new Label();
            AppointmentBookedQuantitativeLabel = new Label();
            appointmentBookedLabel = new Label();
            label2 = new Label();
            panel4 = new Panel();
            MilestoneCongratulationsLabel = new Label();
            MilestoneQuantitativeLabel = new Label();
            MilestonePassedLabel = new Label();
            coursePage = new CoursePage();
            bookingPage = new BookingPage();
            mySchedulePage = new MySchedulePage();
            panel5 = new Panel();
            historyPanel = new Panel();
            label1 = new Label();
            appointmentDoneLabel = new Label();
            historyPanel = new Panel();
            panelNavbar.SuspendLayout();
            panelHeader.SuspendLayout();
            LessonLearnedPanel.SuspendLayout();
            appoinmentDoneLabel.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.NavajoWhite;
            panelNavbar.Controls.Add(logoutButton);
            panelNavbar.Controls.Add(logoutIcon);
            panelNavbar.Controls.Add(lessonButton);
            panelNavbar.Controls.Add(lessonIcon);
            panelNavbar.Controls.Add(scheduleButton);
            panelNavbar.Controls.Add(scheduleIcon);
            panelNavbar.Controls.Add(bookButton);
            panelNavbar.Controls.Add(bookIcon);
            panelNavbar.Location = new Point(0, -2);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(209, 632);
            panelNavbar.TabIndex = 0;
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
            logoutButton.Click += logoutButton_Click;
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
            lessonButton.Text = "My Course";
            lessonButton.UseVisualStyleBackColor = true;
            lessonButton.Click += lessonButton_Click;
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
            scheduleButton.Click += scheduleButton_Click;
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
            bookButton.Click += bookButton_Click;
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
            // panelHeader
            // 
            panelHeader.BackColor = Color.PeachPuff;
            panelHeader.Controls.Add(messageButton);
            panelHeader.Controls.Add(profileButton);
            panelHeader.Controls.Add(dashBoardLabel);
            panelHeader.Location = new Point(0, -2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(920, 48);
            panelHeader.TabIndex = 1;
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
            messageButton.Click += messageButton_Click;
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
            profileButton.Click += profileButton_Click_1;
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
            greetingLabel.Location = new Point(348, 9);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(341, 46);
            greetingLabel.TabIndex = 2;
            greetingLabel.Text = "Hi, Have a Nice Day!";
            greetingLabel.Click += greetingLabel_Click;
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
            // appoinmentDoneLabel
            // 
            appoinmentDoneLabel.BackColor = Color.LightCoral;
            appoinmentDoneLabel.Controls.Add(appointmentDoneLabel);
            appoinmentDoneLabel.Controls.Add(newAppointmentBookedLabel);
            appoinmentDoneLabel.Controls.Add(AppointmentBookedQuantitativeLabel);
            appoinmentDoneLabel.Controls.Add(appointmentBookedLabel);
            appoinmentDoneLabel.Location = new Point(459, 162);
            appoinmentDoneLabel.Name = "appoinmentDoneLabel";
            appoinmentDoneLabel.Size = new Size(206, 125);
            appoinmentDoneLabel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(550, 62);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 3;
            label2.Text = "Lesson Learned";
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
            appointmentBookedLabel.Location = new Point(0, 0);
            appointmentBookedLabel.Name = "appointmentBookedLabel";
            appointmentBookedLabel.Size = new Size(100, 23);
            appointmentBookedLabel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(550, 62);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 3;
            label2.Text = "Lesson Learned";
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
            // coursePage
            // 
            coursePage.Location = new Point(215, 52);
            coursePage.Name = "coursePage";
            coursePage.Size = new Size(705, 578);
            coursePage.TabIndex = 6;
            // 
            // bookingPage
            // 
            bookingPage.Location = new Point(215, 52);
            bookingPage.Name = "bookingPage";
            bookingPage.Size = new Size(705, 578);
            bookingPage.TabIndex = 10;
            // 
            // mySchedulePage
            // 
            mySchedulePage.Location = new Point(215, 52);
            mySchedulePage.Name = "mySchedulePage";
            mySchedulePage.Size = new Size(705, 578);
            mySchedulePage.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(historyPanel);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(greetingLabel);
            panel5.Location = new Point(219, 52);
            panel5.Name = "panel5";
            panel5.Size = new Size(701, 578);
            panel5.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(404, 299);
            label1.Name = "label1";
            label1.Size = new Size(274, 46);
            label1.TabIndex = 11;
            label1.Text = "Lesson's History";
            // 
            // appointmentDoneLabel
            // 
            appointmentDoneLabel.AutoSize = true;
            appointmentDoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            appointmentDoneLabel.ForeColor = SystemColors.ButtonHighlight;
            appointmentDoneLabel.Location = new Point(16, 11);
            appointmentDoneLabel.Name = "appointmentDoneLabel";
            appointmentDoneLabel.Size = new Size(144, 20);
            appointmentDoneLabel.TabIndex = 3;
            appointmentDoneLabel.Text = "Appointment Done";
            // 
            // historyPanel
            // 
            historyPanel.BackColor = Color.NavajoWhite;
            historyPanel.Location = new Point(25, 367);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(636, 58);
            historyPanel.TabIndex = 12;
            // 
            // DashboardMentee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 629);
            Controls.Add(panelHeader);
            Controls.Add(panel4);
            Controls.Add(appoinmentDoneLabel);
            Controls.Add(LessonLearnedPanel);
            Controls.Add(panelNavbar);
            Controls.Add(panel5);
            Controls.Add(coursePage);
            Controls.Add(bookingPage);
            Controls.Add(mySchedulePage);
            MaximizeBox = false;
            Name = "DashboardMentee";
            Text = "Dashboard";
            panelNavbar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            LessonLearnedPanel.ResumeLayout(false);
            LessonLearnedPanel.PerformLayout();
            appoinmentDoneLabel.ResumeLayout(false);
            appoinmentDoneLabel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Panel panelHeader;
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
        private Panel appoinmentDoneLabel;
        private Label newAppointmentBookedLabel;
        private Label AppointmentBookedQuantitativeLabel;
        private Label appointmentBookedLabel;
        private Panel panel4;
        private Label MilestonePassedLabel;
        private Label MilestoneCongratulationsLabel;
        private Label MilestoneQuantitativeLabel;
        private CoursePage coursePage;
        private BookingPage bookingPage;
        private MySchedulePage mySchedulePage;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label appointmentDoneLabel;
        private Panel historyPanel;
    }
}