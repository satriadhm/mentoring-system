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
            coursePage1.SendToBack();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookMentor bookingPage = new BookMentor();
            bookingPage.ShowDialog();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfilePage profilepage = new ProfilePage();
            profilepage.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LessonLearnedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void coursePage1_Load(object sender, EventArgs e)
        {

        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {

        }

        private void lessonButton_Click(object sender, EventArgs e)
        {
            coursePage1.BringToFront();
        }

        private void coursePage1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
