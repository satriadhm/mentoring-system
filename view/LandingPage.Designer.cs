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
            pictureMentor = new PictureBox();
            pictureMentee = new PictureBox();
            buttonMentor = new Button();
            buttonMentee = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureMentor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureMentee).BeginInit();
            SuspendLayout();
            // 
            // pictureMentor
            // 
            pictureMentor.Image = Properties.Resources.teacher;
            pictureMentor.Location = new Point(171, 206);
            pictureMentor.Name = "pictureMentor";
            pictureMentor.Size = new Size(200, 200);
            pictureMentor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMentor.TabIndex = 0;
            pictureMentor.TabStop = false;
            // 
            // pictureMentee
            // 
            pictureMentee.Image = Properties.Resources.student;
            pictureMentee.Location = new Point(452, 206);
            pictureMentee.Name = "pictureMentee";
            pictureMentee.Size = new Size(200, 200);
            pictureMentee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMentee.TabIndex = 1;
            pictureMentee.TabStop = false;
            // 
            // buttonMentor
            // 
            buttonMentor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMentor.Location = new Point(171, 426);
            buttonMentor.Name = "buttonMentor";
            buttonMentor.Size = new Size(200, 45);
            buttonMentor.TabIndex = 2;
            buttonMentor.Text = "Mentor";
            buttonMentor.UseVisualStyleBackColor = true;
            buttonMentor.Click += buttonMentor_Click;
            // 
            // buttonMentee
            // 
            buttonMentee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMentee.Location = new Point(452, 426);
            buttonMentee.Name = "buttonMentee";
            buttonMentee.Size = new Size(200, 45);
            buttonMentee.TabIndex = 3;
            buttonMentee.Text = "Mentee";
            buttonMentee.UseVisualStyleBackColor = true;
            buttonMentee.Click += buttonMentee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(191, 62);
            label1.Name = "label1";
            label1.Size = new Size(426, 36);
            label1.TabIndex = 4;
            label1.Text = "Welcome to Mentoring System!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(294, 120);
            label2.Name = "label2";
            label2.Size = new Size(238, 25);
            label2.TabIndex = 5;
            label2.Text = "You can choose your role ";
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 637);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonMentee);
            Controls.Add(buttonMentor);
            Controls.Add(pictureMentee);
            Controls.Add(pictureMentor);
            Name = "LandingPage";
            Text = "Landing Page";
            ((System.ComponentModel.ISupportInitialize)pictureMentor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureMentee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureMentor;
        private PictureBox pictureMentee;
        private Button buttonMentor;
        private Button buttonMentee;
        private Label label1;
        private Label label2;
    }
}