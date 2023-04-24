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
            registerMentorButton = new Button();
            registerMenteeButton = new Button();
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
            // registerMentorButton
            // 
            registerMentorButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerMentorButton.Location = new Point(171, 426);
            registerMentorButton.Name = "registerMentorButton";
            registerMentorButton.Size = new Size(200, 45);
            registerMentorButton.TabIndex = 2;
            registerMentorButton.Text = "Mentor";
            registerMentorButton.UseVisualStyleBackColor = true;
            registerMentorButton.Click += buttonMentor_Click;
            // 
            // registerMenteeButton
            // 
            registerMenteeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerMenteeButton.Location = new Point(452, 426);
            registerMenteeButton.Name = "registerMenteeButton";
            registerMenteeButton.Size = new Size(200, 45);
            registerMenteeButton.TabIndex = 3;
            registerMenteeButton.Text = "Mentee";
            registerMenteeButton.UseVisualStyleBackColor = true;
            registerMenteeButton.Click += buttonMentee_Click;
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
            label2.Location = new Point(276, 118);
            label2.Name = "label2";
            label2.Size = new Size(275, 25);
            label2.TabIndex = 5;
            label2.Text = "Register and choose your role ";
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 637);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerMenteeButton);
            Controls.Add(registerMentorButton);
            Controls.Add(pictureMentee);
            Controls.Add(pictureMentor);
            MaximizeBox = false;
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
        private Button registerMentorButton;
        private Button registerMenteeButton;
        private Label label1;
        private Label label2;
    }
}