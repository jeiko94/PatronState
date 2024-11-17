using PatronState;

class Program
{
    static void Main(string[] args)
    {
        MaquinaExpendedora maquina = new MaquinaExpendedora(2);

        //Primer producto
        maquina.InsertarMoneda();
        maquina.SeleccionarProducto();

        Console.WriteLine();        

        //Comprar sin moneda
        maquina.SeleccionarProducto();

        Console.WriteLine();

        //Segundo producto
        maquina.InsertarMoneda();
        maquina.SeleccionarProducto();

        Console.WriteLine();

        //Intentar comprar cuando esta agotado
        maquina.InsertarMoneda();
        maquina.SeleccionarProducto();

        
    }
}