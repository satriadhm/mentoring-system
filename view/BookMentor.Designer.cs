namespace mentoring_system.view
{
    partial class BookMentor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMentor));
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
            bookMentorDateTimePicker = new DateTimePicker();
            bayarButton = new Button();
            masukListButton = new Button();
            comboBoxCourseName = new ComboBox();
            label1 = new Label();
            searchButton = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.TabIndex = 3;
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
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 48);
            panel2.TabIndex = 4;
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
            dashBoardLabel.Size = new Size(149, 31);
            dashBoardLabel.TabIndex = 0;
            dashBoardLabel.Text = "BookMentor";
            // 
            // bookMentorDateTimePicker
            // 
            bookMentorDateTimePicker.Location = new Point(275, 218);
            bookMentorDateTimePicker.Name = "bookMentorDateTimePicker";
            bookMentorDateTimePicker.Size = new Size(250, 27);
            bookMentorDateTimePicker.TabIndex = 5;
            // 
            // bayarButton
            // 
            bayarButton.BackColor = Color.NavajoWhite;
            bayarButton.FlatAppearance.BorderSize = 0;
            bayarButton.FlatStyle = FlatStyle.Flat;
            bayarButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bayarButton.ForeColor = Color.SaddleBrown;
            bayarButton.Location = new Point(705, 515);
            bayarButton.Name = "bayarButton";
            bayarButton.Size = new Size(178, 29);
            bayarButton.TabIndex = 6;
            bayarButton.Text = "Bayar";
            bayarButton.UseVisualStyleBackColor = false;
            // 
            // masukListButton
            // 
            masukListButton.BackColor = Color.Linen;
            masukListButton.FlatAppearance.BorderColor = Color.RosyBrown;
            masukListButton.FlatStyle = FlatStyle.Flat;
            masukListButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            masukListButton.ForeColor = Color.SaddleBrown;
            masukListButton.Location = new Point(472, 515);
            masukListButton.Name = "masukListButton";
            masukListButton.Size = new Size(178, 29);
            masukListButton.TabIndex = 7;
            masukListButton.Text = "Masuk List";
            masukListButton.UseVisualStyleBackColor = false;
            // 
            // comboBoxCourseName
            // 
            comboBoxCourseName.FormattingEnabled = true;
            comboBoxCourseName.Items.AddRange(new object[] { "Kalkulus", "Pemrograman Dasar", "Kimia ", "Fisika", "Biologi" });
            comboBoxCourseName.Location = new Point(553, 216);
            comboBoxCourseName.Name = "comboBoxCourseName";
            comboBoxCourseName.Size = new Size(176, 28);
            comboBoxCourseName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(707, 106);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 3;
            label1.Text = "Book a Mentor";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(748, 216);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(135, 29);
            searchButton.TabIndex = 11;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(606, 146);
            label2.Name = "label2";
            label2.Size = new Size(277, 20);
            label2.TabIndex = 12;
            label2.Text = "Choose the schedule, lesson, and mentor";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(275, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(151, 141);
            dataGridView1.TabIndex = 13;
            // 
            // BookMentor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 629);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Controls.Add(comboBoxCourseName);
            Controls.Add(masukListButton);
            Controls.Add(bayarButton);
            Controls.Add(bookMentorDateTimePicker);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BookMentor";
            Text = "BookMentor";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button logoutButton;
        private Button logoutIcon;
        private Button lessonButton;
        private Button lessonIcon;
        private Button scheduleButton;
        private Button scheduleIcon;
        private Button bookButton;
        private Button bookIcon;
        private Panel panel2;
        private Button messageButton;
        private Button profileButton;
        private Label dashBoardLabel;
        private DateTimePicker bookMentorDateTimePicker;
        private Button bayarButton;
        private Button masukListButton;
        private ComboBox comboBoxCourseName;
        private Label label1;
        private Button searchButton;
        private Label label2;
        private DataGridView dataGridView1;
    }
}