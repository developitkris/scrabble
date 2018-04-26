using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ScrabbleScoreboard.Controllers;
using ScrabbleScoreboard.Models;

namespace ScrabbleScoreboard.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
        public ActionResult Index()
        {
          return new EmptyResult();
        }
        [TestMethod]
        public void Index_HasCorrectModelType_ItemList()
        {
            //Arrange
            HomeController controller = new HomeController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Item>));
        }
    }
}
