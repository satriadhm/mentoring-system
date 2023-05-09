using mentoring_system.implementation;
using mentoring_system.view.Mentee;
using mentoring_system.model;
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
    public partial class ProfilePageMentee : Form
    {
        mentee Mentee;
        public ProfilePageMentee(mentee Mentee)
        {
            InitializeComponent();
            this.Mentee = Mentee;
            LoadDataMentee();
        }

        public void LoadDataMentee()
        {
            ProfileSet<string> profile = new ProfileSet<string>(Mentee.NamaLengkap, Mentee.umur, Mentee.userName, Mentee.password);
            textBoxNamaLengkap.Text = profile.Getnama().ToString();
            textBoxUmur.Text = profile.Getumur().ToString();
            textBoxUserName.Text = profile.GetuserName().ToString();
            textBoxPassword.Text = profile.Getpassword().ToString();


        }

        public bool IsUsernameValid(string username)
        {
            if (username.Any(char.IsUpper))
            {
                return true;
            }
            return false;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButtton_Click(object sender, EventArgs e)
        {
            signUpMentee.menteeData.NamaLengkap = textBoxNamaLengkap.Text;
            signUpMentee.menteeData.umur = textBoxUmur.Text;
            signUpMentee.menteeData.userName = textBoxUserName.Text;
            signUpMentee.menteeData.password = textBoxPassword.Text;

            this.Hide();
            DashboardMentee dashboard = new DashboardMentee(signUpMentee.menteeData);
            dashboard.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardMentee dashboard = new DashboardMentee(signUpMentee.menteeData);
            dashboard.ShowDialog();
        }
    }
}
