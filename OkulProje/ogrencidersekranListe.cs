﻿using System;
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
    public partial class ogrencidersekranListe : Form
    {
        public ogrencidersekranListe()
        {
            InitializeComponent();
        }
        odev1Entities db = new odev1Entities();

        void listeleme()
        {
            dataGridView1.DataSource = (from x in db.ogrenciderstablo
                                        select new
                                        {
                                            x.ogrencidersid,
                                            x.derstablo.dersadi,
                                            x.ogrencilertablo.ogrenciadsoyad



                                        }).ToList();






            var derslist = db.derstablo.ToList();


        }
        private void ogrencidersekranListe_Load(object sender, EventArgs e)
        {
            listeleme();
            var ogrenciler = (from x in db.ogrencilertablo
                              select new
                              {
                                  x.ogrenciid,
                                  x.ogrenciadsoyad

                              }).ToList();


            var dersler = (from x in db.derstablo
                           select new
                           {
                               x.dersid,
                               x.dersadi

                           }).ToList();

        }
    }
}
