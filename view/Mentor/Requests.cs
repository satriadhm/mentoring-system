using mentoring_system.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string request = await client.GetStringAsync("http://localhost:5132/api/mentorshipRequest");
            List<MentorshipRequest> requestsList = JsonConvert.DeserializeObject<List<MentorshipRequest>>(request);
            for (int i=0; i<requestsList.Count; i++)
            {
                MenteeRequests.Rows.Add(requestsList[i].name, requestsList[i].schedule);
            }
            //MenteeRequests.Rows.Add(requestsList[0].name, requestsList[0].schedule);
        }

        private void MenteeRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
