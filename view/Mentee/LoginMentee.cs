using mentoring_system.implementation;
using mentoring_system.model;
using mentoring_system.view;
using System.Diagnostics;
using System.Net.Http.Json;

namespace mentoring_system
{
    public partial class LoginMentee : Form
    {
        registerstate registerState = new registerstate();
        public static mentee menteeData { get; set; }

        HttpClient client = new HttpClient();
        public LoginMentee()
        {
            InitializeComponent();
           
            registerState.ActivateTrigger(registerstate.bookTrigger.OPEN_LOGIN_PAGE);
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
          
            try
            {
                bool admin = isAdmin(usernameTextbox.Text, passwordTextBox.Text);
                if (admin)
                {
                    this.Hide();
                    registerState.ActivateTrigger(registerstate.bookTrigger.OPEN_DASHBOARD);
                    DashboardMentee dashboard = new DashboardMentee();
                    dashboard.ShowDialog();

                }
                else
                {
                    switch (string.Empty)
                    {
                        case string s when usernameTextbox.Text == s:
                            MessageBox.Show("username empty", "login page");
                            break;
                        case string s when passwordTextBox.Text == s:
                            MessageBox.Show("password empty", "login page");
                            break;
                        default:
                            var response = await client.GetAsync($"http://128.199.77.50:5132/api/mentee?username={usernameTextbox.Text}&password={passwordTextBox.Text}");
                            if (response != null && response.IsSuccessStatusCode)
                            {
                                var result = await response.Content.ReadFromJsonAsync<mentee[]>();
                                if (result.Length == 1)
                                {
                                    int id = result[0].Id;
                                    string stringId = id.ToString();
                                    string urlCloud = "http://128.199.77.50:5132/api/mentee/";
                                    string urlLocal = "http://localhost:5132/api/mentee/";
                                    menteeData = await client.GetFromJsonAsync<mentee>(urlCloud + stringId);
                                    this.Hide();
                                    DashboardMentee dashboard = new DashboardMentee();
                                    dashboard.ShowDialog();
                                }
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
        private bool isAdmin(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}