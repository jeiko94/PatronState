
namespace PatronState
{
    public class MaquinaExpendedora
    {
        public IEstado EstadoSinMoneda { get; private set; } 
        public IEstado EstadoConMoneda { get; private set; }
        public IEstado EstadoVendiendo { get; private set; }
        public IEstado EstadoAgotado { get; private set; }

        public IEstado EstadoActual { get; set; }
        public int CantidadProducto { get; private set; }

        public MaquinaExpendedora(int cantidadProducto)
        {
            EstadoSinMoneda = new SinMoneda(this);
            EstadoConMoneda = new ConMoneda(this);
            EstadoVendiendo = new Vendiendo(this);
            EstadoAgotado = new Agotado(this);

            CantidadProducto = cantidadProducto;

            if (cantidadProducto > 0)
            {
                EstadoActual = EstadoSinMoneda;
            }
            else
            {
                EstadoActual = EstadoAgotado;
            }
        }

        public void InsertarMoneda()
        {
            EstadoActual.InsertarMoneda();
        }
        public void EyectarMoneda()
        {
            EstadoActual.EyectarMoneda();
        }
        public void SeleccionarProducto()
        {
            EstadoActual.SeleccionarProducto();
            EstadoActual.Dispensar();
        }

        public void LiberarProducto()
        {
            if (CantidadProducto > 0)
            {
                CantidadProducto--;
                Console.WriteLine("El producto ha sido dispensado.");
            }
        }
    }
}
