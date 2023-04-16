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
    public partial class DashboardMentor : Form
    {
        public DashboardMentor()
        {
            InitializeComponent();
            Dropdown.Visible = false;
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
    }
}
