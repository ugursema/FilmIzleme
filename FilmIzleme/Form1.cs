using CefSharp.WinForms;
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

namespace FilmIzleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddFilm addfilm = new FrmAddFilm();
            addfilm.Show();
        }

        private void FilmListesi() 
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OD8JBL6\SQLEXPRESS;Initial Catalog=SU_Project;Integrated Security=True"))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT *From Tbl_Filmler", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilmListesi();
        }


        ChromiumWebBrowser chromiumWeb;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string Link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            // webBrowser1.Navigate(Link);
            chromiumWeb = new ChromiumWebBrowser(Link);
            this.groupBox2.Controls.Add(chromiumWeb);
           // chromiumWeb.Dock = DockStyle.Fill;
            chromiumWeb.Load(Link);
        }

        //hakkımızda butonu
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje 11 Şubat 2026 tarihinde kodlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //CIKIS
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //renk değiştir
        private void button4_Click(object sender, EventArgs e)
        {
            string[] renkler = { "Red", "Blue", "Green", "Yellow", "Purple", "Orange", "Pink", "Grey", "white" };
            int index = 0;
            index++;

            this.BackColor = Color.FromName(renkler[index]);


            if (index >= renkler.Length)
            {
                index = 0;
            }
        }
    }

    }
 
