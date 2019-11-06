using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scrum_Yapısı
{
    public partial class FrmScrum : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=scrum.accdb");
        OleDbDataAdapter adaptor = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        DataSet dr= new DataSet();
        public int i = 0;
        DateTime Tarih = DateTime.Now;
        public string KullaniciAdi { get; set; }

        public FrmScrum()
        {
            InitializeComponent();
        }

        private void btnHikayeOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Hikayeler (Hikaye,Tarih) VALUES ('" + txtHikaye.Text + "', '" + Tarih + "')", baglanti);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();

            MessageBox.Show("KAYIT EDİLDİ");

            txtHikaye.Clear();
        }

        Label[] gorevBaslatilmadi;
        Label[] gorevDevam;
        Label[] gorevBitti;


        void GorevBaslatilmadiListele()
        {
            int storySayisi;
            baglanti.Open();
            komut = new OleDbCommand("SELECT COUNT(*) FROM GorevBaslatilmadi", baglanti);
            storySayisi = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            gorevBaslatilmadi = new Label[storySayisi];

            for (i = 0; i < storySayisi; i++)
            {
                gorevBaslatilmadi[i] = new Label();
                gorevBaslatilmadi[i].Width = 170;
                gorevBaslatilmadi[i].Height = 100;
                flowPanelBaslatilmadi.Controls.Add(gorevBaslatilmadi[i]);
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from GorevBaslatilmadi ", baglanti);
                da.Fill(dt);
                gorevBaslatilmadi[i].Text = dt.Rows[i][0].ToString() + Environment.NewLine + dt.Rows[i][1].ToString() + Environment.NewLine + dt.Rows[i][2].ToString() + Environment.NewLine + dt.Rows[i][3].ToString();
                baglanti.Close();
            }
        }

        void GorevDevamListele()
        {
            int storySayisi;
            baglanti.Open();
            komut = new OleDbCommand("SELECT COUNT(*) FROM GorevDevam", baglanti);
            storySayisi = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            gorevDevam = new Label[storySayisi];

            for (i = 0; i < storySayisi; i++)
            {
                gorevDevam[i] = new Label();
                gorevDevam[i].Width = 170;
                gorevDevam[i].Height = 100;
                flowPanelDevam.Controls.Add(gorevDevam[i]);
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from GorevDevam ", baglanti);
                da.Fill(dt);
                gorevDevam[i].Text = dt.Rows[i][0].ToString() + Environment.NewLine + dt.Rows[i][1].ToString() + Environment.NewLine + dt.Rows[i][2].ToString() + Environment.NewLine + dt.Rows[i][3].ToString();
                baglanti.Close();
            }
        }

        void GorevBittiListele()
        {
            int storySayisi;
            baglanti.Open();
            komut = new OleDbCommand("SELECT COUNT(*) FROM GorevBitti", baglanti);
            storySayisi = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            gorevBitti = new Label[storySayisi];

            for (i = 0; i < storySayisi; i++)
            {
                gorevBitti[i] = new Label();
                gorevBitti[i].Width = 170;
                gorevBitti[i].Height = 100;
                flowPanelBitti.Controls.Add(gorevBitti[i]);
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from GorevBitti ", baglanti);
                da.Fill(dt);
                gorevBitti[i].Text = dt.Rows[i][0].ToString() + Environment.NewLine + dt.Rows[i][1].ToString() + Environment.NewLine + dt.Rows[i][2].ToString() + Environment.NewLine + dt.Rows[i][3].ToString();
                baglanti.Close();
            }
        }

        Label[] hikaye;

        void HikayeListele()
        {
            int storySayisi;
            baglanti.Open();
            komut = new OleDbCommand("SELECT COUNT(*) FROM Hikayeler", baglanti);
            storySayisi = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();

            hikaye = new Label[storySayisi];

            for (i = 0; i <storySayisi; i++)
            {
                hikaye[i] = new Label();
                
                hikaye[i].Width = 150;
                hikaye[i].Height = 100;
                flowPanelHikaye.Controls.Add(hikaye[i]);

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * from Hikayeler ", baglanti);
                da.Fill(dt);
                hikaye[i].Text = dt.Rows[i][0].ToString()+ Environment.NewLine + dt.Rows[i][1].ToString()+ Environment.NewLine + dt.Rows[i][2].ToString();
                baglanti.Close();
               
            }

        }


        private void FrmScrum_Load(object sender, EventArgs e)
        {
            HikayeListele();
            GorevBaslatilmadiListele();
            GorevDevamListele();
            GorevBittiListele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            flowPanelHikaye.Controls.Clear();
            flowPanelBaslatilmadi.Controls.Clear();
            flowPanelDevam.Controls.Clear();
            flowPanelBitti.Controls.Clear();
            HikayeListele();
            GorevBaslatilmadiListele();
            GorevDevamListele();
            GorevBittiListele();

        }

        private void btnGorevOlustur_Click(object sender, EventArgs e)
        {
            if (rdbtnBaslamadi.Checked)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO GorevBaslatilmadi (Gorev,AdSoyad,Tarih) VALUES ('" + txtGorev.Text + "','" + KullaniciAdi + "', '" + Tarih + "')", baglanti);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();

                MessageBox.Show("KAYIT EDİLDİ");
                txtGorev.Clear();
            }
            else if (rdbtnDevam.Checked)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO GorevDevam (Gorev,AdSoyad,Tarih) VALUES ('" + txtGorev.Text + "','" + KullaniciAdi + "', '" + Tarih + "')", baglanti);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();

                MessageBox.Show("KAYIT EDİLDİ");
                txtGorev.Clear();
            }
            else if(rdbtnBitti.Checked)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO GorevBitti (Gorev,AdSoyad,Tarih) VALUES ('" + txtGorev.Text + "','" + KullaniciAdi + "', '" + Tarih + "')", baglanti);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();

                MessageBox.Show("KAYIT EDİLDİ");
                txtGorev.Clear();
            }
            rdbtnBaslamadi.Checked = false;
            rdbtnDevam.Checked = false;
            rdbtnBitti.Checked = false;
        }

        private void btnHikayeSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM Hikayeler WHERE HikayeNumarasi = @hikayenumarasil ";
            komut.Parameters.AddWithValue("@hikayenumarasil", int.Parse(txtSilinecekHikayeNo.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            dr.Clear();
            txtSilinecekHikayeNo.Clear();

            MessageBox.Show("HİKAYE SİLİNDİ");
        }

        private void btnGorevSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "DELETE FROM GorevBitti WHERE GorevNumarasi = @gorevnumarasil ";
            komut.Parameters.AddWithValue("@gorevnumarasil", int.Parse(txtSilinecekGorevNo.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            dr.Clear();
            txtSilinecekGorevNo.Clear();

            MessageBox.Show("GÖREV SİLİNDİ");

        }

        private void btnGorevTasi_Click(object sender, EventArgs e)
        {
            if (cBoxOncekiBaslatilmadi.Checked && cBoxSonrakiDevam.Checked)
            {
                baglanti.Open();
                DataTable dt = new DataTable();
                OleDbCommand komut = new OleDbCommand("INSERT INTO GorevDevam(Gorev,AdSoyad,Tarih) SELECT E.Gorev,E.AdSoyad,E.Tarih FROM GorevBaslatilmadi E WHERE GorevNumarasi = @gorevtasi", baglanti);
                komut.Parameters.AddWithValue("@gorevtasi", int.Parse(txtTasinacakGorevNo.Text));

                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM GorevBaslatilmadi WHERE GorevNumarasi = @gorevnumarasil ";
                komut.Parameters.AddWithValue("@gorevnumarasil", int.Parse(txtTasinacakGorevNo.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                dr.Clear();
            }

            else if (cBoxOncekiBaslatilmadi.Checked && cBoxSonrakiBitti.Checked)
            {
                baglanti.Open();
                DataTable dt = new DataTable();
                OleDbCommand komut = new OleDbCommand("INSERT INTO GorevBitti(Gorev,AdSoyad,Tarih) SELECT E.Gorev,E.AdSoyad,E.Tarih FROM GorevBaslatilmadi E WHERE GorevNumarasi = @gorevtasi", baglanti);
                komut.Parameters.AddWithValue("@gorevtasi", int.Parse(txtTasinacakGorevNo.Text));

                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM GorevBaslatilmadi WHERE GorevNumarasi = @gorevnumarasil ";
                komut.Parameters.AddWithValue("@gorevnumarasil", int.Parse(txtTasinacakGorevNo.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                dr.Clear();

            }
            else if (cBoxOncekiDevam.Checked && cBoxSonrakiBitti.Checked)
            {
                baglanti.Open();
                DataTable dt = new DataTable();
                OleDbCommand komut = new OleDbCommand("INSERT INTO GorevBitti(Gorev,AdSoyad,Tarih) SELECT E.Gorev,E.AdSoyad,E.Tarih FROM GorevDevam E WHERE GorevNumarasi = @gorevtasi", baglanti);
                komut.Parameters.AddWithValue("@gorevtasi", int.Parse(txtTasinacakGorevNo.Text));

                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM GorevDevam WHERE GorevNumarasi = @gorevnumarasil ";
                komut.Parameters.AddWithValue("@gorevnumarasil", int.Parse(txtTasinacakGorevNo.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                dr.Clear();


            }

            MessageBox.Show("GÖREV TAŞINDI");

            txtTasinacakGorevNo.Clear();
            cBoxOncekiBaslatilmadi.Checked = false;
            cBoxOncekiDevam.Checked = false;
            cBoxSonrakiDevam.Checked = false;
            cBoxSonrakiBitti.Checked = false;

        }
    }
}
