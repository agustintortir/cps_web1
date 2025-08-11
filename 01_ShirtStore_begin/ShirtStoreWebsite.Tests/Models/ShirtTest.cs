using ShirtStoreWebsite.Models;
using NUnit.Framework;

namespace ShirtStoreWebsite.Tests
{
    public class ShirtTest
    {
        public void IsGetFormattedTaxedPriceReturnsCorrectly()
        {
            Shirt shirt = new Shirt { Price = 10f, Tax = 1.2f};
            string taxedPrice = shirt.GetFormattedTaxedPrice();
            Assert.AreEqual("$12.00", taxedPrice);
        }
    }
}