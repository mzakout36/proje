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
    public partial class okulyönetimekranListe : Form
    {
        public okulyönetimekranListe()
        {
            InitializeComponent();
        }
        odev1Entities db = new odev1Entities();
        public string deger;

        void listele()
        {
            dataGridView1.DataSource = db.okulyonetimtablo.ToList();
            dataGridView1.Columns[4].Visible = false;

            var yonetimlist = db.okulyonetimtablo.ToList();


        }
        private void okulyönetimekranListe_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
