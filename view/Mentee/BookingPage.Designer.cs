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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            searchButton = new Button();
            BookAMentorLabel = new Label();
            comboBoxCourseName = new ComboBox();
            masukListButton = new Button();
            bayarButton = new Button();
            bookMentorDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(151, 141);
            dataGridView1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(379, 110);
            label2.Name = "label2";
            label2.Size = new Size(277, 20);
            label2.TabIndex = 20;
            label2.Text = "Choose the schedule, lesson, and mentor";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(521, 180);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(135, 29);
            searchButton.TabIndex = 19;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
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
            comboBoxCourseName.Items.AddRange(new object[] { "Kalkulus", "Pemrograman Dasar", "Kimia ", "Fisika", "Biologi" });
            comboBoxCourseName.Location = new Point(326, 180);
            comboBoxCourseName.Name = "comboBoxCourseName";
            comboBoxCourseName.Size = new Size(176, 28);
            comboBoxCourseName.TabIndex = 18;
            // 
            // masukListButton
            // 
            masukListButton.BackColor = Color.Linen;
            masukListButton.FlatAppearance.BorderColor = Color.RosyBrown;
            masukListButton.FlatStyle = FlatStyle.Flat;
            masukListButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            masukListButton.ForeColor = Color.SaddleBrown;
            masukListButton.Location = new Point(245, 479);
            masukListButton.Name = "masukListButton";
            masukListButton.Size = new Size(178, 29);
            masukListButton.TabIndex = 17;
            masukListButton.Text = "Masuk List";
            masukListButton.UseVisualStyleBackColor = false;
            // 
            // bayarButton
            // 
            bayarButton.BackColor = Color.NavajoWhite;
            bayarButton.FlatAppearance.BorderSize = 0;
            bayarButton.FlatStyle = FlatStyle.Flat;
            bayarButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bayarButton.ForeColor = Color.SaddleBrown;
            bayarButton.Location = new Point(478, 479);
            bayarButton.Name = "bayarButton";
            bayarButton.Size = new Size(178, 29);
            bayarButton.TabIndex = 16;
            bayarButton.Text = "Bayar";
            bayarButton.UseVisualStyleBackColor = false;
            // 
            // bookMentorDateTimePicker
            // 
            bookMentorDateTimePicker.Location = new Point(48, 182);
            bookMentorDateTimePicker.Name = "bookMentorDateTimePicker";
            bookMentorDateTimePicker.Size = new Size(250, 27);
            bookMentorDateTimePicker.TabIndex = 15;
            // 
            // BookingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(searchButton);
            Controls.Add(BookAMentorLabel);
            Controls.Add(comboBoxCourseName);
            Controls.Add(masukListButton);
            Controls.Add(bayarButton);
            Controls.Add(bookMentorDateTimePicker);
            Name = "BookingPage";
            Size = new Size(705, 578);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button searchButton;
        private Label BookAMentorLabel;
        private ComboBox comboBoxCourseName;
        private Button masukListButton;
        private Button bayarButton;
        private DateTimePicker bookMentorDateTimePicker;
    }
}
