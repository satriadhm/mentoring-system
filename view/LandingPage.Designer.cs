namespace mentoring_system.view
{
    partial class LandingPage
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.teacher;
            pictureBox1.Location = new Point(171, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.student;
            pictureBox2.Location = new Point(452, 206);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(171, 426);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 2;
            button1.Text = "Mentor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Poppins Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(452, 426);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 3;
            button2.Text = "Mentee";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 55);
            label1.Name = "label1";
            label1.Size = new Size(596, 53);
            label1.TabIndex = 4;
            label1.Text = "Selamat Datang di aplikasi Mentoring";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 108);
            label2.Name = "label2";
            label2.Size = new Size(454, 36);
            label2.TabIndex = 5;
            label2.Text = "Silakan pilih user role sesuai kebutuhanmu!";
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 637);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "LandingPage";
            Text = "Landing_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}