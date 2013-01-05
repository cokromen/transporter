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
    public partial class FormUpdateMember : Form
    {
        koneksi table;
        public DataSet ds;
        public FormUpdateMember()
        {
            InitializeComponent();
            table = new koneksi();
            ds = new DataSet();
        }

        private void udpateButton_Click(object sender, EventArgs e)
        {
            table.Open();
            if (comboMemberGanti.Text == "TanggalLahir")
            {
                string tgl = tanggalBaru.Value.ToString("dd-MM-yyyy");
                string input = "UPDATE pelanggan set " + comboMemberGanti.Text + "= '" + tgl + "'  WHERE ID_LANGGAN = '" + textBox1.Text + "'";
                table.ExecuteNonQuery(input);
            }
            else
            {
                string input = "UPDATE pelanggan set " + comboMemberGanti.Text + "= '" + gantiDengan.Text + "' WHERE ID_LANGGAN = '" + textBox1.Text + "'";
                table.ExecuteNonQuery(input);
            }
            MessageBox.Show("Data berhasil diupdate");
            table.Close();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin min = new formMasterAdmin();
            min.Show();
        }

        private void _BacktoMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin min = new formMasterAdmin();
            min.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            table.Open();
            string input = "DELETE FROM pelanggan WHERE ID_LANGGAN = '" + textBox2.Text + "'";
            MessageBox.Show("Data berhasil dihapus");
            table.ExecuteNonQuery(input);
            table.Close();
        }

    }
}
