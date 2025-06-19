using mentoring_system;
using mentoring_system.view;

namespace unit_test_mentor
{
    [TestClass]
    public class LoginTest
    {
        // Test case Satria
        [TestMethod]
        public void isAdminTrue()
        {
            LoginMentee login = new LoginMentee();
            bool admin = login.isAdmin("admin" , "admin");
            Assert.IsTrue(admin);
        }

        [TestMethod]
        public void isAdminFalse()
        {
            LoginMentee login = new LoginMentee();
            bool admin = login.isAdmin("user", "password");
            Assert.IsFalse(admin);
        }

        // Test case Haikal
        [TestMethod]
        public void isValidSubject()
        {
            LoginMentor Mentor = new LoginMentor();
            String namaMatkul = "Data Structure";
            Assert.IsTrue(Mentor.isValidSubject(namaMatkul));
        }

        [TestMethod]
        public void checkRole()
        {
            LoginMentor login = new LoginMentor();
            Assert.IsTrue(login.isMentor("Rafidhia Haikal"));
        }

        // Test case Vidya
        [TestMethod]
        public void IsUsernameValid_Should_Return_False_For_Username_With_Uppercase_Letter()
            {
                // Arrange
                ProfilePageMentee user = new ProfilePageMentee();

                // Act
                bool result = user.IsUsernameValid("UserName");

                // Assert
                Assert.IsTrue(result);
            }
    }
}