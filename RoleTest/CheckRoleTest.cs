using mentoring_system;
using mentoring_system.view;

namespace unit_test_mentor
{
    [TestClass]
    public class RoleTest
    {
        [TestMethod]
        public void checkRole()
        {
            // Test case: User is a mentor
            LoginMentor login = new LoginMentor();
            Assert.IsTrue(login.isMentor("Rafidhia Haikal"));
        }
    }
}
