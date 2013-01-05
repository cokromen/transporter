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
    public partial class RecordTransaksi : Form
    {
        DataTable rent = new DataTable();
        string sewa;
        public RecordTransaksi()
        {
            InitializeComponent();
        }

        private void RecordTransaksi_Load(object sender, EventArgs e)
        {
            Program.conn.Open();
            sewa = "SELECT * FROM transaksi_peminjaman";
            rent = Program.conn.ExecuteDataTable(sewa);
            int baris = rent.Rows.Count;

            dataGridView2.DataSource = rent;

            Program.conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.conn.Open();
            sewa = "SELECT * FROM transaksi_peminjaman";
            rent = Program.conn.ExecuteDataTable(sewa);
            int baris = rent.Rows.Count;

            dataGridView2.DataSource = rent;

            Program.conn.Close();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin min = new formMasterAdmin();
            min.Show();
        }
    }
}
