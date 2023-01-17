using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciekran ogrpanel = new ogrenciekran();
            ogrpanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            okulyönetimekran oklyonetim = new okulyönetimekran();
            oklyonetim.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dersekran derspanel = new dersekran();
            derspanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrencidersekran derspanel = new ogrencidersekran();
            derspanel.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciekran ogrenciEkran = new ogrenciekran();
            ogrenciEkran.Show();
        }

        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            okulyönetimekran okulyönetimekran = new okulyönetimekran ();
            okulyönetimekran.Show();
        }

        private void girişToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ogrencidersekran ogrencidersekran = new ogrencidersekran();
            ogrencidersekran.Show();
        }

        private void girişToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dersekran dersekran = new dersekran();
            dersekran.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciekranListe ogrenciekranListe = new ogrenciekranListe();
            ogrenciekranListe.Show();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            okulyönetimekranListe okulYönetimekranListe = new okulyönetimekranListe();
            okulYönetimekranListe.Show();
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ogrencidersekranListe ogrencidersekran = new ogrencidersekranListe();
            ogrencidersekran.Show();
        }

        private void listeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dersekranListe dersekranListeder = new dersekranListe();
            dersekranListeder.Show();
        }
    }
}
