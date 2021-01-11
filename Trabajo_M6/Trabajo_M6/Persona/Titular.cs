using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
    class Titular : Persona
    {
        private bool seguro;
        private bool garage;

        #region cons
        public Titular()
        {
        }

        public Titular(bool seguro, bool garage)
        {
            this.seguro = seguro;
            this.garage = garage;
        }
        #endregion


        #region getters
        public bool Seguro { get => seguro; set => seguro = value; }
        public bool Garage { get => garage; set => garage = value; }
        #endregion
    }
}
