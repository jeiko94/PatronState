

namespace PatronState
{
    public class Vendiendo : IEstado
    {
        private MaquinaExpendedora _maquina;

        public Vendiendo(MaquinaExpendedora maquina)
        {
            _maquina = maquina;
        }

        public void InsertarMoneda()
        {
            Console.WriteLine("Espere, estamos dispensando su producto.");
        }
        public void EyectarMoneda()
        {
            Console.WriteLine("No puede devolver la moneda despues de seleccionar el producto");
        }
        public void SeleccionarProducto()
        {
            Console.WriteLine("Ya se seleccionó el producto.");
        }
        public void Dispensar()
        {
            Console.WriteLine("Dispensando el producto...");
            _maquina.LiberarProducto();

            if (_maquina.CantidadProducto > 0)
            {
                _maquina.EstadoActual = _maquina.EstadoSinMoneda;
            }
            else
            {
                Console.WriteLine("El producto se ha agotado.");
                _maquina.EstadoActual = _maquina.EstadoAgotado;
            }
        }
    }
}
