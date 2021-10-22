using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Deportista
    {
        private int cantidadPartidos;
        private int edad;
        private string nombreApellido;

        public string NombreApellido
        {
            get { return nombreApellido; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int CantidadPartidos
        {
            get { return cantidadPartidos; }
            set { cantidadPartidos = value; }
        }

        public Deportista(string nombreApellido, int edad, int cantidadPartidos)
        {
            this.cantidadPartidos = cantidadPartidos;
            this.edad = edad;
            this.nombreApellido = nombreApellido;
        }


    }
}
