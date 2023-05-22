namespace mentoring_system.view.Mentee
{
    partial class MySchedulePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySchedulePage));
            yourschedulelabel = new Label();
            MyScheduleLabel = new Label();
            lessonComboBox = new ComboBox();
            upcomingScheduleLabel = new Label();
            mentorNameLabel = new Label();
            lessonNameLabel = new Label();
            lessonPictureBox = new PictureBox();
            scheduleListBox = new ListBox();
            scheduleDateTimePicker = new DateTimePicker();
            searchButton = new Button();
            lessonLabel = new Label();
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)lessonPictureBox).BeginInit();
            SuspendLayout();
            // 
            // yourschedulelabel
            // 
            yourschedulelabel.AutoSize = true;
            yourschedulelabel.BackColor = Color.Transparent;
            yourschedulelabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            yourschedulelabel.ForeColor = Color.SaddleBrown;
            yourschedulelabel.Location = new Point(542, 77);
            yourschedulelabel.Name = "yourschedulelabel";
            yourschedulelabel.Size = new Size(103, 20);
            yourschedulelabel.TabIndex = 22;
            yourschedulelabel.Text = "Your Schedule";
            // 
            // MyScheduleLabel
            // 
            MyScheduleLabel.AutoSize = true;
            MyScheduleLabel.BackColor = Color.Transparent;
            MyScheduleLabel.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MyScheduleLabel.ForeColor = Color.SaddleBrown;
            MyScheduleLabel.Location = new Point(491, 46);
            MyScheduleLabel.Name = "MyScheduleLabel";
            MyScheduleLabel.Size = new Size(156, 31);
            MyScheduleLabel.TabIndex = 21;
            MyScheduleLabel.Text = "My Schedule";
            // 
            // lessonComboBox
            // 
            lessonComboBox.FormattingEnabled = true;
            lessonComboBox.Items.AddRange(new object[] { "Lates Schedule ", "Upcoming Schedule" });
            lessonComboBox.Location = new Point(61, 145);
            lessonComboBox.Name = "lessonComboBox";
            lessonComboBox.Size = new Size(228, 28);
            lessonComboBox.TabIndex = 23;
            // 
            // upcomingScheduleLabel
            // 
            upcomingScheduleLabel.AutoSize = true;
            upcomingScheduleLabel.BackColor = Color.Transparent;
            upcomingScheduleLabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            upcomingScheduleLabel.ForeColor = Color.SaddleBrown;
            upcomingScheduleLabel.Location = new Point(130, 225);
            upcomingScheduleLabel.Name = "upcomingScheduleLabel";
            upcomingScheduleLabel.Size = new Size(159, 20);
            upcomingScheduleLabel.TabIndex = 25;
            upcomingScheduleLabel.Tag = "upcomingScheduleLessonBox";
            upcomingScheduleLabel.Text = "Upcoming Schedule";
            // 
            // mentorNameLabel
            // 
            mentorNameLabel.AutoSize = true;
            mentorNameLabel.BackColor = Color.NavajoWhite;
            mentorNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mentorNameLabel.Location = new Point(217, 313);
            mentorNameLabel.Name = "mentorNameLabel";
            mentorNameLabel.Size = new Size(90, 20);
            mentorNameLabel.TabIndex = 29;
            mentorNameLabel.Tag = "upcomingScheduleLessonBox";
            mentorNameLabel.Text = "Mentor: Zira";
            // 
            // lessonNameLabel
            // 
            lessonNameLabel.AutoSize = true;
            lessonNameLabel.BackColor = Color.NavajoWhite;
            lessonNameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lessonNameLabel.Location = new Point(216, 285);
            lessonNameLabel.Name = "lessonNameLabel";
            lessonNameLabel.Size = new Size(216, 25);
            lessonNameLabel.TabIndex = 28;
            lessonNameLabel.Tag = "upcomingScheduleLessonBox";
            lessonNameLabel.Text = "Programming Algorithm";
            // 
            // lessonPictureBox
            // 
            lessonPictureBox.BackColor = Color.NavajoWhite;
            lessonPictureBox.Image = (Image)resources.GetObject("lessonPictureBox.Image");
            lessonPictureBox.Location = new Point(130, 270);
            lessonPictureBox.Name = "lessonPictureBox";
            lessonPictureBox.Size = new Size(80, 80);
            lessonPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            lessonPictureBox.TabIndex = 27;
            lessonPictureBox.TabStop = false;
            lessonPictureBox.Tag = "upcomingScheduleLessonBox";
            // 
            // scheduleListBox
            // 
            scheduleListBox.BackColor = Color.NavajoWhite;
            scheduleListBox.BorderStyle = BorderStyle.None;
            scheduleListBox.ForeColor = Color.White;
            scheduleListBox.FormattingEnabled = true;
            scheduleListBox.ItemHeight = 20;
            scheduleListBox.Location = new Point(130, 270);
            scheduleListBox.Name = "scheduleListBox";
            scheduleListBox.Size = new Size(347, 80);
            scheduleListBox.TabIndex = 26;
            scheduleListBox.Tag = "upcomingScheduleLessonBox";
            // 
            // scheduleDateTimePicker
            // 
            scheduleDateTimePicker.Location = new Point(295, 146);
            scheduleDateTimePicker.Name = "scheduleDateTimePicker";
            scheduleDateTimePicker.Size = new Size(182, 27);
            scheduleDateTimePicker.TabIndex = 34;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(491, 144);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(154, 29);
            searchButton.TabIndex = 35;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += button1_Click;
            // 
            // lessonLabel
            // 
            lessonLabel.AutoSize = true;
            lessonLabel.BackColor = Color.Transparent;
            lessonLabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lessonLabel.ForeColor = Color.SaddleBrown;
            lessonLabel.Location = new Point(61, 110);
            lessonLabel.Name = "lessonLabel";
            lessonLabel.Size = new Size(59, 20);
            lessonLabel.TabIndex = 36;
            lessonLabel.Text = "Lesson";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.ForeColor = Color.SaddleBrown;
            dateLabel.Location = new Point(295, 110);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(45, 20);
            dateLabel.TabIndex = 37;
            dateLabel.Text = "Date";
            // 
            // MySchedulePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateLabel);
            Controls.Add(lessonLabel);
            Controls.Add(searchButton);
            Controls.Add(scheduleDateTimePicker);
            Controls.Add(mentorNameLabel);
            Controls.Add(lessonNameLabel);
            Controls.Add(lessonPictureBox);
            Controls.Add(scheduleListBox);
            Controls.Add(upcomingScheduleLabel);
            Controls.Add(lessonComboBox);
            Controls.Add(yourschedulelabel);
            Controls.Add(MyScheduleLabel);
            Name = "MySchedulePage";
            Size = new Size(705, 578);
            Load += MySchedulePage_Load;
            ((System.ComponentModel.ISupportInitialize)lessonPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label yourschedulelabel;
        private Label MyScheduleLabel;
        private ComboBox lessonComboBox;
        private Label latestScheduleLabel;
        private Label upcomingScheduleLabel;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private ListBox listBox2;
        private Label mentorNameLabel;
        private Label lessonNameLabel;
        private PictureBox lessonPictureBox;
        private ListBox scheduleListBox;
        private DateTimePicker scheduleDateTimePicker;
        private Button searchButton;
        private Label lessonLabel;
        private Label dateLabel;
    }
}
