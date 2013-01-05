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
    public partial class TransaksiPenyewaan : Form
    {
        koneksi table;
        public DataSet ds;
        public TransaksiPenyewaan()
        {
            InitializeComponent();
            table = new koneksi();
            ds = new DataSet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tgl_pinjam = dateTimePicker1.Text;
            string tgl_kembali = dateTimePicker2.Text;
            //int total = (dateTimePicker2.Value.DayOfYear - dateTimePicker1.Value.DayOfYear) * 10000;
           // string biaya = total.ToString();

            MessageBox.Show("Transaksi Berhasil");

            DataTable dt = new DataTable();
            table.Open();
            string input = "insert into transaksi_peminjaman values ('"
                + textBox1.Text + "','"
                + textBox2.Text + "','"
                + textBox8.Text + "','"
                + textBox3.Text + "','"
                + textBox7.Text + "',to_date('"
                + tgl_pinjam + "','mm/DD/yyyy'),'"
                + textBox6.Text + "','"
                + textBox5.Text + "',to_date('"
                + tgl_kembali + "','mm/DD/yyyy'),'"
                + comboBox1.Text +
                "')";
            table.ExecuteNonQuery(input);
            table.Close();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formKasir kas = new formKasir();
            kas.Show();
        }
    }
}
