using System;
using System.Collections.Generic;
using NUnit.Framework;
using test_TP3;

namespace TestProject2
{
    [TestFixture]
    public class Tests7
    {
        [Test]
        public void Test7()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 30 } };
            GildedRose app = new GildedRose(Items);
            
            app.UpdateQuality();
            
            Assert.AreEqual(33, Items[0].Quality);
        }
    }
}