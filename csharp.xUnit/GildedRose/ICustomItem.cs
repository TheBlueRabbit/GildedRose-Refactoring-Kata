using System;

namespace GildedRoseKata;

public interface ICustomItem
{
    public void UpdateSellIn(Item item) => item.SellIn --;
    public void UpdateQuality(Item item);

    public void MinMax(Item item){
        if (item.Quality > Constants.MAXQUALITY){
            item.Quality = Constants.MAXQUALITY;
        }
        
        if (item.Quality < Constants.MINQUALITY){
            item.Quality = Constants.MINQUALITY;
        }
    }
}
