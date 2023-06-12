using mentoring_system.model;
using mentoring_system.Implementation;
using System.Diagnostics.Contracts;
using System.Diagnostics;

namespace mentoring_system.view.Mentor
{
    public partial class signUpMentor : Form
    {
        RegisterState registerState = new RegisterState();

        static HttpClient client = new HttpClient();
        public signUpMentor()
        {
            InitializeComponent();
            registerState.ActivateTrigger(RegisterState.bookTrigger.OPEN_SIGNUP_PAGE);

        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes(); // Memvalidasi TextBox yang harus terisi

            string namaLengkapMentor = namaLengkapTextBox.Text;
            string usernameMentor = usernameTextBox.Text;
            string passwordMentor = passwordTextBox.Text;
            string umurMentor = umurTextBox.Text;

            subjekMentoring subjek = mentorSelectCourse();

            model.Mentor mentorData = CreateMentorData(namaLengkapMentor, usernameMentor, passwordMentor, umurMentor, subjek);

            string urlCloud = "http://178.128.215.35:5132/api/mentor";
            try
            {
                await MentorFunctionality.SendMentorData(urlCloud, mentorData);
                OpenDashboardMentor(mentorData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sign Up Mentor");
            }
        }

        private void ValidateTextBoxes()
        {
            Debug.Assert(!string.IsNullOrEmpty(namaLengkapTextBox.Text), "Nama lengkap tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(usernameTextBox.Text), "Username tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(passwordTextBox.Text), "Password tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(umurTextBox.Text), "Umur tidak boleh kosong");
        }

        private model.Mentor CreateMentorData(string namaLengkap, string username, string password, string umur, subjekMentoring subjek)
        {
            return new model.Mentor(namaLengkap, username, password, umur, subjek);
        }

        private void OpenDashboardMentor(model.Mentor mentorData)
        {
            this.Hide();
            DashboardMentor dashboard = new DashboardMentor(mentorData);
            dashboard.Show();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMentor login = new LoginMentor();
            login.Show();
        }

        private subjekMentoring mentorSelectCourse() 
        {
            if (dataStructureRadioButton.Checked)
            {
                return subjekMentoring.dataStructure;
            }
            else if (algorithmProgrammingRadioButton.Checked)
            {
                return  subjekMentoring.Algorithm;
            }
            else if (interactionDesignRadioButton.Checked)
            {
                return subjekMentoring.interactionDesign;
            }
            else
            {
                return 0;
            }
        }

        private void signUpMentor_Load(object sender, EventArgs e)
        {

        }
    }
}
