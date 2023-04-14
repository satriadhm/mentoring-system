using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    public class genericsMentorship<T>
    {
        public int Id { get; set; }
        public T MentorID { get; set; }
        public T MenteeID { get; set;}

        public genericsMentorship(int Id, T mentorID, T menteeID)
        {
            this.Id = Id;
            MentorID = mentorID;
            MenteeID = menteeID;
        }
    }
}
