using mentoring_system;
using mentoring_system.view;

namespace unit_test_mentor
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void isValidSubject()
        {
            // Test case: Valid subject name is provided
            LoginMentor mentor = new LoginMentor();
            string subject = "Data Structure";
            Assert.IsTrue(mentor.isValidSubject(subject));
        }

        [TestMethod]
        public void isInvalidSubject()
        {
            // Test case: Invalid subject name is provided
            LoginMentor mentor = new LoginMentor();
            string subject = "Invalid Subject";
            Assert.IsFalse(mentor.isValidSubject(subject));
        }
    }
}
