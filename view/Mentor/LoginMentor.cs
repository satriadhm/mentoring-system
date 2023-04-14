using mentoring_system.view;

namespace mentoring_system
{
    public partial class LoginMentor : Form
    {
        public LoginMentor()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTextbox.TextLength == 0 || passwordTextBox.TextLength == 0)
                {
                    MessageBox.Show("Username atau password tidak boleh kosong", "Login Page");
                }
                else
                {
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