using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Torneo
    {
        private static Equipo campeon;
        private static List<Fecha> fixture;
        private static List<Equipo> listaEquipos;
        private static string nombreTorneo;

        public static List<Equipo> ListaEquipos
        {
            get
            {
                return listaEquipos;
            }

            set
            {
                listaEquipos = value;
            }
        }

        static Torneo()
        {
            nombreTorneo = "Torneo Developer";
            fixture = new List<Fecha>();
            listaEquipos = new List<Equipo>();
            CargarEquipos();
            CargarPartidos();
        }

        private static void CargarEquipos()
        {
            listaEquipos.Add(new Equipo("LaFrontend",
                                        new Entrenador("Brendan Eich", 53, 120, 7, false),
                                        new List<Jugador> { new Jugador("HTML", 34, 76, Jugador.EPuesto.Delantero),
                                                            new Jugador("CSS", 30, 53, Jugador.EPuesto.Delantero),
                                                            new Jugador("JS", 27, 61, Jugador.EPuesto.Defensor),
                                                            new Jugador("Angular", 20, 31, Jugador.EPuesto.Arquero),
                                                            new Jugador("React", 19, 28, Jugador.EPuesto.Defensor)},
                                        new Estadistica() ));
            
            listaEquipos.Add(new Equipo("SuperBackend",
                                        new Entrenador("Dennis Ritchie", 76, 309, 2, false),
                                        new List<Jugador> { new Jugador("CSharp", 48, 173, Jugador.EPuesto.Defensor),
                                                            new Jugador("C++", 55, 240, Jugador.EPuesto.Defensor),
                                                            new Jugador("C", 58, 275, Jugador.EPuesto.Arquero),
                                                            new Jugador("Java", 56, 200, Jugador.EPuesto.Delantero),
                                                            new Jugador("PHP", 46, 98, Jugador.EPuesto.Delantero)},
                                        new Estadistica() ));
            
            listaEquipos.Add(new Equipo("Gamers",
                                        new Entrenador("Hidetaka Miyazaki", 37, 102, 4, true),
                                        new List<Jugador> { new Jugador("Unity", 37, 134, Jugador.EPuesto.Delantero),
                                                            new Jugador("Unreal", 34, 118, Jugador.EPuesto.Delantero),
                                                            new Jugador("CryEngine", 23, 56, Jugador.EPuesto.Defensor),
                                                            new Jugador("RPGMaker", 25, 35, Jugador.EPuesto.Arquero),
                                                            new Jugador("Cocos 2D", 19, 20, Jugador.EPuesto.Defensor)},
                                        new Estadistica() ));
            
            listaEquipos.Add(new Equipo("LinuxComand",
                                        new Entrenador("Linus Torvalds", 60, 338, 3, true),
                                        new List<Jugador> { new Jugador("sudo", 48, 180, Jugador.EPuesto.Delantero),
                                                            new Jugador("echo", 43, 115, Jugador.EPuesto.Delantero),
                                                            new Jugador("bash", 50, 176, Jugador.EPuesto.Defensor),
                                                            new Jugador("grep", 47, 135, Jugador.EPuesto.Defensor),
                                                            new Jugador("man man", 51, 140, Jugador.EPuesto.Arquero)},
                                        new Estadistica() ));
        }

        private static void CargarPartidos()
        {            
            Partido partidoIda1 = new Partido(listaEquipos[0], listaEquipos[3]);
            Partido partidoIda2 = new Partido(listaEquipos[1], listaEquipos[2]);
            Partido partidoIda3 = new Partido(listaEquipos[0], listaEquipos[2]);
            Partido partidoIda4 = new Partido(listaEquipos[1], listaEquipos[3]);
            Partido partidoIda5 = new Partido(listaEquipos[0], listaEquipos[1]);
            Partido partidoIda6 = new Partido(listaEquipos[2], listaEquipos[3]);

            Partido partidoVuelta1 = new Partido(listaEquipos[3], listaEquipos[0]);
            Partido partidoVuelta2 = new Partido(listaEquipos[2], listaEquipos[1]);
            Partido partidoVuelta3 = new Partido(listaEquipos[2], listaEquipos[0]);
            Partido partidoVuelta4 = new Partido(listaEquipos[3], listaEquipos[1]);
            Partido partidoVuelta5 = new Partido(listaEquipos[1], listaEquipos[0]);
            Partido partidoVuelta6 = new Partido(listaEquipos[3], listaEquipos[2]);

            fixture.Add(new Fecha(1, new List<Partido> { partidoIda1, partidoIda2 }) );
            fixture.Add(new Fecha(2, new List<Partido> { partidoIda3, partidoIda4 }) );
            fixture.Add(new Fecha(3, new List<Partido> { partidoIda5, partidoIda6 }) );
            fixture.Add(new Fecha(4, new List<Partido> { partidoVuelta1, partidoVuelta2 }) );
            fixture.Add(new Fecha(5, new List<Partido> { partidoVuelta3, partidoVuelta4 }) );
            fixture.Add(new Fecha(6, new List<Partido> { partidoVuelta5, partidoVuelta6 }) );
        }

        public static void JugarPartido(int nroFecha)
        {
            if (nroFecha > 0)
            {
                foreach (Fecha partidoFecha in fixture)
                {
                    if (partidoFecha.Id == nroFecha)
                    {
                        foreach (Partido partidos in partidoFecha.Partidos)
                        {
                            partidos.SimularPartido();
                        }
                    }
                }
            }
            else
            {
                throw new Exception_FechaNoValida();
            }

        }

    }
}
