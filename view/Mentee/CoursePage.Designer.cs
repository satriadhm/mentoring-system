namespace mentoring_system.view
{
    partial class CoursePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursePage));
            CourseYoureTakingLabel = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            listBox2 = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CourseYoureTakingLabel
            // 
            CourseYoureTakingLabel.AutoSize = true;
            CourseYoureTakingLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CourseYoureTakingLabel.ForeColor = Color.SaddleBrown;
            CourseYoureTakingLabel.Location = new Point(423, 64);
            CourseYoureTakingLabel.Name = "CourseYoureTakingLabel";
            CourseYoureTakingLabel.Size = new Size(227, 31);
            CourseYoureTakingLabel.TabIndex = 0;
            CourseYoureTakingLabel.Text = "Course you're taking";
            CourseYoureTakingLabel.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.NavajoWhite;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(176, 232);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(347, 80);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.NavajoWhite;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.NavajoWhite;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(262, 247);
            label2.Name = "label2";
            label2.Size = new Size(216, 25);
            label2.TabIndex = 4;
            label2.Text = "Programming Algorithm";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.NavajoWhite;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(263, 275);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Mentor: Zira";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.NavajoWhite;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(263, 376);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 9;
            label4.Text = "Mentor: Aaron";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.NavajoWhite;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(262, 348);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 8;
            label5.Text = "UI/UX Design";
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.NavajoWhite;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(176, 333);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.NavajoWhite;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.ForeColor = Color.White;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(176, 333);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(347, 80);
            listBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(507, 106);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 10;
            label1.Text = "Course you're taking";
            label1.Click += label1_Click_1;
            // 
            // CoursePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(CourseYoureTakingLabel);
            Name = "CoursePage";
            Size = new Size(705, 578);
            Load += CoursePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CourseYoureTakingLabel;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private ListBox listBox2;
        private Label label1;
    }
}
