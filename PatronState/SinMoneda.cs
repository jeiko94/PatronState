
namespace PatronState
{
    public class SinMoneda : IEstado
    {
        private MaquinaExpendedora _maquina;

        public SinMoneda(MaquinaExpendedora maquina)
        {
            _maquina = maquina;
        }
        public void InsertarMoneda()
        {
            Console.WriteLine("Moneda insertada.");
            _maquina.EstadoActual = _maquina.EstadoConMoneda;
        }

        public void EyectarMoneda()
        {
            Console.WriteLine("No hay moneda que devolver.");
        }

        public void SeleccionarProducto()
        {
            Console.WriteLine("Primero inserte una moneda.");
        }

        public void Dispensar()
        {
            Console.WriteLine("Primero pague el producto.");
        }
    }
}
