using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mentoring_system.view.Mentee
{
    public partial class MessagePages : Form
    {
        model.Mentee Mentee;
        public MessagePages(model.Mentee Mentee)
        {
            InitializeComponent();
            this.Mentee = Mentee;
        }

        private void MessagePages_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardMentee dashboard = new DashboardMentee(Mentee);
            dashboard.ShowDialog();
        }
    }
}
