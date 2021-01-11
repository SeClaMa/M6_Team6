using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
    public class Titular : Persona
    {
        private bool seguro;
        private bool garage;

        #region cons
        public Titular()
        {
            this.nombre = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.fecha_nacimiento = DateTime.Now;
            this.seguro = false;
            this.garage = false;
            this.licencia_perso = new Licencia();

        }
        public Titular(string nombre, string apellido1, string apellido2, DateTime fecha_nacimiento, bool seguro, bool garage, Licencia licencia)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fecha_nacimiento = fecha_nacimiento;
            this.seguro = seguro;
            this.garage = garage;
            this.licencia_perso = licencia;
        }
        #endregion


        #region getters
        public bool Seguro { get => seguro; set => seguro = value; }
        public bool Garage { get => garage; set => garage = value; }
        #endregion

        public override string ToString()
        {
            return "Nombre: " + nombre + " primer apellido: " + apellido1 + " segundo apellido: " + apellido2 + " Fecha de nacimiento: " + fecha_nacimiento.Date + " Seguro " + seguro + " Garage " + garage + " ID licencia " + licencia_perso.Id + " Tipo licencia " + licencia_perso.Tipo + " Fecha caducidad licencia " + licencia_perso.Fecha_caducidad;
        }
    }
}
