
namespace PatronState
{
    public class Agotado : IEstado
    {
        private MaquinaExpendedora _maquina;

        public Agotado(MaquinaExpendedora maquina)
        {
            _maquina = maquina;
        }

        public void InsertarMoneda()
        {
            Console.WriteLine("Producto agotado.");
        }
        public void EyectarMoneda()
        {
            Console.WriteLine("No hay moneda que devolver.");
        }
        public void SeleccionarProducto()
        {
            Console.WriteLine("Producto agotado.");
        }
        public void Dispensar()
        {
            Console.WriteLine("No se puede dispensar.");
        }
    }
}
