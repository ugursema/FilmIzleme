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

namespace FilmIzleme
{
    public partial class FrmAddFilm : Form
    {
        public FrmAddFilm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
          
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OD8JBL6\SQLEXPRESS;Initial Catalog=SU_Project;Integrated Security=True"))
            {
                try { 
                con.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Filmler (Ad, Kategori, Link) VALUES (@Ad,@Kategori, @Link) ",con);

                komut.Parameters.AddWithValue("@Ad",txtFilmAd.Text);
                komut.Parameters.AddWithValue("@Kategori", txtKategori.Text);
                komut.Parameters.AddWithValue("@Link", txtLink.Text);
                komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
