namespace Pizzeria
{
    partial class NieuwIngrediënt
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
            this.btnNieuwIngrediëntOpslaan = new System.Windows.Forms.Button();
            this.tbNieuwIngrediëntVerkoop = new System.Windows.Forms.TextBox();
            this.tbNieuwIngrediëntInkoop = new System.Windows.Forms.TextBox();
            this.tbNieuwIngrediëntNaam = new System.Windows.Forms.TextBox();
            this.lblNieuwIngrediëntVerkoop = new System.Windows.Forms.Label();
            this.lblNieuwIngrediëntInkoop = new System.Windows.Forms.Label();
            this.lblNieuwIngrediëntNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNieuwIngrediëntOpslaan
            // 
            this.btnNieuwIngrediëntOpslaan.Location = new System.Drawing.Point(324, 71);
            this.btnNieuwIngrediëntOpslaan.Name = "btnNieuwIngrediëntOpslaan";
            this.btnNieuwIngrediëntOpslaan.Size = new System.Drawing.Size(85, 41);
            this.btnNieuwIngrediëntOpslaan.TabIndex = 17;
            this.btnNieuwIngrediëntOpslaan.Text = "Opslaan";
            this.btnNieuwIngrediëntOpslaan.UseVisualStyleBackColor = true;
            this.btnNieuwIngrediëntOpslaan.Click += new System.EventHandler(this.btnNieuwIngrediëntOpslaan_Click);
            // 
            // tbNieuwIngrediëntVerkoop
            // 
            this.tbNieuwIngrediëntVerkoop.Location = new System.Drawing.Point(86, 92);
            this.tbNieuwIngrediëntVerkoop.Name = "tbNieuwIngrediëntVerkoop";
            this.tbNieuwIngrediëntVerkoop.Size = new System.Drawing.Size(162, 20);
            this.tbNieuwIngrediëntVerkoop.TabIndex = 15;
            // 
            // tbNieuwIngrediëntInkoop
            // 
            this.tbNieuwIngrediëntInkoop.Location = new System.Drawing.Point(86, 50);
            this.tbNieuwIngrediëntInkoop.Name = "tbNieuwIngrediëntInkoop";
            this.tbNieuwIngrediëntInkoop.Size = new System.Drawing.Size(162, 20);
            this.tbNieuwIngrediëntInkoop.TabIndex = 14;
            // 
            // tbNieuwIngrediëntNaam
            // 
            this.tbNieuwIngrediëntNaam.Location = new System.Drawing.Point(86, 6);
            this.tbNieuwIngrediëntNaam.Name = "tbNieuwIngrediëntNaam";
            this.tbNieuwIngrediëntNaam.Size = new System.Drawing.Size(162, 20);
            this.tbNieuwIngrediëntNaam.TabIndex = 13;
            // 
            // lblNieuwIngrediëntVerkoop
            // 
            this.lblNieuwIngrediëntVerkoop.AutoSize = true;
            this.lblNieuwIngrediëntVerkoop.Location = new System.Drawing.Point(12, 95);
            this.lblNieuwIngrediëntVerkoop.Name = "lblNieuwIngrediëntVerkoop";
            this.lblNieuwIngrediëntVerkoop.Size = new System.Drawing.Size(47, 13);
            this.lblNieuwIngrediëntVerkoop.TabIndex = 11;
            this.lblNieuwIngrediëntVerkoop.Text = "Verkoop";
            // 
            // lblNieuwIngrediëntInkoop
            // 
            this.lblNieuwIngrediëntInkoop.AutoSize = true;
            this.lblNieuwIngrediëntInkoop.Location = new System.Drawing.Point(12, 53);
            this.lblNieuwIngrediëntInkoop.Name = "lblNieuwIngrediëntInkoop";
            this.lblNieuwIngrediëntInkoop.Size = new System.Drawing.Size(40, 13);
            this.lblNieuwIngrediëntInkoop.TabIndex = 10;
            this.lblNieuwIngrediëntInkoop.Text = "Inkoop";
            // 
            // lblNieuwIngrediëntNaam
            // 
            this.lblNieuwIngrediëntNaam.AutoSize = true;
            this.lblNieuwIngrediëntNaam.Location = new System.Drawing.Point(12, 9);
            this.lblNieuwIngrediëntNaam.Name = "lblNieuwIngrediëntNaam";
            this.lblNieuwIngrediëntNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNieuwIngrediëntNaam.TabIndex = 9;
            this.lblNieuwIngrediëntNaam.Text = "Naam";
            // 
            // NieuwIngrediënt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 126);
            this.Controls.Add(this.btnNieuwIngrediëntOpslaan);
            this.Controls.Add(this.tbNieuwIngrediëntVerkoop);
            this.Controls.Add(this.tbNieuwIngrediëntInkoop);
            this.Controls.Add(this.tbNieuwIngrediëntNaam);
            this.Controls.Add(this.lblNieuwIngrediëntVerkoop);
            this.Controls.Add(this.lblNieuwIngrediëntInkoop);
            this.Controls.Add(this.lblNieuwIngrediëntNaam);
            this.Name = "NieuwIngrediënt";
            this.Text = "Nieuw Ingrediënt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NieuwIngrediënt_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNieuwIngrediëntOpslaan;
        private System.Windows.Forms.TextBox tbNieuwIngrediëntVerkoop;
        private System.Windows.Forms.TextBox tbNieuwIngrediëntInkoop;
        private System.Windows.Forms.TextBox tbNieuwIngrediëntNaam;
        private System.Windows.Forms.Label lblNieuwIngrediëntVerkoop;
        private System.Windows.Forms.Label lblNieuwIngrediëntInkoop;
        private System.Windows.Forms.Label lblNieuwIngrediëntNaam;
    }
}