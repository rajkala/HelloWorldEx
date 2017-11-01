using System;
using HelloWorld.WebAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.WebAPI.Models;

namespace HelloWorld.WebAPI.Tests.Controllers
{
    [TestClass]
    public class ShoutHelloWorldUnitTest
    {
        [TestMethod]


        public void GetGreetingTbl()
        {
            //         // Arrange
            ShoutHelloWorldAPIController controller = new ShoutHelloWorldAPIController();
            TESTDATABASEEntities1 TestDbSet = new TESTDATABASEEntities1();

            //         // Act
            var result = controller.GetGreetingTbls();

            Assert.IsNotNull(result);
       // I had to add some more tests for all the actions of CRUD operations

        }
    }
}
    

