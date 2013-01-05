using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FP
{
    public partial class formLogin : Form
    {
        DataTable tabel = new DataTable();
        public formLogin()
        {
            InitializeComponent();
        }

        private void _Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string mentah = PassBox.Text;
            string password = MD5Password.EncodePassword(mentah);
            string sandi;
            string kondisi = ("SELECT password FROM pegawai WHERE username = '" + username + "'");
            int kondisi_level;

            Program.conn.Open();
            tabel = Program.conn.ExecuteDataTable(kondisi);
            int baris = tabel.Rows.Count;
            if (baris > 0)
            {
                if (tabel.Rows[0].ItemArray[0].ToString() !=null)
                {
                    sandi = tabel.Rows[0].ItemArray[0].ToString();
                    Program.conn.Close();
                    if (sandi == password){
                        kondisi = "UPDATE pegawai SET islogin = 1 WHERE username = '"+username+"' AND password = '"+password+"'";
                        Program.conn.Open();
                        Program.conn.ExecuteNonQuery(kondisi);
                        Program.conn.Close();

                        kondisi = "SELECT flag_level FROM pegawai WHERE username = '" + username + "' AND password ='" + password + "'";
                        Program.conn.Open();
                        tabel = Program.conn.ExecuteDataTable(kondisi);
                        kondisi_level = int.Parse(tabel.Rows[0].ItemArray[0].ToString());

                        if (kondisi_level == 1)
                        {
                            this.Hide();
                            formMasterAdmin mimin = new formMasterAdmin();
                            mimin.Show();
                        }
                        else {
                            this.Hide();
                            formKasir kasir = new formKasir();
                            kasir.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong username or Password");
            }
               
        }

        public OracleConnection conn { get; set; }
    }
}
