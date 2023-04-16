namespace mentoring_system
{
    partial class LoginMentee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMentee));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            loginAsset = new PictureBox();
            copyWritingLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginAsset).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlLightLight;
            splitContainer1.Panel2.Controls.Add(loginAsset);
            splitContainer1.Panel2.Controls.Add(copyWritingLabel);
            splitContainer1.Panel2.Controls.Add(passwordLabel);
            splitContainer1.Panel2.Controls.Add(usernameLabel);
            splitContainer1.Panel2.Controls.Add(loginButton);
            splitContainer1.Panel2.Controls.Add(passwordTextBox);
            splitContainer1.Panel2.Controls.Add(usernameTextbox);
            splitContainer1.Size = new Size(802, 638);
            splitContainer1.SplitterDistance = 335;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 633);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loginAsset
            // 
            loginAsset.Image = (Image)resources.GetObject("loginAsset.Image");
            loginAsset.Location = new Point(320, 69);
            loginAsset.Name = "loginAsset";
            loginAsset.Size = new Size(102, 97);
            loginAsset.TabIndex = 7;
            loginAsset.TabStop = false;
            // 
            // copyWritingLabel
            // 
            copyWritingLabel.AutoSize = true;
            copyWritingLabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            copyWritingLabel.Location = new Point(135, 197);
            copyWritingLabel.MaximumSize = new Size(300, 0);
            copyWritingLabel.Name = "copyWritingLabel";
            copyWritingLabel.Size = new Size(287, 40);
            copyWritingLabel.TabIndex = 6;
            copyWritingLabel.Text = "\"Unlock your potential with our mentorship program - register now!\"";
            copyWritingLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(190, 346);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(190, 259);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(247, 445);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(175, 27);
            loginButton.TabIndex = 2;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(190, 369);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(232, 27);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(190, 294);
            usernameTextbox.Multiline = true;
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(232, 26);
            usernameTextbox.TabIndex = 0;
            usernameTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // LoginMentee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 638);
            Controls.Add(splitContainer1);
            Name = "LoginMentee";
            Text = "Login Page";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginAsset).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox passwordTextBox;
        private TextBox usernameTextbox;
        private Button loginButton;
        private PictureBox pictureBox1;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label copyWritingLabel;
        private PictureBox loginAsset;
    }
}