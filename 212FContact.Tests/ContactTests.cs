using _212FContact.Controllers;
using _212FContact.Data;
using _212FContact.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.ComponentModel.DataAnnotations;

namespace _212FContact.Tests
{
    namespace _212FContact.Tests.Controllers
    {
        public class ContactControllerTests
        {
            [Fact]
            public void Index_Post_ValidModel_ReturnsRedirectToActionResult()
            {
                // Arrange
                var mockContactProvider = new Mock<IContactProvider>();
                var controller = new ContactController(mockContactProvider.Object);
                var contact = new Contact
                {
                    FirstName = "Vahid",
                    LastName = "Khourgami",
                    Email = "Vahid@Khourgami.com",
                    Message = "Test message"
                };

                // Act
                var result = controller.Index(contact) as RedirectToActionResult;

                // Assert
                Assert.NotNull(result);
                Assert.Equal("Index", result.ActionName); // Assuming you're redirecting to Index action
            }

            [Fact]
            public void Index_Post_InvalidModel_ReturnsViewResult()
            {
                // Arrange
                var mockContactProvider = new Mock<IContactProvider>();
                var controller = new ContactController(mockContactProvider.Object);
                var contact = new Contact(); // Empty model to simulate invalid data
                controller.ModelState.AddModelError("Email", "The Email field is required."); // Adding error to ModelState

                // Act
                var result = controller.Index(contact) as ViewResult;

                // Assert
                Assert.NotNull(result);
                Assert.False(result.ViewData.ModelState.IsValid); // Ensure ModelState is invalid
                Assert.Equal(contact, result.Model); // Ensure model is passed back to the view
            }
        }
    }
}