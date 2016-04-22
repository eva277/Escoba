namespace Cliente
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelConfiguration = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ServertextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Beginbutton = new System.Windows.Forms.Button();
            this.PlayertextBox = new System.Windows.Forms.TextBox();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.Button();
            this.Player0 = new System.Windows.Forms.Button();
            this.Puntos = new System.Windows.Forms.GroupBox();
            this.SieteOrostextBox5 = new System.Windows.Forms.TextBox();
            this.SietestextBox4 = new System.Windows.Forms.TextBox();
            this.OrostextBox3 = new System.Windows.Forms.TextBox();
            this.NumCartastextBox2 = new System.Windows.Forms.TextBox();
            this.EscobastextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TableroPanel = new System.Windows.Forms.Panel();
            this.Table6 = new System.Windows.Forms.Button();
            this.Table7 = new System.Windows.Forms.Button();
            this.Table3 = new System.Windows.Forms.Button();
            this.Table4 = new System.Windows.Forms.Button();
            this.Table5 = new System.Windows.Forms.Button();
            this.Table0 = new System.Windows.Forms.Button();
            this.Table1 = new System.Windows.Forms.Button();
            this.Table2 = new System.Windows.Forms.Button();
            this.CheckCardstimer = new System.Windows.Forms.Timer(this.components);
            this.Turnotimer = new System.Windows.Forms.Timer(this.components);
            this.PanelConfiguration.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.PlayerPanel.SuspendLayout();
            this.Puntos.SuspendLayout();
            this.TableroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelConfiguration
            // 
            this.PanelConfiguration.Controls.Add(this.label9);
            this.PanelConfiguration.Controls.Add(this.ServertextBox);
            this.PanelConfiguration.Controls.Add(this.label10);
            this.PanelConfiguration.Controls.Add(this.Beginbutton);
            this.PanelConfiguration.Controls.Add(this.PlayertextBox);
            this.PanelConfiguration.Location = new System.Drawing.Point(79, 55);
            this.PanelConfiguration.Name = "PanelConfiguration";
            this.PanelConfiguration.Size = new System.Drawing.Size(803, 86);
            this.PanelConfiguration.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Direccion del Servidor";
            // 
            // ServertextBox
            // 
            this.ServertextBox.Location = new System.Drawing.Point(307, 50);
            this.ServertextBox.Name = "ServertextBox";
            this.ServertextBox.Size = new System.Drawing.Size(125, 20);
            this.ServertextBox.TabIndex = 9;
            this.ServertextBox.Text = "127.0.0.1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nombre del Jugador";
            // 
            // Beginbutton
            // 
            this.Beginbutton.Location = new System.Drawing.Point(468, 33);
            this.Beginbutton.Name = "Beginbutton";
            this.Beginbutton.Size = new System.Drawing.Size(100, 23);
            this.Beginbutton.TabIndex = 8;
            this.Beginbutton.Text = "Conectar";
            this.Beginbutton.UseVisualStyleBackColor = true;
            this.Beginbutton.Click += new System.EventHandler(this.Beginbutton_Click);
            // 
            // PlayertextBox
            // 
            this.PlayertextBox.Location = new System.Drawing.Point(307, 17);
            this.PlayertextBox.Name = "PlayertextBox";
            this.PlayertextBox.Size = new System.Drawing.Size(125, 20);
            this.PlayertextBox.TabIndex = 7;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Controls.Add(this.MessageTextBox);
            this.MessagePanel.Controls.Add(this.label1);
            this.MessagePanel.Location = new System.Drawing.Point(702, 147);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(183, 371);
            this.MessagePanel.TabIndex = 16;
            this.MessagePanel.Visible = false;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(6, 30);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.Size = new System.Drawing.Size(174, 338);
            this.MessageTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensajes";
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.Controls.Add(this.label3);
            this.PlayerPanel.Controls.Add(this.label2);
            this.PlayerPanel.Controls.Add(this.EnterButton);
            this.PlayerPanel.Controls.Add(this.Player2);
            this.PlayerPanel.Controls.Add(this.Player1);
            this.PlayerPanel.Controls.Add(this.Player0);
            this.PlayerPanel.Controls.Add(this.Puntos);
            this.PlayerPanel.Location = new System.Drawing.Point(79, 526);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(806, 170);
            this.PlayerPanel.TabIndex = 15;
            this.PlayerPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(641, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hacer Jugada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cartas en Mano";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Transparent;
            this.EnterButton.BackgroundImage = global::Cliente.Properties.Resources.push_button;
            this.EnterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnterButton.Enabled = false;
            this.EnterButton.Location = new System.Drawing.Point(644, 47);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(102, 104);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Player2
            // 
            this.Player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2.Location = new System.Drawing.Point(452, 39);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(80, 120);
            this.Player2.TabIndex = 3;
            this.Player2.UseVisualStyleBackColor = true;
            this.Player2.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Player1
            // 
            this.Player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1.Location = new System.Drawing.Point(343, 39);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(80, 120);
            this.Player1.TabIndex = 2;
            this.Player1.UseVisualStyleBackColor = true;
            this.Player1.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Player0
            // 
            this.Player0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player0.Location = new System.Drawing.Point(227, 39);
            this.Player0.Name = "Player0";
            this.Player0.Size = new System.Drawing.Size(80, 120);
            this.Player0.TabIndex = 1;
            this.Player0.UseVisualStyleBackColor = true;
            this.Player0.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Puntos
            // 
            this.Puntos.Controls.Add(this.SieteOrostextBox5);
            this.Puntos.Controls.Add(this.SietestextBox4);
            this.Puntos.Controls.Add(this.OrostextBox3);
            this.Puntos.Controls.Add(this.NumCartastextBox2);
            this.Puntos.Controls.Add(this.EscobastextBox);
            this.Puntos.Controls.Add(this.label8);
            this.Puntos.Controls.Add(this.label7);
            this.Puntos.Controls.Add(this.label6);
            this.Puntos.Controls.Add(this.label5);
            this.Puntos.Controls.Add(this.label4);
            this.Puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos.Location = new System.Drawing.Point(3, 3);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(197, 164);
            this.Puntos.TabIndex = 0;
            this.Puntos.TabStop = false;
            this.Puntos.Text = "Puntos";
            // 
            // SieteOrostextBox5
            // 
            this.SieteOrostextBox5.Enabled = false;
            this.SieteOrostextBox5.Location = new System.Drawing.Point(143, 127);
            this.SieteOrostextBox5.Name = "SieteOrostextBox5";
            this.SieteOrostextBox5.ReadOnly = true;
            this.SieteOrostextBox5.Size = new System.Drawing.Size(48, 21);
            this.SieteOrostextBox5.TabIndex = 19;
            // 
            // SietestextBox4
            // 
            this.SietestextBox4.Enabled = false;
            this.SietestextBox4.Location = new System.Drawing.Point(143, 101);
            this.SietestextBox4.Name = "SietestextBox4";
            this.SietestextBox4.ReadOnly = true;
            this.SietestextBox4.Size = new System.Drawing.Size(48, 21);
            this.SietestextBox4.TabIndex = 18;
            // 
            // OrostextBox3
            // 
            this.OrostextBox3.Enabled = false;
            this.OrostextBox3.Location = new System.Drawing.Point(143, 75);
            this.OrostextBox3.Name = "OrostextBox3";
            this.OrostextBox3.ReadOnly = true;
            this.OrostextBox3.Size = new System.Drawing.Size(48, 21);
            this.OrostextBox3.TabIndex = 17;
            // 
            // NumCartastextBox2
            // 
            this.NumCartastextBox2.Enabled = false;
            this.NumCartastextBox2.Location = new System.Drawing.Point(143, 49);
            this.NumCartastextBox2.Name = "NumCartastextBox2";
            this.NumCartastextBox2.ReadOnly = true;
            this.NumCartastextBox2.Size = new System.Drawing.Size(48, 21);
            this.NumCartastextBox2.TabIndex = 16;
            // 
            // EscobastextBox
            // 
            this.EscobastextBox.Enabled = false;
            this.EscobastextBox.Location = new System.Drawing.Point(143, 23);
            this.EscobastextBox.Name = "EscobastextBox";
            this.EscobastextBox.ReadOnly = true;
            this.EscobastextBox.Size = new System.Drawing.Size(48, 21);
            this.EscobastextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Siete de oros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sietes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Oros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cartas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Escobas";
            // 
            // TableroPanel
            // 
            this.TableroPanel.BackgroundImage = global::Cliente.Properties.Resources.background;
            this.TableroPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TableroPanel.Controls.Add(this.Table6);
            this.TableroPanel.Controls.Add(this.Table7);
            this.TableroPanel.Controls.Add(this.Table3);
            this.TableroPanel.Controls.Add(this.Table4);
            this.TableroPanel.Controls.Add(this.Table5);
            this.TableroPanel.Controls.Add(this.Table0);
            this.TableroPanel.Controls.Add(this.Table1);
            this.TableroPanel.Controls.Add(this.Table2);
            this.TableroPanel.Location = new System.Drawing.Point(79, 147);
            this.TableroPanel.Name = "TableroPanel";
            this.TableroPanel.Size = new System.Drawing.Size(617, 371);
            this.TableroPanel.TabIndex = 14;
            this.TableroPanel.Visible = false;
            // 
            // Table6
            // 
            this.Table6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table6.Location = new System.Drawing.Point(314, 193);
            this.Table6.Name = "Table6";
            this.Table6.Size = new System.Drawing.Size(80, 120);
            this.Table6.TabIndex = 12;
            this.Table6.UseVisualStyleBackColor = true;
            this.Table6.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Table7
            // 
            this.Table7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table7.Location = new System.Drawing.Point(452, 193);
            this.Table7.Name = "Table7";
            this.Table7.Size = new System.Drawing.Size(80, 120);
            this.Table7.TabIndex = 11;
            this.Table7.UseVisualStyleBackColor = true;
            this.Table7.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Table3
            // 
            this.Table3.BackColor = System.Drawing.Color.Transparent;
            this.Table3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table3.Location = new System.Drawing.Point(452, 30);
            this.Table3.Name = "Table3";
            this.Table3.Size = new System.Drawing.Size(80, 120);
            this.Table3.TabIndex = 10;
            this.Table3.UseVisualStyleBackColor = false;
            this.Table3.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Table4
            // 
            this.Table4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table4.Location = new System.Drawing.Point(38, 193);
            this.Table4.Name = "Table4";
            this.Table4.Size = new System.Drawing.Size(80, 120);
            this.Table4.TabIndex = 9;
            this.Table4.UseVisualStyleBackColor = true;
            this.Table4.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Table5
            // 
            this.Table5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table5.Location = new System.Drawing.Point(176, 193);
            this.Table5.Name = "Table5";
            this.Table5.Size = new System.Drawing.Size(80, 120);
            this.Table5.TabIndex = 8;
            this.Table5.UseVisualStyleBackColor = true;
            this.Table5.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Table0
            // 
            this.Table0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table0.Location = new System.Drawing.Point(38, 30);
            this.Table0.Name = "Table0";
            this.Table0.Size = new System.Drawing.Size(80, 120);
            this.Table0.TabIndex = 7;
            this.Table0.UseVisualStyleBackColor = true;
            this.Table0.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Table1
            // 
            this.Table1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table1.Location = new System.Drawing.Point(176, 30);
            this.Table1.Name = "Table1";
            this.Table1.Size = new System.Drawing.Size(80, 120);
            this.Table1.TabIndex = 6;
            this.Table1.UseVisualStyleBackColor = true;
            this.Table1.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // Table2
            // 
            this.Table2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table2.Location = new System.Drawing.Point(314, 30);
            this.Table2.Name = "Table2";
            this.Table2.Size = new System.Drawing.Size(80, 120);
            this.Table2.TabIndex = 5;
            this.Table2.UseVisualStyleBackColor = true;
            this.Table2.Click += new System.EventHandler(this.Button_Clic_Listener);
            // 
            // CheckCardstimer
            // 
            this.CheckCardstimer.Interval = 10000;
            this.CheckCardstimer.Tick += new System.EventHandler(this.CheckCardstimer_Tick);
            // 
            // Turnotimer
            // 
            this.Turnotimer.Interval = 15000;
            this.Turnotimer.Tick += new System.EventHandler(this.Turnotimer_Tick);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 751);
            this.Controls.Add(this.PanelConfiguration);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.TableroPanel);
            this.Name = "Cliente";
            this.Text = "Form1";
            this.PanelConfiguration.ResumeLayout(false);
            this.PanelConfiguration.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            this.Puntos.ResumeLayout(false);
            this.Puntos.PerformLayout();
            this.TableroPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelConfiguration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ServertextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Beginbutton;
        private System.Windows.Forms.TextBox PlayertextBox;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button Player2;
        private System.Windows.Forms.Button Player1;
        private System.Windows.Forms.Button Player0;
        private System.Windows.Forms.GroupBox Puntos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel TableroPanel;
        private System.Windows.Forms.Button Table6;
        private System.Windows.Forms.Button Table7;
        private System.Windows.Forms.Button Table3;
        private System.Windows.Forms.Button Table4;
        private System.Windows.Forms.Button Table5;
        private System.Windows.Forms.Button Table0;
        private System.Windows.Forms.Button Table1;
        private System.Windows.Forms.Button Table2;
        private System.Windows.Forms.TextBox SieteOrostextBox5;
        private System.Windows.Forms.TextBox SietestextBox4;
        private System.Windows.Forms.TextBox OrostextBox3;
        private System.Windows.Forms.TextBox NumCartastextBox2;
        private System.Windows.Forms.TextBox EscobastextBox;
        private System.Windows.Forms.Timer CheckCardstimer;
        private System.Windows.Forms.Timer Turnotimer;
    }
}

