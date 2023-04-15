namespace mentoring_system.view.Mentee
{
    partial class BookingPage
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
            label2 = new Label();
            submitButton = new Button();
            BookAMentorLabel = new Label();
            comboBoxCourseName = new ComboBox();
            proceedButton = new Button();
            bookMentorDateTimePicker = new DateTimePicker();
            comboBoxMentorName = new ComboBox();
            mentorNameLabel = new Label();
            scheduleLabel = new Label();
            label1 = new Label();
            mentorshipRequestData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)mentorshipRequestData).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(372, 110);
            label2.Name = "label2";
            label2.Size = new Size(277, 20);
            label2.TabIndex = 20;
            label2.Text = "Choose the schedule, lesson, and mentor";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(521, 180);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(135, 29);
            submitButton.TabIndex = 19;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // BookAMentorLabel
            // 
            BookAMentorLabel.AutoSize = true;
            BookAMentorLabel.BackColor = Color.Transparent;
            BookAMentorLabel.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BookAMentorLabel.ForeColor = Color.SaddleBrown;
            BookAMentorLabel.Location = new Point(480, 70);
            BookAMentorLabel.Name = "BookAMentorLabel";
            BookAMentorLabel.Size = new Size(176, 31);
            BookAMentorLabel.TabIndex = 14;
            BookAMentorLabel.Text = "Book a Mentor";
            // 
            // comboBoxCourseName
            // 
            comboBoxCourseName.FormattingEnabled = true;
            comboBoxCourseName.Location = new Point(341, 180);
            comboBoxCourseName.Name = "comboBoxCourseName";
            comboBoxCourseName.Size = new Size(161, 28);
            comboBoxCourseName.TabIndex = 18;
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.NavajoWhite;
            proceedButton.FlatAppearance.BorderSize = 0;
            proceedButton.FlatStyle = FlatStyle.Flat;
            proceedButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            proceedButton.ForeColor = Color.SaddleBrown;
            proceedButton.Location = new Point(406, 479);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(250, 29);
            proceedButton.TabIndex = 16;
            proceedButton.Text = "Proceed";
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += proceedButton_Click;
            // 
            // bookMentorDateTimePicker
            // 
            bookMentorDateTimePicker.Location = new Point(143, 181);
            bookMentorDateTimePicker.Name = "bookMentorDateTimePicker";
            bookMentorDateTimePicker.Size = new Size(180, 27);
            bookMentorDateTimePicker.TabIndex = 15;
            // 
            // comboBoxMentorName
            // 
            comboBoxMentorName.FormattingEnabled = true;
            comboBoxMentorName.Location = new Point(19, 180);
            comboBoxMentorName.Name = "comboBoxMentorName";
            comboBoxMentorName.Size = new Size(98, 28);
            comboBoxMentorName.TabIndex = 21;
            // 
            // mentorNameLabel
            // 
            mentorNameLabel.AutoSize = true;
            mentorNameLabel.BackColor = Color.Transparent;
            mentorNameLabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mentorNameLabel.ForeColor = Color.SaddleBrown;
            mentorNameLabel.Location = new Point(19, 148);
            mentorNameLabel.Name = "mentorNameLabel";
            mentorNameLabel.Size = new Size(53, 20);
            mentorNameLabel.TabIndex = 22;
            mentorNameLabel.Text = "Name";
            // 
            // scheduleLabel
            // 
            scheduleLabel.AutoSize = true;
            scheduleLabel.BackColor = Color.Transparent;
            scheduleLabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            scheduleLabel.ForeColor = Color.SaddleBrown;
            scheduleLabel.Location = new Point(143, 148);
            scheduleLabel.Name = "scheduleLabel";
            scheduleLabel.Size = new Size(77, 20);
            scheduleLabel.TabIndex = 23;
            scheduleLabel.Text = "Schedule";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(341, 148);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 24;
            label1.Text = "Subject";
            // 
            // mentorshipRequestData
            // 
            mentorshipRequestData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mentorshipRequestData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mentorshipRequestData.Location = new Point(19, 228);
            mentorshipRequestData.Name = "mentorshipRequestData";
            mentorshipRequestData.RowHeadersWidth = 51;
            mentorshipRequestData.RowTemplate.Height = 29;
            mentorshipRequestData.Size = new Size(637, 216);
            mentorshipRequestData.TabIndex = 25;
            // 
            // BookingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mentorshipRequestData);
            Controls.Add(label1);
            Controls.Add(scheduleLabel);
            Controls.Add(mentorNameLabel);
            Controls.Add(comboBoxMentorName);
            Controls.Add(label2);
            Controls.Add(submitButton);
            Controls.Add(BookAMentorLabel);
            Controls.Add(comboBoxCourseName);
            Controls.Add(proceedButton);
            Controls.Add(bookMentorDateTimePicker);
            Name = "BookingPage";
            Size = new Size(705, 578);
            Load += BookingPage_Load;
            ((System.ComponentModel.ISupportInitialize)mentorshipRequestData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button submitButton;
        private Label BookAMentorLabel;
        private ComboBox comboBoxCourseName;
        private Button proceedButton;
        private DateTimePicker bookMentorDateTimePicker;
        private ComboBox comboBoxMentorName;
        private Label mentorNameLabel;
        private Label scheduleLabel;
        private Label label1;
        private DataGridView mentorshipRequestData;
    }
}
