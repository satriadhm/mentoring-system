namespace mentoring_system.view.Mentor
{
    partial class acceptanceMentorship
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
            mentorRequestDeclineButton = new Button();
            menteeAcceptRequestButton = new Button();
            menteeRequestName = new TextBox();
            menteeRequestSchedule = new TextBox();
            menteeNameRequestLabel = new Label();
            menteeScheduleRequestLabel = new Label();
            SuspendLayout();
            // 
            // mentorRequestDeclineButton
            // 
            mentorRequestDeclineButton.BackColor = Color.Firebrick;
            mentorRequestDeclineButton.FlatAppearance.BorderSize = 0;
            mentorRequestDeclineButton.FlatStyle = FlatStyle.Flat;
            mentorRequestDeclineButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mentorRequestDeclineButton.ForeColor = SystemColors.Control;
            mentorRequestDeclineButton.Location = new Point(55, 143);
            mentorRequestDeclineButton.Name = "mentorRequestDeclineButton";
            mentorRequestDeclineButton.Size = new Size(121, 44);
            mentorRequestDeclineButton.TabIndex = 19;
            mentorRequestDeclineButton.Text = "Decline";
            mentorRequestDeclineButton.UseVisualStyleBackColor = false;
            // 
            // menteeAcceptRequestButton
            // 
            menteeAcceptRequestButton.BackColor = Color.MediumSeaGreen;
            menteeAcceptRequestButton.FlatAppearance.BorderSize = 0;
            menteeAcceptRequestButton.FlatStyle = FlatStyle.Flat;
            menteeAcceptRequestButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            menteeAcceptRequestButton.ForeColor = SystemColors.ButtonFace;
            menteeAcceptRequestButton.Location = new Point(226, 143);
            menteeAcceptRequestButton.Name = "menteeAcceptRequestButton";
            menteeAcceptRequestButton.Size = new Size(121, 44);
            menteeAcceptRequestButton.TabIndex = 18;
            menteeAcceptRequestButton.Text = "Accept";
            menteeAcceptRequestButton.UseVisualStyleBackColor = false;
            // 
            // menteeRequestName
            // 
            menteeRequestName.Location = new Point(170, 43);
            menteeRequestName.Name = "menteeRequestName";
            menteeRequestName.Size = new Size(177, 27);
            menteeRequestName.TabIndex = 20;
            // 
            // menteeRequestSchedule
            // 
            menteeRequestSchedule.Location = new Point(170, 91);
            menteeRequestSchedule.Name = "menteeRequestSchedule";
            menteeRequestSchedule.Size = new Size(177, 27);
            menteeRequestSchedule.TabIndex = 21;
            // 
            // menteeNameRequestLabel
            // 
            menteeNameRequestLabel.AutoSize = true;
            menteeNameRequestLabel.Location = new Point(55, 50);
            menteeNameRequestLabel.Name = "menteeNameRequestLabel";
            menteeNameRequestLabel.Size = new Size(49, 20);
            menteeNameRequestLabel.TabIndex = 22;
            menteeNameRequestLabel.Text = "Name";
            // 
            // menteeScheduleRequestLabel
            // 
            menteeScheduleRequestLabel.AutoSize = true;
            menteeScheduleRequestLabel.Location = new Point(55, 94);
            menteeScheduleRequestLabel.Name = "menteeScheduleRequestLabel";
            menteeScheduleRequestLabel.Size = new Size(69, 20);
            menteeScheduleRequestLabel.TabIndex = 23;
            menteeScheduleRequestLabel.Text = "Schedule";
            // 
            // acceptanceMentorship
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 212);
            Controls.Add(menteeScheduleRequestLabel);
            Controls.Add(menteeNameRequestLabel);
            Controls.Add(menteeRequestSchedule);
            Controls.Add(menteeRequestName);
            Controls.Add(mentorRequestDeclineButton);
            Controls.Add(menteeAcceptRequestButton);
            Name = "acceptanceMentorship";
            Text = "acceptanceMentorship";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mentorRequestDeclineButton;
        private Button menteeAcceptRequestButton;
        private TextBox menteeRequestName;
        private TextBox menteeRequestSchedule;
        private Label menteeNameRequestLabel;
        private Label menteeScheduleRequestLabel;
    }
}