using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteTercihApp
{
    public partial class Form1 : Form
    {

        SqlConnection cn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL obl = new OgrenciBL();
                Ogrenci ogr = new Ogrenci();
                ogr.Ad = txtAd.Text.Trim();
                ogr.Soyad = txtSoyad.Text.Trim();
                ogr.Numara = int.Parse(txtNumara.Text.Trim());
                MessageBox.Show(obl.Kaydet(ogr) ? "Başarılı" : "Başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 245:
                        MessageBox.Show("Numara alanına sadece rakam giriniz");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası" + ex.Number);
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Numara alanına sadece rakam giriniz");
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        private void Ogrnbul_Click(object sender, EventArgs e)
        {
            frmbul frm = new frmbul(this);
            frm.Show();
        }
    }
}
}
