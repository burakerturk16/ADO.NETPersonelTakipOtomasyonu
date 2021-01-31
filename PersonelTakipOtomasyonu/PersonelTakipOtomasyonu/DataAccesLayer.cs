using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PersonelTakipOtomasyonu
{
   internal class DataAccesLayer
    {
        SqlConnection bgl;
        SqlCommand gm;
        SqlDataReader reader;
        int sonuc = 0;

        public DataAccesLayer()
        {
            bgl = new SqlConnection();
            bgl.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            
        }
        internal void BaglantiAyarla()
        {
            if (bgl.State == ConnectionState.Closed)
                bgl.Open();
            else bgl.Close();
        }

        internal int SistemGirisKontrol(SistemGirisKontrol SK)
        {
            try
            {
                gm = new SqlCommand("SP_KullaniciKontrol",bgl);
                gm.CommandType = CommandType.StoredProcedure;
                gm.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = SK.KullaniciAdi;
                gm.Parameters.Add("@KullaniciSifre", SqlDbType.NVarChar).Value = SK.KullaniciSifre;
                BaglantiAyarla();
                sonuc = (int)gm.ExecuteScalar();
            }
            catch (Exception)
            {
                //log 

            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;
        }
        internal int YeniPersonelKayitEkle(Personeller per)
        {
            try
            {
                gm = new SqlCommand("SP_PersonelEkle", bgl);
                gm.CommandType = CommandType.StoredProcedure;
                gm.Parameters.Add("@PerID", SqlDbType.UniqueIdentifier).Value = per.PerID;
                gm.Parameters.Add("@PerAdi", SqlDbType.NVarChar).Value = per.PerAdi.ToUpper();
                gm.Parameters.Add("@PerSoyad", SqlDbType.NVarChar).Value = per.PerSoyad.ToUpper();
                gm.Parameters.Add("@PerEmail", SqlDbType.NVarChar).Value = per.PerEmail;
                gm.Parameters.Add("@PerTelno", SqlDbType.NVarChar).Value = per.PerTelno;
                BaglantiAyarla();
                sonuc = (int)gm.ExecuteNonQuery();
            }
            catch (Exception)
            {

               //log
            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;
        }
        internal SqlDataReader PersonelListele()
        {
            gm = new SqlCommand("SP_PersonelGetir",bgl);
            gm.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return gm.ExecuteReader();

        }
        internal SqlDataReader PersonelTekKayitGetir(Guid ID)
        {
            gm = new SqlCommand("SP_PersonelTekGetir", bgl);
            gm.CommandType = CommandType.StoredProcedure;
            gm.Parameters.Add("@PerID", SqlDbType.UniqueIdentifier).Value = ID;
            BaglantiAyarla();
            return gm.ExecuteReader();
        }
        internal int PersonelGuncelle(Personeller per)
        {
            try
            {
                gm = new SqlCommand("SP_PersonelGuncelle", bgl);
                gm.CommandType = CommandType.StoredProcedure;
                gm.Parameters.Add("@PerID", SqlDbType.UniqueIdentifier).Value = per.PerID;
                gm.Parameters.Add("@PerAdi", SqlDbType.NVarChar).Value = per.PerAdi;
                gm.Parameters.Add("@PerSoyad", SqlDbType.NVarChar).Value = per.PerSoyad;
                gm.Parameters.Add("@PerEmail", SqlDbType.NVarChar).Value = per.PerEmail;
                gm.Parameters.Add("@PerTelno", SqlDbType.NVarChar).Value = per.PerTelno;
                BaglantiAyarla();
                sonuc = (int)gm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                //log
            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;
        }
       internal int PersonelSil(Guid ID)
        {
            try
            {

                gm = new SqlCommand("SP_PersonelSil", bgl);
                gm.CommandType = CommandType.StoredProcedure;
                gm.Parameters.Add("@PerID", SqlDbType.UniqueIdentifier).Value = ID;
              BaglantiAyarla();
                sonuc = (int)gm.ExecuteNonQuery();
            
            }
            catch (Exception)
            {

                //log
            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;
        }
    }
    }

