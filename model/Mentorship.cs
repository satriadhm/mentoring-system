namespace mentoring_system.model
{
    public class Mentorship<T>
    {
        public int Id { get; set; }
        public T MentorID { get; set; }
        public T MenteeID { get; set;}

        public Mentorship(int Id, T mentorID, T menteeID)
        {
            this.Id = Id;
            MentorID = mentorID;
            MenteeID = menteeID;
        }
    }
}
