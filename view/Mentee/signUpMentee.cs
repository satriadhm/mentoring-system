using mentoring_system.controller;
using mentoring_system.model;

namespace mentoring_system.view.Mentee;

public partial class signUpMentee : Form
{


    public signUpMentee()
    {
        InitializeComponent();
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        string namaLengkapMentee = namaLengkapTextBox.Text;
        string usernameMentee = usernameTextBox.Text;
        string passwordMentee = passwordTextBox.Text;
        string umurMentee = umurTextBox.Text;
        Console.WriteLine(namaLengkapMentee + usernameMentee + passwordMentee + umurMentee);
        model.mentee menteeData = new(namaLengkapMentee, usernameMentee, passwordMentee, umurMentee, Role.MENTEE);

        JSONparserBase jSONparserBase = new JSONparserBase();
        jSONparserBase.WriteJSON(menteeData);
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
