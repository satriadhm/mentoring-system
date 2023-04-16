using mentoring_system.view;
using System.Diagnostics;

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
                        Console.WriteLine(usernameMentee + passwordMentee);
                        model.mentee menteeData = new("Unknown", usernameMentee, passwordMentee, "Unknown");
                        await client.PostAsJsonAsync("http://localhost:5132/api/mentee", menteeData);
                        this.Hide();
                        DashboardMentee dashboard = new DashboardMentee();
                        dashboard.ShowDialog();

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