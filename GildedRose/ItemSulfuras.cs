namespace GildedRoseKata
{
    public class ItemSulfuras : Item
    {
        public ItemSulfuras(int sellIn, int quality)
        {
            Nombre = "Sulfuras, Hand of Ragnaros";
            DiasHastaLaVenta = sellIn;
            Calidad = quality;
        }

        public override void ActualizarCalidad()
        {
            //Segun las Notas Finales tiene una calidad inmutable de 80
            //if (Calidad < 50)
            //    Calidad += 1;
        }

        public override void ActualizarDiasVenta()
        {
        } 
    }
}
