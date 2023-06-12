using mentoring_system.Abstraction;
using mentoring_system.controller;
using mentoring_system.Implementation;
using mentoring_system.model;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace mentoring_system.view.Mentee
{
    public partial class signUpMentee : Form
    {
        private static RegisterState registerState = new RegisterState();
        public static bool isSignup;
        public static model.Mentee? menteeData;

        public signUpMentee()
        {
            InitializeComponent();
        }

        private void ValidateFields()
        {
            // Validate that all fields are filled
            Debug.Assert(!string.IsNullOrEmpty(namaLengkapTextBox.Text), "Nama lengkap tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(usernameTextBox.Text), "Username tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(passwordTextBox.Text), "Password tidak boleh kosong");
            Debug.Assert(!string.IsNullOrEmpty(umurTextBox.Text), "Umur tidak boleh kosong");
        }

        public async void registerButton_Click(object sender, EventArgs e)
        {
            ApiClient apiClient = new ApiClient(); // Contoh implementasi ApiClient
            MenteeFunctionality menteeFunctionality = new MenteeFunctionality(apiClient);
            // Precondition: All fields must be filled
            ValidateFields();


            string namaLengkapMentee = namaLengkapTextBox.Text;
            string usernameMentee = usernameTextBox.Text;
            string passwordMentee = passwordTextBox.Text;
            string umurMentee = umurTextBox.Text;
            string urlCloud = "http://178.128.215.35:5132/api/mentee";

            // Hash the password
            string hashedPassword = HashPassword(passwordMentee);

            menteeData = new model.Mentee(namaLengkapMentee, usernameMentee, hashedPassword, umurMentee);

            try
            {
                await menteeFunctionality.AddMenteeData(urlCloud, menteeData);
            }
            catch (Exception ex)
            {
                // Handle the exception securely, avoid exposing sensitive information
                Debug.WriteLine("Error: " + ex.Message);
                Debug.WriteLine("Error: " + urlCloud);
                // You might want to log the error and display a generic error message to the user
                // rather than printing the exception details directly
            }

            isSignup = true;

            HideForm();
            ActivateBookingTrigger();
            ShowDashboard(menteeData);
        }

        private void HideForm()
        {
            // Hide the current form
            this.Hide();
        }

        private void ActivateBookingTrigger()
        {
            // Activate the trigger to perform booking
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.REGISTER);
        }

        private void ShowDashboard(model.Mentee menteeData)
        {
            // Display the mentee dashboard with the newly added mentee data
            DashboardMentee dashboard = new DashboardMentee(menteeData);
            dashboard.Show();
        }

        private string HashPassword(string password)
        {
            // Hash the password using a secure hashing algorithm (e.g., bcrypt)
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMentee login = new LoginMentee();
            login.Show();
        }
    }
}
