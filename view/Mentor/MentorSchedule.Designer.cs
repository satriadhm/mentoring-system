namespace mentoring_system.view.Mentor
{
    partial class MentorSchedule
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
            button1 = new Button();
            ScheduleTable = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ScheduleTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(494, 137);
            button1.Name = "button1";
            button1.Size = new Size(90, 45);
            button1.TabIndex = 15;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ScheduleTable
            // 
            ScheduleTable.AllowUserToAddRows = false;
            ScheduleTable.AllowUserToDeleteRows = false;
            ScheduleTable.AllowUserToResizeColumns = false;
            ScheduleTable.AllowUserToResizeRows = false;
            ScheduleTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ScheduleTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            ScheduleTable.BackgroundColor = SystemColors.InactiveCaption;
            ScheduleTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ScheduleTable.ColumnHeadersHeight = 30;
            ScheduleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ScheduleTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            ScheduleTable.Location = new Point(29, 206);
            ScheduleTable.Name = "ScheduleTable";
            ScheduleTable.RowHeadersVisible = false;
            ScheduleTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ScheduleTable.RowTemplate.Height = 25;
            ScheduleTable.Size = new Size(555, 250);
            ScheduleTable.TabIndex = 14;
            ScheduleTable.CellContentClick += ScheduleTable_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ButtonShadow;
            dateTimePicker1.Location = new Point(262, 137);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MinimumSize = new Size(4, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 45);
            dateTimePicker1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(19, 56);
            label2.Name = "label2";
            label2.Size = new Size(443, 25);
            label2.TabIndex = 12;
            label2.Text = "Take control of your mentoring schedule with ease";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 11;
            label1.Text = "Set Schedule";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.ItemHeight = 15;
            comboBox1.Items.AddRange(new object[] { "interactionDesign", "Algorithm", "dataStructure" });
            comboBox1.Location = new Point(29, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(262, 108);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 17;
            label3.Text = "New Schedule";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(29, 108);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 18;
            label4.Text = "Mentoring Subject";
            // 
            // Column1
            // 
            Column1.HeaderText = "Date";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Subject";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // MentorSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(ScheduleTable);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MentorSchedule";
            Size = new Size(615, 459);
            ((System.ComponentModel.ISupportInitialize)ScheduleTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView ScheduleTable;

        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
