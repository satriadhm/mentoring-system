using mentoring_system.controller;
using mentoring_system.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Media.Protection.PlayReady;

namespace mentoring_system.view.Mentee
{
    public partial class PaymentPage : Form
    {
        string urlCloud = "http://128.199.77.50:5132/api/mentorshipRequest";

        public static HttpClient client = new HttpClient();
        public PaymentPage()
        {
            InitializeComponent();
        }

        private async void proceedButton_Click(object sender, EventArgs e)
        {
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.PAYMENT);
            
            MentorshipRequest menteeRequest = new MentorshipRequest(BookingPage.menteeData, BookingPage.selectedMentorName, BookingPage.bookingDate, BookingPage.selectedSubject);

            Console.WriteLine(BookingPage.menteeData.NamaLengkap);

            HttpResponseMessage response = await client.PostAsJsonAsync(urlCloud, menteeRequest);

            string responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);


            response.EnsureSuccessStatusCode();

            Debug.Assert(response.IsSuccessStatusCode, "Data mentorship request baru tidak berhasil ditambahkan");

            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LandingPage.state.ActivateTrigger(bookingState.bookTrigger.CANCELDATE);
            this.Hide();
        }
    }
}
