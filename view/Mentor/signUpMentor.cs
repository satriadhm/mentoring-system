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
using mentoring_system.implementation;

namespace mentoring_system.view.Mentor
{
    public partial class signUpMentor : Form
    {
        registerstate registerState = new registerstate();

        static HttpClient client = new HttpClient();
        public signUpMentor()
        {
            InitializeComponent();
            registerState.ActivateTrigger(registerstate.bookTrigger.OPEN_SIGNUP_PAGE);

        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            string namaLengkapMentor = namaLengkapTextBox.Text;
            string usernameMentor = usernameTextBox.Text;
            string passwordMentor = passwordTextBox.Text;
            string umurMentor = umurTextBox.Text;

            subjekMentoring subjek;

            if (dataStructureRadioButton.Checked)
            {
                subjek = subjekMentoring.dataStructure;
            }
            else if (algorithmProgrammingRadioButton.Checked)
            {
                subjek = subjekMentoring.Algorithm;
            }
            else if (interactionDesignRadioButton.Checked)
            {
                subjek = subjekMentoring.interactionDesign;
            }
            else 
            {
                subjek = 0;
            }
            model.mentor mentorData = new(namaLengkapMentor, usernameMentor, passwordMentor, umurMentor, subjek);
            Console.WriteLine(mentorData.NamaLengkap,mentorData.umur,mentorData.userName);
            string urlCloud = "http://128.199.77.50:5132/api/mentor";
            string urlLocal = "http://localhost:5132/api/mentor";
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(urlCloud, mentorData);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Error: " + urlLocal);
            }

            //JSONparserBase jSONparserBase = new JSONparserBase(); ;
            //jSONparserBase.WriteJSON(mentorData,"mentor");

            this.Hide();
            registerState.ActivateTrigger(registerstate.bookTrigger.OPEN_DASHBOARD);
            DashboardMentor dashboard = new DashboardMentor();
            dashboard.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMentor login = new LoginMentor();
            login.Show();
        }
    }
}
