using apimentoringsystem.Controllers;
using mentoring_system.controller;
using mentoring_system.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mentoring_system.view.Mentor
{
    public partial class MentorSchedule : UserControl
    {
        //DataGridView ScheduleTable = new DataGridView();

        public MentorSchedule()
        {
            InitializeComponent();
        }

        private void MentorSchedule_Load(object sender, EventArgs e)
        {
            ScheduleTable.Columns[0].Name = "Date";
            ScheduleTable.Columns[1].Name = "Description";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void ScheduleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
