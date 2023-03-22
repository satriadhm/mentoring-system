using mentoring_system.view;

namespace mentoring_system
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!(usernameTextbox.Text == string.Empty))
                {
                    if (!(passwordTextBox.Text == string.Empty))
                    {
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();

                    }
                    else 
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                } else
                {
                    MessageBox.Show("username empty", "login page");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
    }
}