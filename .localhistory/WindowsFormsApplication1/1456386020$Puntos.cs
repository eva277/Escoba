using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Puntos
    {
        public int escobas;
        public int cartas;
        public int oros;
        public int sietes;
        public int sieteOros;
        List<Jugada> listaJugadas;

        public Puntos(List<Jugada> listaJugadas)
        {
            escobas = 0;
            cartas = 0;
            oros = 0;
            sietes = 0;
            sieteOros = 0;
            this.listaJugadas = listaJugadas;
        }

        private void GetPoints()
        {
            foreach (Jugada jugadas in listaJugadas)
            {

            }
        }

    }
}
