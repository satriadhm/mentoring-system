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
        static HttpClient client = new HttpClient();

        DataTable table = new DataTable("Mentorship Request");

        public BookingPage()
        {
            InitializeComponent();
            LoadDataMentor();
        }
        private async void LoadDataMentor()
        {
            try
            {
                var response = await client.GetAsync("http://localhost:5132/api/mentor");
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsAsync<IEnumerable<mentor>>();
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

        private async void submitButton_Click(object sender, EventArgs e)
        {

            controller.bookingState state = new controller.bookingState();
            state.ActivateTrigger(bookingState.bookTrigger.CHOOSEDATE);

            subjekMentoring selectedSubject = (subjekMentoring)Enum.Parse(typeof(subjekMentoring), comboBoxCourseName.SelectedItem.ToString());

            mentor selectedMentor = (mentor)comboBoxMentorName.SelectedItem;
            string selectedMentorName = selectedMentor.NamaLengkap;
            string menteeName = await client.GetStringAsync("http://localhost:5132/api/mentee");
            List<model.mentee> menteeList = JsonConvert.DeserializeObject<List<model.mentee>>(menteeName);

            
            for (int i = 0; i < menteeList.Count; i++)
            {
                MentorshipRequest menteeRequest = new MentorshipRequest(menteeList[i].NamaLengkap, bookMentorDateTimePicker.Value, selectedSubject);
                string url = "http://localhost:5132/api/mentorshipRequest";

                HttpResponseMessage response = await client.PostAsJsonAsync(url, menteeRequest);
                
                response.EnsureSuccessStatusCode();
                Debug.Assert(response.IsSuccessStatusCode, "Data mentorship request baru tidak berhasil ditambahkan");
            }
            

            

            //Console.WriteLine(comboBoxMentorName.SelectedItem.ToString() +  comboBoxCourseName.SelectedItem.ToString());

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
            mentor selectedMentor = (mentor)comboBoxMentorName.SelectedItem;

            // add courses for the selected mentor
            foreach (string subjekMentoring in Enum.GetNames(typeof(model.subjekMentoring)))
            {
                if (subjekMentoring == selectedMentor.Subjek.ToString())
                {
                    comboBoxCourseName.Items.Add(subjekMentoring);
                }
            }
        }

        private void comboBoxCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
