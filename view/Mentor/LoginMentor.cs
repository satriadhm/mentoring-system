using mentoring_system.implementation;
using mentoring_system.model;
using mentoring_system.view;

namespace mentoring_system
{
    public partial class LoginMentor : Form
    {
        registerstate registerState = new registerstate();

        public LoginMentor()
        {
            InitializeComponent();
            registerState.ActivateTrigger(registerstate.bookTrigger.OPEN_LOGIN_PAGE);
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(usernameTextbox.Text))
                    throw new ArgumentException("Username textbox should not be empty.");
                if (string.IsNullOrEmpty(passwordTextBox.Text))
                    throw new ArgumentException("Password textbox should not be empty.");

                HttpClient client = new HttpClient();
                string usernameMentor = usernameTextbox.Text;
                string passwordMentor = passwordTextBox.Text;

                string url = $"http://128.199.77.50:5132/api/mentor?username={usernameMentor}&password={passwordMentor}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var mentorLogins = await response.Content.ReadAsAsync<List<mentor>>();

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
                MessageBox.Show(ex.Message, "Login Page");
            }

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}