using mentoring_system.model;
using mentoring_system.view;

namespace mentoring_system
{
    public partial class LoginMentor : Form
    {
        public LoginMentor()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
                if (usernameTextbox.TextLength == 0 || passwordTextBox.TextLength == 0)
                {
                    MessageBox.Show("Username atau password tidak boleh kosong", "Login Page");
                }
                else
                {
                    string usernameMentor = usernameTextbox.Text;
                    string passwordMentor = passwordTextBox.Text;

                    string url = $"http://128.199.77.50:5132/api/mentor?username={usernameMentor}&password={passwordMentor}";
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var mentorLogins = await response.Content.ReadAsAsync<List<mentor>>();

                    for (int i=0; i<mentorLogins.Count; i++)
                    {
                        if (mentorLogins[i].userName == usernameMentor && mentorLogins[i].password == passwordMentor)
                        {
                            this.Hide();
                            DashboardMentor home = new DashboardMentor(mentorLogins[i]);
                            home.Show();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}