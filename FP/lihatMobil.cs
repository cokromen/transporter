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
    public partial class lihatMobil : Form
    {
        DataTable car = new DataTable();
        string mobil;
        //string proses;

        public lihatMobil()
        {
           
            InitializeComponent();
            
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
            mobil = "SELECT * FROM mobil";
            car = Program.conn.ExecuteDataTable(mobil);
            int baris = car.Rows.Count;

            dataGridView2.DataSource = car;

            Program.conn.Close();
           
        }

        private void lihatMobil_Load(object sender, EventArgs e)
        {
            Program.conn.Open();
            mobil = "SELECT * FROM mobil";
            car = Program.conn.ExecuteDataTable(mobil);
            int baris = car.Rows.Count;

            dataGridView2.DataSource = car;

            Program.conn.Close();
        }

    }
}
