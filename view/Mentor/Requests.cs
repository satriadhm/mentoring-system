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
        mentor MentorName;

        public Requests(mentor MentorName)
        {
            this.MentorName = MentorName;
            InitializeComponent();
            GetMenteeRequestAsync();
        }

        public async void GetMenteeRequestAsync()
        {
            string request = await client.GetStringAsync("http://128.199.77.50:5132/api/mentorshipRequest");
            List<MentorshipRequest> requestsList = JsonConvert.DeserializeObject<List<MentorshipRequest>>(request);
            for (int i=0; i<requestsList.Count; i++)
            {
                if (requestsList[i].name == MentorName.NamaLengkap)
                {
                    MenteeRequests.Rows.Add(requestsList[i].mentee.NamaLengkap, requestsList[i].schedule);
                }
            }
        }

        private void MenteeRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
