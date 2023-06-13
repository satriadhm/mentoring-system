namespace mentoring_system.view.Mentee
{
    partial class MessagePages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagePages));
            panel1 = new Panel();
            DashboardButton = new Button();
            panel3 = new Panel();
            labelContact = new Label();
            profileContactButton = new Button();
            profileButton = new Button();
            messagePicture = new PictureBox();
            panel2 = new Panel();
            labelMassage = new Label();
            pictureSend = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)messagePicture).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSend).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(DashboardButton);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 637);
            panel1.TabIndex = 1;
            // 
            // DashboardButton
            // 
            DashboardButton.BackColor = Color.PeachPuff;
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DashboardButton.ForeColor = Color.SaddleBrown;
            DashboardButton.Location = new Point(2, 10);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(101, 35);
            DashboardButton.TabIndex = 1;
            DashboardButton.Text = "Dashboard";
            DashboardButton.UseVisualStyleBackColor = false;
            DashboardButton.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelContact);
            panel3.Controls.Add(profileContactButton);
            panel3.Location = new Point(0, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 60);
            panel3.TabIndex = 0;
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelContact.ForeColor = Color.SaddleBrown;
            labelContact.Location = new Point(44, 18);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(101, 23);
            labelContact.TabIndex = 4;
            labelContact.Text = "Mentor Zira";
            // 
            // profileContactButton
            // 
            profileContactButton.BackColor = Color.Transparent;
            profileContactButton.BackgroundImage = (Image)resources.GetObject("profileContactButton.BackgroundImage");
            profileContactButton.BackgroundImageLayout = ImageLayout.Stretch;
            profileContactButton.FlatAppearance.BorderColor = Color.Moccasin;
            profileContactButton.FlatAppearance.BorderSize = 0;
            profileContactButton.FlatAppearance.MouseDownBackColor = Color.Moccasin;
            profileContactButton.FlatAppearance.MouseOverBackColor = Color.White;
            profileContactButton.FlatStyle = FlatStyle.Flat;
            profileContactButton.Location = new Point(3, 13);
            profileContactButton.Name = "profileContactButton";
            profileContactButton.Size = new Size(35, 35);
            profileContactButton.TabIndex = 3;
            profileContactButton.UseVisualStyleBackColor = false;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.WhiteSmoke;
            profileButton.BackgroundImage = (Image)resources.GetObject("profileButton.BackgroundImage");
            profileButton.BackgroundImageLayout = ImageLayout.Stretch;
            profileButton.FlatAppearance.BorderColor = Color.Moccasin;
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatAppearance.MouseDownBackColor = Color.Moccasin;
            profileButton.FlatAppearance.MouseOverBackColor = Color.White;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Location = new Point(734, 67);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(56, 54);
            profileButton.TabIndex = 4;
            profileButton.UseVisualStyleBackColor = false;
            // 
            // messagePicture
            // 
            messagePicture.Image = Properties.Resources._4_40385_iphone_text_bubble_png_blue_blue_text_bubble;
            messagePicture.Location = new Point(466, 78);
            messagePicture.Name = "messagePicture";
            messagePicture.Size = new Size(262, 43);
            messagePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            messagePicture.TabIndex = 3;
            messagePicture.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.NavajoWhite;
            panel2.Controls.Add(labelMassage);
            panel2.Controls.Add(pictureSend);
            panel2.Location = new Point(249, 569);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 69);
            panel2.TabIndex = 5;
            // 
            // labelMassage
            // 
            labelMassage.AutoSize = true;
            labelMassage.ForeColor = Color.SaddleBrown;
            labelMassage.Location = new Point(16, 23);
            labelMassage.Name = "labelMassage";
            labelMassage.Size = new Size(82, 20);
            labelMassage.TabIndex = 1;
            labelMassage.Text = "Type here...";
            // 
            // pictureSend
            // 
            pictureSend.Image = (Image)resources.GetObject("pictureSend.Image");
            pictureSend.Location = new Point(510, 22);
            pictureSend.Name = "pictureSend";
            pictureSend.Size = new Size(31, 35);
            pictureSend.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSend.TabIndex = 0;
            pictureSend.TabStop = false;
            // 
            // MessagePages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 638);
            Controls.Add(panel2);
            Controls.Add(profileButton);
            Controls.Add(messagePicture);
            Controls.Add(panel1);
            Name = "MessagePages";
            Text = "MessagePages";
            Load += MessagePages_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)messagePicture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSend).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label labelContact;
        private Button profileContactButton;
        private Button profileButton;
        private PictureBox messagePicture;
        private Button DashboardButton;
        private Panel panel2;
        private Label labelMassage;
        private PictureBox pictureSend;
    }
}