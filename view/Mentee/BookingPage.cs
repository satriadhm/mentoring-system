using mentoring_system.controller;
using mentoring_system.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
            LoadDataCourse();
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
                    comboBoxMentorName.Items.Add(item.NamaLengkap);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void LoadDataCourse()
        {
            foreach (string subjekMentoring in Enum.GetNames(typeof(model.subjekMentoring)))
            {
                comboBoxCourseName.Items.Add(subjekMentoring);
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

            controller.bookingState state = new controller.bookingState();
            state.ActivateTrigger(bookingState.bookTrigger.CHOOSEDATE);

            table.Rows.Add(comboBoxMentorName.SelectedItem, bookMentorDateTimePicker.Value, comboBoxCourseName.SelectedItem);

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
