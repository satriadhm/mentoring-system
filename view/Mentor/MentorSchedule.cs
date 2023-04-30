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

        private async void button1_Click(object sender, EventArgs e)
        {
            ScheduleTable.Rows.Add(comboBox1.SelectedItem, dateTimePicker1.Value);
            genericsMentorship<string> mentorship = new genericsMentorship<string>(1, "Mentor123", "Mentee456");

            HttpClient client = new HttpClient();
            string baseUrl = "http://128.199.77.50:5132/api/mentorship";
            HttpResponseMessage response = await client.PostAsJsonAsync(baseUrl, mentorship);


        }

        private void ScheduleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
