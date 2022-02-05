using System;
using System.Collections.Generic;
using NUnit.Framework;
using test_TP3;

namespace TestProject2
{
    [TestFixture]
    public class Tests3
    {
        [Test]
        public void Test3()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 20, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            
            app.UpdateQuality();
            
            Assert.AreEqual(3, Items[0].Quality);
        }
    }
}