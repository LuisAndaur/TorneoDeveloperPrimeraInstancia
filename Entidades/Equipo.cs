using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private Entrenador entrenador;
        private Estadistica estadistica;
        private List<Jugador> listaJugadores;
        private string nombreEquipo;        

        public string NombreEquipo
        {
            get { return nombreEquipo; }
        }

        public List<Jugador> ListaJugadores
        {
            get { return listaJugadores; }
            set { listaJugadores = value; }
        }

        public Estadistica Estadistica
        {
            get { return estadistica; }
            set { estadistica = value; }
        }

        public Entrenador Entrenador
        {
            get { return entrenador; }
            set { entrenador = value; }
        }

        public Equipo(string nombreEquipo, Entrenador entrenador, List<Jugador> listaJugadores, Estadistica estadistica)
        {
            this.entrenador = entrenador;
            this.estadistica = estadistica;
            this.listaJugadores = listaJugadores;
            this.nombreEquipo = nombreEquipo;
        }


    }
}
