namespace Pizzeria
{
    partial class BestelStandaardPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStandaardPizzas = new System.Windows.Forms.ListBox();
            this.lblStandaardPizzas = new System.Windows.Forms.Label();
            this.btnBestel = new System.Windows.Forms.Button();
            this.btnBestelOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStandaardPizzas
            // 
            this.lbStandaardPizzas.FormattingEnabled = true;
            this.lbStandaardPizzas.Location = new System.Drawing.Point(12, 25);
            this.lbStandaardPizzas.Name = "lbStandaardPizzas";
            this.lbStandaardPizzas.Size = new System.Drawing.Size(270, 199);
            this.lbStandaardPizzas.TabIndex = 0;
            // 
            // lblStandaardPizzas
            // 
            this.lblStandaardPizzas.AutoSize = true;
            this.lblStandaardPizzas.Location = new System.Drawing.Point(12, 9);
            this.lblStandaardPizzas.Name = "lblStandaardPizzas";
            this.lblStandaardPizzas.Size = new System.Drawing.Size(90, 13);
            this.lblStandaardPizzas.TabIndex = 1;
            this.lblStandaardPizzas.Text = "Standaard pizza\'s";
            // 
            // btnBestel
            // 
            this.btnBestel.Location = new System.Drawing.Point(156, 230);
            this.btnBestel.Name = "btnBestel";
            this.btnBestel.Size = new System.Drawing.Size(126, 49);
            this.btnBestel.TabIndex = 2;
            this.btnBestel.Text = "Voeg toe aan bestelling";
            this.btnBestel.UseVisualStyleBackColor = true;
            this.btnBestel.Click += new System.EventHandler(this.btnBestel_Click);
            // 
            // btnBestelOverzicht
            // 
            this.btnBestelOverzicht.Location = new System.Drawing.Point(343, 230);
            this.btnBestelOverzicht.Name = "btnBestelOverzicht";
            this.btnBestelOverzicht.Size = new System.Drawing.Size(133, 49);
            this.btnBestelOverzicht.TabIndex = 3;
            this.btnBestelOverzicht.Text = "Besteloverzicht";
            this.btnBestelOverzicht.UseVisualStyleBackColor = true;
            this.btnBestelOverzicht.Click += new System.EventHandler(this.btnBestelOverzicht_Click);
            // 
            // BestelStandaardPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 355);
            this.Controls.Add(this.btnBestelOverzicht);
            this.Controls.Add(this.btnBestel);
            this.Controls.Add(this.lblStandaardPizzas);
            this.Controls.Add(this.lbStandaardPizzas);
            this.Name = "BestelStandaardPizza";
            this.Text = "BestelStandaardPizza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BestelStandaardPizza_FormClosed);
            this.Load += new System.EventHandler(this.BestelStandaardPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStandaardPizzas;
        private System.Windows.Forms.Label lblStandaardPizzas;
        private System.Windows.Forms.Button btnBestel;
        private System.Windows.Forms.Button btnBestelOverzicht;
    }
}