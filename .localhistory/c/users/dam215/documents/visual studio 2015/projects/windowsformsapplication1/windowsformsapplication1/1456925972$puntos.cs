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
        public int puntosTotal;
        List<Carta> listaCartas;

        public Puntos(Jugada jugada)
        {
            listaCartas = jugada.listaBaza;
            escobas = 0;
            cartas = listaCartas.Count;
            oros = 0;
            sietes = 0;
            sieteOros = 0;
        }
        public Puntos()
        {
            escobas = 0;
            cartas = listaCartas.Count;
            oros = 0;
            sietes = 0;
            sieteOros = 0;
            puntosTotal = 0;
        }
        public int GetNumCartas()
        {
            return cartas;
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
            return oros;
        }
        public int GetSieteOros()
        {
            foreach (Carta carta in listaCartas)
            {
                if (carta.nombre.Equals("siete-oros"))
                {
                    sieteOros = 1; ;
                }
            }
            return sieteOros;
        }
    }
}
