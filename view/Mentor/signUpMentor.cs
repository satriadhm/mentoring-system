using mentoring_system.model;
using mentoring_system.implementation;
using System.Diagnostics.Contracts;
using System.Diagnostics;

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
            // Pre Condition: Semua TextBox harus terisi
            Debug.Assert(!string.IsNullOrEmpty(namaLengkapTextBox.Text), "Nama lengkap tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(usernameTextBox.Text), "Username tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(passwordTextBox.Text), "Password tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(umurTextBox.Text), "Umur tidak boleh kosong");

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

            
            mentor mentorData = new(namaLengkapMentor, usernameMentor, passwordMentor, umurMentor, subjek);
            Console.WriteLine(mentorData.NamaLengkap, mentorData.umur, mentorData.userName);

            string urlLocal = "http://localhost:5132/api/mentor";
            string urlCloud = "http://128.1299.77.50:5132/api/mentor";
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(urlCloud, mentorData);
                response.EnsureSuccessStatusCode();
                this.Hide();
                DashboardMentor dashboard = new DashboardMentor(mentorData);
                dashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sign Up Mentor");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMentor login = new LoginMentor();
            login.Show();
        }

        private void namaLengkapTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataStructureRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
