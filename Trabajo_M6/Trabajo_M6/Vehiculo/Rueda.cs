using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
   public class Rueda
    {
        #region Atributos
        private float diametro;
        private string marca;
        #endregion

        #region Get Set
        public float Diametro { get => diametro; set => diametro = value; }
        public string Marca { get => marca; set => marca = value; }
        #endregion


        #region Constructores
        public Rueda()
        {
            diametro = 0;
            marca = "";

        }

        public Rueda(float diametro, string marca)
        {
            this.diametro = diametro;
            this.marca = marca;
        }

        #endregion

    }
}
