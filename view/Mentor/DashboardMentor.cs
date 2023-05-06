using mentoring_system.model;

namespace mentoring_system.view
{
    public partial class DashboardMentor : Form
    {
        private mentor Mentor;
        public DashboardMentor(mentor Mentor)
        {
            InitializeComponent();
            this.Mentor = Mentor;
            string[] textSubjek = { "UI/UX Design", "Programming Algorithm", "Data Structure" };

            Dropdown.Visible = false;
            mentorProfile.SendToBack();
            userName.Text = $"Welcome, {Mentor.NamaLengkap}";
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
        private void button1_Click(object sender, EventArgs e)
        {
            mentorProfile.BringToFront();
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            ShowDropdown(Dropdown);
        }

        private void DashboardMentor_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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
            mentorProfile.SendToBack();
            requests1.SendToBack();
            //profileMentor1.SendToBack();
        }

        private void RequestsBtn_Click(object sender, EventArgs e)
        {
            requests1.BringToFront();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //Profile Button
        {
            //profileMentor1.BringToFront();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SubjekText_Click(object sender, EventArgs e)
        {

        }
    }
}
