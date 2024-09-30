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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HBE_PANSİYON
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-44ELMSQ\\SQLEXPRESS;Initial Catalog=hbe;Integrated Security=True");
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "', Sifre='" + TxtSifre.Text + "'",  baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
