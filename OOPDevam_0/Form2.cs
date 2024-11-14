using OOPDevam_0.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDevam_0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Lab l;

        private void BtnLabYarat_Click(object sender, EventArgs e)
        {
            //Bu butona basıldıgında bir Lab yaratılacak ve sonra bu button disable olacak...
            l = new Lab();
            l.Kati = TxtLabKat.Text;
            l.LabNo = TxtLabNo.Text;
            l.Ogrenciler = new List<Ogrenci>();
            BtnLabYarat.Enabled = false;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //Bu butona tıklanıldıgında Ogrencinin ismi ve soyismi ilgili textboxlardan alınacak ve az önce yaratılmıs laba bir ögrenci eklenecek ve ögrencinin ismi, soyismi ve bulundugu lab numarası ve labın katı ListBox'ta listelenecek

            Ogrenci ogr = new Ogrenci();
            ogr.Ismi = TxtOgrenciIsim.Text;
            ogr.SoyIsmi = TxtOgrenciSoyIsim.Text;
            ogr.Labi = l; //BUrada ögrencinin Lab'ina atama yapıyoruz
            l.Ogrenciler.Add(ogr); //Burada yaratmıs oldugumuz global alandaki lab'in ögrenciler listesine de yaratmıs oldugumuz ögrenciyi ekliyoruz...
            LstSonuc.Items.Add(ogr.BilgiGoster());
        }
    }
}
