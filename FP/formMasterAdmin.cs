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
        DataTable tabel = new DataTable();
        //string statement;
      //  string user;

        public formMasterAdmin()
        {
            InitializeComponent();
        }

        private void _Logout_Click(object sender, EventArgs e)
        {
            //Program.conn.Open();
            //statement = "SELECT username FROM pegawai WHERE islogin = 1";
           // Program.conn.ExecuteDataTable(statement);
           // user = tabel.Rows[0].ItemArray[0].ToString();
            //Program.conn.Close();

            //Program.conn.Open();
            //statement = "UPDATE pegawai SET islogin = 0 WHERE username ='" + user + "'";
           // Program.conn.ExecuteNonQuery(statement);
            //Program.conn.Close();

            this.Close();
            formLogin login = new formLogin();
            login.Show();
        }

        private void _InserCar_Click(object sender, EventArgs e)
        {
            this.Close();
            formInsertCar masukmobil = new formInsertCar();
            masukmobil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInsertUser user = new formInsertUser();
            user.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            formInsertMember mem = new formInsertMember();
            mem.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            LihatUser use = new LihatUser();
            use.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            lihatMobil lihatM = new lihatMobil();
            lihatM.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            lihatMember liatM = new lihatMember();
            liatM.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormUpdateMember memb = new FormUpdateMember();
            memb.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormUpdateUser editUser = new FormUpdateUser();
            editUser.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            formUpdateMobil car = new formUpdateMobil();
            car.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportTransaksi trans = new ReportTransaksi();
            trans.Show();
            
        }
    }
}
