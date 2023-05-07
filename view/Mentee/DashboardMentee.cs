using mentoring_system.model;
using mentoring_system.view.Mentee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mentoring_system.view
{
    public partial class DashboardMentee : Form
    {
        public DashboardMentee(mentee Mentee)
        {
            // Precondition: parameter Mentee tidak boleh null
            Debug.Assert(Mentee != null, "Mentee should not be null");

            InitializeComponent();
            string[] role = { "Mentor", "Mente" };

            coursePage.SendToBack();
            bookingPage.SendToBack();
            mySchedulePage.SendToBack();

            labelRole.Text = $"Your Role: {role[(int)Mentee.role]}";

            // Postcondition: labelRole harus berisi teks "Your Role: Mentor" atau "Your Role: Mente"
            Debug.Assert(labelRole.Text == $"Your Role: {role[(int)Mentee.role]}", "Invalid labelRole value");
        }


        private void bookButton_Click(object sender, EventArgs e)
        {

            bookingPage.BringToFront();
        }


        private void scheduleButton_Click(object sender, EventArgs e)
        {
            mySchedulePage.BringToFront();
        }

        private void lessonButton_Click(object sender, EventArgs e)
        {
            coursePage.BringToFront();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
        }

        private void greetingLabel_Click(object sender, EventArgs e)
        {

        }

        private void profileButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ProfilePageMentee profilepage = new ProfilePageMentee();
            profilepage.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }
    }
}
