using HelloWorld.WebAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.WebAPI.Tests.Controllers
{
    [TestClass]
  public class SayHelloWorldAPIUnitTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            SayHelloWorldAPIController controller = new SayHelloWorldAPIController();

            // Act
            string result = controller.Get();

            // Assert
            Assert.AreEqual("Hello World", result);
        }
        [TestMethod]
        public void Get_NotNull_Test()
        {
            // Arrange
            SayHelloWorldAPIController controller = new SayHelloWorldAPIController();

            // Act
            string result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
