using mentoring_system.implementation;
using mentoring_system.model;
using mentoring_system.view;
using System.Diagnostics;
using System.Diagnostics.Metrics;
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
                            var response = await client.GetAsync("http://128.199.77.50:5132/api/mentee");
                            if (response != null && response.IsSuccessStatusCode)
                            {
                                var loggedInUser = default(mentee);
                                var result = await response.Content.ReadFromJsonAsync<mentee[]>();
                                foreach (var mentee in result)
                                {
                                    if (mentee.userName == usernameTextbox.Text && mentee.password == passwordTextBox.Text)
                                    {
                                        if (loggedInUser != null)
                                        {
                                            MessageBox.Show("Multiple users found with same credentials", "Login failed");
                                            return;
                                        }
                                        loggedInUser = mentee;
                                    }
                                }
                                if (loggedInUser == null)
                                {
                                    MessageBox.Show("Invalid login credentials", "Login failed");
                                }
                                else
                                {
                                    menteeData = await client.GetFromJsonAsync<mentee>($"http://128.199.77.50:5132/api/mentee/{loggedInUser.Id}");
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
        public bool isAdmin(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return true;
            }
            return false;
        }
    }

}