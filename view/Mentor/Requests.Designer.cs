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
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            MenteeRequests = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)MenteeRequests).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(410, 520);
            button2.Name = "button2";
            button2.Size = new Size(121, 44);
            button2.TabIndex = 22;
            button2.Text = "Decline";
            button2.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(548, 520);
            button1.Name = "button1";
            button1.Size = new Size(121, 44);
            button1.TabIndex = 21;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = false;
            // 
            // Requests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MenteeRequests);
            Controls.Add(button1);
            Name = "Requests";
            Size = new Size(700, 600);
            ((System.ComponentModel.ISupportInitialize)MenteeRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private Label label1;
        private DataGridView MenteeRequests;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn dateColumn;
        private Button button1;
    }
}
