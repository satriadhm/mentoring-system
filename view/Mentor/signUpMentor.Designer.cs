namespace mentoring_system.view.Mentor
{
    partial class signUpMentor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpMentor));
            umurLabel = new Label();
            umurTextBox = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            namaLengkapTextBox = new TextBox();
            pictureBoxLoginPageMentor = new PictureBox();
            loginButton = new Button();
            registerButton = new Button();
            subjectLabel = new Label();
            dataStructureRadioButton = new RadioButton();
            interactionDesignRadioButton = new RadioButton();
            algorithmProgrammingRadioButton = new RadioButton();
            namaLengkapLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoginPageMentor).BeginInit();
            SuspendLayout();
            // 
            // umurLabel
            // 
            umurLabel.AutoSize = true;
            umurLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            umurLabel.Location = new Point(399, 171);
            umurLabel.Name = "umurLabel";
            umurLabel.Size = new Size(49, 20);
            umurLabel.TabIndex = 22;
            umurLabel.Text = "Umur";
            // 
            // umurTextBox
            // 
            umurTextBox.Location = new Point(399, 194);
            umurTextBox.Name = "umurTextBox";
            umurTextBox.Size = new Size(335, 27);
            umurTextBox.TabIndex = 21;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(399, 308);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(399, 241);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(80, 20);
            usernameLabel.TabIndex = 19;
            usernameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(399, 331);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(335, 27);
            passwordTextBox.TabIndex = 17;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(399, 264);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(335, 27);
            usernameTextBox.TabIndex = 16;
            // 
            // namaLengkapTextBox
            // 
            namaLengkapTextBox.Location = new Point(399, 127);
            namaLengkapTextBox.Name = "namaLengkapTextBox";
            namaLengkapTextBox.Size = new Size(335, 27);
            namaLengkapTextBox.TabIndex = 15;
            namaLengkapTextBox.TextChanged += namaLengkapTextBox_TextChanged;
            // 
            // pictureBoxLoginPageMentor
            // 
            pictureBoxLoginPageMentor.Image = (Image)resources.GetObject("pictureBoxLoginPageMentor.Image");
            pictureBoxLoginPageMentor.Location = new Point(1, 0);
            pictureBoxLoginPageMentor.Name = "pictureBoxLoginPageMentor";
            pictureBoxLoginPageMentor.Size = new Size(345, 638);
            pictureBoxLoginPageMentor.TabIndex = 25;
            pictureBoxLoginPageMentor.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LightSkyBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(516, 584);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(218, 33);
            loginButton.TabIndex = 27;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.PaleTurquoise;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Location = new Point(516, 527);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(218, 39);
            registerButton.TabIndex = 26;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            subjectLabel.Location = new Point(399, 378);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(60, 20);
            subjectLabel.TabIndex = 28;
            subjectLabel.Text = "Subject";
            // 
            // dataStructureRadioButton
            // 
            dataStructureRadioButton.AutoSize = true;
            dataStructureRadioButton.Location = new Point(399, 414);
            dataStructureRadioButton.Name = "dataStructureRadioButton";
            dataStructureRadioButton.Size = new Size(125, 24);
            dataStructureRadioButton.TabIndex = 29;
            dataStructureRadioButton.TabStop = true;
            dataStructureRadioButton.Text = "Data Structure";
            dataStructureRadioButton.UseVisualStyleBackColor = true;
            dataStructureRadioButton.CheckedChanged += dataStructureRadioButton_CheckedChanged;
            // 
            // interactionDesignRadioButton
            // 
            interactionDesignRadioButton.AutoSize = true;
            interactionDesignRadioButton.Location = new Point(545, 414);
            interactionDesignRadioButton.Name = "interactionDesignRadioButton";
            interactionDesignRadioButton.Size = new Size(151, 24);
            interactionDesignRadioButton.TabIndex = 30;
            interactionDesignRadioButton.TabStop = true;
            interactionDesignRadioButton.Text = "Interaction Design";
            interactionDesignRadioButton.UseVisualStyleBackColor = true;
            // 
            // algorithmProgrammingRadioButton
            // 
            algorithmProgrammingRadioButton.AutoSize = true;
            algorithmProgrammingRadioButton.Location = new Point(399, 456);
            algorithmProgrammingRadioButton.Name = "algorithmProgrammingRadioButton";
            algorithmProgrammingRadioButton.Size = new Size(192, 24);
            algorithmProgrammingRadioButton.TabIndex = 31;
            algorithmProgrammingRadioButton.TabStop = true;
            algorithmProgrammingRadioButton.Text = "Algorithm Programming";
            algorithmProgrammingRadioButton.UseVisualStyleBackColor = true;
            // 
            // namaLengkapLabel
            // 
            namaLengkapLabel.AutoSize = true;
            namaLengkapLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            namaLengkapLabel.Location = new Point(399, 104);
            namaLengkapLabel.Name = "namaLengkapLabel";
            namaLengkapLabel.Size = new Size(114, 20);
            namaLengkapLabel.TabIndex = 18;
            namaLengkapLabel.Text = "Nama Lengkap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(399, 54);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 24;
            label1.Text = "Register and scale up your skill!";
            // 
            // signUpMentor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 638);
            Controls.Add(algorithmProgrammingRadioButton);
            Controls.Add(interactionDesignRadioButton);
            Controls.Add(dataStructureRadioButton);
            Controls.Add(subjectLabel);
            Controls.Add(loginButton);
            Controls.Add(registerButton);
            Controls.Add(pictureBoxLoginPageMentor);
            Controls.Add(label1);
            Controls.Add(umurLabel);
            Controls.Add(umurTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(namaLengkapLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(namaLengkapTextBox);
            MaximizeBox = false;
            Name = "signUpMentor";
            Text = "signUpMentor";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoginPageMentor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label umurLabel;
        private TextBox umurTextBox;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private TextBox namaLengkapTextBox;
        private PictureBox pictureBoxLoginPageMentor;
        private Button loginButton;
        private Button registerButton;
        private Label subjectLabel;
        private RadioButton dataStructureRadioButton;
        private RadioButton interactionDesignRadioButton;
        private RadioButton algorithmProgrammingRadioButton;
        private Label label1;
        private Label namaLengkapLabel;
    }
}