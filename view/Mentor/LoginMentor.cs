using mentoring_system.Implementation;
using mentoring_system.model;
using mentoring_system.view;

namespace mentoring_system
{
    public partial class LoginMentor : Form
    {
        RegisterState registerState = new RegisterState();

        public LoginMentor()
        {
            InitializeComponent();
            registerState.ActivateTrigger(RegisterState.bookTrigger.OPEN_LOGIN_PAGE);
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response;
            try
            {
                if (string.IsNullOrEmpty(usernameTextbox.Text))
                    throw new ArgumentException("Username textbox should not be empty.");
                if (string.IsNullOrEmpty(passwordTextBox.Text))
                    throw new ArgumentException("Password textbox should not be empty.");

                HttpClient client = new HttpClient();
                string usernameMentor = usernameTextbox.Text;
                string passwordMentor = passwordTextBox.Text;

                string url = $"http://178.128.215.35:5132/api/mentor?username={usernameMentor}&password={passwordMentor}";
                response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var mentorLogins = await response.Content.ReadAsAsync<List<Mentor>>();

                for (int i = 0; i < mentorLogins.Count; i++)
                {
                    if (mentorLogins[i].userName == usernameMentor && mentorLogins[i].password == passwordMentor)
                    {
                        this.Hide();
                        DashboardMentor home = new DashboardMentor(mentorLogins[i]);
                        home.Show();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Login Page");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Maaf, terjadi kegagalan koneksi ke server. Coba lagi nanti!", "Login Page");
            }

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        public bool isValidSubject(string matkul)
        {
            string[] textSubjek = { "UI/UX Design", "Programming Algorithm", "Data Structure"};
            return textSubjek.Contains(matkul);
        }

        public bool isMentor(string mentor)
        {
            string[] namaMentor = { "Rafidhia Haikal", "Farhan Mulya", "Putu Vidya", "Glorious Satria", "Kevin" };
            return namaMentor.Contains(mentor);
        }

    }
}