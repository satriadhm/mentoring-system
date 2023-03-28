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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
    }
}
