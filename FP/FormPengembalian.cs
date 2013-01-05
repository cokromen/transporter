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
    public partial class FormPengembalian : Form
    {
        koneksi table;
        public DataSet ds;
        public FormPengembalian()
        {
            InitializeComponent();
            table = new koneksi();
            ds = new DataSet();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string tgl_pinjam = dateTimePicker1.Text;
            string tgl_kembali = dateTimePicker1.Text;
            //int total = (dateTimePicker2.Value.DayOfYear - dateTimePicker1.Value.DayOfYear) * 10000;
            // string biaya = total.ToString();

            MessageBox.Show("Transaksi Berhasil");

            DataTable dt = new DataTable();
            table.Open();
            string input = "insert into transaksi_pengembalian values ('"
                + textBox1.Text + "','"
                + textBox2.Text + "',to_date('"
                + tgl_kembali + "','mm/DD/yyyy'),'"
                + textBox3.Text +
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
