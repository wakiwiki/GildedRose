using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var itemName = Items[i].Name;
                if (itemName != "Aged Brie" && itemName != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (itemName != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality -= 1;
                            if(Items[i].Quality > 0 && itemName == "Conjured Mana Cake")
                                Items[i].Quality -= 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality += 1;

                        if (itemName == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality += 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality += 1;
                                }
                            }
                        }
                    }
                }

                if (itemName != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn -= 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (itemName != "Aged Brie")
                    {
                        if (itemName != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (itemName != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality -= 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality -= Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality += 1;
                        }
                    }
                }
            }
        }
    }
}
