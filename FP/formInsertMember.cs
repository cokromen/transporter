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
    public partial class formInsertMember : Form
    {
        string path;
        string curfile;
        OpenFileDialog of = new OpenFileDialog();

        public formInsertMember()
        {
            InitializeComponent();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin amin = new formMasterAdmin();
            amin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nama = PassBox.Text;
            string tempatlahir = textBox2.Text;
            string tanggal = dateTimePicker1.Text;
            string warga = comboBox1.Text;
            string ident = comboBox2.Text;
            string noid = textBox5.Text;
            string jenkel = comboBox3.Text;
            string alamat = richTextBox1.Text;
            string hp = textBox8.Text;
            string telp = textBox7.Text;
            string gabung = dateTimePicker2.Text;

            Program.conn.Open();

            //string fileGambar = of.FileName;
           // byte[] blob = Program.getBlobImage(fileGambar);
            //Program.conn.ExecuteBlobQuery("INSERT INTO pelanggan (,FOTO_PELANGGAN) VALUES(:PARAM1)", "PARAM1", blob);
                
                      
            string input = "INSERT INTO pelanggan (ID_LANGGAN,NAMA_LENGKAP,TEMPAT_LAHIR,TANGGAL_LAHIR,WARGA_NEGARA,JENIS_IDENTITAS,NO_IDENTITAS,J_KEL,ALAMAT,NO_HP,NO_TELP,TANGGAL_BERGABUNG) VALUES ('" + id + "','" + nama + "','" + tempatlahir + "',to_date('" + tanggal + "','mm/DD/yyyy'),'" + warga + "','" + ident + "','" + noid + "','" + jenkel + "','" + alamat + "','"+hp+"','"+telp+"',to_date('" + gabung + "','mm/DD/yyyy'))";
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
    }
}
