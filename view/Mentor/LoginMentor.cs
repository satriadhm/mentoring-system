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
                    //Here
                    string usernameMentor = usernameTextbox.Text;
                    string passwordMentor = passwordTextBox.Text;
                    Console.WriteLine(usernameMentor + passwordMentor);
                    //model.mentor mentorData = new("Unknown", usernameMentor, passwordMentor, "Unknown");
                    //await client.PostAsJsonAsync("http://localhost:5133/api/mentor", mentorData);
                    this.Hide();
                    DashboardMentor home = new DashboardMentor();
                    
                    home.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
    }
}