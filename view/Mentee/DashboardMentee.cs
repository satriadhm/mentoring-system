using mentoring_system.view.Mentee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mentoring_system.view
{
    public partial class DashboardMentee : Form
    {
        public DashboardMentee()
        {
            InitializeComponent();
            coursePage.SendToBack();
            bookingPage.SendToBack();
            mySchedulePage.SendToBack();

        }

        private void bookButton_Click(object sender, EventArgs e)
        {

            bookingPage.BringToFront();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfilePage profilepage = new ProfilePage();
            profilepage.ShowDialog();
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

        private void appointmentBookedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
