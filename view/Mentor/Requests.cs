using apimentoringsystem.Controllers;
using mentoring_system.model;
using Newtonsoft.Json;
using System.Diagnostics.Contracts;

namespace mentoring_system.view.Mentor
{
    public partial class Requests : UserControl
    {
        static HttpClient client = new HttpClient();
        private mentor Mentor;
        public Requests(mentor Mentor)
        {
            InitializeComponent();
            GetMenteeRequestAsync();
            loadRequestMenteeName();
            this.Mentor = Mentor;
        }

        public async void GetMenteeRequestAsync()
        {
            Contract.Requires(Mentor != null, "The Mentor object should not be null.");

            string request = await client.GetStringAsync("http://128.199.77.50:5132/api/mentorshipRequest");
            List<MentorshipRequest> requestsList = JsonConvert.DeserializeObject<List<MentorshipRequest>>(request);
            for (int i = 0; i < requestsList.Count; i++)
            {
                MenteeRequests.Rows.Add(requestsList[i].mentee.NamaLengkap, requestsList[i].schedule);

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void loadRequestMenteeName()
        {

        }
    }
}
