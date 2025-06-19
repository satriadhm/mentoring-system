using apimentoringsystem.Controllers;
using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unit_test_mentor
{
    [TestClass]
    public class MentorshipRequestControllerTest
    {
        [TestMethod]
        public void Get_ReturnsAllMentorshipRequests()
        {
            // Arrange
            var controller = new mentorshipRequestController();
            var expectedRequests = new List<MentorshipRequest>()
            {
                new MentorshipRequest { Id = 1, RequestMessage = "Request 1" },
                new MentorshipRequest { Id = 2, RequestMessage = "Request 2" },
                new MentorshipRequest { Id = 3, RequestMessage = "Request 3" }
            };
            mentorshipRequestController.mentorshipRequests = expectedRequests;

            // Act
            var result = controller.Get();

            // Assert
            var okResult = result as OkObjectResult;
            var actualRequests = okResult.Value as IEnumerable<MentorshipRequest>;
            Assert.AreEqual(expectedRequests.Count, actualRequests.Count);
        }

        [TestMethod]
        public void Get_WithValidId_ReturnsMentorshipRequest()
        {
            // Arrange
            var controller = new mentorshipRequestController();
            var request = new MentorshipRequest { Id = 1, RequestMessage = "Request 1" };
            mentorshipRequestController.mentorshipRequests = new List<MentorshipRequest>() { request };

            // Act
            var result = controller.Get(1);

            // Assert
            var okResult = result as OkObjectResult;
            var actualRequest = okResult.Value as MentorshipRequest;
            Assert.AreEqual(request.Id, actualRequest.Id);
            Assert.AreEqual(request.RequestMessage, actualRequest.RequestMessage);
        }

        [TestMethod]
        public void Get_WithInvalidId_ReturnsNotFound()
        {
            // Arrange
            var controller = new mentorshipRequestController();
            mentorshipRequestController.mentorshipRequests = new List<MentorshipRequest>();

            // Act
            var result = controller.Get(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void Post_AddsMentorshipRequest()
        {
            // Arrange
            var controller = new mentorshipRequestController();
            var request = new MentorshipRequest { Id = 1, RequestMessage = "Request 1" };

            // Act
            controller.Post(request);

            // Assert
            Assert.IsTrue(mentorshipRequestController.mentorshipRequests.Contains(request));
        }
    }
}
