using apimentoringsystem.Controllers;
using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unit_test_mentor
{
    [TestClass]
    public class MentorshipControllerTest
    {
        [TestMethod]
        public void Get_ReturnsAllMentorships()
        {
            // Arrange
            var controller = new mentorshipController();
            var expectedMentorships = new List<genericsMentorship<string>>()
            {
                new genericsMentorship<string> { Id = 1, Data = "Data 1" },
                new genericsMentorship<string> { Id = 2, Data = "Data 2" },
                new genericsMentorship<string> { Id = 3, Data = "Data 3" }
            };
            mentorshipController.mentorship = expectedMentorships;

            // Act
            var result = controller.Get();

            // Assert
            var okResult = result as OkObjectResult;
            var actualMentorships = okResult.Value as IEnumerable<genericsMentorship<string>>;
            Assert.AreEqual(expectedMentorships.Count, actualMentorships.Count);
        }

        [TestMethod]
        public void Get_WithValidId_ReturnsMentorship()
        {
            // Arrange
            var controller = new mentorshipController();
            var mentorship = new genericsMentorship<string> { Id = 1, Data = "Data 1" };
            mentorshipController.mentorship = new List<genericsMentorship<string>>() { mentorship };

            // Act
            var result = controller.Get(1);

            // Assert
            var okResult = result as OkObjectResult;
            var actualMentorship = okResult.Value as genericsMentorship<string>;
            Assert.AreEqual(mentorship.Id, actualMentorship.Id);
            Assert.AreEqual(mentorship.Data, actualMentorship.Data);
        }

        [TestMethod]
        public void Get_WithInvalidId_ReturnsNotFound()
        {
            // Arrange
            var controller = new mentorshipController();
            mentorshipController.mentorship = new List<genericsMentorship<string>>();

            // Act
            var result = controller.Get(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void Post_AddsMentorship()
        {
            // Arrange
            var controller = new mentorshipController();
            var mentorship = new genericsMentorship<string> { Id = 1, Data = "Data 1" };

            // Act
            controller.Post(mentorship);

            // Assert
            Assert.IsTrue(mentorshipController.mentorship.Contains(mentorship));
        }
    }
}
