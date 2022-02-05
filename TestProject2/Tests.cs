using System;
using System.Collections.Generic;
using NUnit.Framework;
using test_TP3;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = -1, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            
            app.UpdateQuality();
            
            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}