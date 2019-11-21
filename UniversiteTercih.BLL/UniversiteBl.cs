﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversiteTercih.DAL;
using UniversiteTercihMODELS;

namespace UniversiteTercih.BLL
{
    public class UniversiteBl
    {
        public bool Kaydet(Universite o)
        {
            try
            {
                Helper hlp = new Helper();
                SqlParameter[] p = { new SqlParameter("@Ad", o.Ad), new SqlParameter("@Soyad", o.Soyad), new SqlParameter("@Numara", o.Numara), new SqlParameter("@SinifId", o.Sinifid) };
                return hlp.ExecuteNonQuery("Insert into tblOgrenciler values(@Ad,@Soyad,@Numara,@SinifId)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Universite OgrenciBul(int numara)
        {
            Helper hlp = new Helper();
            SqlParameter[] p = { new SqlParameter("@Numara", numara) };
            SqlDataReader dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara,SinifId from tblOgrenciler Where Numara=@Numara", p);
            Universite o = null;
            if (dr.Read())
            {
                o = new Universite();
                o.Ad = dr["Ad"].ToString();
                o.Soyad = dr["Soyad"].ToString();
                o.Numara = Convert.ToInt32(dr["Numara"]);
                o.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                o.Sinifid = Convert.ToInt32(dr["SinifId"]);
            }
            dr.Close();
            return o;

        }
    }
}

