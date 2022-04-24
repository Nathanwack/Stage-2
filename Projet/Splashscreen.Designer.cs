namespace Projet
{
    partial class Splashcreen
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
            this.components = new System.ComponentModel.Container();
            this.Closeit = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Closeit
            // 
            this.Closeit.Enabled = true;
            this.Closeit.Interval = 500;
            this.Closeit.Tick += new System.EventHandler(this.Closeit_Tick_1);
            // 
            // Splashcreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet.Properties.Resources.Logo___optimyse_waifu2x_2x_2n_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(704, 204);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splashcreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private void Closeit_Tick(object sender, System.EventArgs e)
        {
            Closeit.Stop();
            this.Close();
        }
    private System.Windows.Forms.Timer Closeit;
        
    }
}