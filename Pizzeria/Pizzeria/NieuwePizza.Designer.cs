namespace Pizzeria
{
    partial class NieuwePizza
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
            this.tbNieuwePizzaNaam = new System.Windows.Forms.TextBox();
            this.lblNieuwePizzaNaam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNieuwePizzaFormaat = new System.Windows.Forms.Label();
            this.cbNieuwePizzaBodem = new System.Windows.Forms.ComboBox();
            this.cbNieuwePizzaVorm = new System.Windows.Forms.ComboBox();
            this.tbNieuwePizzaFormaat = new System.Windows.Forms.TextBox();
            this.btnNieuwePizzaOpslaan = new System.Windows.Forms.Button();
            this.lbNieuwePizzaIngrediënten = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNieuwePizzaIngrediëntenOpPizza = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNieuwePizzaNaam
            // 
            this.tbNieuwePizzaNaam.Location = new System.Drawing.Point(120, 28);
            this.tbNieuwePizzaNaam.Name = "tbNieuwePizzaNaam";
            this.tbNieuwePizzaNaam.Size = new System.Drawing.Size(157, 20);
            this.tbNieuwePizzaNaam.TabIndex = 0;
            // 
            // lblNieuwePizzaNaam
            // 
            this.lblNieuwePizzaNaam.AutoSize = true;
            this.lblNieuwePizzaNaam.Location = new System.Drawing.Point(8, 31);
            this.lblNieuwePizzaNaam.Name = "lblNieuwePizzaNaam";
            this.lblNieuwePizzaNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNieuwePizzaNaam.TabIndex = 1;
            this.lblNieuwePizzaNaam.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vorm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bodem";
            // 
            // lblNieuwePizzaFormaat
            // 
            this.lblNieuwePizzaFormaat.AutoSize = true;
            this.lblNieuwePizzaFormaat.Location = new System.Drawing.Point(8, 143);
            this.lblNieuwePizzaFormaat.Name = "lblNieuwePizzaFormaat";
            this.lblNieuwePizzaFormaat.Size = new System.Drawing.Size(79, 13);
            this.lblNieuwePizzaFormaat.TabIndex = 4;
            this.lblNieuwePizzaFormaat.Text = "Formaat (in cm)";
            // 
            // cbNieuwePizzaBodem
            // 
            this.cbNieuwePizzaBodem.FormattingEnabled = true;
            this.cbNieuwePizzaBodem.Items.AddRange(new object[] {
            "Dunne_bodem",
            "Dikke_bodem",
            "Glutenvrije_bodem"});
            this.cbNieuwePizzaBodem.Location = new System.Drawing.Point(120, 105);
            this.cbNieuwePizzaBodem.Name = "cbNieuwePizzaBodem";
            this.cbNieuwePizzaBodem.Size = new System.Drawing.Size(157, 21);
            this.cbNieuwePizzaBodem.TabIndex = 5;
            // 
            // cbNieuwePizzaVorm
            // 
            this.cbNieuwePizzaVorm.FormattingEnabled = true;
            this.cbNieuwePizzaVorm.Items.AddRange(new object[] {
            "Rond",
            "Driehoek",
            "Rechthoek"});
            this.cbNieuwePizzaVorm.Location = new System.Drawing.Point(120, 67);
            this.cbNieuwePizzaVorm.Name = "cbNieuwePizzaVorm";
            this.cbNieuwePizzaVorm.Size = new System.Drawing.Size(157, 21);
            this.cbNieuwePizzaVorm.TabIndex = 6;
            // 
            // tbNieuwePizzaFormaat
            // 
            this.tbNieuwePizzaFormaat.Location = new System.Drawing.Point(120, 140);
            this.tbNieuwePizzaFormaat.Name = "tbNieuwePizzaFormaat";
            this.tbNieuwePizzaFormaat.Size = new System.Drawing.Size(157, 20);
            this.tbNieuwePizzaFormaat.TabIndex = 7;
            // 
            // btnNieuwePizzaOpslaan
            // 
            this.btnNieuwePizzaOpslaan.Location = new System.Drawing.Point(783, 119);
            this.btnNieuwePizzaOpslaan.Name = "btnNieuwePizzaOpslaan";
            this.btnNieuwePizzaOpslaan.Size = new System.Drawing.Size(83, 43);
            this.btnNieuwePizzaOpslaan.TabIndex = 8;
            this.btnNieuwePizzaOpslaan.Text = "Opslaan";
            this.btnNieuwePizzaOpslaan.UseVisualStyleBackColor = true;
            this.btnNieuwePizzaOpslaan.Click += new System.EventHandler(this.btnNieuwePizzaOpslaan_Click);
            // 
            // lbNieuwePizzaIngrediënten
            // 
            this.lbNieuwePizzaIngrediënten.FormattingEnabled = true;
            this.lbNieuwePizzaIngrediënten.Location = new System.Drawing.Point(352, 28);
            this.lbNieuwePizzaIngrediënten.Name = "lbNieuwePizzaIngrediënten";
            this.lbNieuwePizzaIngrediënten.Size = new System.Drawing.Size(154, 134);
            this.lbNieuwePizzaIngrediënten.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Beschikbare ingrediënten";
            // 
            // lbNieuwePizzaIngrediëntenOpPizza
            // 
            this.lbNieuwePizzaIngrediëntenOpPizza.FormattingEnabled = true;
            this.lbNieuwePizzaIngrediëntenOpPizza.Location = new System.Drawing.Point(630, 28);
            this.lbNieuwePizzaIngrediëntenOpPizza.Name = "lbNieuwePizzaIngrediëntenOpPizza";
            this.lbNieuwePizzaIngrediëntenOpPizza.Size = new System.Drawing.Size(147, 134);
            this.lbNieuwePizzaIngrediëntenOpPizza.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingrediënten op de pizza";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(530, 96);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 66);
            this.btnToevoegen.TabIndex = 13;
            this.btnToevoegen.Text = "Voeg ingrediënt toe aan de pizza";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // NieuwePizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 172);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNieuwePizzaIngrediëntenOpPizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNieuwePizzaIngrediënten);
            this.Controls.Add(this.btnNieuwePizzaOpslaan);
            this.Controls.Add(this.tbNieuwePizzaFormaat);
            this.Controls.Add(this.cbNieuwePizzaVorm);
            this.Controls.Add(this.cbNieuwePizzaBodem);
            this.Controls.Add(this.lblNieuwePizzaFormaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNieuwePizzaNaam);
            this.Controls.Add(this.tbNieuwePizzaNaam);
            this.Name = "NieuwePizza";
            this.Text = "NieuwePizza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NieuwePizza_FormClosed);
            this.Load += new System.EventHandler(this.NieuwePizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNieuwePizzaNaam;
        private System.Windows.Forms.Label lblNieuwePizzaNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNieuwePizzaFormaat;
        private System.Windows.Forms.ComboBox cbNieuwePizzaBodem;
        private System.Windows.Forms.ComboBox cbNieuwePizzaVorm;
        private System.Windows.Forms.TextBox tbNieuwePizzaFormaat;
        private System.Windows.Forms.Button btnNieuwePizzaOpslaan;
        private System.Windows.Forms.ListBox lbNieuwePizzaIngrediënten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbNieuwePizzaIngrediëntenOpPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToevoegen;
    }
}