using mentoring_system.view.Mentee;
using mentoring_system.view.Mentor;
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
    public partial class LandingPage : Form
    {

        public LandingPage()
        {
            InitializeComponent();
        }

        private void buttonMentee_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpMentee mentee = new signUpMentee();
            mentee.Show();
        }

        private void buttonMentor_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpMentor mentor = new signUpMentor();
            mentor.Show();
        }
    }
}
