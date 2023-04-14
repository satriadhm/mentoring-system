namespace mentoring_system
{
    partial class LoginMentor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMentor));
            pictureBox1 = new PictureBox();
            loginAsset = new PictureBox();
            copyWritingLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextbox = new TextBox();
            loginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginAsset).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 638);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // loginAsset
            // 
            loginAsset.Anchor = AnchorStyles.Top;
            loginAsset.Image = (Image)resources.GetObject("loginAsset.Image");
            loginAsset.Location = new Point(632, 54);
            loginAsset.Name = "loginAsset";
            loginAsset.Size = new Size(102, 97);
            loginAsset.TabIndex = 7;
            loginAsset.TabStop = false;
            // 
            // copyWritingLabel
            // 
            copyWritingLabel.AutoSize = true;
            copyWritingLabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            copyWritingLabel.Location = new Point(447, 190);
            copyWritingLabel.MaximumSize = new Size(300, 0);
            copyWritingLabel.Name = "copyWritingLabel";
            copyWritingLabel.Size = new Size(287, 40);
            copyWritingLabel.TabIndex = 14;
            copyWritingLabel.Text = "\"Unlock your potential with our mentorship program - register now!\"";
            copyWritingLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(502, 339);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(502, 252);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 12;
            usernameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(502, 362);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(232, 27);
            passwordTextBox.TabIndex = 10;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(502, 287);
            usernameTextbox.Multiline = true;
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(232, 26);
            usernameTextbox.TabIndex = 9;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LightSkyBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(516, 440);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(218, 33);
            loginButton.TabIndex = 28;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // LoginMentor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 637);
            Controls.Add(loginButton);
            Controls.Add(copyWritingLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextbox);
            Controls.Add(pictureBox1);
            Controls.Add(loginAsset);
            Name = "LoginMentor";
            Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginAsset).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox loginAsset;
        private Label copyWritingLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextbox;
        private Button loginButton;
    }
}