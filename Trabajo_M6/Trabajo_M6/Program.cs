using System;

namespace Trabajo_M6
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcion, 
                marca="",
                color="",
                matricula="";

            Console.WriteLine("Ponga la Marca del Vehiculo");
            marca = Console.ReadLine();

            Console.WriteLine("Ponga la Color del Vehiculo");
            color = Console.ReadLine();

            Console.WriteLine("Ponga la Matricula del Vehiculo");
            matricula = Console.ReadLine();

            Console.WriteLine("Que vehiculo desea crear: 1(Coche), 2(Moto)");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                 case "1":                  
                    Coche coche1 = new Coche(marca,color,matricula);

                    coche1.CrearRuedas();

                    Console.WriteLine(coche1.ToString());
                    coche1.mostrarRuedas();

                    break;

                case "2":
                    Moto moto1 = new Moto(marca,color,matricula);

                    moto1.CrearRuedas();

                    Console.WriteLine(moto1.ToString());
                    moto1.mostrarRuedas();

                    break;

                default:
                    break;
            }



        }
    }
}
