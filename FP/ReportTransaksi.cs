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
    public partial class ReportTransaksi : Form
    {
        public ReportTransaksi()
        {
            InitializeComponent();
        }

        private void ReportTransaksi_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void _BacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            formMasterAdmin min = new formMasterAdmin();
            min.Show();
        }
    }
}
