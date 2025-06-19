using mentoring_system;

namespace unit_test_mentor
{
    [TestClass]
    public class SignUpTest
    {
        [TestMethod]
        public void SignUpMentor_Success()
        {
            // Test case: Mentor sign up succeeds
            SignUpMentor signUpMentor = new SignUpMentor();
            string username = "mentor_user";
            string password = "mentor_password";
            string email = "mentor@example.com";
            string subject = "Computer Science";
            bool signUpResult = signUpMentor.SignUp(username, password, email, subject);
            Assert.IsTrue(signUpResult);
        }

        [TestMethod]
        public void SignUpMentor_Failure()
        {
            // Test case: Mentor sign up fails (e.g., duplicate username)
            SignUpMentor signUpMentor = new SignUpMentor();
            string username = "existing_user";
            string password = "mentor_password";
            string email = "mentor@example.com";
            string subject = "Computer Science";
            bool signUpResult = signUpMentor.SignUp(username, password, email, subject);
            Assert.IsFalse(signUpResult);
        }
    }
}
