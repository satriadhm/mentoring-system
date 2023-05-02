using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Security.Policy;
using mentoring_system.view.Mentor;
using mentoring_system.model;

namespace mentoring_system.view
{
    public partial class DashboardMentor : Form
    {
        private mentor Mentor;
        public DashboardMentor(mentor Mentor)
        {
            this.Mentor = Mentor;
            InitializeComponent();
            Dropdown.Visible = false;
            mentorSchedule2.SendToBack();
            userName.Text = $"Welcome, {Mentor.NamaLengkap}";

        }

        private void HideDropdown()
        {
            if (Dropdown.Visible)
            {
                Dropdown.Visible = false;
            }
        }

        private void ShowDropdown(Panel submenu)
        {
            if (!submenu.Visible)
            {
                HideDropdown();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mentorSchedule2.BringToFront();
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            ShowDropdown(Dropdown);
        }

        private void DashboardMentor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            mentorSchedule2.SendToBack();
            requests1.SendToBack();
        }

        private void RequestsBtn_Click(object sender, EventArgs e)
        {
            requests1.BringToFront();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
