﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace YKS
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-44ELMSQ\\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }


    }
}
