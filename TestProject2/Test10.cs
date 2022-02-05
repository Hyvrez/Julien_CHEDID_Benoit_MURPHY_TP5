using System;
using System.Collections.Generic;
using NUnit.Framework;
using test_TP3;

namespace TestProject2
{
    [TestFixture]
    public class Tests10
    {
        [Test]
        public void Test10()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            
            app.UpdateQuality();
            
            Assert.AreEqual(80, Items[0].Quality);
        }
    }
}