using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partido
    {
        private Equipo equipoLocal;
        private Equipo equipoVisitante;
        private int golesLocal;
        private int golesVisitante;
        private bool partidoJugado;
        private Random random;
        private EResultado resultadoEquipoLocal;

        private Partido()
        {

        }

        public Partido(Equipo local, Equipo visitante)
        {
            this.equipoLocal = local;
            this.equipoVisitante = visitante;
        }

        public void SimularPartido()
        {

        }

    }
}
