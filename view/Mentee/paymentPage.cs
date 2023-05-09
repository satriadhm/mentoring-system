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
using PaymentLibraries;

namespace mentoring_system.view.Mentee
{
    public partial class PaymentPage : Form
    {
        public static string method;
        public PaymentPage()
        {
           
            InitializeComponent();
            PaymentMethodIs(method);
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.PAYMENT);
            PaymentLibraries.PaymentLibraries payment = new PaymentLibraries.PaymentLibraries(method,"Rp",30000);
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.CANCELDATE);
            this.Hide();
        }

        public void PaymentMethodIs(string method) 
        {
           
            if (ewalletRadioButton.Checked)
            {
                method = "e-wallet";
            }
            else if (mobileBankingRadioButton.Checked)
            {
                method = "mobile_banking";
            }
            else if (cashRadioButton.Checked)
            {
                method = "cash";
            }
        }
    }
}
