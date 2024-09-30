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

namespace YKS
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();


        private void pictureBox2_Click(object sender, EventArgs e)
        {


            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet1.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata, işlem gerçekleşmedi.");

            }
            
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet1.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet1.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {

            try
            {
                
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm eklendi.");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet1.Bolumler);
            }
            catch
            {
                MessageBox.Show("Hata oluştu yeniden deneyiniz.");
            }


        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumid.Text = id;
            TxtBolumAd.Text = bolumad;
            
        }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut3 = new SqlCommand("update Bolumler set BolumAd=@p1 where Bolumid=@p2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                komut3.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet1.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
             
            }


            

        }
    }
}
