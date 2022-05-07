namespace GildedRoseKata
{
    public class ItemBackstagePass : Item
    {
        public ItemBackstagePass(int sellIn, int quality)
        {
            Nombre = "Backstage passes to a TAFKAL80ETC concert";
            DiasHastaLaVenta = sellIn;
            Calidad = quality;
        }

        public override void ActualizarCalidad()
        {
            if (DiasHastaLaVenta < 0)
            {
                Calidad = 0;
            }
            else if (Calidad < 50)
            {
                Calidad += 1;
                if(DiasHastaLaVenta < 11)
                    Calidad += 1;
                if (DiasHastaLaVenta < 5)
                    Calidad += 1;
            }
        }
    }
}
