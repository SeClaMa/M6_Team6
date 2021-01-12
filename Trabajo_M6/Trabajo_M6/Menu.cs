using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
    public class Menu
    {
        public void MostrarMenu()
        {
            bool acabar = false;
            string opcion = "";
            string opcion2 = "";

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

            int posicion = 0;

            List<Persona> list_conductor = new List<Persona>();
            List<Titular> list_titular = new List<Titular>();
            List<Vehiculo> list_vehiculos = new List<Vehiculo>();

            Console.WriteLine("A continuación deberá crear todos los usuarios del programa");
            while (!acabar)
            {
                Console.WriteLine("Introduce el nombre del usuario");
                nombre = Console.ReadLine();
                Console.WriteLine("Introduce el primer apellido del usuario");
                apellido1 = Console.ReadLine();
                Console.WriteLine("Introduce el segundo apellido del usuario");
                apellido2 = Console.ReadLine();

                nombre_completo = nombre + " " + apellido1 + " " + apellido2;

                Console.WriteLine("Introduce la fecha de nacimiendo del usuario");
                fecha_nacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("¿Que tipo de licencia tienes?");
                tipo_licencia = Convert.ToChar(Console.ReadLine());
                licencia_perso = new Licencia("1", tipo_licencia, nombre_completo);

                Console.WriteLine("¿Quieres crear un conductor o un titular? 1-conductor 2-titular");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Conductor cond = new Conductor(nombre, apellido1, apellido2, fecha_nacimiento, licencia_perso);
                        list_conductor.Add(cond);
                        break;
                    case "2":
                        Console.WriteLine("¿Este titular tiene garage? 1- Si 2 - No");
                        opcion2 = Console.ReadLine();
                        if (opcion2 == "1") garage = true;
                        else if (opcion2 == "2") garage = false;
                        else
                        {
                            Console.WriteLine("Opcion invalida. Se pondra como que no tiene garage por defecto");
                            garage = false;
                        }

                        Console.WriteLine("¿Este titular tiene seguro? 1- Si 2 - No");
                        opcion2 = Console.ReadLine();
                        if (opcion2 == "1") seguro = true;
                        else if (opcion2 == "2") seguro = false;
                        else
                        {
                            Console.WriteLine("Opcion invalida. Se pondra como que no tiene seguro por defecto");
                            seguro = false;
                        }

                        Titular tit = new Titular(nombre, apellido1, apellido2, fecha_nacimiento, seguro, garage, licencia_perso);
                        list_titular.Add(tit);
                        list_conductor.Add(tit);
                        break;
                }

                Console.WriteLine("¿Quiere seguir creando usuarios? 1 - Si 2-No");
                opcion = Console.ReadLine();
                if (opcion == "2") acabar = true;
                else acabar = false;
            }
            acabar = false;
            Console.WriteLine("A continuación creará los vehiculos");
            while (!acabar)
            {
                Console.WriteLine("Ponga la Marca del Vehiculo");
                marca = Console.ReadLine();

                Console.WriteLine("Ponga la Color del Vehiculo");
                color = Console.ReadLine();

                Console.WriteLine("Ponga la Matricula del Vehiculo");
                matricula = Console.ReadLine();

                Console.WriteLine("¿Este vehiculo tiene titular? 1 - Si 2 - No");
                opcion2 = Console.ReadLine();
                if (opcion2 == "1" && list_titular.Count > 0)
                {
                    int j = 0;
                    foreach (Titular t in list_titular)
                    {
                        Console.Write(j + "-:");
                        Console.WriteLine(t.ToString());
                        j++;
                    }
                    Console.WriteLine("¿Cual es el titular del vehiculo? (Pon el numero del titular)");
                    posicion = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Que vehiculo desea crear: 1(Coche), 2(Moto), 3(Camion)");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Coche coche1 = new Coche(marca, color, matricula, list_titular[posicion]);

                        coche1.CrearRuedas();

                        Console.WriteLine(coche1.ToString());
                        coche1.mostrarRuedas();
                        coche1.AgregarConductores(list_conductor);
                        list_vehiculos.Add(coche1);

                        break;

                    case "2":
                        Moto moto1 = new Moto(marca, color, matricula, list_titular[posicion]);

                        moto1.CrearRuedas();

                        Console.WriteLine(moto1.ToString());
                        moto1.mostrarRuedas();
                        moto1.AgregarConductores(list_conductor);
                        list_vehiculos.Add(moto1);

                        break;

                    case "3":
                        Camion camion1 = new Camion(marca, color, matricula, list_titular[posicion]);

                        camion1.CrearRuedas();

                        Console.WriteLine(camion1.ToString());
                        camion1.mostrarRuedas();
                        camion1.AgregarConductores(list_conductor);
                        list_vehiculos.Add(camion1);
                        break;

                    default:
                        break;
                }

                Console.WriteLine("¿Quiere seguir creando vehiculos? 1 - Si 2-No");
                opcion = Console.ReadLine();
                if (opcion == "2") acabar = true;
                else acabar = false;
            }

            foreach (Persona p in list_conductor)
            {
                Console.WriteLine(p.ToString());
            }

            foreach (Vehiculo v in list_vehiculos)
            {
                Console.WriteLine(v.ToString());
            }
        }
    }
}
