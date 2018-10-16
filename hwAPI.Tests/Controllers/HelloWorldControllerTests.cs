using NUnit.Framework;
using hwAPI.Controllers;
using hwAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hwAPI.Controllers.Tests
{
    [TestFixture]
    public class HelloWorldControllerTests
    {

        [Test]
        public void Text_IsNotNull()
        {
            //Arrange
            var controller = new HelloWorldController();

            //Act
            var result = controller.Get();

            //Assert
            Assert.That(result, Is.Not.Null.Or.Empty, "Result string must not be null or empty");
        }
         
    }
}