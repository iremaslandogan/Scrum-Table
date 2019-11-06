using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
    

namespace Scrum_Yapısı
{
    public partial class FrmGiris : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=scrum.accdb");
        OleDbDataAdapter adaptor = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        DataSet veri = new DataSet();

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {           
            string kullanici;

            string sifre;

            kullanici = txtAd.Text;

            sifre = txtSifre.Text;

            if (sifre == "123456")
            {
                this.Hide();
                FrmScrum frm = new FrmScrum();                              
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO Kullanici (AdSoyad) VALUES ('" + txtAd.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                frm.KullaniciAdi = txtAd.Text;
                frm.ShowDialog();
                //frm.Show();
            }
            else
            {
                {
                    MessageBox.Show("YANLIŞ ŞİFRE");
                }
            }

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
