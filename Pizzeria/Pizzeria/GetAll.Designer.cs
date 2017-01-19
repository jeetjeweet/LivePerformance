namespace Pizzeria
{
    partial class GetAll
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
            this.lbGetAll = new System.Windows.Forms.ListBox();
            this.lblGetAll = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnWijzigen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGetAll
            // 
            this.lbGetAll.FormattingEnabled = true;
            this.lbGetAll.Location = new System.Drawing.Point(12, 25);
            this.lbGetAll.Name = "lbGetAll";
            this.lbGetAll.Size = new System.Drawing.Size(215, 212);
            this.lbGetAll.TabIndex = 0;
            // 
            // lblGetAll
            // 
            this.lblGetAll.AutoSize = true;
            this.lblGetAll.Location = new System.Drawing.Point(12, 9);
            this.lblGetAll.Name = "lblGetAll";
            this.lblGetAll.Size = new System.Drawing.Size(35, 13);
            this.lblGetAll.TabIndex = 1;
            this.lblGetAll.Text = "label1";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(305, 25);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 34);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "Nieuw";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.Location = new System.Drawing.Point(305, 118);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(75, 34);
            this.btnWijzigen.TabIndex = 3;
            this.btnWijzigen.Text = "Wijzigen";
            this.btnWijzigen.UseVisualStyleBackColor = true;
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(305, 203);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(75, 34);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(499, 203);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 34);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // GetAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 265);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnWijzigen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblGetAll);
            this.Controls.Add(this.lbGetAll);
            this.Name = "GetAll";
            this.Text = "GetAll";
            this.Load += new System.EventHandler(this.GetAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGetAll;
        private System.Windows.Forms.Label lblGetAll;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnWijzigen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnHome;
    }
}