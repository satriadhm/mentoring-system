using mentoring_system.controller;
using mentoring_system.Implementation;
using mentoring_system.model;
using System.Diagnostics;

namespace mentoring_system.view.Mentee;

public partial class signUpMentee : Form
{
    public static RegisterState registerState = new RegisterState();
    public static bool isSignup { get; set; }
    public static model.Mentee? menteeData { get; set; }

    public signUpMentee()
    {
        InitializeComponent();
    }
    private void ValidateFields()
    {
        // Memvalidasi bahwa semua field telah terisi
        Debug.Assert(!string.IsNullOrEmpty(namaLengkapTextBox.Text), "Nama lengkap tidak boleh kosong");
        Debug.Assert(!string.IsNullOrEmpty(usernameTextBox.Text), "Username tidak boleh kosong");
        Debug.Assert(!string.IsNullOrEmpty(passwordTextBox.Text), "Password tidak boleh kosong");
        Debug.Assert(!string.IsNullOrEmpty(umurTextBox.Text), "Umur tidak boleh kosong");
    }
    public async void registerButton_Click(object sender, EventArgs e)
    {
        // Pre Condition: Semua field harus terisi
        ValidateFields();

        string namaLengkapMentee = namaLengkapTextBox.Text;
        string usernameMentee = usernameTextBox.Text;
        string passwordMentee = passwordTextBox.Text;
        string umurMentee = umurTextBox.Text;
        string urlCloud = "http://178.128.215.35:5132/api/mentee";

        menteeData = new(namaLengkapMentee, usernameMentee, passwordMentee, umurMentee);
        try
        {
            await MenteeFunctionality.AddMenteeData(urlCloud, menteeData);
        }
        catch (Exception ex)
        {
            // Exception: Menampilkan pesan error saat terjadi exception
            System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            System.Diagnostics.Debug.WriteLine("Error: " + urlCloud);
        }
        isSignup = true;


        HideForm(); 
        ActivateBookingTrigger(); 
        ShowDashboard(menteeData); 
    }
    private void HideForm()
    {
        // Menyembunyikan form saat ini
        this.Hide();
    }

    private void ActivateBookingTrigger()
    {
        // Mengaktifkan trigger untuk melakukan booking
        LandingPage.state.ActivateTrigger(bookingState.bookTrigger.REGISTER);
    }

    private void ShowDashboard(model.Mentee menteeData)
    {
        // Menampilkan dashboard mentee dengan data mentee yang baru ditambahkan
        DashboardMentee dashboard = new DashboardMentee(menteeData);
        dashboard.Show();
    }


    private void loginButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        LoginMentee login = new LoginMentee();
        login.Show();
    }

}
