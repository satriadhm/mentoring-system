using apimentoringsystem.Controllers;
using mentoring_system.model;
using Newtonsoft.Json;
using System.Diagnostics.Contracts;

namespace mentoring_system.view.Mentor
{
    public partial class MentorRequests : UserControl
    {
        static HttpClient client = new HttpClient();
        //mentor MentorName = ;
        public static string? menteeName;
        public static string? schedule;


        public MentorRequests(mentor MentorName)
        {
            InitializeComponent();
            GetMenteeRequestAsync();
        }

        public async void GetMenteeRequestAsync()
        {
           // Contract.Requires(Mentor != null, "The Mentor object should not be null.");

            string request = await client.GetStringAsync("http://128.199.77.50:5132/api/mentorshipRequest");
            List<MentorshipRequest> requestsList = JsonConvert.DeserializeObject<List<MentorshipRequest>>(request);
            for (int i = 0; i < requestsList.Count; i++)
            {

                    MenteeRequests.Rows.Add(requestsList[i].mentee.NamaLengkap, requestsList[i].schedule);    
            }
        }

        public void MenteeRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Ambil nilai sel tertentu
                menteeName = MenteeRequests.Rows[e.RowIndex].Cells[0].Value.ToString();
                schedule = MenteeRequests.Rows[e.RowIndex].Cells[1].Value.ToString();
                acceptancePage acceptance = new acceptancePage();
                acceptance.ShowDialog();


            }
        }
    }
}
