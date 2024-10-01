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
        Item item;
        for (var i = 0; i < Items.Count; i++)
        {
            item = Items[i];

            if (item.Name.Equals("Sulfuras, Hand of Ragnaros")){
                UpdateSulfurasQuality(item);
            }

            else{
                item.SellIn -= 1;
            
                if (item.Name.Equals("Aged Brie")){
                    UpdateBrieQuality(item); 
                }
                
                else if (item.Name.Equals("Backstage passes to a TAFKAL80ETC concert")){
                    UpdateBackStageQuality(item);
                }

                else if (item.Name.Contains("Conjured")){
                    UpdateConjuredQuality(item);
                }

                else{
                    UpdateOtherQuality(item);
                }

                MinMax(item);
            }
        }
    }

    private void UpdateBrieQuality(Item brie){
        if (brie.SellIn >= 0){
            brie.Quality += 1;
        }
        else{
            brie.Quality += 2;
        }

        return;
    }

    private void UpdateSulfurasQuality(Item sulfuras){
        return;
    }

    private void UpdateBackStageQuality(Item backStage){
        if (backStage.SellIn >= 10){
            backStage.Quality += 1;
        }

        else if (backStage.SellIn >= 5){
            backStage.Quality += 2;
        }

        else if (backStage.SellIn >= 0){
            backStage.Quality += 3;
        }

        else{
            backStage.Quality = MINQUALITY;
        }


        return;
    }

    private void UpdateConjuredQuality(Item conjured){

        if (conjured.SellIn >= 0){
            conjured.Quality -= 2;
        }

        else {
            conjured.Quality -= 4;
        }

        return;
    }

    private void UpdateOtherQuality(Item other){
        
        if (other.SellIn >= 0){
            other.Quality -= 1;
        }
        
        else {
            other.Quality -= 2;
        }

        return;
    }

    private void MinMax(Item item){
        if (item.Quality > MAXQUALITY){
            item.Quality = MAXQUALITY;
        }
        
        if (item.Quality < MINQUALITY){
            item.Quality = MINQUALITY;
        }
    }

}