using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_M6
{
    public class Licencia
    {
        private string id;
        private char tipo;
        private string nombre_completo;
        private DateTime fecha_caducidad;

        #region cons
        public Licencia()
        {
            this.id = "";
            this.tipo = ' ';
            this.nombre_completo = "";
            this.fecha_caducidad = new DateTime(GenerarAño(), 1, 1);
        }

        public Licencia(string id, char tipo, string nombre_completo)
        {
            this.id = id;
            this.tipo = comprobarLicencia(tipo);
            this.nombre_completo = nombre_completo;
            this.fecha_caducidad = new DateTime(GenerarAño(),1,1);
        }
        #endregion
        #region getters
        public string Id { get => id; set => id = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public DateTime Fecha_caducidad { get => fecha_caducidad; set => fecha_caducidad = value; }
        #endregion

        public int GenerarAño()
        {
            return DateTime.Now.Year + 4;
        }

        public char comprobarLicencia(char tipo_licencia)
        {
            tipo_licencia = Char.ToUpper(tipo_licencia);
            if(tipo_licencia != 'A' && tipo_licencia != 'B' && tipo_licencia != 'C')
            {
                Console.WriteLine("No es un tipo de licencia correcta, te pondremos la licencia por defecto (tipo B)");
                return 'B';
            }
            return tipo_licencia;
        }
    }
}
