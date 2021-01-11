using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
    public class Conductor : Persona
    {
        #region cons
        public Conductor()
        {
            this.nombre = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.fecha_nacimiento = DateTime.Now;
            this.licencia_perso = new Licencia();

        }
        public Conductor(string nombre, string apellido1, string apellido2, DateTime fecha_nacimiento, Licencia licencia)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fecha_nacimiento = fecha_nacimiento;
            this.licencia_perso = licencia;
        }
        #endregion

        public override string ToString()
        {
            return "Nombre: " + nombre + " primer apellido: " + apellido1 + " segundo apellido: " + apellido2 + " Fecha de nacimiento: " + fecha_nacimiento.Date + " ID licencia " + licencia_perso.Id + " Tipo licencia " + licencia_perso.Tipo + " Fecha caducidad licencia " + licencia_perso.Fecha_caducidad;
        }
    }


}
