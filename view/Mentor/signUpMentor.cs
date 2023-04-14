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
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace mentoring_system.view.Mentor
{
    public partial class signUpMentor : Form
    {
        static HttpClient client = new HttpClient();
        public signUpMentor()
        {
            InitializeComponent();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string namaLengkapMentor= namaLengkapTextBox.Text;
            string usernameMentor= usernameTextBox.Text;
            string passwordMentor = passwordTextBox.Text;
            string umurMentor = umurTextBox.Text;
            model.mentor mentorData = new(namaLengkapMentor, usernameMentor, passwordMentor, umurMentor);
            await client.PostAsJsonAsync("http://localhost:5132/api/mentor", mentorData);

            //JSONparserBase jSONparserBase = new JSONparserBase(); ;
            //jSONparserBase.WriteJSON(mentorData,"mentor");
            this.Hide();
            DashboardMentee dashboard = new DashboardMentee();
            dashboard.Show();
        }

    }
}
