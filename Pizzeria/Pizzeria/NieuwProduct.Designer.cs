namespace Pizzeria
{
    partial class NieuwProduct
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
            this.lblNieuwProductNaam = new System.Windows.Forms.Label();
            this.lblNieuwProductInkoop = new System.Windows.Forms.Label();
            this.lblNieuwProductVerkoop = new System.Windows.Forms.Label();
            this.lblNieuwProductAlcohol = new System.Windows.Forms.Label();
            this.tbNieuwProductNaam = new System.Windows.Forms.TextBox();
            this.tbNieuwProductInkoop = new System.Windows.Forms.TextBox();
            this.tbNieuwProductVerkoop = new System.Windows.Forms.TextBox();
            this.cbNieuwProductAlcohol = new System.Windows.Forms.ComboBox();
            this.btnNieuwProductOpslaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNieuwProductNaam
            // 
            this.lblNieuwProductNaam.AutoSize = true;
            this.lblNieuwProductNaam.Location = new System.Drawing.Point(12, 9);
            this.lblNieuwProductNaam.Name = "lblNieuwProductNaam";
            this.lblNieuwProductNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNieuwProductNaam.TabIndex = 0;
            this.lblNieuwProductNaam.Text = "Naam";
            // 
            // lblNieuwProductInkoop
            // 
            this.lblNieuwProductInkoop.AutoSize = true;
            this.lblNieuwProductInkoop.Location = new System.Drawing.Point(12, 53);
            this.lblNieuwProductInkoop.Name = "lblNieuwProductInkoop";
            this.lblNieuwProductInkoop.Size = new System.Drawing.Size(40, 13);
            this.lblNieuwProductInkoop.TabIndex = 1;
            this.lblNieuwProductInkoop.Text = "Inkoop";
            // 
            // lblNieuwProductVerkoop
            // 
            this.lblNieuwProductVerkoop.AutoSize = true;
            this.lblNieuwProductVerkoop.Location = new System.Drawing.Point(12, 95);
            this.lblNieuwProductVerkoop.Name = "lblNieuwProductVerkoop";
            this.lblNieuwProductVerkoop.Size = new System.Drawing.Size(47, 13);
            this.lblNieuwProductVerkoop.TabIndex = 2;
            this.lblNieuwProductVerkoop.Text = "Verkoop";
            // 
            // lblNieuwProductAlcohol
            // 
            this.lblNieuwProductAlcohol.AutoSize = true;
            this.lblNieuwProductAlcohol.Location = new System.Drawing.Point(12, 139);
            this.lblNieuwProductAlcohol.Name = "lblNieuwProductAlcohol";
            this.lblNieuwProductAlcohol.Size = new System.Drawing.Size(42, 13);
            this.lblNieuwProductAlcohol.TabIndex = 3;
            this.lblNieuwProductAlcohol.Text = "Alcohol";
            // 
            // tbNieuwProductNaam
            // 
            this.tbNieuwProductNaam.Location = new System.Drawing.Point(86, 6);
            this.tbNieuwProductNaam.Name = "tbNieuwProductNaam";
            this.tbNieuwProductNaam.Size = new System.Drawing.Size(162, 20);
            this.tbNieuwProductNaam.TabIndex = 4;
            // 
            // tbNieuwProductInkoop
            // 
            this.tbNieuwProductInkoop.Location = new System.Drawing.Point(86, 50);
            this.tbNieuwProductInkoop.Name = "tbNieuwProductInkoop";
            this.tbNieuwProductInkoop.Size = new System.Drawing.Size(162, 20);
            this.tbNieuwProductInkoop.TabIndex = 5;
            // 
            // tbNieuwProductVerkoop
            // 
            this.tbNieuwProductVerkoop.Location = new System.Drawing.Point(86, 92);
            this.tbNieuwProductVerkoop.Name = "tbNieuwProductVerkoop";
            this.tbNieuwProductVerkoop.Size = new System.Drawing.Size(162, 20);
            this.tbNieuwProductVerkoop.TabIndex = 6;
            // 
            // cbNieuwProductAlcohol
            // 
            this.cbNieuwProductAlcohol.FormattingEnabled = true;
            this.cbNieuwProductAlcohol.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.cbNieuwProductAlcohol.Location = new System.Drawing.Point(86, 136);
            this.cbNieuwProductAlcohol.Name = "cbNieuwProductAlcohol";
            this.cbNieuwProductAlcohol.Size = new System.Drawing.Size(162, 21);
            this.cbNieuwProductAlcohol.TabIndex = 7;
            // 
            // btnNieuwProductOpslaan
            // 
            this.btnNieuwProductOpslaan.Location = new System.Drawing.Point(329, 114);
            this.btnNieuwProductOpslaan.Name = "btnNieuwProductOpslaan";
            this.btnNieuwProductOpslaan.Size = new System.Drawing.Size(85, 41);
            this.btnNieuwProductOpslaan.TabIndex = 8;
            this.btnNieuwProductOpslaan.Text = "Opslaan";
            this.btnNieuwProductOpslaan.UseVisualStyleBackColor = true;
            this.btnNieuwProductOpslaan.Click += new System.EventHandler(this.btnNieuwProductOpslaan_Click);
            // 
            // NieuwProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 172);
            this.Controls.Add(this.btnNieuwProductOpslaan);
            this.Controls.Add(this.cbNieuwProductAlcohol);
            this.Controls.Add(this.tbNieuwProductVerkoop);
            this.Controls.Add(this.tbNieuwProductInkoop);
            this.Controls.Add(this.tbNieuwProductNaam);
            this.Controls.Add(this.lblNieuwProductAlcohol);
            this.Controls.Add(this.lblNieuwProductVerkoop);
            this.Controls.Add(this.lblNieuwProductInkoop);
            this.Controls.Add(this.lblNieuwProductNaam);
            this.Name = "NieuwProduct";
            this.Text = "Nieuw Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NieuwProduct_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNieuwProductNaam;
        private System.Windows.Forms.Label lblNieuwProductInkoop;
        private System.Windows.Forms.Label lblNieuwProductVerkoop;
        private System.Windows.Forms.Label lblNieuwProductAlcohol;
        private System.Windows.Forms.TextBox tbNieuwProductNaam;
        private System.Windows.Forms.TextBox tbNieuwProductInkoop;
        private System.Windows.Forms.TextBox tbNieuwProductVerkoop;
        private System.Windows.Forms.ComboBox cbNieuwProductAlcohol;
        private System.Windows.Forms.Button btnNieuwProductOpslaan;
    }
}