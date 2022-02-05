using System.Collections.Generic;

namespace test_TP3
{
    public class GildedRose_Refactoring
    {
        private Updating _updating = new Updating();
        IList<Item> Items;
        
        public GildedRose_Refactoring(IList<Item> Items)
        {
            this.Items = Items;
        }
        
        
        public void updateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                switch (Items[i].Name)
                {
                    case "Aged Brie":
                        _updating.updating_Aged(Items[i]);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        _updating.updating_Backstage(Items[i]);
                        break;
                    case "Conjured Mana Cake":
                        _updating.updating_Mana(Items[i]);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    default:
                        _updating.updating_default(Items[i]);
                        break;
                }
            }
        }
    }
}