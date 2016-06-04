namespace WindowsFormsApplication1
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.ListenButton = new System.Windows.Forms.Button();
            this.autoPlaycheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ListenButton
            // 
            this.ListenButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ListenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.ListenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.ListenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListenButton.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenButton.Location = new System.Drawing.Point(72, 282);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(162, 43);
            this.ListenButton.TabIndex = 5;
            this.ListenButton.Text = "Conectar Servidor";
            this.ListenButton.UseVisualStyleBackColor = false;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // autoPlaycheckBox
            // 
            this.autoPlaycheckBox.AutoSize = true;
            this.autoPlaycheckBox.Checked = true;
            this.autoPlaycheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoPlaycheckBox.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoPlaycheckBox.Location = new System.Drawing.Point(72, 257);
            this.autoPlaycheckBox.Name = "autoPlaycheckBox";
            this.autoPlaycheckBox.Size = new System.Drawing.Size(162, 19);
            this.autoPlaycheckBox.TabIndex = 6;
            this.autoPlaycheckBox.Text = "Jugar contra la Maquina";
            this.autoPlaycheckBox.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.main_escoba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 337);
            this.Controls.Add(this.autoPlaycheckBox);
            this.Controls.Add(this.ListenButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 376);
            this.MinimumSize = new System.Drawing.Size(316, 376);
            this.Name = "Server";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escoba - Servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.CheckBox autoPlaycheckBox;
    }
}

