using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Akhir
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Error : UserName dan Password tidak boleh kosong");
            }
            else if (UserName.Text == "")
            {
                MessageBox.Show("Error : UserName tidak boleh kosong");
            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Error : Password tidak boleh kosong");
            }
            else
            {
                if (UserName.Text == "21120118130080" && Password.Text == "admin")
                {
                    MessageBox.Show("Login sukses");
                    Form1 utama = new Form1();
                    utama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("UserName atau Password salah!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}