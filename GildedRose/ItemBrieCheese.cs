namespace GildedRoseKata
{
    public class ItemBrieCheese : Item
    {
        public ItemBrieCheese(int sellIn, int quality)
        {
            Nombre = "Aged Brie";
            DiasHastaLaVenta = sellIn;
            Calidad = quality;
        }

        public override void ActualizarCalidad()
        {
            if (Calidad >= 50)
            {
                Calidad += 1;
                if (DiasHastaLaVenta < 0)
                {
                    Calidad += 1;
                }
            }
        }
    }
}
