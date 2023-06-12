using mentoring_system.model;

namespace mentoring_system.view
{
    public partial class DashboardMentor : Form
    {
        private model.Mentor Mentor;
        public DashboardMentor(model.Mentor Mentor)
        {
            this.Mentor = Mentor;
            InitializeComponent();
            string[] textSubjek = { "Interaction Design", "Programming Algorithm", "Data Structure" };
            string[] role = { "Mentor", "Mente" };

            Dropdown.Visible = false;
            userName.Text = $"Welcome, {Mentor.NamaLengkap}";
            labelRoleMentor.Text = $"Your Role: {role[(int)Mentor.role]}";
            SubjekText.Text = $"Your Mentoring Subject: {textSubjek[(int)Mentor.Subjek]}";
        }

        private void HideDropdown()
        {
            if (Dropdown.Visible)
            {
                Dropdown.Visible = false;
            }
        }

        private void ShowDropdown(Panel submenu)
        {
            if (!submenu.Visible)
            {
                HideDropdown();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            ShowDropdown(Dropdown);
        }

        private void DashboardMentor_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            requests2.SendToBack();
            mentorshipGranted1.SendToBack();
        }

        private void RequestsBtn_Click(object sender, EventArgs e)
        {
            requests2.BringToFront();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SubjekText_Click(object sender, EventArgs e)
        {

        }

        private void labelRoleMentor_Click(object sender, EventArgs e)
        {

        }

        private void YourClassBtn_Click(object sender, EventArgs e)
        {
            mentorshipGranted1.BringToFront();
        }
    }
}
