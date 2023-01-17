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
    public partial class dersekranListe : Form
    {
        public dersekranListe()
        {
            InitializeComponent();
        }
        odev1Entities db = new odev1Entities();



        void listeleme()
        {
            dataGridView1.DataSource = (from x in db.derstablo
                                        select new
                                        {
                                            x.dersid,
                                            x.dersadi,
                                            x.derskredisi,
                                            x.okulyonetimtablo.yonetimadsoyad

                                        }).ToList();



            //dataGridView1.Columns[4].Visible = false;

            var derslist = db.derstablo.ToList();


        }
        private void dersekranListe_Load(object sender, EventArgs e)
        {
            listeleme();
            var ogretmenler = (from x in db.okulyonetimtablo
                               where x.yonetimtipi == "12"
                               select new
                               {
                                   x.yonetimid,
                                   x.yonetimadsoyad

                               }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
