using GildedRoseKata;
using System;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public static class TexttestFixture
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Nombre = "+5 Dexterity Vest", DiasHastaLaVenta = 10, Calidad = 20},
                new ItemBrieCheese(sellIn:2,quality:0),
                new Item {Nombre = "Elixir of the Mongoose", DiasHastaLaVenta = 5, Calidad = 7},
                new ItemSulfuras(sellIn:0, quality:80),
                new ItemSulfuras(sellIn:-1, quality:80),
                new ItemBackstagePass(sellIn:15,quality:20),
                new ItemBackstagePass(sellIn:10,quality:49),
                new ItemBackstagePass(sellIn:5,quality:49),
                // this conjured item does not work properly yet
                new ItemConjurados(nombre:"Conjured Mana Cake",diasHastaLaVenta:3, calidad:6)
            };

            var app = new GildedRose(Items);

            int days = 2;
            if (args.Length > 0)
            {
                days = int.Parse(args[0]) + 1;
            }

            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Nombre + ", " + Items[j].DiasHastaLaVenta + ", " + Items[j].Calidad);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
