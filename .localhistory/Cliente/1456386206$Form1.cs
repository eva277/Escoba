using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace Cliente
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        string dato = "";
        string idJug;
        string[] cartasJug = new string[3];
        string[] cartasMesa = new string[4];
        List<Button> buttonClicked = new List<Button>();
        bool isClicked = false;
        string jugada = "/";

        public Form1()
        {
            InitializeComponent();
        }
        delegate void DelegadoRespuesta();
        private void EscribirFormulario()
        {
            this.MessageTextBox.Text += dato + Environment.NewLine;
        }
        private void printCardsPlayer()
        {
            string g = Directory.GetCurrentDirectory();
            string card1 = cartasJug[0];
            string card2 = cartasJug[1];
            string card3 = cartasJug[2];

            string PathFolderImages = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + card1 + ".jpg";
            string PathFolderImages1 = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + card2 + ".jpg";
            string PathFolderImages2 = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + card3 + ".jpg";

            Player0.BackgroundImage = Image.FromFile(PathFolderImages);
            Player1.BackgroundImage = Image.FromFile(PathFolderImages1);
            Player2.BackgroundImage = Image.FromFile(PathFolderImages2);

        }
        private void printCardsTable()
        {
            string g = Directory.GetCurrentDirectory();
            string card1 = cartasMesa[0];
            string card2 = cartasMesa[1];
            string card3 = cartasMesa[2];
            string card4 = cartasMesa[3];

            string PathFolderImages = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + card1 + ".jpg";
            string PathFolderImages1 = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + card2 + ".jpg";
            string PathFolderImages2 = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + card3 + ".jpg";
            string PathFolderImages3 = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Images\\Baraja\\" + card4 + ".jpg";

            Table0.BackgroundImage = Image.FromFile(PathFolderImages);
            Table1.BackgroundImage = Image.FromFile(PathFolderImages1);
            Table2.BackgroundImage = Image.FromFile(PathFolderImages2);
            Table3.BackgroundImage = Image.FromFile(PathFolderImages3);
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
        private List<string> GetNameCards()
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
            List<string> jugadaPlayer = new List<string>();
            switch (jugada[0])
            {
                case "0":
                    jugadaPlayer.Add(cartasJug[0]);
                    break;
                case "1":
                    jugadaPlayer.Add(cartasJug[1]);
                    break;
                case "2":
                    jugadaPlayer.Add(cartasJug[2]);
                    break;
            }
            for (int i = 1; i < jugada.Length; i++)
            {
                switch (jugada[i])
                {
                    case "0":
                        jugadaPlayer.Add(cartasMesa[0]);
                        break;
                    case "1":
                        jugadaPlayer.Add(cartasMesa[1]);
                        break;
                    case "2":
                        jugadaPlayer.Add(cartasMesa[2]);
                        break;
                    case "3":
                        jugadaPlayer.Add(cartasMesa[3]);
                        break;
                    case "4":
                        jugadaPlayer.Add(cartasMesa[4]);
                        break;
                    case "5":
                        jugadaPlayer.Add(cartasMesa[5]);
                        break;
                    case "6":
                        jugadaPlayer.Add(cartasMesa[6]);
                        break;
                    case "7":
                        jugadaPlayer.Add(cartasMesa[7]);
                        break;
                }
            }
            return jugadaPlayer;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttonClicked)
            {
                MessageTextBox.Text += button.Name + Environment.NewLine;
            }
            MessageTextBox.Text += buttonClicked.Count;
            GetNameCards();
        }

        private void Beginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(this.ServertextBox.Text, 2001);
                ns = client.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
                string id = client.Client.LocalEndPoint.ToString();
                MessageTextBox.Text = id;

                sw.WriteLine("#INSCRIBIR#" + this.PlayertextBox.Text + "#");
                sw.Flush();
                dato += sr.ReadLine() + Environment.NewLine;


                sw.WriteLine("#REPARTECARTAS#");
                sw.Flush();

                string[] str = sr.ReadLine().Split('/');
                cartasJug[0] = str[0];
                cartasJug[1] = str[1];
                cartasJug[2] = str[2];

                str = sr.ReadLine().Split('/');
                cartasMesa[0] = str[0];
                cartasMesa[1] = str[1];
                cartasMesa[2] = str[2];
                cartasMesa[3] = str[3];

                DelegadoRespuesta dr = new DelegadoRespuesta(EscribirFormulario);
                this.Invoke(dr);

                printCardsPlayer();
                printCardsTable();

                PlayerPanel.Visible = true;
                TableroPanel.Visible = true;
                MessagePanel.Visible = true;
                PanelConfiguration.Enabled = false;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.ToString());
            }
        }
        private void Button_Clic_Listener(Object sender, EventArgs e)
        {
            Button MyButton = new Button();
            MyButton = sender as Button;
            if (buttonClicked.Count > 0)
            {
                if (MyButton.Name.StartsWith("Player"))
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
            }
        }
    }
}
