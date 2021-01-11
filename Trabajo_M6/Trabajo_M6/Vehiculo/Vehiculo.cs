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


    }
}
