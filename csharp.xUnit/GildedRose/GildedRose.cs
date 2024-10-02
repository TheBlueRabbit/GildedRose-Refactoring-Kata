using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;
    private const int MAXQUALITY = 50;
    private const int MINQUALITY = 0;
    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (Item item in Items)
        {
            ICustomItem customItem = CustomItemFactory.CustomizeItem(item);
            customItem.UpdateSellIn(item);
            customItem.UpdateQuality(item);
            customItem.MinMax(item);
        }
    }


}