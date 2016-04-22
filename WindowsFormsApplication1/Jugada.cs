using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Jugada
    {
        public List<Carta> listaBaza = new List<Carta>();

        int suma = 0;

        public Jugada(Carta cartaJugador, List<Carta> cartasMesa)
        {
            listaBaza.Add(cartaJugador);
            foreach (Carta cartas in cartasMesa)
            {
                listaBaza.Add(cartas);
            }
        }
        public bool checkBaza()
        {
            foreach (Carta cartas in listaBaza)
            {
                suma += cartas.valor;
            }
            if (suma == 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
