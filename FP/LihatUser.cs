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
    public partial class LihatUser : Form
    {
        public LihatUser()
        {
            InitializeComponent();
        }

        private void LihatUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataUser.PEGAWAI' table. You can move, or remove it, as needed.
            this.pEGAWAITableAdapter.Fill(this.dataUser.PEGAWAI);

        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin min = new formMasterAdmin();
            min.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
