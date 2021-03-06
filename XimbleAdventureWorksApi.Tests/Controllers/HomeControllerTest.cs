﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XimbleAdventureWorksApi;
using XimbleAdventureWorksApi.Controllers;

namespace XimbleAdventureWorksApi.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Ximble Adventure Works Api", result.ViewBag.Title);
        }
    }
}
