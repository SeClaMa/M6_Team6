using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
   public class Vehiculo
    {      
        protected string marca;
        protected string color;
        protected string matricula;


        #region Get Set
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        #endregion

        public string generarMatricula()
        {
            Random aleatorio = new Random();
            char letra = ' ';
            matricula = "";

            for (int i = 0; i < 4; i++) 
            {
               matricula=matricula.Insert(i,Convert.ToString(aleatorio.Next(0, 10)));
            }

            for(int i = 4; i < 7; i++)
            {
                letra = (char)aleatorio.Next('A', 'Z');
                matricula = matricula.Insert(i,Convert.ToString(letra));
            }

            return matricula;
        }

    }
}
