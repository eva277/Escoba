using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Puntos
    {
        public int escobas = 0;
        public int cartas=0;
        public int oros = 0;
        public int sietes = 0;
        public int sieteOros = 0;
        public int puntosTotal = 0;
        List<Carta> listaCartas = new List<Carta>();

        public Puntos(Jugada jugada)
        {
            listaCartas = jugada.listaBaza;
            cartas = listaCartas.Count;

        }

        public Puntos()
        {

        }

        public void addBaza(List<Carta> trick)
        {
            foreach (Carta card in trick)
            {
                listaCartas.Add(card);
            }
        }

        public int GetNumCartas()
        {
            if (cartas!=0)
            {
                return cartas;
            }
            else
            {
                return listaCartas.Count;
            }
        }

        public int GetNumOros()
        {
            foreach (Carta carta in listaCartas)
            {
                if (carta.palo.Equals("oros"))
                {
                    oros++;
                }
            }
            return oros;
        }

        public int GetNumSietes()
        {
            foreach (Carta carta in listaCartas)
            {
                if (carta.valor == 7)
                {
                    sietes++;
                }
            }
            return sietes;
        }

        public int GetSieteOros()
        {
            foreach (Carta carta in listaCartas)
            {
                if (carta.nombre.Equals("siete-oros"))
                {
                    sieteOros = 1;
                }
            }
            return sieteOros;
        }
    }
}
