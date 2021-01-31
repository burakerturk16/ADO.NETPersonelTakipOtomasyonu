using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PersonelTakipOtomasyonu
{
    public partial class Form1 : Form
    {
        BussiniesLogicLayer bll;
        public Form1()
        {
            bll = new BussiniesLogicLayer();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void btn_sistemGiris_Click(object sender, EventArgs e)
        { 
            int EKS = bll.SistemGirisKontrol(txt_kullaniciAdi.Text, txt_sifre.Text);
            if (EKS > 0) 
                {
                MessageBox.Show("Giris Başarılı");
                AnaForm anaForm = new AnaForm();
                anaForm.Show();
                }
            else
            {
                MessageBox.Show("Hatalı Giriş Eksik Bilgi Girmediginizden Emin Olun!");
            }
        }
    }
}
