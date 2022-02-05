using System;
using System.Collections.Generic;
using NUnit.Framework;
using test_TP3;

namespace TestProject2
{
    [TestFixture]
    public class Tests9
    {
        [Test]
        public void Test9()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake" , SellIn = 0, Quality = 30 } };
            GildedRose app = new GildedRose(Items);
            
            app.UpdateQuality();
            
            Assert.AreEqual(28, Items[0].Quality);
        }
    }
}