using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
    public class Persona
    {
        protected string nombre;
        protected string apellido1;
        protected string apellido2;
        protected DateTime fecha_nacimiento;
        protected Licencia licencia_perso;
        #region cons
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public Licencia Licencia_perso { get => licencia_perso; set => licencia_perso = value; }
        #endregion

        public DateTime GenerarFechaNacimiento()
        {
            DateTime fecha_por_defecto = new DateTime(2000, 1, 1);
            return fecha_por_defecto;
        }
    }
}
