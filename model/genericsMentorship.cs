using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    public class genericsMentorship<T>
    {
        public int ID { get; set; }
        public T MentorID { get; set; }
        public T MenteeID { get; set;}

        public genericsMentorship(int iD, T mentorID, T menteeID)
        {
            ID = iD;
            MentorID = mentorID;
            MenteeID = menteeID;
        }
    }
}
