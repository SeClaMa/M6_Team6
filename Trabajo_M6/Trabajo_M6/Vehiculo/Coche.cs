using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
   public class Coche : Vehiculo
    {
        protected const int n_ruedas = 4 ;

        private Rueda[] array_ruedas = new Rueda[n_ruedas];

        #region Constructores
        public Coche()
        {
            marca = "";
            color = "";
            matricula = "";
        }


        public Coche(string marca, string color)
        {
            this.marca = marca;
            this.color = color;
            this.matricula = generarMatricula();
        }

        public Coche (string marca, string color, string matricula, Titular titu)
        {
            this.marca = marca;
            this.color = color;
            this.matricula = comprobarMatricula(matricula);
            this.titu = titu;
        }
        #endregion


        public void CrearRuedas()
        {
            string marca_rueda;
            float diametro_rueda;

            for (int i = 0; i < array_ruedas.Length; i++)
            {
                if (i <= 1)
                {
                    Console.WriteLine("Inserte la marca de la rueda delantera: '{0}'",i + 1);
                    marca_rueda = Console.ReadLine();

                    Console.WriteLine("Inserte el diametro de la rueda delantera: '{0}'", i + 1);
                    diametro_rueda = Convert.ToSingle(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Inserte la marca de la rueda trasera: '{0}'", i + 1);
                    marca_rueda = Console.ReadLine();

                    Console.WriteLine("Inserte el diametro de la rueda trasera: '{0}'", i + 1);
                    diametro_rueda = Convert.ToSingle(Console.ReadLine());
                }

                if (diametro_rueda <= 0.4)
                {
                    diametro_rueda = 0.5f;
                }
                else if (diametro_rueda >= 4)
                {
                    diametro_rueda = 4f;
                }

                
                array_ruedas[i] = new Rueda(diametro_rueda, marca_rueda);
            }
        }

        public void mostrarRuedas()
        {
            for (int i = 0; i < array_ruedas.Length; i++)
            {
                Console.WriteLine("Rueda: "+ (i+1) +" Marca: "+ array_ruedas[i].Marca +" Diametro: "+ array_ruedas[i].Diametro);

            }
        }

        public override string ToString()
        {
            return "Marca: "+ marca +" Color: "+ color +" Matricula: "+ matricula + " Titular: " + titu;
        }
        public void AgregarConductores(List<Persona> list_menu)
        {
            string opcion = "";
            bool acabar = false;
            int posicion = 0;
            Console.WriteLine("¿Desea añadir algun conductor? 1-Si 2-No");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                int i = 0;
                foreach (Persona cond in list_menu)
                {
                    Console.WriteLine("{0} -: {1}", i, cond.ToString());
                    i++;
                }
                while (!acabar)
                {
                    Console.WriteLine("¿Que conductor quieres agregar?");
                    posicion = Convert.ToInt32(Console.ReadLine());
                    if(list_menu[posicion].Licencia_perso.Tipo == 'B')
                    {
                        lista_conductors.Add(list_menu[posicion]);

                    }
                    else
                    {
                        Console.WriteLine("Este conductor no puede conducir este vehiculo");
                    }
                    Console.WriteLine("¿Quieres añadir otro conductor? 1-Si 2-No");
                    opcion = Console.ReadLine();
                    if (opcion == "1") acabar = false;
                    else acabar = true;
                }
            }
        }
    }
}
