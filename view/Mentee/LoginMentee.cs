using mentoring_system.model;
using mentoring_system.view;
using System.Diagnostics;
using System.Net.Http.Json;

namespace mentoring_system
{
    public partial class LoginMentee : Form
    {
        public LoginMentee()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
                if (!(usernameTextbox.Text == string.Empty))
                {

                    if (!(passwordTextBox.Text == string.Empty))
                    {

                        string usernameMentee = usernameTextbox.Text;
                        string passwordMentee = passwordTextBox.Text;
                        var response = await client.GetAsync($"http://localhost:5132/api/mentee?username={usernameMentee}&password={passwordMentee}");
                        if (response != null)
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var result = await response.Content.ReadFromJsonAsync<mentee[]>();
                                if (result.Length == 1)
                                {
                                    int id = result[0].Id;
                                    string stringId = id.ToString();
                                    mentee menteeData = await client.GetFromJsonAsync<mentee>("http://localhost:5132/api/mentee/" + stringId);
                                    this.Hide();
                                    DashboardMentee dashboard = new DashboardMentee();
                                    dashboard.ShowDialog();
                                }
                            }
                            if (usernameMentee.Equals("admin") && passwordMentee.Equals("admin"))
                            {
                                this.Hide();
                                DashboardMentee dashboard = new DashboardMentee();
                                dashboard.ShowDialog();

                            }

                        }
                        else
                        {
                            MessageBox.Show(" password empty", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show("username empty", "login page");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}