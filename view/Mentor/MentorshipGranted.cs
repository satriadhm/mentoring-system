using mentoring_system.model;
using Newtonsoft.Json;

namespace mentoring_system.view.Mentor
{
    public partial class MentorshipGranted : UserControl
    {
        static HttpClient client = new HttpClient();
        public MentorshipGranted()
        {
            InitializeComponent();
            GetMentoringSchedule();
        }

        public async void GetMentoringSchedule()
        {
            string request = await client.GetStringAsync("http://178.128.215.35:5132/api/mentorship");
            List<GenericsMentorship<string>> mentoringList = JsonConvert.DeserializeObject<List<GenericsMentorship<string>>>(request);
            for (int i = 0; i < mentoringList.Count; i++)
            {
                MentoringSchedule.Rows.Add(mentoringList[i].MenteeID, mentoringList[i].MentorID);
            }
        }
    }
}
