namespace mentoring_system.view.Mentee
{
    partial class signUpMentee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpMentee));
            namaLengkapTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            namaLengkapLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            umurLabel = new Label();
            umurTextBox = new TextBox();
            registerButton = new Button();
            pictureBox1 = new PictureBox();
            RegisterNowLabel = new Label();
            label1 = new Label();
            loginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // namaLengkapTextBox
            // 
            namaLengkapTextBox.Location = new Point(415, 195);
            namaLengkapTextBox.Name = "namaLengkapTextBox";
            namaLengkapTextBox.Size = new Size(335, 27);
            namaLengkapTextBox.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(415, 332);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(335, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(415, 399);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(335, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // namaLengkapLabel
            // 
            namaLengkapLabel.AutoSize = true;
            namaLengkapLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            namaLengkapLabel.Location = new Point(415, 172);
            namaLengkapLabel.Name = "namaLengkapLabel";
            namaLengkapLabel.Size = new Size(114, 20);
            namaLengkapLabel.TabIndex = 3;
            namaLengkapLabel.Text = "Nama Lengkap";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(415, 309);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(80, 20);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(415, 376);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            // 
            // umurLabel
            // 
            umurLabel.AutoSize = true;
            umurLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            umurLabel.Location = new Point(415, 239);
            umurLabel.Name = "umurLabel";
            umurLabel.Size = new Size(49, 20);
            umurLabel.TabIndex = 9;
            umurLabel.Text = "Umur";
            // 
            // umurTextBox
            // 
            umurTextBox.Location = new Point(415, 262);
            umurTextBox.Name = "umurTextBox";
            umurTextBox.Size = new Size(335, 27);
            umurTextBox.TabIndex = 8;
            umurTextBox.TextChanged += umurTextBox_TextChanged;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.NavajoWhite;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Location = new Point(532, 499);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(218, 39);
            registerButton.TabIndex = 11;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 633);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // RegisterNowLabel
            // 
            RegisterNowLabel.AutoSize = true;
            RegisterNowLabel.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterNowLabel.Location = new Point(415, 91);
            RegisterNowLabel.Name = "RegisterNowLabel";
            RegisterNowLabel.Size = new Size(185, 31);
            RegisterNowLabel.TabIndex = 13;
            RegisterNowLabel.Text = "REGISTER NOW";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(415, 122);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 14;
            label1.Text = "Register and scale up your skill!";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.PeachPuff;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(532, 556);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(218, 33);
            loginButton.TabIndex = 15;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // signUpMentee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 638);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(RegisterNowLabel);
            Controls.Add(pictureBox1);
            Controls.Add(registerButton);
            Controls.Add(umurLabel);
            Controls.Add(umurTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(namaLengkapLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(namaLengkapTextBox);
            MaximizeBox = false;
            Name = "signUpMentee";
            Text = "Register / Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox namaLengkapTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label namaLengkapLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label umurLabel;
        private TextBox umurTextBox;
        private Button registerButton;
        private PictureBox pictureBox1;
        private Label RegisterNowLabel;
        private Label label1;
        private Button loginButton;
    }
}