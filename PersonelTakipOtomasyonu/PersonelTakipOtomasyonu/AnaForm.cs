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
using System.IO;
using System.Reflection;

namespace PersonelTakipOtomasyonu
{
   
  public partial class AnaForm : Form
    {
       
        BussiniesLogicLayer bll;
        public AnaForm()
        {
         
            bll = new BussiniesLogicLayer();
            InitializeComponent();
        }

        private void btn_perEkle_Click(object sender, EventArgs e)
        {
           int EKSP = bll.YeniPersonelKayitEkle(Guid.NewGuid(),txt_Eadi.Text, txt_Esoyadi.Text, txt_Eemail.Text, txt_EtelNo.Text);
            if (EKSP > 0)
            {
                MessageBox.Show("Kayıt Başarıyla Eklendi!", EKSP.ToString());
                PersonelleriListele();
                
            }
            else
                MessageBox.Show("Kayıt Eklenemedi Kontrol Ediniz!");
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            PersonelleriListele();
        }
        private void PersonelleriListele()
        {
            //List<Personeller> perList = bll.PersonelListele();
            //list_personeller.DataSource = perList;
            list_personeller.DataSource = bll.PersonelListele();
        }
       

        private void list_personeller_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Personeller personeller =(Personeller)list_personeller.SelectedItem;
            if(personeller != null)
            {
                txt_gsAdı.Text = personeller.PerAdi;
                txt_gsSoyadı.Text = personeller.PerSoyad;
                txt_gsEmail.Text = personeller.PerEmail;
                txt_gsTelno.Text = personeller.PerTelno;
            }
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            
           Guid perID = ((Personeller)list_personeller.SelectedItem).PerID;
           int EKSG = bll.PersonelGuncelle(perID,txt_gsAdı.Text, txt_gsSoyadı.Text, txt_gsEmail.Text, txt_gsTelno.Text);
         
            if (EKSG > 0)
            {
                PersonelleriListele();
                MessageBox.Show("Kayit Guncellendi", EKSG.ToString());
            }
            else
                MessageBox.Show("Kayit Guncellenemedi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Kaydı Silmek İstediginizden Emin misiniz?","Bilgilendirme",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Guid ID = ((Personeller)list_personeller.SelectedItem).PerID;
                int EKSS = bll.PersonelSil(ID);
                if(EKSS>0)
                {
                    PersonelleriListele();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal edildi");
            }
        }

        private void btn_testDatGetir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                bll.YeniPersonelKayitEkle(Guid.NewGuid(),FakeData.NameData.GetFirstName(),FakeData.NameData.GetSurname(),
                FakeData.NameData.GetFullName()+"@abc.com",FakeData.PhoneNumberData.GetPhoneNumber());
            }
            PersonelleriListele();
        }

        private void btn_json_Click(object sender, EventArgs e)
        {
            List<Personeller> personellerim = bll.PersonelListele();
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(personellerim);
            File.WriteAllText(@"G:\JSON\Personellerim.json", jsonData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonData = File.ReadAllText(@"G:\JSON\Personellerim.json");
            List<Personeller> getPersonellerim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personeller>>(jsonData);
            for (int i = 0; i<getPersonellerim.Count; i++)
            {
                bll.YeniPersonelKayitEkle(getPersonellerim[i].PerID, getPersonellerim[i].PerAdi, getPersonellerim[i].PerSoyad,
                    getPersonellerim[i].PerEmail, getPersonellerim[i].PerTelno);
            }
            PersonelleriListele();
        }
        private void searchEmployessName(string key)
        {

            
            var result = bll.PersonelListele().Where(e => e.PerAdi.Contains(key.ToUpper())).ToList();
         

            list_personeller.DataSource = result;

        }
        private void searchEmployessSurname(string key)
        {


            var result = bll.PersonelListele().Where(e => e.PerSoyad.Contains(key.ToUpper())).ToList();

            list_personeller.DataSource = result;
           
        }
        private void searchEmployessEmail(string key)
        {


            var result = bll.PersonelListele().Where(e => e.PerEmail.Contains(key.ToUpper())).ToList();

            list_personeller.DataSource = result;
        }
        private void searchEmployessPhoneNumber(string key)
        {


            var result = bll.PersonelListele().Where(e => e.PerTelno.Contains(key)).ToList();

            list_personeller.DataSource = result;
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (cmbFields.SelectedItem == "Name")
            {
                searchEmployessName(tbxSearch.Text);
       
            }
            if (cmbFields.SelectedItem == "Surname")
            {
                searchEmployessSurname(tbxSearch.Text);
            }
            if (cmbFields.SelectedItem == "Email")
            {
                searchEmployessEmail(tbxSearch.Text);
            }
            if (cmbFields.SelectedItem == "Phonenumber")
            {
                searchEmployessPhoneNumber(tbxSearch.Text);
            }



        }
      


    }
}
