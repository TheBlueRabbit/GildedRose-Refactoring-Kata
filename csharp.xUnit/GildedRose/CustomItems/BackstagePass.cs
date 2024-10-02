using System;

namespace GildedRoseKata.CustomItems;

public class BackstagePass : ICustomItem
{
    public void UpdateQuality(Item item){
        if (item.SellIn >= 10){
            item.Quality += 1;
        }

        else if (item.SellIn >= 5){
            item.Quality += 2;
        }

        else if (item.SellIn >= 0){
            item.Quality += 3;
        }

        else{
            item.Quality = Constants.MINQUALITY;
        }


        return;
    }
}
