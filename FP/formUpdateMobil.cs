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
    public partial class formUpdateMobil : Form
    {

        koneksi table;
        public DataSet ds;
        public formUpdateMobil()
        {
            InitializeComponent();
            table = new koneksi();
            ds = new DataSet();
        }

        //private void formUpdateMobil_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'dataMobil.MOBIL' table. You can move, or remove it, as needed.
        //    this.mOBILTableAdapter.Fill(this.dataMobil.MOBIL);

        //}

        private void udpateButton_Click(object sender, EventArgs e)
        {
            table.Open();
            if (comboCarGanti.Text == "TAHUN_PEMBUATAN")
            {
                string tgl = tanggalBaru2.Value.ToString("dd-MM-yyyy");
                string input = "UPDATE mobil set " + comboCarGanti.Text + "= '" + tgl + "'  WHERE ID_MOBIL = '" + textBox1.Text + "'";
                table.ExecuteNonQuery(input);
            }
            else
            {
                string input = "UPDATE mobil set " + comboCarGanti.Text + "= '" + gantiWith.Text + "' WHERE ID_MOBIL = '" + textBox1.Text + "'";
                table.ExecuteNonQuery(input);
            }
            MessageBox.Show("Data berhasil diupdate");
            table.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            table.Open();
            string input = "DELETE FROM mobil WHERE ID_MOBIL = '" + textBox2.Text + "'";
            MessageBox.Show("Data berhasil dihapus");
            table.ExecuteNonQuery(input);
            table.Close();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin min = new formMasterAdmin();
            min.Show();
        }
    }
}
