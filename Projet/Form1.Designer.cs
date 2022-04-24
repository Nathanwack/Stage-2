namespace Projet
{
    partial class Séléctionneur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LienCra = new System.Windows.Forms.Button();
            this.LienCongé = new System.Windows.Forms.Button();
            this.LienCompta = new System.Windows.Forms.Button();
            this.LienWeb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BoutonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LienCra
            // 
            this.LienCra.BackColor = System.Drawing.Color.Ivory;
            this.LienCra.Location = new System.Drawing.Point(91, 311);
            this.LienCra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LienCra.Name = "LienCra";
            this.LienCra.Size = new System.Drawing.Size(400, 100);
            this.LienCra.TabIndex = 1;
            this.LienCra.Text = "C.R.A automatisé";
            this.LienCra.UseVisualStyleBackColor = false;
            this.LienCra.Click += new System.EventHandler(this.LienCra_Click);
            // 
            // LienCongé
            // 
            this.LienCongé.BackColor = System.Drawing.Color.Ivory;
            this.LienCongé.Location = new System.Drawing.Point(598, 311);
            this.LienCongé.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LienCongé.Name = "LienCongé";
            this.LienCongé.Size = new System.Drawing.Size(400, 100);
            this.LienCongé.TabIndex = 2;
            this.LienCongé.Text = "Demande de congé";
            this.LienCongé.UseVisualStyleBackColor = false;
            this.LienCongé.Click += new System.EventHandler(this.LienCongé_Click);
            // 
            // LienCompta
            // 
            this.LienCompta.BackColor = System.Drawing.Color.Ivory;
            this.LienCompta.Location = new System.Drawing.Point(91, 531);
            this.LienCompta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LienCompta.Name = "LienCompta";
            this.LienCompta.Size = new System.Drawing.Size(400, 100);
            this.LienCompta.TabIndex = 3;
            this.LienCompta.Text = "Comptabilité";
            this.LienCompta.UseVisualStyleBackColor = false;
            this.LienCompta.Click += new System.EventHandler(this.LienCompta_Click);
            // 
            // LienWeb
            // 
            this.LienWeb.BackColor = System.Drawing.Color.Ivory;
            this.LienWeb.Location = new System.Drawing.Point(598, 531);
            this.LienWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LienWeb.Name = "LienWeb";
            this.LienWeb.Size = new System.Drawing.Size(400, 100);
            this.LienWeb.TabIndex = 4;
            this.LienWeb.Text = "Accéder au site Internet";
            this.LienWeb.UseVisualStyleBackColor = false;
            this.LienWeb.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Projet.Properties.Resources.Logo___optimyse_waifu2x_2x_2n_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(184, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BoutonClose
            // 
            this.BoutonClose.FlatAppearance.BorderSize = 0;
            this.BoutonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoutonClose.Location = new System.Drawing.Point(481, 222);
            this.BoutonClose.Name = "BoutonClose";
            this.BoutonClose.Size = new System.Drawing.Size(132, 42);
            this.BoutonClose.TabIndex = 6;
            this.BoutonClose.Text = "Fermer";
            this.BoutonClose.UseVisualStyleBackColor = true;
            this.BoutonClose.Click += new System.EventHandler(this.BoutonClose_Click);
            // 
            // Séléctionneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 814);
            this.Controls.Add(this.BoutonClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LienWeb);
            this.Controls.Add(this.LienCompta);
            this.Controls.Add(this.LienCongé);
            this.Controls.Add(this.LienCra);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Séléctionneur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LienCra;
        private System.Windows.Forms.Button LienCongé;
        private System.Windows.Forms.Button LienCompta;
        private System.Windows.Forms.Button LienWeb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BoutonClose;
    }
}

