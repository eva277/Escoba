using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] mazo = { "as-espadas", "dos-espadas", "tres-espadas", "cuatro-espadas", "cinco-espadas","seis-espadas","siete-espadas","sota-espadas","caballo-espadas","rey-espadas",
            "as-bastos", "dos-bastos", "tres-bastos", "cuatro-bastos", "cinco-bastos","seis-bastos","siete-bastos","sota-bastos","caballo-bastos","rey-bastos",
            "as-copas", "dos-copas", "tres-copas", "cuatro-copas", "cinco-copas","seis-copas","siete-copas","sota-copas","caballo-copas","rey-copas",
            "as-oros", "dos-oros", "tres-oros", "cuatro-oros", "cinco-oros","seis-oros","siete-oros","sota-oros","caballo-oros","rey-oros",};
        public List<Carta> listaCartasMazo;
        static Random _random = new Random();
        Carta carta;
        static List<Carta> CargaMazo(string[] mazo)
        {
            List<Carta> listaMazo = new List<Carta>();
            for (int i = 0; i < mazo.Length; i++)
            {
                Carta carta = new Carta(mazo[i]);
                listaMazo.Add(carta);
            }
            return listaMazo;
        }
        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }


        private void ListenButton_Click(object sender, EventArgs e)
        {

        }
    }
}
