using mentoring_system.controller;
using mentoring_system.Implementation;
using mentoring_system.model;
using mentoring_system.view;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.Http.Json;

namespace mentoring_system
{
    public partial class LoginMentee : Form
    {
        RegisterState registerState = new RegisterState();
        public static Mentee menteeData { get; set; }

        HttpClient client = new HttpClient();
        public LoginMentee()
        {
            InitializeComponent();
            registerState.ActivateTrigger(RegisterState.bookTrigger.OPEN_LOGIN_PAGE);
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAdminUser = CheckAdminUser(usernameTextbox.Text, passwordTextBox.Text);

                if (isAdminUser)
                {
                    OpenAdminDashboard();
                }
                else
                {
                    string username = usernameTextbox.Text;
                    string password = passwordTextBox.Text;

                    if (string.IsNullOrEmpty(username))
                    {
                        ShowMessageBox("Username empty", "Login page");
                    }
                    else if (string.IsNullOrEmpty(password))
                    {
                        ShowMessageBox("Password empty", "Login page");
                    }
                    else
                    {
                        menteeData = await MenteeFunctionality.AuthenticateUser(username, password);

                        if (menteeData == null)
                        {
                            ShowMessageBox("Invalid login credentials", "Login failed");
                        }
                        else
                        {
                            ActivateBookingTrigger();
                            HideForm();
                            ShowDashboard(menteeData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox(Text, ex.Message);
            }
        }

        private bool CheckAdminUser(string username, string password)
        {
            // Memeriksa apakah pengguna adalah admin berdasarkan username dan password
            return isAdmin(username, password);
        }

        private void OpenAdminDashboard()
        {
            // Membuka dashboard admin
            HideForm();
            registerState.ActivateTrigger(RegisterState.bookTrigger.OPEN_DASHBOARD);
            DashboardMentee dashboard = new DashboardMentee(menteeData);
            dashboard.ShowDialog();
        }

        private void ShowMessageBox(string message, string title)
        {
            // Menampilkan dialog MessageBox dengan pesan dan judul tertentu
            MessageBox.Show(message, title);
        }

 

        private void ActivateBookingTrigger()
        {
            // Mengaktifkan trigger untuk melakukan booking
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.REGISTER);
        }

        private void HideForm()
        {
            // Menyembunyikan form saat ini
            this.Hide();
        }

        private void ShowDashboard(Mentee menteeData)
        {
            // Menampilkan dashboard mentee dengan data mentee yang berhasil diautentikasi
            DashboardMentee dashboard = new DashboardMentee(menteeData);
            dashboard.ShowDialog();
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