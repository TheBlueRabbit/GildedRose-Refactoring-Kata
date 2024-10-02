using System;
using System.ComponentModel;
using System.Diagnostics;
using GildedRoseKata.CustomItems;

namespace GildedRoseKata;

public static class CustomItemFactory
{

    public static ICustomItem CustomizeItem(Item item){
        switch (item.Name){
            
            case"Aged Brie" : 
                return new AgedBrie();

            case "Backstage passes to a TAFKAL80ETC concert":
                return new BackstagePass();

            case "Conjured Mana Cake":
                return new ConjuredItem();

            case "Sulfuras, Hand of Ragnaros":
                return new SulfurasItem();
            
            default:
                return new OtherItem();
                
        }

    }
}
