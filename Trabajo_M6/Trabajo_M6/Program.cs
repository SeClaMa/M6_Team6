using System;

namespace Trabajo_M6
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("Toyota","Rojo","56MD34");

            coche1.CrearRuedas();

            Console.WriteLine(coche1.ToString());
            coche1.mostrarRuedas();
        }
    }
}
