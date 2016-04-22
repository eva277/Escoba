﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Collections;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Server : Form
    {
        public Server()
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
        string[] mesaActualizada = new string[8];

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


        List<Carta> listaCartasMesa = new List<Carta>();
        string[] cartasMesa = new string[4];

        string jugador1 = "";
        string idJug1 = "";
        List<Carta> ListaManoJugador1 = new List<Carta>();
        //string[] cartasJugador1 = new string[3];
        string IpJug1 = "";
        string PortJug1 = "";


        string jugador2 = "";
        string idJug2 = "";
        List<Carta> ListaManoJugador2 = new List<Carta>();
        string[] cartasJugador2 = new string[3];
        string[] jugada2 = new string[2];
        string IpJug2 = "";
        string PortJug2 = "";

        int puntos1 = 0;
        int puntos2 = 0;

        int numJugada = 1;

        int cont;
        string turno;

        private void ManejarCliente(TcpClient cli)
        {
            string data;
            NetworkStream ns = cli.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            //sw.WriteLine("#INSCRIBIR#nombre#");
            //sw.WriteLine("#REPARTECARTAS#{cartasJugador1/cartasJugador2}#cartasMesa#");
            //sw.WriteLine("#TURNO#turnoJugador#idturnoJugador#");
            //sw.WriteLine("#JUGADA#cartamanoJug2#numCartasMesa#cartasMesa(cartaMesa1/cartamesa2...)#");
            //sw.WriteLine("#ACTUALIZAMESA#cartasMesa#");
            //sw.WriteLine("#PUNTUACION#");
            sw.Flush();
            while (true)
            {
                try
                {
                    data = sr.ReadLine();
                    //Console.WriteLine(data); //para depuración es server
                    String[] subdatos = data.Split('#');
                    #region comINSCRIBIR
                    if (subdatos[1] == "INSCRIBIR")
                    {
                        repartecartasMesa();

                        if (jugador1 == "")
                        {
                            jugador1 = subdatos[2];
                            idJug1 = cli.Client.RemoteEndPoint.ToString();
                            turno = idJug1;
                            IpJug1 = idJug1.Split(':')[0];
                            sw.WriteLine("Bienvenido jugador: " + jugador1);
                            sw.WriteLine(ListarCartasMesa());
                            sw.Flush();
                        }
                        else if (jugador2 == "")
                        {
                            jugador2 = subdatos[2];
                            idJug2 = cli.Client.RemoteEndPoint.ToString();
                            IpJug2 = idJug2.Split(':')[0];
                            sw.WriteLine("Bienvenido jugador: " + jugador2);
                            sw.WriteLine(ListarCartasMesa());
                            sw.Flush();
                        }
                        else
                        {
                            sw.WriteLine("Ya hay dos jugadores");
                            sw.Flush();
                        }
                    }
                    #endregion
                    #region comREPARTIRCARTAS
                    if (subdatos[1] == "REPARTECARTAS")
                    {
                        repartecartasJug();
                        if (idJug1 == cli.Client.RemoteEndPoint.ToString())
                        {
                            sw.WriteLine(ListarCartasJugador1());
                            sw.Flush();
                        }
                        if (idJug2 == cli.Client.RemoteEndPoint.ToString())
                        {
                            sw.WriteLine(ListarCartasJugador2());
                            sw.Flush();
                        }
                    }
                    #endregion
                    #region comESTABLECETURNO
                    if (subdatos[1] == "TURNO")
                    {
                        if (turno.Equals(idJug1))
                        {
                            sw.WriteLine("El turno es de " + jugador1 + "#" + idJug1);
                            sw.Flush();
                        }
                        else if (turno.Equals(idJug2))
                        {
                            sw.WriteLine("El turno es de " + jugador2 + "#" + idJug2);
                            sw.Flush();
                        }
                    }
                    #endregion
                    #region comJugada
                    if (subdatos[1] == "JUGADA")
                    {
                        if (idJug1 == cli.Client.RemoteEndPoint.ToString())
                        {
                            if (subdatos[2] == "0")
                            {
                                mesaActualizada = subdatos[3].Split('/');
                                turno = idJug2;
                            }
                            else
                            {
                                Jugada jugada = HacerJugada(data);
                                if (jugada.checkBaza())
                                {
                                    sw.WriteLine("El jugador " + jugador1 + " ha hecho baza");
                                    // sw.Flush();
                                    Puntos puntos = new Puntos(jugada);
                                    sw.WriteLine(
                                        puntos.GetNumCartas() + "#"
                                        + puntos.GetNumOros() + "#"
                                        + puntos.GetNumSietes() + "#"
                                        + puntos.GetSieteOros());
                                    sw.Flush();
                                    turno = idJug2;
                                }
                                else
                                {
                                    sw.WriteLine("No se puede hacer baza. Intentalo de nuevo");
                                    sw.Flush();
                                }
                            }

                        }
                        else if (idJug2 == cli.Client.RemoteEndPoint.ToString())
                        {
                            if (subdatos[2] == "0")
                            {
                                mesaActualizada = subdatos[3].Split('/');
                                turno = idJug1;

                            }
                            else
                            {
                                Jugada jugada = HacerJugada(data);
                                if (jugada.checkBaza())
                                {
                                    sw.WriteLine("El jugador " + jugador2 + " ha hecho baza");
                                    Puntos puntos = new Puntos(jugada);
                                    sw.WriteLine(
                                        puntos.GetNumCartas() + "#"
                                        + puntos.GetNumOros() + "#"
                                        + puntos.GetNumSietes() + "#"
                                        + puntos.GetSieteOros());
                                    turno = idJug1;

                                }
                                else
                                {
                                    sw.WriteLine("No se puede hacer baza. Intentalo de nuevo");
                                    sw.Flush();
                                }
                            }
                        }
                    }
                    #endregion
                    #region comUpdateTable
                    if (subdatos[1] == "UPDATETABLE")
                    {
                        mesaActualizada = subdatos[2].Split('/');

                    }
                    #endregion
                    #region comACTUALIZARMESA
                    if (subdatos[1] == "ACTUALIZAMESA")
                    {
                        string mesa = "";
                        for (int i = 0; i < mesaActualizada.Length; i++)
                        {
                            if (!String.IsNullOrWhiteSpace(mesaActualizada[i]))
                            {
                                mesa += mesaActualizada[i] + "/";
                            }
                        }
                        sw.WriteLine(mesa);
                        sw.Flush();
                    }
                    #endregion
                    #region comCheckCardsPlayer2
                    if (subdatos[1] == "CHECKCARDS")
                    {
                        if (idJug2 == cli.Client.RemoteEndPoint.ToString())
                        {
                            if (subdatos[2] == "0")
                            {
                                sw.WriteLine("#OK#Jugadores sin carta#");
                                sw.Flush();
                                repartecartasJug();
                                if (idJug1 == cli.Client.RemoteEndPoint.ToString())
                                {
                                    sw.WriteLine(ListarCartasJugador1());
                                    sw.Flush();
                                }
                                if (idJug2 == cli.Client.RemoteEndPoint.ToString())
                                {
                                    sw.WriteLine(ListarCartasJugador2());
                                    sw.Flush();
                                }
                            }
                        }
                        else
                        {
                            sw.WriteLine("#OK#Jugadores con carta#");
                            sw.Flush();
                        }

                    }
                    #endregion
                }
                catch (Exception error)
                {
                    Console.WriteLine("Error: {0}", error.ToString());
                    break;
                }
            }
            ns.Close();
            cli.Close();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            Shuffle(mazo);
            listaCartasMazo = CargaMazo(mazo);
            //thread de recepción continua de clientes
            Thread t = new Thread(this.EsperaClientes);
            t.Start();
            this.ListenButton.Enabled = false;
        }
        private void EsperaClientes()
        {
            TcpListener newsock = new TcpListener(IPAddress.Any, 2000);
            newsock.Start();

            Console.WriteLine("Esperando por cliente");

            while (true)
            {
                TcpClient cliente = newsock.AcceptTcpClient(); //linea bloqueante
                Thread t = new Thread(() => this.ManejarCliente(cliente));
                //t.IsBackground = true;
                t.Start();
            }
        }

        private void repartecartasJug()
        {
            int i;
            for (i = cont; i < cont + 6; i++)
            {
                if (i % 2 != 0)
                {
                    ListaManoJugador2.Add(listaCartasMazo[i]);
                }
                else
                {
                    ListaManoJugador1.Add(listaCartasMazo[i]);
                }
            }
            cont = i;
        }
        private void repartecartasMesa()
        {
            int i;
            for (i = cont; i < cont + 4; i++)
            {
                listaCartasMesa.Add(listaCartasMazo[i]);
            }
            cont = i;
        }
        private string ListarCartasJugador1()
        {
            string datos = "";
            foreach (Carta cartas in ListaManoJugador1)
            {
                datos += cartas.nombre + "/";
            }
            return datos;
        }
        private string ListarCartasJugador2()
        {
            string datos = "";

            foreach (Carta cartas in ListaManoJugador2)
            {
                datos += cartas.nombre + "/";
            }
            return datos;
        }
        private string ListarCartasMesa()
        {
            string datos = "";

            foreach (Carta cartas in listaCartasMesa)
            {
                datos += cartas.nombre + "/";
            }
            return datos;
        }
        private Jugada HacerJugada(string datos)
        {
            String[] subdatos = datos.Split('#');

            Carta cartPlayer = new Carta(subdatos[2]);
            int numCardsMesa = Convert.ToInt16(subdatos[3]);
            string[] str = new string[numCardsMesa];
            str = subdatos[4].Split('/');
            List<Carta> bazaMesa = new List<Carta>();
            for (int i = 0; i < numCardsMesa; i++)
            {
                Carta carta = new Carta(str[i]);
                bazaMesa.Add(carta);
            }
            Jugada jugada = new Jugada(cartPlayer, bazaMesa);

            return jugada;
        }
    }
}

