using System;

namespace Trabajo_M6
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcion = "";
            string marca = "";
            string color = "";
            string matricula = "";

            string nombre = "";
            string apellido1 = "";
            string apellido2 = "";

            string nombre_completo = "";
            DateTime fecha_nacimiento;
            Licencia licencia_perso;

            char tipo_licencia = ' ';
            bool garage = false;
            bool seguro = false;


            Console.WriteLine("Introduce tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu primer apellido");
            apellido1 = Console.ReadLine();
            Console.WriteLine("Introduce tu segundo apellido");
            apellido2 = Console.ReadLine();

            nombre_completo = nombre + " " + apellido1 + " " + apellido2;

            Console.WriteLine("Introduce tu fecha de nacimiento");
            fecha_nacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("¿Que tipo de licencia tienes?");
            tipo_licencia = Convert.ToChar(Console.ReadLine());
            licencia_perso = new Licencia("1", tipo_licencia, nombre_completo);

            Console.WriteLine("¿Tienes garage? 1 - Si 2- No");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    garage = true;
                    break;
                case "2":
                    garage = false;
                    break;
                default:
                    Console.WriteLine("La opcion no es correcta, se pondra como que no tienes garage");
                    garage = false;
                    break;
            }

            Console.WriteLine("¿Tienes seguro? 1 - Si 2- No");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    seguro = true;
                    break;
                case "2":
                    seguro = false;
                    break;
                default:
                    Console.WriteLine("La opcion no es correcta, se pondra como que no tienes seguro");
                    seguro = false;
                    break;
            }

            Titular titu1 = new Titular(nombre, apellido1, apellido2, fecha_nacimiento, garage, seguro, licencia_perso);
            Console.WriteLine(titu1.ToString());

            Console.WriteLine("Buenas " + nombre_completo);

            Console.WriteLine("Ponga la Marca del Vehiculo");
            marca = Console.ReadLine();

            Console.WriteLine("Ponga la Color del Vehiculo");
            color = Console.ReadLine();

            Console.WriteLine("Ponga la Matricula del Vehiculo");
            matricula = Console.ReadLine();

            Console.WriteLine("Que vehiculo desea crear: 1(Coche), 2(Moto), 3(Camion)");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                 case "1":       
                    if(titu1.Licencia_perso.Tipo == 'B')
                    {
                        Coche coche1 = new Coche(marca, color, matricula);

                        coche1.CrearRuedas();

                        Console.WriteLine(coche1.ToString());
                        coche1.mostrarRuedas();
                    }

                    else
                    {
                        Console.WriteLine("No puedes crar este tipo de vehiculo con esa licencia");
                    }
                   

                    break;

                case "2":
                    if (titu1.Licencia_perso.Tipo == 'A')
                    {
                        Moto moto1 = new Moto(marca, color, matricula);

                        moto1.CrearRuedas();

                        Console.WriteLine(moto1.ToString());
                        moto1.mostrarRuedas();
                    }

                    else
                    {
                        Console.WriteLine("No puedes crar este tipo de vehiculo con esa licencia");
                    }

                    break;

                case "3":
                    if (titu1.Licencia_perso.Tipo == 'C')
                    {
                        Camion camion1 = new Camion(marca, color, matricula);

                        camion1.CrearRuedas();

                        Console.WriteLine(camion1.ToString());
                        camion1.mostrarRuedas();
                    }

                    else
                    {
                        Console.WriteLine("No puedes crar este tipo de vehiculo con esa licencia");
                    }

                    break;

                default:
                    break;
            }

            Console.WriteLine("¿Eres tu el titular del vehiculo? 1- Si 2- No");
            opcion = Console.ReadLine();
            if(opcion == "2")
            {
                Console.WriteLine("Introduce tu nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Introduce tu primer apellido");
                apellido1 = Console.ReadLine();
                Console.WriteLine("Introduce tu segundo apellido");
                apellido2 = Console.ReadLine();

                nombre_completo = nombre + " " + apellido1 + " " + apellido2;

                Console.WriteLine("Introduce tu fecha de nacimiento");
                fecha_nacimiento = Convert.ToDateTime(Console.ReadLine());
                licencia_perso = new Licencia("1", 'B', nombre_completo);

                Console.WriteLine("¿Tienes garage? 1 - Si 2- No");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        garage = true;
                        break;
                    case "2":
                        garage = false;
                        break;
                    default:
                        Console.WriteLine("La opcion no es correcta, se pondra como que no tienes garage");
                        garage = false;
                        break;
                }

                Console.WriteLine("¿Tienes seguro? 1 - Si 2- No");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        seguro = true;
                        break;
                    case "2":
                        seguro = false;
                        break;
                    default:
                        Console.WriteLine("La opcion no es correcta, se pondra como que no tienes seguro");
                        seguro = false;
                        break;
                }

                Titular titu2 = new Titular(nombre, apellido1, apellido2, fecha_nacimiento, garage, seguro, licencia_perso);
            }

        }
    }
}
