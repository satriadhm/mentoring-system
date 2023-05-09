using mentoring_system.model;
using Newtonsoft.Json;

namespace mentoring_system.view.Mentor
{
    public partial class Requests : UserControl
    {
        static HttpClient client = new HttpClient();
        public Requests()
        {
            InitializeComponent();
            GetMenteeRequestAsync();
        }

        public async void GetMenteeRequestAsync()
        {
            string request = await client.GetStringAsync("http://128.199.77.50:5132/api/mentorshipRequest");
            List<MentorshipRequest> requestsList = JsonConvert.DeserializeObject<List<MentorshipRequest>>(request);
            for (int i = 0; i < requestsList.Count; i++)
            {
                MenteeRequests.Rows.Add(requestsList[i].mentee.NamaLengkap, requestsList[i].schedule);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenteeRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
