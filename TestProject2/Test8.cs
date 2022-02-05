using System;
using System.Collections.Generic;
using NUnit.Framework;
using test_TP3;

namespace TestProject2
{
    [TestFixture]
    public class Tests8
    {
        [Test]
        public void Test8()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 30 } };
            GildedRose app = new GildedRose(Items);
            
            app.UpdateQuality();
            
            Assert.AreEqual(0, Items[0].Quality);
        }
    }
}