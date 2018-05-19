using Microsoft.AspNetCore.Mvc;
using Moq;
using NASK.Common;
using NASK.Domain;
using NASK.Web.Controllers;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void VerySimpleTest()
        {
            //arrange
            var serviceImitation = new Mock<IDocService>();
            serviceImitation
                .Setup(x => x.GetDocumentById(1))
                .Returns(new StoredDocument
                {
                    Author = "",
                    Description = "",
                    MimeType = "html",
                    Id = 1,
                    Title = ""
                });
            var controller = new DocumentController(serviceImitation.Object);
            //act
            var result = controller.Details(1);
            //assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
