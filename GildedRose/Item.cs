namespace GildedRoseKata
{
    public class Item : ICalculoCalidad
    {
        public string Nombre { get; set; }
        public int DiasHastaLaVenta { get; set; }
        public int Calidad { get; set; }

        public virtual void ActualizarDiasVenta()
        {
            DiasHastaLaVenta -= 1;
        }

        public virtual void ActualizarCalidad()
        {
            if (Calidad <= 0) return;
            {
                Calidad -= 1;
                if (DiasHastaLaVenta < 0)
                {
                    Calidad += 1;
                }
            }
        }
    }
}
