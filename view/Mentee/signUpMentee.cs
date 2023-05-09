using mentoring_system.controller;
using mentoring_system.implementation;
using mentoring_system.model;
using System.Diagnostics;

namespace mentoring_system.view.Mentee;

public partial class signUpMentee : Form
{
    public static registerstate registerState = new registerstate();
    public static HttpClient client = new HttpClient();
    public static bool isSignup { get; set; }
    public static model.mentee menteeData { get; set; }
    public static controller.bookingState state = new controller.bookingState();

    public signUpMentee()
    {
        InitializeComponent();
    }

    public async void registerButton_Click(object sender, EventArgs e)
    {
        // Pre Condition: Semua field harus terisi
        Debug.Assert(!string.IsNullOrEmpty(namaLengkapTextBox.Text), "Nama lengkap tidak boleh kosong");
        Debug.Assert(!string.IsNullOrEmpty(usernameTextBox.Text), "Username tidak boleh kosong");
        Debug.Assert(!string.IsNullOrEmpty(passwordTextBox.Text), "Password tidak boleh kosong");
        Debug.Assert(!string.IsNullOrEmpty(umurTextBox.Text), "Umur tidak boleh kosong");

        string namaLengkapMentee = namaLengkapTextBox.Text;
        string usernameMentee = usernameTextBox.Text;
        string passwordMentee = passwordTextBox.Text;
        string umurMentee = umurTextBox.Text;
        string urlCloud = "http://128.199.77.50:5132/api/mentee";
        string urlLocal = "http://localhost:5132/api/mentee";

        menteeData = new(namaLengkapMentee, usernameMentee, passwordMentee, umurMentee);
        try
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(urlCloud, menteeData);
            response.EnsureSuccessStatusCode();

            // Post Condition: Response dari API mengindikasikan data mentee baru berhasil ditambahkan
            Debug.Assert(response.IsSuccessStatusCode, "Data mentee baru tidak berhasil ditambahkan");
        }
        catch (Exception ex)
        {
            // Exception: Menampilkan pesan error saat terjadi exception
            System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            System.Diagnostics.Debug.WriteLine("Error: " + urlCloud);
        }
        isSignup = true;

        this.Hide();
        state.ActivateTrigger(bookingState.bookTrigger.REGISTER);
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
