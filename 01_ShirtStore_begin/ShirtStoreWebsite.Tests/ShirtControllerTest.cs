using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using ShirtStoreWebsite.Controllers;
using ShirtStoreWebsite.Models;
using ShirtStoreWebsite.Services;
using ShirtStoreWebsite.Tests.FakeRepositories;
using Microsoft.Extensions.Logging;
using Moq;

namespace ShirtStoreWebsite.Tests
{
    [TestClass]
    public class ShirtControllerTest
    {
        public IShirtRepository _fakeShirtRepository;
        public IShirtController shirtController;


        [TestMethod]
        public void IndexModelShouldContainAllShirts()
        {
            _fakeShirtRepository = new FakeShirtRepository();
            var mockLogger = new Mock<ILogger<ShirtController>>();
            _shirtController = new ShirtController(_fakeShirtRepository, mockLogger.Object);

            ViewResult viewResult = _shirtController.Index() as ViewResult;
            List<Shirt> shirts = viewResult.Model as List<Shirt>;
            Assert.AreEqual(shirts.Count, 3);
        }



    }
}

