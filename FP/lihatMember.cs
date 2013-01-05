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
    public partial class lihatMember : Form
    {
        DataTable member = new DataTable();
        string pelanggan;
        public lihatMember()
        {
            InitializeComponent();
        }

        private void lihatMember_Load(object sender, EventArgs e)
        {
            Program.conn.Open();
            pelanggan = "SELECT * FROM pelanggan";
            member = Program.conn.ExecuteDataTable(pelanggan);
            int baris = member.Rows.Count;

            dataGridView3.DataSource = member;

            Program.conn.Close();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin min = new formMasterAdmin();
            min.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.conn.Open();
            pelanggan = "SELECT * FROM pelanggan";
            member = Program.conn.ExecuteDataTable(pelanggan);
            int baris = member.Rows.Count;

            dataGridView3.DataSource = member;

            Program.conn.Close();
        }
    }
}
