namespace mentoring_system.view.Mentor
{
    partial class acceptancePage
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
            declineButton = new Button();
            acceptButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            menteeRequestLabel = new Label();
            scheduleRequestLabel = new Label();
            SuspendLayout();
            // 
            // declineButton
            // 
            declineButton.BackColor = Color.Firebrick;
            declineButton.FlatAppearance.BorderSize = 0;
            declineButton.FlatStyle = FlatStyle.Flat;
            declineButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            declineButton.ForeColor = SystemColors.Control;
            declineButton.Location = new Point(75, 156);
            declineButton.Name = "declineButton";
            declineButton.Size = new Size(121, 44);
            declineButton.TabIndex = 24;
            declineButton.Text = "Decline";
            declineButton.UseVisualStyleBackColor = false;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.MediumSeaGreen;
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            acceptButton.ForeColor = SystemColors.ButtonFace;
            acceptButton.Location = new Point(213, 156);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(121, 44);
            acceptButton.TabIndex = 23;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 26;
            // 
            // menteeRequestLabel
            // 
            menteeRequestLabel.AutoSize = true;
            menteeRequestLabel.Location = new Point(75, 54);
            menteeRequestLabel.Name = "menteeRequestLabel";
            menteeRequestLabel.Size = new Size(49, 20);
            menteeRequestLabel.TabIndex = 27;
            menteeRequestLabel.Text = "Name";
            // 
            // scheduleRequestLabel
            // 
            scheduleRequestLabel.AutoSize = true;
            scheduleRequestLabel.Location = new Point(75, 105);
            scheduleRequestLabel.Name = "scheduleRequestLabel";
            scheduleRequestLabel.Size = new Size(69, 20);
            scheduleRequestLabel.TabIndex = 28;
            scheduleRequestLabel.Text = "Schedule";
            // 
            // acceptancePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 254);
            Controls.Add(scheduleRequestLabel);
            Controls.Add(menteeRequestLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(declineButton);
            Controls.Add(acceptButton);
            Name = "acceptancePage";
            Text = "Accept Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button declineButton;
        private Button acceptButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label menteeRequestLabel;
        private Label scheduleRequestLabel;
    }
}