namespace mentoring_system.view.Mentor
{
    partial class MentorRequests
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
            label2 = new Label();
            label1 = new Label();
            MenteeRequests = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)MenteeRequests).BeginInit();
            SuspendLayout();
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
            MenteeRequests.Location = new Point(35, 226);
            MenteeRequests.Margin = new Padding(3, 4, 3, 4);
            MenteeRequests.Name = "MenteeRequests";
            MenteeRequests.RowHeadersVisible = false;
            MenteeRequests.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            MenteeRequests.RowTemplate.Height = 25;
            MenteeRequests.Size = new Size(634, 342);
            MenteeRequests.TabIndex = 20;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 28);
            comboBox1.TabIndex = 21;
            // 
            // MentorRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MenteeRequests);
            Name = "MentorRequests";
            Size = new Size(703, 598);
            ((System.ComponentModel.ISupportInitialize)MenteeRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private DataGridView MenteeRequests;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn dateColumn;
        private ComboBox comboBox1;
    }
}
