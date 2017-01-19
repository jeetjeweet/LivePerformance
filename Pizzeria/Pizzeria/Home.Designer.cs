namespace Pizzeria
{
    partial class Home
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
            this.btnAlleProducten = new System.Windows.Forms.Button();
            this.btnAlleIngrediënten = new System.Windows.Forms.Button();
            this.btnAllePizzas = new System.Windows.Forms.Button();
            this.lbPizzasInOven = new System.Windows.Forms.ListBox();
            this.lblPizzasInOven = new System.Windows.Forms.Label();
            this.lblPizzasWachtende = new System.Windows.Forms.Label();
            this.lbWachtendePizzas = new System.Windows.Forms.ListBox();
            this.lbPizzasGereed = new System.Windows.Forms.ListBox();
            this.lblPizzasGereed = new System.Windows.Forms.Label();
            this.btnBestelOverzicht = new System.Windows.Forms.Button();
            this.btnBestellen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlleProducten
            // 
            this.btnAlleProducten.Location = new System.Drawing.Point(677, 335);
            this.btnAlleProducten.Name = "btnAlleProducten";
            this.btnAlleProducten.Size = new System.Drawing.Size(89, 58);
            this.btnAlleProducten.TabIndex = 0;
            this.btnAlleProducten.Text = "Alle Producten";
            this.btnAlleProducten.UseVisualStyleBackColor = true;
            this.btnAlleProducten.Click += new System.EventHandler(this.btnAlleProducten_Click);
            // 
            // btnAlleIngrediënten
            // 
            this.btnAlleIngrediënten.Location = new System.Drawing.Point(677, 271);
            this.btnAlleIngrediënten.Name = "btnAlleIngrediënten";
            this.btnAlleIngrediënten.Size = new System.Drawing.Size(89, 58);
            this.btnAlleIngrediënten.TabIndex = 1;
            this.btnAlleIngrediënten.Text = "Alle Ingrediënten";
            this.btnAlleIngrediënten.UseVisualStyleBackColor = true;
            this.btnAlleIngrediënten.Click += new System.EventHandler(this.btnAlleIngrediënten_Click);
            // 
            // btnAllePizzas
            // 
            this.btnAllePizzas.Location = new System.Drawing.Point(677, 207);
            this.btnAllePizzas.Name = "btnAllePizzas";
            this.btnAllePizzas.Size = new System.Drawing.Size(89, 58);
            this.btnAllePizzas.TabIndex = 2;
            this.btnAllePizzas.Text = "Alle Pizza\'s";
            this.btnAllePizzas.UseVisualStyleBackColor = true;
            this.btnAllePizzas.Click += new System.EventHandler(this.btnAllePizzas_Click);
            // 
            // lbPizzasInOven
            // 
            this.lbPizzasInOven.FormattingEnabled = true;
            this.lbPizzasInOven.Location = new System.Drawing.Point(12, 25);
            this.lbPizzasInOven.Name = "lbPizzasInOven";
            this.lbPizzasInOven.Size = new System.Drawing.Size(164, 173);
            this.lbPizzasInOven.TabIndex = 3;
            // 
            // lblPizzasInOven
            // 
            this.lblPizzasInOven.AutoSize = true;
            this.lblPizzasInOven.Location = new System.Drawing.Point(12, 9);
            this.lblPizzasInOven.Name = "lblPizzasInOven";
            this.lblPizzasInOven.Size = new System.Drawing.Size(92, 13);
            this.lblPizzasInOven.TabIndex = 4;
            this.lblPizzasInOven.Text = "Pizza\'s in de oven";
            // 
            // lblPizzasWachtende
            // 
            this.lblPizzasWachtende.AutoSize = true;
            this.lblPizzasWachtende.Location = new System.Drawing.Point(12, 207);
            this.lblPizzasWachtende.Name = "lblPizzasWachtende";
            this.lblPizzasWachtende.Size = new System.Drawing.Size(97, 13);
            this.lblPizzasWachtende.TabIndex = 5;
            this.lblPizzasWachtende.Text = "Wachtende pizza\'s";
            // 
            // lbWachtendePizzas
            // 
            this.lbWachtendePizzas.FormattingEnabled = true;
            this.lbWachtendePizzas.Location = new System.Drawing.Point(15, 223);
            this.lbWachtendePizzas.Name = "lbWachtendePizzas";
            this.lbWachtendePizzas.Size = new System.Drawing.Size(164, 173);
            this.lbWachtendePizzas.TabIndex = 6;
            // 
            // lbPizzasGereed
            // 
            this.lbPizzasGereed.FormattingEnabled = true;
            this.lbPizzasGereed.Location = new System.Drawing.Point(221, 25);
            this.lbPizzasGereed.Name = "lbPizzasGereed";
            this.lbPizzasGereed.Size = new System.Drawing.Size(164, 173);
            this.lbPizzasGereed.TabIndex = 7;
            // 
            // lblPizzasGereed
            // 
            this.lblPizzasGereed.AutoSize = true;
            this.lblPizzasGereed.Location = new System.Drawing.Point(218, 9);
            this.lblPizzasGereed.Name = "lblPizzasGereed";
            this.lblPizzasGereed.Size = new System.Drawing.Size(75, 13);
            this.lblPizzasGereed.TabIndex = 8;
            this.lblPizzasGereed.Text = "Pizza\'s gereed";
            // 
            // btnBestelOverzicht
            // 
            this.btnBestelOverzicht.Location = new System.Drawing.Point(541, 335);
            this.btnBestelOverzicht.Name = "btnBestelOverzicht";
            this.btnBestelOverzicht.Size = new System.Drawing.Size(89, 58);
            this.btnBestelOverzicht.TabIndex = 9;
            this.btnBestelOverzicht.Text = "Bestel Overzicht";
            this.btnBestelOverzicht.UseVisualStyleBackColor = true;
            this.btnBestelOverzicht.Click += new System.EventHandler(this.btnBestelOverzicht_Click);
            // 
            // btnBestellen
            // 
            this.btnBestellen.Location = new System.Drawing.Point(441, 335);
            this.btnBestellen.Name = "btnBestellen";
            this.btnBestellen.Size = new System.Drawing.Size(75, 58);
            this.btnBestellen.TabIndex = 10;
            this.btnBestellen.Text = "Bestellen";
            this.btnBestellen.UseVisualStyleBackColor = true;
            this.btnBestellen.Click += new System.EventHandler(this.btnBestellen_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 405);
            this.Controls.Add(this.btnBestellen);
            this.Controls.Add(this.btnBestelOverzicht);
            this.Controls.Add(this.lblPizzasGereed);
            this.Controls.Add(this.lbPizzasGereed);
            this.Controls.Add(this.lbWachtendePizzas);
            this.Controls.Add(this.lblPizzasWachtende);
            this.Controls.Add(this.lblPizzasInOven);
            this.Controls.Add(this.lbPizzasInOven);
            this.Controls.Add(this.btnAllePizzas);
            this.Controls.Add(this.btnAlleIngrediënten);
            this.Controls.Add(this.btnAlleProducten);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlleProducten;
        private System.Windows.Forms.Button btnAlleIngrediënten;
        private System.Windows.Forms.Button btnAllePizzas;
        private System.Windows.Forms.ListBox lbPizzasInOven;
        private System.Windows.Forms.Label lblPizzasInOven;
        private System.Windows.Forms.Label lblPizzasWachtende;
        private System.Windows.Forms.ListBox lbWachtendePizzas;
        private System.Windows.Forms.ListBox lbPizzasGereed;
        private System.Windows.Forms.Label lblPizzasGereed;
        private System.Windows.Forms.Button btnBestelOverzicht;
        private System.Windows.Forms.Button btnBestellen;
    }
}

