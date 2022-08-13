using GildedRoseKata;

namespace GildedRoseTests;

internal static class DefinitionExtensions
{
    internal static Item With(this Item item, int sellIn, int quality)
    {
        item.SellIn=sellIn;
        item.Quality=quality;
        return item;
    }
}