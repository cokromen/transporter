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
    public partial class FormUpdateUser : Form
    {
        koneksi table;
        public DataSet ds;
        public FormUpdateUser()
        {
            InitializeComponent();
            table = new koneksi();
            ds = new DataSet();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin amin = new formMasterAdmin();
            amin.Show();
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataUser.PEGAWAI' table. You can move, or remove it, as needed.
            this.pEGAWAITableAdapter.Fill(this.dataUser.PEGAWAI);

        }

        private void udpateButton_Click(object sender, EventArgs e)
        {
            table.Open();
            if (comboCarGanti.Text == "DITERIMA_KERJA")
            {
                string tgl = tanggalBaru2.Value.ToString("dd-MM-yyyy");
                string input = "UPDATE pegawai set " + comboCarGanti.Text + "= '" + tgl + "'  WHERE username = '" + comboCar.Text + "'";
                table.ExecuteNonQuery(input);
            }
            else
            {
                string input = "UPDATE pegawai set " + comboCarGanti.Text + "= '" + gantiWith.Text + "' WHERE username = '" + comboCar.Text + "'";
                table.ExecuteNonQuery(input);
            }
            MessageBox.Show("Data berhasil diupdate");
            table.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            table.Open();
            string input = "DELETE FROM pegawai WHERE username = '" + carCombo.Text + "'";
            MessageBox.Show("Data berhasil dihapus");
            table.ExecuteNonQuery(input);
            table.Close();
        }
    }
}
