using mentoring_system.controller;
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

namespace mentoring_system.view.Mentor
{
    public partial class signUpMentor : Form
    {
        public signUpMentor()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string namaLengkapMentor= namaLengkapTextBox.Text;
            string usernameMentor= usernameTextBox.Text;
            string passwordMentor = passwordTextBox.Text;
            string umurMentor = umurTextBox.Text;
            Console.WriteLine(namaLengkapMentor + usernameMentor + passwordMentor + umurMentor);
            model.mentee menteeData = new(namaLengkapMentor, usernameMentor, passwordMentor, umurMentor, Role.MENTOR);

            JSONparserBase jSONparserBase = new JSONparserBase();
            jSONparserBase.WriteJSON(menteeData,"mentor");
            this.Hide();
            DashboardMentee dashboard = new DashboardMentee();
            dashboard.Show();
        }
    }
}
