namespace mentoring_system.view.Mentor
{
    partial class Requests
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DeclineBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            MenteeRequests = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            AcceptBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)MenteeRequests).BeginInit();
            SuspendLayout();
            // 
            // DeclineBtn
            // 
            DeclineBtn.BackColor = Color.Firebrick;
            DeclineBtn.FlatAppearance.BorderSize = 0;
            DeclineBtn.FlatStyle = FlatStyle.Flat;
            DeclineBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeclineBtn.ForeColor = SystemColors.Control;
            DeclineBtn.Location = new Point(410, 520);
            DeclineBtn.Name = "DeclineBtn";
            DeclineBtn.Size = new Size(121, 44);
            DeclineBtn.TabIndex = 22;
            DeclineBtn.Text = "Decline";
            DeclineBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(35, 88);
            label2.Name = "label2";
            label2.Size = new Size(526, 31);
            label2.TabIndex = 19;
            label2.Text = "View and manage incoming mentorship requests.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(329, 45);
            label1.TabIndex = 18;
            label1.Text = "Mentorship Requests";
            label1.Click += label1_Click;
            // 
            // MenteeRequests
            // 
            MenteeRequests.AllowUserToAddRows = false;
            MenteeRequests.AllowUserToDeleteRows = false;
            MenteeRequests.AllowUserToResizeColumns = false;
            MenteeRequests.AllowUserToResizeRows = false;
            MenteeRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MenteeRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            MenteeRequests.BackgroundColor = SystemColors.InactiveCaption;
            MenteeRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MenteeRequests.ColumnHeadersHeight = 30;
            MenteeRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MenteeRequests.Columns.AddRange(new DataGridViewColumn[] { nameColumn, dateColumn });
            MenteeRequests.Location = new Point(35, 154);
            MenteeRequests.Margin = new Padding(3, 4, 3, 4);
            MenteeRequests.Name = "MenteeRequests";
            MenteeRequests.RowHeadersVisible = false;
            MenteeRequests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            MenteeRequests.RowTemplate.Height = 25;
            MenteeRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MenteeRequests.Size = new Size(634, 333);
            MenteeRequests.TabIndex = 20;
            MenteeRequests.CellContentClick += MenteeRequests_CellContentClick;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Mentee's Name";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Mentoring Date Request";
            dateColumn.MinimumWidth = 6;
            dateColumn.Name = "dateColumn";
            dateColumn.ReadOnly = true;
            // 
            // AcceptBtn
            // 
            AcceptBtn.BackColor = Color.MediumSeaGreen;
            AcceptBtn.FlatAppearance.BorderSize = 0;
            AcceptBtn.FlatStyle = FlatStyle.Flat;
            AcceptBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AcceptBtn.ForeColor = SystemColors.ButtonFace;
            AcceptBtn.Location = new Point(548, 520);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(121, 44);
            AcceptBtn.TabIndex = 21;
            AcceptBtn.Text = "Accept";
            AcceptBtn.UseVisualStyleBackColor = false;
            AcceptBtn.Click += button1_Click;
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeclineBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MenteeRequests);
            Controls.Add(AcceptBtn);
            Name = "Requests";
            Size = new Size(700, 600);
            ((System.ComponentModel.ISupportInitialize)MenteeRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeclineBtn;
        private Label label2;
        private Label label1;
        private DataGridView MenteeRequests;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn dateColumn;
        private Button AcceptBtn;
    }
}
