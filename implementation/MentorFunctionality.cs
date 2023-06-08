using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Protection.PlayReady;

namespace mentoring_system.Implementation
{
    internal class MentorFunctionality
    {
        public static HttpClient client = new HttpClient();
        public static async Task SendMentorData(string url, model.Mentor mentorData)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(url, mentorData);
            response.EnsureSuccessStatusCode();
        }
    }
}
