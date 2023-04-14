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

        private void loginButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!(usernameTextbox.Text == string.Empty))
                {
                    
                    if (!(passwordTextBox.Text == string.Empty))
                    {
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