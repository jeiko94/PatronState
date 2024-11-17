
namespace PatronState
{
    public class ConMoneda : IEstado
    {
        private MaquinaExpendedora _maquina;

        public ConMoneda(MaquinaExpendedora maquina)
        {
            _maquina = maquina;
        }
        public void InsertarMoneda()
        {
            Console.WriteLine("Ya hay una moneda insertada.");

        }

        public void EyectarMoneda()
        {
            Console.WriteLine("Moneda devuelta.");
            _maquina.EstadoActual = _maquina.EstadoSinMoneda;
        }

        public void SeleccionarProducto()
        {
            Console.WriteLine("Producto seleccionado.");
            _maquina.EstadoActual = _maquina.EstadoVendiendo;
        }

        public void Dispensar()
        {
            Console.WriteLine("No se ha seleccionado el producto.");
        }
    }
}
