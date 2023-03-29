using mentoring_system.view;
using System.Diagnostics;

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
                    //Debug.Assert(usernameTextbox.Text.Length >= 10,"Not a valid name");
                    if (!(passwordTextBox.Text == string.Empty))
                    {
                        //Debug.Assert(passwordTextBox.Text.Length >= 10, "Not a valid name");
                        this.Hide();
                        DashboardMentee dashboard = new DashboardMentee();
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