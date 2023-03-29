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
            loginAsset = new PictureBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextbox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginAsset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginAsset
            // 
            loginAsset.Anchor = AnchorStyles.Top;
            loginAsset.Image = (Image)resources.GetObject("loginAsset.Image");
            loginAsset.Location = new Point(482, 46);
            loginAsset.Margin = new Padding(3, 2, 3, 2);
            loginAsset.Name = "loginAsset";
            loginAsset.Size = new Size(89, 73);
            loginAsset.TabIndex = 7;
            loginAsset.TabStop = false;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(406, 237);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(406, 164);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            usernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top;
            loginButton.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(489, 326);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(153, 34);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top;
            passwordTextBox.Location = new Point(406, 263);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(236, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.WordWrap = false;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Anchor = AnchorStyles.Top;
            usernameTextbox.Location = new Point(406, 190);
            usernameTextbox.Margin = new Padding(3, 2, 3, 2);
            usernameTextbox.Multiline = true;
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(236, 25);
            usernameTextbox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 478);
            Controls.Add(pictureBox1);
            Controls.Add(loginAsset);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextbox);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(loginButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginPage";
            Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)loginAsset).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordTextBox;
        private TextBox usernameTextbox;
        private Button loginButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private PictureBox loginAsset;
        private PictureBox pictureBox1;
    }
}