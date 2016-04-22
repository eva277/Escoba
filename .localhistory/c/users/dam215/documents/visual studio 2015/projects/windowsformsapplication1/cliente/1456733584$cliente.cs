using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace Cliente
{
    public partial class Cliente : Form
    {
        TcpClient client;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        string dato = "";
        int escobas = 0;
        int numCartas = 0;
        int sieteOros = 0;
        int sietes = 0;
        int oros = 0;

        int cont = 0;
        string turno = "";
        string idJugador;

        string[] turnoId;

        string[] cartasJug = new string[3];
        string[] cartasMesa = new string[8];
        List<Button> listButton = new List<Button>();
        List<Button> buttonClicked = new List<Button>();
        bool isClicked = false;
        string jugada = "/";
        string g = Directory.GetCurrentDirectory();

        public Cliente()
        {
            InitializeComponent();
            listButton.Add(Player0);
            listButton.Add(Player1);
            listButton.Add(Player2);
            listButton.Add(Table0);
            listButton.Add(Table1);
            listButton.Add(Table2);
            listButton.Add(Table3);
            listButton.Add(Table4);
            listButton.Add(Table5);
            listButton.Add(Table6);
            listButton.Add(Table7);
        }
        delegate void DelegadoRespuesta();
        private void EscribirFormulario()
        {
            this.MessageTextBox.Text += dato + Environment.NewLine;
        }
        private void Beginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(this.ServertextBox.Text, 2000);
                ns = client.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
                idJugador = client.Client.LocalEndPoint.ToString();

                sw.WriteLine("#INSCRIBIR#" + this.PlayertextBox.Text + "#");
                sw.Flush();
                dato += sr.ReadLine();

                DelegadoRespuesta dr = new DelegadoRespuesta(EscribirFormulario);
                this.Invoke(dr);

                string[]  str = sr.ReadLine().Split('/');
                cartasMesa[0] = str[0];
                cartasMesa[1] = str[1];
                cartasMesa[2] = str[2];
                cartasMesa[3] = str[3];
                for (int i = 0; i < cartasMesa.Length; i++)
                {
                    printCardTable(i);
                }

                sw.WriteLine("#REPARTECARTAS#");
                sw.Flush();

                str = sr.ReadLine().Split('/');
                cartasJug[0] = str[0];
                cartasJug[1] = str[1];
                cartasJug[2] = str[2];
                for (int i = 0; i < cartasJug.Length; i++)
                {
                    printCardPlayer(i);
                }

                CheckCardstimer.Enabled = true;

                PlayerPanel.Visible = true;
                TableroPanel.Visible = true;
                MessagePanel.Visible = true;
                PanelConfiguration.Enabled = false;

                Turnotimer.Enabled = true;
                sw.WriteLine("#TURNO#");
                sw.Flush();
                turnoId = sr.ReadLine().Split('#');
                if (turnoId[1].Equals(idJugador))
                {
                    EnterButton.Enabled = true;
                }
                turno= turnoId[1];
                MessageTextBox.Text += turno + Environment.NewLine;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.ToString());
            }
        }
        private void printCardPlayer(int IndexCarta)
        {
            string PathFolderImages = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + cartasJug[IndexCarta] + ".jpg";
            Button b = listButton.Find(f => f.Name.Contains("Player") && f.Name.Contains(IndexCarta.ToString()));
            b.BackgroundImage = Image.FromFile(PathFolderImages);
        }
        private void printCardTable(int IndexCarta)
        {
            Button b = listButton.Find(f => f.Name.Contains("Table") && f.Name.Contains(IndexCarta.ToString()));

            if (!String.IsNullOrEmpty(cartasMesa[IndexCarta]))
            {
                string PathFolderImages = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + cartasMesa[IndexCarta] + ".jpg";
                b.BackgroundImage = Image.FromFile(PathFolderImages);
            }
            else
            {
                b.BackgroundImage = null;
            }

        }
        private void Button_Clic_Listener(Object sender, EventArgs e)
        {
            Button MyButton = new Button();
            MyButton = sender as Button;
            if (buttonClicked.Count > 0 )
            {
                if (MyButton.Name.StartsWith("Player"))
                {
                        if (buttonClicked.Contains(MyButton))
                        {
                            buttonClicked.Remove(MyButton);
                            isClicked = false;
                            ClickedButton(MyButton);
                            cont = 0;
                        }
                        else if(cont==0)
                        {
                            buttonClicked.Add(MyButton);
                            isClicked = true;
                            ClickedButton(MyButton);
                            cont = 1;
                        }
                }
                else
                {
                    if (buttonClicked.Contains(MyButton))
                    {
                        buttonClicked.Remove(MyButton);
                        isClicked = false;
                        ClickedButton(MyButton);
                    }
                    else
                    {
                        buttonClicked.Add(MyButton);
                        isClicked = true;
                        ClickedButton(MyButton);
                    }
                }
            }
            else
            {
                buttonClicked.Add(MyButton);
                isClicked = true;
                ClickedButton(MyButton);
                if (MyButton.Name.StartsWith("Player"))
                {
                    cont = 1;
                }
            }
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (turno.Equals(idJugador))
            {
                Button b = buttonClicked.Find(h => h.Name.StartsWith("Player"));

                if (buttonClicked.Count == 1 && buttonClicked.Contains(b))
                {
                    //Colocar carta jugador en la mesa
                    string mesaActualizada = "";

                    for (int i = 0; i < cartasMesa.Length; i++)
                    {
                        if (String.IsNullOrEmpty(cartasMesa[i]))
                        {
                            cartasMesa[i] = GetNameCardPlayer(b.Name.Substring(6));
                            printCardTable(i);
                            b.Visible = false;
                            break;
                        }
                    }
                    for (int x = 0; x < cartasMesa.Length; x++)
                    {
                        if (!String.IsNullOrEmpty(cartasMesa[x]))
                        {
                            mesaActualizada += cartasMesa[x] + "/";
                        }
                    }
                    sw.WriteLine("#JUGADA#0#" + mesaActualizada);
                    sw.Flush();
                    EnterButton.Enabled = false;
                }
                else
                {
                    sw.WriteLine(GetJugada());
                    sw.Flush();
                    string d = sr.ReadLine();
                    if (d.Equals("No se puede hacer baza. Intentalo de nuevo"))
                    {
                        MessageBox.Show(d, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        foreach (Button button in buttonClicked)
                        {
                            button.FlatAppearance.BorderSize = 1;
                            button.FlatStyle = FlatStyle.Standard;
                        }
                    }
                    else
                    {
                        foreach (Button button in buttonClicked)
                        {
                            button.BackgroundImage = null;

                        }
                        string[] points = sr.ReadLine().Split('#');

                        numCartas += Convert.ToInt16(points[0]);
                        oros += Convert.ToInt16(points[1]);
                        sietes += Convert.ToInt16(points[2]);
                        sieteOros += Convert.ToInt16(points[3]);

                        NumCartastextBox2.Text = numCartas.ToString();
                        OrostextBox3.Text = oros.ToString();
                        SietestextBox4.Text = sietes.ToString();
                        SieteOrostextBox5.Text = sieteOros.ToString();

                        MessageTextBox.Text += d + Environment.NewLine;
                        EnterButton.Enabled = false;
                        string mesaActualizada = "";
                        RemoveCardsTable();

                        for (int i = 0; i < cartasMesa.Length; i++)
                        {
                            if (!String.IsNullOrEmpty(cartasMesa[i]))
                            {
                                mesaActualizada += cartasMesa[i] + "/";
                            }
                        }
                        sw.WriteLine("#UPDATETABLE#" + mesaActualizada);
                        sw.Flush();
                    }
                }
                MessageTextBox.Text += GetNumCardsTable() + Environment.NewLine;
                buttonClicked.Clear();
            }
        }
        private void ClickedButton(Button button)
        {
            if (!isClicked)
            {
                button.FlatAppearance.BorderSize = 1;
                button.FlatStyle = FlatStyle.Standard;

            }
            else
            {
                button.FlatAppearance.BorderColor = Color.Red;
                button.FlatAppearance.BorderSize = 5;
                button.FlatStyle = FlatStyle.Flat;
            }
        }
        private string GetJugada()
        {
            int numCartas = buttonClicked.Count;
            string[] jugada = new string[numCartas];

            Button b = buttonClicked.Find(h => h.Name.StartsWith("Player"));
            jugada[0] = b.Name.Substring(6);

            buttonClicked.Remove(b);
            int a = 1;
            foreach (Button button in buttonClicked)
            {
                jugada[a] = button.Name.Substring(5);
                a++;
            }
            string PlayerTrick = "#JUGADA#" + GetNameCardPlayer(jugada[0]) + "#" + (numCartas - 1).ToString() + "#" + GetNameCardsTable(jugada) + "#";
            buttonClicked.Insert(buttonClicked.Count, b);
            return PlayerTrick;
        }
        private string GetNameCardPlayer(string ButtonName)
        {
            string card = "";
            switch (ButtonName)
            {
                case "0":
                    card = cartasJug[0];
                    break;
                case "1":
                    card = cartasJug[1];
                    break;
                case "2":
                    card = cartasJug[2];
                    break;
            }
            return card;
        }
        private string GetNameCardsTable(string[] jugada)
        {
            string card = "";
            for (int i = 1; i < jugada.Length; i++)
            {
                switch (jugada[i])
                {
                    case "0":
                        card += cartasMesa[0] + "/";
                        break;
                    case "1":
                        card += cartasMesa[1] + "/";
                        break;
                    case "2":
                        card += (cartasMesa[2]) + "/";
                        break;
                    case "3":
                        card += (cartasMesa[3]) + "/";
                        break;
                    case "4":
                        card += (cartasMesa[4]) + "/";
                        break;
                    case "5":
                        card += (cartasMesa[5]) + "/";
                        break;
                    case "6":
                        card += (cartasMesa[6]) + "/";
                        break;
                    case "7":
                        card += (cartasMesa[7]) + "/";
                        break;
                }
            }
            return card;
        }
        private int GetNumCardsTable()
        {
            int sum = 0;
            for (int i = 0; i < cartasMesa.Length; i++)
            {
                if (cartasMesa[i]!=null)
                {
                    sum++;   
                }
            }
            return sum;
        }

        private void RemoveCardsTable()
        {
            string[] jugada = GetJugada().Split('#');
            int numCardsMesa = Convert.ToInt16(jugada[3]);
            string[] str = new string[numCardsMesa];
            str = jugada[4].Split('/');

            for (int i = 0; i < str.Length - 1; i++)
            {
                bazaMesa.Add(str[i]);
            }
            for (int i = 0; i < cartasMesa.Length; i++)
            {
                if (bazaMesa.Contains(cartasMesa[i]))
                {
                    cartasMesa[i] = null;
                }
            }
        }

        List<string> bazaMesa = new List<string>();

        private void Turnotimer_Tick(object sender, EventArgs e)
        {
            try
            {
                sw.WriteLine("#TURNO#");
                sw.Flush();
                cartasMesa = new string[8];
                string[] turnoId = sr.ReadLine().Split('#');
                if (turnoId[1].Equals(idJugador))
                {
                    EnterButton.Enabled = true;
                    sw.WriteLine("#ACTUALIZAMESA#");
                    sw.Flush();
                    cartasMesa = sr.ReadLine().Split('/');

                    foreach (Button but in listButton)
                    {
                        if (but.Name.Contains("Table"))
                        {
                            but.BackgroundImage = null;
                        }
                    }
                    for (int i = 0; i < cartasMesa.Length - 1; i++)
                    {
                        printCardTable(i);

                    }
                }
                turno = turnoId[1];
                MessageTextBox.Text += turnoId[0] + Environment.NewLine;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (BackgroundImage != null) e.Graphics.DrawImage(BackgroundImage, 0, 0);
        }

        private void CheckCardstimer_Tick(object sender, EventArgs e)
        {
            foreach (Button button in listButton)
            {
                if (button.Name.StartsWith("Player") && button.BackgroundImage == null)
                {
                    sum--;
                }
            }
            sw.WriteLine("#CHECKCARDS#" + sum.ToString());
            sw.Flush();
            if (!sr.ReadLine().Equals("NOK"))
            {
                string[] str = sr.ReadLine().Split('/');
                cartasJug[0] = str[0];
                cartasJug[1] = str[1];
                cartasJug[2] = str[2];
                for (int i = 0; i < cartasJug.Length; i++)
                {
                    printCardPlayer(i);
                }
            }

        }
        int sum = 3;

    }
}
