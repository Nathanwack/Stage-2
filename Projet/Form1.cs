using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class Séléctionneur : Form
    {
        public Séléctionneur()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.optimyse.fr/");
        }

        private void LienCompta_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://mon-expert-en-gestion.fr/cas/login");
        }

        private void LienCra_Click(object sender, EventArgs e)
        {
            Process.Start(@"ressources\excel\CRA AUTO.xls");
        }

        private void BoutonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LienCongé_Click(object sender, EventArgs e)
        {
            Process.Start(@"ressources\word\conge.docx");
        }
    }
}
