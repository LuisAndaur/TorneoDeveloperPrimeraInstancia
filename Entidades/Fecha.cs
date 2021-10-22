using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fecha
    {
        private int id;
        private List<Partido> partidos = new List<Partido>();

        public Fecha(int id, List<Partido> partidos)
        {
            this.id = id;
            this.Partidos = partidos;
        }

        public List<Partido> Partidos
        {
            get { return partidos; }
            set { partidos = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



    }
}
