using mentoring_system.controller;
using mentoring_system.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mentoring_system.view.Mentee
{
    public partial class BookingPage : UserControl
    {
        public static HttpClient client = new HttpClient();

        DataTable table = new DataTable("Mentorship Request");

        public static subjekMentoring selectedSubject { get; set; }

        public static model.Mentor? selectedMentor { get; set; }
        
        public static string? selectedMentorName { get; set; }
        public static model.Mentee? menteeData { get; set; }
        
        public static string urlCloud = "http://128.199.77.50:5132/api/mentor";
        
        public static string urlLocal = "http://localhost:5132/api/mentor";

        public static DateTime bookingDate { get; set; }


        public BookingPage()
        {
            InitializeComponent();
            LoadDataMentor();
        }
        private async void LoadDataMentor()
        {
            try
            {
               
                var response = await client.GetAsync(urlCloud);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsAsync<IEnumerable<model.Mentor>>();
                foreach (var item in data)
                {
                    comboBoxMentorName.Items.Add(item);
                    LoadDataCourse(item.Subjek);
                }
                comboBoxMentorName.DisplayMember = "NamaLengkap";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void LoadDataCourse(subjekMentoring subjek)
        {
            comboBoxCourseName.Items.Clear();
            foreach (string subjekMentoring in Enum.GetNames(typeof(model.subjekMentoring)))
            {
                if (subjekMentoring == subjek.ToString())
                {
                    comboBoxCourseName.Items.Add(subjekMentoring);
                }
            }
        }
        private void BookingPage_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Mentor Name", Type.GetType("System.String"));
            table.Columns.Add("Schedule Date", Type.GetType("System.DateTime"));
            table.Columns.Add("Mentoring Subject", Type.GetType("System.String"));
            mentorshipRequestData.DataSource = table;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.CHOOSEDATE);
            selectedSubject = (subjekMentoring)Enum.Parse(typeof(subjekMentoring), comboBoxCourseName.SelectedItem.ToString());
            selectedMentor = (model.Mentor)comboBoxMentorName.SelectedItem;
            selectedMentorName = selectedMentor.NamaLengkap;
            bookingDate = bookMentorDateTimePicker.Value;
            if (signUpMentee.isSignup)
            {
                menteeData = signUpMentee.menteeData;

            }
            else
            {
                menteeData = LoginMentee.menteeData;
                Console.WriteLine(menteeData.NamaLengkap);

            }

            table.Rows.Add(selectedMentorName, bookMentorDateTimePicker.Value, comboBoxCourseName.SelectedItem);

        }
        private void proceedButton_Click(object sender, EventArgs e)
        {
            // tambahkan user control baru
            PaymentPage paymentpage = new PaymentPage();
            paymentpage.Show();

        }

        private void comboBoxMentorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCourseName.Items.Clear();

            // get selected mentor
            model.Mentor selectedMentor = (model.Mentor)comboBoxMentorName.SelectedItem;

            // add courses for the selected mentor
            foreach (string subjekMentoring in Enum.GetNames(typeof(model.subjekMentoring)))
            {
                if (subjekMentoring == selectedMentor.Subjek.ToString())
                {
                    comboBoxCourseName.Items.Add(subjekMentoring);
                }
            }
        }
    }
}
