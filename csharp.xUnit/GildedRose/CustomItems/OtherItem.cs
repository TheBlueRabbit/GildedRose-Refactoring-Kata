using System;

namespace GildedRoseKata.CustomItems;

public class OtherItem : ICustomItem
{
    public void UpdateQuality(Item item){
        if (item.SellIn >= 0){
            item.Quality -= 1;
        }
        
        else {
            item.Quality -= 2;
        }

        return;
    }
}
