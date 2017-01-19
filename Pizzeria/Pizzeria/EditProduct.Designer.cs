namespace Pizzeria
{
    partial class EditProduct
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
            this.btnEditProductOpslaan = new System.Windows.Forms.Button();
            this.cbEditProductAlcohol = new System.Windows.Forms.ComboBox();
            this.tbEditProductVerkoop = new System.Windows.Forms.TextBox();
            this.tbEditProductInkoop = new System.Windows.Forms.TextBox();
            this.tbEditProductNaam = new System.Windows.Forms.TextBox();
            this.lblEditProductAlcohol = new System.Windows.Forms.Label();
            this.lblEditProductVerkoop = new System.Windows.Forms.Label();
            this.lblEditProductInkoop = new System.Windows.Forms.Label();
            this.lblEditProductNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditProductOpslaan
            // 
            this.btnEditProductOpslaan.Location = new System.Drawing.Point(329, 114);
            this.btnEditProductOpslaan.Name = "btnEditProductOpslaan";
            this.btnEditProductOpslaan.Size = new System.Drawing.Size(85, 41);
            this.btnEditProductOpslaan.TabIndex = 17;
            this.btnEditProductOpslaan.Text = "Opslaan";
            this.btnEditProductOpslaan.UseVisualStyleBackColor = true;
            this.btnEditProductOpslaan.Click += new System.EventHandler(this.btnEditProductOpslaan_Click);
            // 
            // cbEditProductAlcohol
            // 
            this.cbEditProductAlcohol.FormattingEnabled = true;
            this.cbEditProductAlcohol.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.cbEditProductAlcohol.Location = new System.Drawing.Point(86, 136);
            this.cbEditProductAlcohol.Name = "cbEditProductAlcohol";
            this.cbEditProductAlcohol.Size = new System.Drawing.Size(162, 21);
            this.cbEditProductAlcohol.TabIndex = 16;
            // 
            // tbEditProductVerkoop
            // 
            this.tbEditProductVerkoop.Location = new System.Drawing.Point(86, 92);
            this.tbEditProductVerkoop.Name = "tbEditProductVerkoop";
            this.tbEditProductVerkoop.Size = new System.Drawing.Size(162, 20);
            this.tbEditProductVerkoop.TabIndex = 15;
            // 
            // tbEditProductInkoop
            // 
            this.tbEditProductInkoop.Location = new System.Drawing.Point(86, 50);
            this.tbEditProductInkoop.Name = "tbEditProductInkoop";
            this.tbEditProductInkoop.Size = new System.Drawing.Size(162, 20);
            this.tbEditProductInkoop.TabIndex = 14;
            // 
            // tbEditProductNaam
            // 
            this.tbEditProductNaam.Location = new System.Drawing.Point(86, 6);
            this.tbEditProductNaam.Name = "tbEditProductNaam";
            this.tbEditProductNaam.Size = new System.Drawing.Size(162, 20);
            this.tbEditProductNaam.TabIndex = 13;
            // 
            // lblEditProductAlcohol
            // 
            this.lblEditProductAlcohol.AutoSize = true;
            this.lblEditProductAlcohol.Location = new System.Drawing.Point(12, 139);
            this.lblEditProductAlcohol.Name = "lblEditProductAlcohol";
            this.lblEditProductAlcohol.Size = new System.Drawing.Size(42, 13);
            this.lblEditProductAlcohol.TabIndex = 12;
            this.lblEditProductAlcohol.Text = "Alcohol";
            // 
            // lblEditProductVerkoop
            // 
            this.lblEditProductVerkoop.AutoSize = true;
            this.lblEditProductVerkoop.Location = new System.Drawing.Point(12, 95);
            this.lblEditProductVerkoop.Name = "lblEditProductVerkoop";
            this.lblEditProductVerkoop.Size = new System.Drawing.Size(47, 13);
            this.lblEditProductVerkoop.TabIndex = 11;
            this.lblEditProductVerkoop.Text = "Verkoop";
            // 
            // lblEditProductInkoop
            // 
            this.lblEditProductInkoop.AutoSize = true;
            this.lblEditProductInkoop.Location = new System.Drawing.Point(12, 53);
            this.lblEditProductInkoop.Name = "lblEditProductInkoop";
            this.lblEditProductInkoop.Size = new System.Drawing.Size(40, 13);
            this.lblEditProductInkoop.TabIndex = 10;
            this.lblEditProductInkoop.Text = "Inkoop";
            // 
            // lblEditProductNaam
            // 
            this.lblEditProductNaam.AutoSize = true;
            this.lblEditProductNaam.Location = new System.Drawing.Point(12, 9);
            this.lblEditProductNaam.Name = "lblEditProductNaam";
            this.lblEditProductNaam.Size = new System.Drawing.Size(35, 13);
            this.lblEditProductNaam.TabIndex = 9;
            this.lblEditProductNaam.Text = "Naam";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 168);
            this.Controls.Add(this.btnEditProductOpslaan);
            this.Controls.Add(this.cbEditProductAlcohol);
            this.Controls.Add(this.tbEditProductVerkoop);
            this.Controls.Add(this.tbEditProductInkoop);
            this.Controls.Add(this.tbEditProductNaam);
            this.Controls.Add(this.lblEditProductAlcohol);
            this.Controls.Add(this.lblEditProductVerkoop);
            this.Controls.Add(this.lblEditProductInkoop);
            this.Controls.Add(this.lblEditProductNaam);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditProductOpslaan;
        private System.Windows.Forms.ComboBox cbEditProductAlcohol;
        private System.Windows.Forms.TextBox tbEditProductVerkoop;
        private System.Windows.Forms.TextBox tbEditProductInkoop;
        private System.Windows.Forms.TextBox tbEditProductNaam;
        private System.Windows.Forms.Label lblEditProductAlcohol;
        private System.Windows.Forms.Label lblEditProductVerkoop;
        private System.Windows.Forms.Label lblEditProductInkoop;
        private System.Windows.Forms.Label lblEditProductNaam;
    }
}