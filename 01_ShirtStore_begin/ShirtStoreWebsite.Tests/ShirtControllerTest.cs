using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using ShirtStoreWebsite.Controllers;
using ShirtStoreWebsite.Models;
using ShirtStoreWebsite.Services;
using ShirtStoreWebsite.Tests.FakeRepositories;

namespace ShirtStoreWebsite.Tests
{
    [TestClass]
    public class ShirtControllerTest
    {
        private IShirtRepository _fakeShirtRepository;
        private ShirtController _shirtController;

        public ShirtControllerTest()
        {
            _fakeShirtRepository = new FakeShirtRepository();

            _shirtController = new ShirtController(_fakeShirtRepository);
        }

        [TestMethod]
        public void IndexModelShouldContainAllShirts()
        {
            ViewResult viewResult = _shirtController.Index() as ViewResult;
            List<Shirt> shirts = viewResult.Model as List<Shirt>;
            Assert.AreEqual(shirts.Count, 3);
        }



    }
}
