namespace Pizzeria
{
    partial class BestelOverzicht
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
            this.lblBestellingPizzas = new System.Windows.Forms.Label();
            this.lblBestellingProducten = new System.Windows.Forms.Label();
            this.lbBestellingPizzas = new System.Windows.Forms.ListBox();
            this.lbBestellingProducten = new System.Windows.Forms.ListBox();
            this.btnBestelOverzichtBestellen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBestellingPizzas
            // 
            this.lblBestellingPizzas.AutoSize = true;
            this.lblBestellingPizzas.Location = new System.Drawing.Point(12, 9);
            this.lblBestellingPizzas.Name = "lblBestellingPizzas";
            this.lblBestellingPizzas.Size = new System.Drawing.Size(97, 13);
            this.lblBestellingPizzas.TabIndex = 0;
            this.lblBestellingPizzas.Text = "Pizza\'s in bestelling";
            // 
            // lblBestellingProducten
            // 
            this.lblBestellingProducten.AutoSize = true;
            this.lblBestellingProducten.Location = new System.Drawing.Point(263, 9);
            this.lblBestellingProducten.Name = "lblBestellingProducten";
            this.lblBestellingProducten.Size = new System.Drawing.Size(114, 13);
            this.lblBestellingProducten.TabIndex = 1;
            this.lblBestellingProducten.Text = "Producten in bestelling";
            // 
            // lbBestellingPizzas
            // 
            this.lbBestellingPizzas.FormattingEnabled = true;
            this.lbBestellingPizzas.Location = new System.Drawing.Point(12, 25);
            this.lbBestellingPizzas.Name = "lbBestellingPizzas";
            this.lbBestellingPizzas.Size = new System.Drawing.Size(200, 186);
            this.lbBestellingPizzas.TabIndex = 2;
            // 
            // lbBestellingProducten
            // 
            this.lbBestellingProducten.FormattingEnabled = true;
            this.lbBestellingProducten.Location = new System.Drawing.Point(266, 25);
            this.lbBestellingProducten.Name = "lbBestellingProducten";
            this.lbBestellingProducten.Size = new System.Drawing.Size(200, 186);
            this.lbBestellingProducten.TabIndex = 3;
            // 
            // btnBestelOverzichtBestellen
            // 
            this.btnBestelOverzichtBestellen.Location = new System.Drawing.Point(504, 148);
            this.btnBestelOverzichtBestellen.Name = "btnBestelOverzichtBestellen";
            this.btnBestelOverzichtBestellen.Size = new System.Drawing.Size(103, 63);
            this.btnBestelOverzichtBestellen.TabIndex = 4;
            this.btnBestelOverzichtBestellen.Text = "Bestellen";
            this.btnBestelOverzichtBestellen.UseVisualStyleBackColor = true;
            this.btnBestelOverzichtBestellen.Click += new System.EventHandler(this.btnBestelOverzichtBestellen_Click);
            // 
            // BestelOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 234);
            this.Controls.Add(this.btnBestelOverzichtBestellen);
            this.Controls.Add(this.lbBestellingProducten);
            this.Controls.Add(this.lbBestellingPizzas);
            this.Controls.Add(this.lblBestellingProducten);
            this.Controls.Add(this.lblBestellingPizzas);
            this.Name = "BestelOverzicht";
            this.Text = "BestelOverzicht";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BestelOverzicht_FormClosed);
            this.Load += new System.EventHandler(this.BestelOverzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBestellingPizzas;
        private System.Windows.Forms.Label lblBestellingProducten;
        private System.Windows.Forms.ListBox lbBestellingPizzas;
        private System.Windows.Forms.ListBox lbBestellingProducten;
        private System.Windows.Forms.Button btnBestelOverzichtBestellen;
    }
}