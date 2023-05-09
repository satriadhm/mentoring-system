using mentoring_system.controller;
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
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.PAYMENT);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.CANCELDATE);
            this.Hide();
        }
    }
}
