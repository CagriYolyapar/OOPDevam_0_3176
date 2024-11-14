using OOPDevam_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDevam_0
{
    public partial class Form1 : Form
    {
        /*
              List
        List sizin bir baska koleksiyon tipinizdir. Ve sizin koleksiyonunuzun eleman sayısı degişebilir bir halde olsun istiyorsanız kullanacagınız en rahat koleksiyon tiplerinden biridir...
         
         
         
         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Generic parantezleri : Bir class'ın görevini hangi tipe göre yapacagını bildiren parantezlerdir...Mesela List class'ımızın görevi bir koleksiyon yaratmaktır...Edindigi generic parantezlerinin ona söyledigi şey ise bu koleksiyon yaratma görevini hangi tip icin yapacagıdır...



            //List<string> sehirler = new List<string>();

            //sehirler.Add("İstanbul");
            //sehirler.Add("Eskişehir");
            //sehirler.Remove("İstanbul");

            Yazar y = new Yazar();
            y.Ismi = "Stephen";
            y.SoyIsmi = "King";
            y.Kitaplari = new List<Kitap>();
           

            Kitap k = new Kitap();
            k.Isim = "Gece Yarısını 4 gece";
            k.SayfaSayisi = 300;
            k.Yazari = y;

            y.Kitaplari.Add(k);

            
        }

      
        private void BtnYarat_Click(object sender, EventArgs e)
        {
            
         
        }
    }
}
