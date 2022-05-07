namespace GildedRoseKata
{
    public class ItemConjurados : Item
    {
        public ItemConjurados(string nombre, int diasHastaLaVenta, int calidad)
        {
            Nombre = nombre;
            DiasHastaLaVenta = diasHastaLaVenta;
            Calidad = calidad;
        }

        public override void ActualizarCalidad()
        {
            if (Calidad > 2 && Calidad <= 50)
                Calidad -= 2;
            else if (Calidad < 2)
                Calidad = 0;
        }

        public override void ActualizarDiasVenta()
        {
        }
    }
}
