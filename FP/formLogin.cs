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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void _Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Login_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
