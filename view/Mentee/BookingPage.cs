using mentoring_system.controller;
using mentoring_system.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mentoring_system.view.Mentee
{
    public partial class BookingPage : UserControl
    {

        DataTable table = new DataTable("Mentorship Request");
        public BookingPage()
        {
            InitializeComponent();
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Mentor Name", Type.GetType("System.String"));
            table.Columns.Add("Schedule Date", Type.GetType("System.DateTime"));
            table.Columns.Add("Mentoring Subject", typeof(subjekMentoring));
            mentorshipRequestData.DataSource = table;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            controller.bookingState state = new controller.bookingState();
            state.ActivateTrigger(bookingState.bookTrigger.CHOOSEDATE);

            table.Rows.Add(comboBoxMentorName.SelectedText, bookMentorDateTimePicker.Value, comboBoxCourseName.SelectedText);
        }
    }
}
