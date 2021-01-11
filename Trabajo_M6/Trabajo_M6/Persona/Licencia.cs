using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
    class Licencia
    {
        private string id;
        private string tipo;
        private string nombre_completo;
        private DateTime fecha_caducidad;

        #region cons
        public Licencia()
        {
            this.id = "";
            this.tipo = "";
            this.nombre_completo = "";
            this.fecha_caducidad = GenerarFechaCaducidad();
        }

        public Licencia(string id, string tipo, string nombre_completo, DateTime fecha_caducidad)
        {
            this.id = id;
            this.tipo = tipo;
            this.nombre_completo = nombre_completo;
            this.fecha_caducidad = fecha_caducidad;
        }

        #region getters
        public string Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public DateTime Fecha_caducidad { get => fecha_caducidad; set => fecha_caducidad = value; }
        #endregion

        #endregion
        public DateTime GenerarFechaCaducidad()
        {
            DateTime fecha_por_defecto = new DateTime(2050, 1, 1);
            return fecha_por_defecto;
        }

    }
}
