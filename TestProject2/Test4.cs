using System;
using System.Collections.Generic;
using NUnit.Framework;
using test_TP3;

namespace TestProject2
{
    [TestFixture]
    public class Tests4
    {
        [Test]
        public void Test4()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 20, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            
            app.UpdateQuality();
            
            Assert.AreEqual(50, Items[0].Quality);
        }
    }
}