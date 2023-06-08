namespace mentoring_system.view.Mentor
{
    partial class MentorshipGranted
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
            MentoringSchedule = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)MentoringSchedule).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(330, 31);
            label2.TabIndex = 22;
            label2.Text = "View your mentoring schedule";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(167, 45);
            label1.TabIndex = 21;
            label1.Text = "Your Class";
            // 
            // MentoringSchedule
            // 
            MentoringSchedule.AllowUserToAddRows = false;
            MentoringSchedule.AllowUserToDeleteRows = false;
            MentoringSchedule.AllowUserToResizeColumns = false;
            MentoringSchedule.AllowUserToResizeRows = false;
            MentoringSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MentoringSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            MentoringSchedule.BackgroundColor = SystemColors.InactiveCaption;
            MentoringSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MentoringSchedule.ColumnHeadersHeight = 30;
            MentoringSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MentoringSchedule.Columns.AddRange(new DataGridViewColumn[] { nameColumn, dateColumn });
            MentoringSchedule.Location = new Point(35, 134);
            MentoringSchedule.Margin = new Padding(3, 4, 3, 4);
            MentoringSchedule.Name = "MentoringSchedule";
            MentoringSchedule.RowHeadersVisible = false;
            MentoringSchedule.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            MentoringSchedule.RowTemplate.Height = 25;
            MentoringSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MentoringSchedule.Size = new Size(634, 393);
            MentoringSchedule.TabIndex = 23;
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
            dateColumn.HeaderText = "Mentoring Date";
            dateColumn.MinimumWidth = 6;
            dateColumn.Name = "dateColumn";
            dateColumn.ReadOnly = true;
            // 
            // MentorshipGranted
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MentoringSchedule);
            Name = "MentorshipGranted";
            Size = new Size(700, 600);
            ((System.ComponentModel.ISupportInitialize)MentoringSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView MentoringSchedule;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn dateColumn;
    }
}
