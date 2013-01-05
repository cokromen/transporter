using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP
{
    public partial class formInsertCar : Form
    {
        string path;
        string curfile;
        OpenFileDialog of = new OpenFileDialog();

        public formInsertCar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string plat = textBox1.Text;
            string merk = PassBox.Text;
            string tipe = textBox2.Text;
            string tahun = dateTimePicker1.Text;
            string silinder = textBox3.Text;
            string rangka = textBox4.Text;
            string mesin = textBox5.Text;
            string warna = textBox6.Text;
            string bahan = comboBox1.Text;
            string jenis = comboBox2.Text;
            string harga = textBox8.Text;
            string status = comboBox3.Text;


            Program.conn.Open();

           // string fileGambar = of.FileName;
           // byte[] blob = Program.getBlobImage(fileGambar);
            //  Program.conn.ExecuteBlobQuery("INSERT INTO mobil (FOTO_MOBIL) VALUES(:PARAM1)", "PARAM1", blob);

            string input = "INSERT INTO mobil (ID_MOBIL,MERK_MOBIL,JENIS_MOBIL,TAHUN_PEMBUATAN,ISI_SILINDER,NO_RANGKA_MOBIL,NO_MESIN_MOBIL,WARNA,BAHAN_BAKAR,GOLONGAN_MOBIL,HARGA_SEWA,STATUS_SEWA) VALUES ('" +plat+ "','" +merk+ "','" +tipe+ "',to_date('" +tahun+ "','mm/DD/yyyy')," +silinder+ ",'" +rangka+ "','" + mesin + "','" + warna + "','" + bahan + "','"+ jenis + "'," + harga + "," + status + ")";
            Program.conn.ExecuteNonQuery(input);

            Program.conn.Close();
            MessageBox.Show("Data berhasil diinputkan");

            this.Close();
            formMasterAdmin amin = new formMasterAdmin();
            amin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (of.ShowDialog() == DialogResult.OK)
            {
                curfile = of.FileName;
                path = curfile;
                pictureBox1.Load(of.FileName);
            }
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin min = new formMasterAdmin();
            min.Show();
        }
    }
}
