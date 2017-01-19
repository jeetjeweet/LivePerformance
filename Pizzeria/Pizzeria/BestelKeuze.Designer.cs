namespace Pizzeria
{
    partial class BestelKeuze
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
            this.btnStandaardPizzas = new System.Windows.Forms.Button();
            this.btnPizzaSamenstellen = new System.Windows.Forms.Button();
            this.btnProducten = new System.Windows.Forms.Button();
            this.btnBestelOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStandaardPizzas
            // 
            this.btnStandaardPizzas.Location = new System.Drawing.Point(12, 12);
            this.btnStandaardPizzas.Name = "btnStandaardPizzas";
            this.btnStandaardPizzas.Size = new System.Drawing.Size(135, 83);
            this.btnStandaardPizzas.TabIndex = 0;
            this.btnStandaardPizzas.Text = "Standaardpizza\'s bestellen";
            this.btnStandaardPizzas.UseVisualStyleBackColor = true;
            this.btnStandaardPizzas.Click += new System.EventHandler(this.btnStandaardPizzas_Click);
            // 
            // btnPizzaSamenstellen
            // 
            this.btnPizzaSamenstellen.Location = new System.Drawing.Point(192, 12);
            this.btnPizzaSamenstellen.Name = "btnPizzaSamenstellen";
            this.btnPizzaSamenstellen.Size = new System.Drawing.Size(135, 83);
            this.btnPizzaSamenstellen.TabIndex = 1;
            this.btnPizzaSamenstellen.Text = "Zelf pizza samenstellen";
            this.btnPizzaSamenstellen.UseVisualStyleBackColor = true;
            this.btnPizzaSamenstellen.Click += new System.EventHandler(this.btnPizzaSamenstellen_Click);
            // 
            // btnProducten
            // 
            this.btnProducten.Location = new System.Drawing.Point(371, 12);
            this.btnProducten.Name = "btnProducten";
            this.btnProducten.Size = new System.Drawing.Size(135, 83);
            this.btnProducten.TabIndex = 2;
            this.btnProducten.Text = "Producten bestellen";
            this.btnProducten.UseVisualStyleBackColor = true;
            this.btnProducten.Click += new System.EventHandler(this.btnProducten_Click);
            // 
            // btnBestelOverzicht
            // 
            this.btnBestelOverzicht.Location = new System.Drawing.Point(559, 12);
            this.btnBestelOverzicht.Name = "btnBestelOverzicht";
            this.btnBestelOverzicht.Size = new System.Drawing.Size(135, 83);
            this.btnBestelOverzicht.TabIndex = 3;
            this.btnBestelOverzicht.Text = "BestelOverzicht";
            this.btnBestelOverzicht.UseVisualStyleBackColor = true;
            this.btnBestelOverzicht.Click += new System.EventHandler(this.btnBestelOverzicht_Click);
            // 
            // BestelKeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 111);
            this.Controls.Add(this.btnBestelOverzicht);
            this.Controls.Add(this.btnProducten);
            this.Controls.Add(this.btnPizzaSamenstellen);
            this.Controls.Add(this.btnStandaardPizzas);
            this.Name = "BestelKeuze";
            this.Text = "BestelKeuze";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BestelKeuze_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStandaardPizzas;
        private System.Windows.Forms.Button btnPizzaSamenstellen;
        private System.Windows.Forms.Button btnProducten;
        private System.Windows.Forms.Button btnBestelOverzicht;
    }
}