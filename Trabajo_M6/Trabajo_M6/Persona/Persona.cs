using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
    class Persona
    {
        private string nombre;
        private string apellido1;
        private string apellido2;
        private DateTime fecha_nacimiento;

        #region cons
        public Persona()
        {
            this.nombre = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.fecha_nacimiento = GenerarFechaNacimiento();
        }

        public Persona(string nombre, string apellido1, string apellido2, DateTime fecha_nacimiento)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fecha_nacimiento = fecha_nacimiento;
        }
        #endregion

        #region cons
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        #endregion

        public DateTime GenerarFechaNacimiento()
        {
            DateTime fecha_por_defecto = new DateTime(2000, 1, 1);
            return fecha_por_defecto;
        }
    }
}
