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
    public partial class formInsertUser : Form
    {
        string path;
        string curfile;
        OpenFileDialog of = new OpenFileDialog();

        public formInsertUser()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
          
            string id = textBox1.Text;
            string nama = textBox2.Text;
            string alamat = richTextBox1.Text;
            string jeniskelamin = comboBox1.Text;
            string phone = textBox3.Text;
            string hand = textBox4.Text;
            string mail = textBox5.Text;
            string username = textBox6.Text;
            string password = MD5Password.EncodePassword(textBox7.Text);
            string date = dateTimePicker1.Text;
            string jabatan = comboBox2.Text; 
            string level = comboBox3.Text;
            string login = comboBox4.Text;


            Program.conn.Open();

            string fileGambar = of.FileName;
            byte[] blob = Program.getBlobImage(fileGambar);
            Program.conn.ExecuteBlobQuery("INSERT INTO pegawai (FOTO_PEGAWAI) VALUES(:PARAM1)", "PARAM1", blob);

            string input = "INSERT INTO pegawai (ID_NIP_PEGAWAI,NAMA_PEGAWAI,ALAMAT_PEGAWAI,JK,NO_TELP_PEGAWAI,NO_HP_PEGAWAI,EMAIL_PEGAWAI,USERNAME,PASSWORD,DITERIMA_KERJA,JABATAN,FLAG_LEVEL,ISLOGIN) VALUES ('"+id+"','"+nama+"','"+alamat+"','"+jeniskelamin+"','"+phone+"','"+hand+"','"+mail+"','"+username+"','"+password+"',to_date('"+date+"','mm/DD/yyyy'),'"+jabatan+"',"+level+","+login+")";
            Program.conn.ExecuteNonQuery(input);

            Program.conn.Close();
            MessageBox.Show("Data berhasil diinputkan");

            this.Close();
            formMasterAdmin amin = new formMasterAdmin();
            amin.Show();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin amin = new formMasterAdmin();
            amin.Show();
        }

    }
}
