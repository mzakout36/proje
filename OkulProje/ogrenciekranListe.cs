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
    public partial class ogrenciekranListe : Form
    {
        public ogrenciekranListe()
        {
            InitializeComponent();
        }
        odev1Entities db = new odev1Entities();

        void listeleme()
        {

            dataGridView1.DataSource = db.ogrencilertablo.ToList();

            dataGridView1.Columns[6].Visible = false;
        }
        private void ogrenciekranListe_Load(object sender, EventArgs e)
        {
            listeleme();
        }
    }
}
