using mentoring_system.model;
using Newtonsoft.Json;

namespace mentoring_system.view.Mentor
{
    public partial class MentorRequests : UserControl
    {
        static HttpClient client = new HttpClient();
        public static string? menteeName;
        public static string? schedule;

        public MentorRequests(model.Mentor MentorName)
        {
            InitializeComponent();
            GetMenteeRequestAsync();
        }

        public async void GetMenteeRequestAsync()
        {
            string request = await client.GetStringAsync("http://178.128.215.35:5132/api/mentorshipRequest");
            List<MentorshipRequest> requestsList = JsonConvert.DeserializeObject<List<MentorshipRequest>>(request);
            for (int i = 0; i < requestsList.Count; i++)
            {
                MenteeRequests.Rows.Add(requestsList[i].mentee.NamaLengkap, requestsList[i].schedule);
            }
        }

        private async void AcceptBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = MenteeRequests.SelectedRows[0];
            string name = selectedRow.Cells[0].Value.ToString();
            string date = selectedRow.Cells[1].Value.ToString();
            try
            {
                string urlCloud = "http://178.128.215.35:5132/api/mentorship";
                string urlLocal = "http://localhost:5132/api/mentorship";
                GenericsMentorship<String> x = new GenericsMentorship<String>(1, name, date);
                HttpResponseMessage response = await client.PostAsJsonAsync(urlCloud, x);
                response.EnsureSuccessStatusCode();
                MessageBox.Show("Berhasil menerima permintaan mentoring!");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
