using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class BussiniesLogicLayer 
    {
       
        DataAccesLayer DAL;
        SqlDataReader reader;
        public BussiniesLogicLayer()
        {
           
            DAL = new DataAccesLayer();
        }
        internal int SistemGirisKontrol(string kullaniciadi, string kullanicisifre)
        {
            if (!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(kullanicisifre))
            {
                return DAL.SistemGirisKontrol(new SistemGirisKontrol()
                {
                    KullaniciAdi = kullaniciadi,
                    KullaniciSifre = kullanicisifre

                });
            }
            else
            {
                return -100;
            }
        }
        internal int YeniPersonelKayitEkle(Guid perID, string perAdi, string perSoyad, string perEmail, string perTelno)
        {
            if (perID != Guid.Empty && !string.IsNullOrEmpty(perAdi) && !string.IsNullOrEmpty(perSoyad) && !string.IsNullOrEmpty(perEmail) && !string.IsNullOrEmpty(perTelno))
            {


                Personeller p1 = new Personeller();

                p1.PerID = perID;
                p1.PerAdi = perAdi;
                p1.PerSoyad = perSoyad;
                p1.PerEmail = perEmail;
                p1.PerTelno = perTelno;
                return DAL.YeniPersonelKayitEkle(p1);


            }
            else
            {
                return -200;
            }
        }
        internal List<Personeller> PersonelListele()
        {
            
            List<Personeller> personellerim = new List<Personeller>();
            try
            {
               
                
                reader = DAL.PersonelListele();
                while (reader.Read())
                {
                    personellerim.Add(new Personeller()
                    {
                        PerID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        PerAdi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        PerSoyad = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        PerEmail = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        PerTelno = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    }) ; 

                }

                reader.Close();
            }
            catch (Exception)
            {

                //log hatalari
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return personellerim;
        }
        internal Personeller PersonelTekKayitGetir(Guid ID)
        {
            Personeller per = new Personeller();
            try
            {
                reader = DAL.PersonelTekKayitGetir(ID);
                while (reader.Read())
                {

                    per.PerID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    per.PerAdi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    per.PerSoyad = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    per.PerEmail = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    per.PerTelno = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

                }
                reader.Close();

            }
            catch (Exception)
            {
                //log
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return per;
        }
        internal int PersonelGuncelle(Guid perID, string perAdi, string perSoyad, string perEmail, string perTelno)
        {
                Personeller p = new Personeller();
            p.PerID = perID;
            p.PerAdi = perAdi;
            p.PerSoyad = perSoyad;
            p.PerEmail = perEmail;
            p.PerTelno = perTelno;
                return DAL.PersonelGuncelle(p);
        }
        internal int PersonelSil(Guid ID)
        {
            return DAL.PersonelSil(ID);
        }


    }

}



