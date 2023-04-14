using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    public class MentorshipRequest
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public DateTime? schedule { get; set; }
        public subjekMentoring subject { get; set; }

        public MentorshipRequest(string? name, DateTime? schedule, subjekMentoring subject)
        {
            Debug.Assert(!string.IsNullOrEmpty(name), "Nama mentor tidak boleh kosong.");
            Debug.Assert(schedule != null, "Tanggal tidak boleh kosong");


            Random random = new Random();
            this.name = name;
            this.schedule = schedule;
            this.subject = subject;
            this.Id = random.Next();
        }
    }
}
