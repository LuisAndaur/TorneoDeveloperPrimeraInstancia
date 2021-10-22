using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {
        private int empatados;
        private int ganados;
        private int golesEnContra;
        private int golesFavor;
        private int partJugados;
        private int perdidos;
        private int puntos;

        public int Puntos
        {
            get { return puntos; }
        }

        public int Perdidos
        {
            get { return perdidos; }
        }

        public int PartJugados
        {
            get { return partJugados; }
            set { partJugados = value; }
        }

        public int GolesFavor
        {
            get { return golesFavor; }
        }

        public int GolesNegativos
        {
            get { return golesEnContra; }
        }

        public int Ganados
        {
            get { return ganados; }
        }

        public int Empatados
        {
            get { return empatados; }
        }

        public Estadistica()
        {

        }

        public void Actualizar(EResultado resultado, int golFavor, int golNegativo)
        {

        }



    }
}
