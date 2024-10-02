using System;

namespace GildedRoseKata.CustomItems;

public class ConjuredItem : ICustomItem
{
    public void UpdateQuality(Item item){
        if (item.SellIn >= 0){
            item.Quality -= 2;
        }

        else {
            item.Quality -= 4;
        }

        return;
    }
}
