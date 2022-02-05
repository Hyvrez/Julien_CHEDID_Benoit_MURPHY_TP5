namespace test_TP3
{
    public class Updating
    {
        public void updating_Aged(Item item)
        {
            if ( item.Quality <50 && item.SellIn > 0)
            {
                item.Quality = item.Quality + 1;
            }
            else if ( item.Quality <50 && item.SellIn <= 0)
            {
                item.Quality = item.Quality + 2;
            }
            
            item.SellIn = item.SellIn - 1;
        }

        public void updating_Backstage(Item item)
        {
            if (item.Quality <= 50 && item.SellIn > 0)
            {
                if (item.SellIn <= 5)
                {
                    if (item.Quality > 47)
                    {
                        item.Quality = 50;
                    }
                    else
                    {
                        item.Quality = item.Quality + 3;
                    }
                }
                else if(item.SellIn<=10 && item.SellIn >5)
                {
                    if (item.Quality > 47)
                    {
                        item.Quality = 50;
                    }
                    else
                    {
                        item.Quality = item.Quality + 2;
                    }
                    
                }
                else
                {
                    item.Quality = item.Quality + 1;
                }
            }
            else
            {
                item.Quality = 0;
            }
            item.SellIn = item.SellIn - 1;
        }

        public void updating_Mana(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }
            item.SellIn = item.SellIn - 1;
        }

        public void updating_default(Item item)
        {
            if (item.SellIn <= 0 && item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }
            else if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;
        }
    }
}