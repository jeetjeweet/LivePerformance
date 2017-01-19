namespace Pizzeria
{
    partial class EditIngrediënt
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
            this.btnEditingrediëntOpslaan = new System.Windows.Forms.Button();
            this.tbEditingrediëntVerkoop = new System.Windows.Forms.TextBox();
            this.tbEditingrediëntInkoop = new System.Windows.Forms.TextBox();
            this.tbEditingrediëntNaam = new System.Windows.Forms.TextBox();
            this.lblEditingrediëntVerkoop = new System.Windows.Forms.Label();
            this.lblEditingrediëntInkoop = new System.Windows.Forms.Label();
            this.lblEditingrediëntNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditingrediëntOpslaan
            // 
            this.btnEditingrediëntOpslaan.Location = new System.Drawing.Point(325, 71);
            this.btnEditingrediëntOpslaan.Name = "btnEditingrediëntOpslaan";
            this.btnEditingrediëntOpslaan.Size = new System.Drawing.Size(85, 41);
            this.btnEditingrediëntOpslaan.TabIndex = 26;
            this.btnEditingrediëntOpslaan.Text = "Opslaan";
            this.btnEditingrediëntOpslaan.UseVisualStyleBackColor = true;
            this.btnEditingrediëntOpslaan.Click += new System.EventHandler(this.btnEditingrediëntOpslaan_Click);
            // 
            // tbEditingrediëntVerkoop
            // 
            this.tbEditingrediëntVerkoop.Location = new System.Drawing.Point(86, 92);
            this.tbEditingrediëntVerkoop.Name = "tbEditingrediëntVerkoop";
            this.tbEditingrediëntVerkoop.Size = new System.Drawing.Size(162, 20);
            this.tbEditingrediëntVerkoop.TabIndex = 24;
            // 
            // tbEditingrediëntInkoop
            // 
            this.tbEditingrediëntInkoop.Location = new System.Drawing.Point(86, 50);
            this.tbEditingrediëntInkoop.Name = "tbEditingrediëntInkoop";
            this.tbEditingrediëntInkoop.Size = new System.Drawing.Size(162, 20);
            this.tbEditingrediëntInkoop.TabIndex = 23;
            // 
            // tbEditingrediëntNaam
            // 
            this.tbEditingrediëntNaam.Location = new System.Drawing.Point(86, 6);
            this.tbEditingrediëntNaam.Name = "tbEditingrediëntNaam";
            this.tbEditingrediëntNaam.Size = new System.Drawing.Size(162, 20);
            this.tbEditingrediëntNaam.TabIndex = 22;
            // 
            // lblEditingrediëntVerkoop
            // 
            this.lblEditingrediëntVerkoop.AutoSize = true;
            this.lblEditingrediëntVerkoop.Location = new System.Drawing.Point(12, 95);
            this.lblEditingrediëntVerkoop.Name = "lblEditingrediëntVerkoop";
            this.lblEditingrediëntVerkoop.Size = new System.Drawing.Size(47, 13);
            this.lblEditingrediëntVerkoop.TabIndex = 20;
            this.lblEditingrediëntVerkoop.Text = "Verkoop";
            // 
            // lblEditingrediëntInkoop
            // 
            this.lblEditingrediëntInkoop.AutoSize = true;
            this.lblEditingrediëntInkoop.Location = new System.Drawing.Point(12, 53);
            this.lblEditingrediëntInkoop.Name = "lblEditingrediëntInkoop";
            this.lblEditingrediëntInkoop.Size = new System.Drawing.Size(40, 13);
            this.lblEditingrediëntInkoop.TabIndex = 19;
            this.lblEditingrediëntInkoop.Text = "Inkoop";
            // 
            // lblEditingrediëntNaam
            // 
            this.lblEditingrediëntNaam.AutoSize = true;
            this.lblEditingrediëntNaam.Location = new System.Drawing.Point(12, 9);
            this.lblEditingrediëntNaam.Name = "lblEditingrediëntNaam";
            this.lblEditingrediëntNaam.Size = new System.Drawing.Size(35, 13);
            this.lblEditingrediëntNaam.TabIndex = 18;
            this.lblEditingrediëntNaam.Text = "Naam";
            // 
            // EditIngrediënt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 125);
            this.Controls.Add(this.btnEditingrediëntOpslaan);
            this.Controls.Add(this.tbEditingrediëntVerkoop);
            this.Controls.Add(this.tbEditingrediëntInkoop);
            this.Controls.Add(this.tbEditingrediëntNaam);
            this.Controls.Add(this.lblEditingrediëntVerkoop);
            this.Controls.Add(this.lblEditingrediëntInkoop);
            this.Controls.Add(this.lblEditingrediëntNaam);
            this.Name = "EditIngrediënt";
            this.Text = "EditIngrediënt";
            this.Load += new System.EventHandler(this.EditIngrediënt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditingrediëntOpslaan;
        private System.Windows.Forms.TextBox tbEditingrediëntVerkoop;
        private System.Windows.Forms.TextBox tbEditingrediëntInkoop;
        private System.Windows.Forms.TextBox tbEditingrediëntNaam;
        private System.Windows.Forms.Label lblEditingrediëntVerkoop;
        private System.Windows.Forms.Label lblEditingrediëntInkoop;
        private System.Windows.Forms.Label lblEditingrediëntNaam;
    }
}