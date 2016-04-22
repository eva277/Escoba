using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Carta
    {
        public string nombre;
        public int valor;
        public string palo;
        public Carta(string carta)
        {
            nombre = carta;
            string[] datos = carta.Split('-');
            valor = getValue(datos[0]);
            palo = datos[1];
        }
        private int getValue(string valor)
        {
            switch (valor)
            {
                case "as":
                    return 1;
                case "dos":
                    return 2;
                case "tres":
                    return 3;
                case "cuatro":
                    return 4;
                case "cinco":
                    return 5;
                case "seis":
                    return 6;
                case "siete":
                    return 7;
                case "sota":
                    return 8;
                case "caballo":
                    return 9;
                case "rey":
                    return 10;
                default:
                    return 0;
            }
        }
        public override string ToString()
        {
            return string.Format(nombre);
        }
    }
}

