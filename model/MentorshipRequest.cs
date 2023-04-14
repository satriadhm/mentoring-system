using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    public class MentorshipRequest
    {
        public string? Name { get; set; }
        public DateTime? schedule { get; set; }
        public subjekMentoring subject { get; set; }
    }
}
