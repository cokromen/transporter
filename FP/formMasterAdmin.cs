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
    public partial class formMasterAdmin : Form
    {
        public formMasterAdmin()
        {
            InitializeComponent();
        }

        private void _Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin login = new formLogin();
            login.Show();
        }
    }
}
