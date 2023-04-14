using mentoring_system.controller;
using mentoring_system.model;

namespace mentoring_system.view.Mentee;

public partial class signUpMentee : Form
{

    static HttpClient client = new HttpClient();
    public signUpMentee()
    {
        InitializeComponent();
    }

    private async void registerButton_Click(object sender, EventArgs e)
    {
        string namaLengkapMentee = namaLengkapTextBox.Text;
        string usernameMentee = usernameTextBox.Text;
        string passwordMentee = passwordTextBox.Text;
        string umurMentee = umurTextBox.Text;
        Console.WriteLine(namaLengkapMentee + usernameMentee + passwordMentee + umurMentee);
        model.mentee menteeData = new(namaLengkapMentee, usernameMentee, passwordMentee, umurMentee);
        await client.PostAsJsonAsync("http://localhost:5132/api/mentee", menteeData);

        this.Hide();
        DashboardMentee dashboard = new DashboardMentee();
        dashboard.Show();

    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        LoginMentee login = new LoginMentee();
        login.Show();
    }
}
