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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Tujuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Waktu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int menit;
            int detik;
            int biaya;
            int total;

            if (Opr.SelectedIndex == 0)
            {
                if (Tujuan.SelectedIndex == 0)
                {
                    if (Waktu.SelectedIndex == 0)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(18);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                    else if (Waktu.SelectedIndex == 1)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(16);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                }
                if (Tujuan.SelectedIndex == 1)
                {
                    if (Waktu.SelectedIndex == 0)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(22);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                    else if (Waktu.SelectedIndex == 1)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(20);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih."; ;
                    }
                }
            }
            if (Opr.SelectedIndex == 1)
            {
                if (Tujuan.SelectedIndex == 0)
                {
                    if (Waktu.SelectedIndex == 0)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(15);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                    else if (Waktu.SelectedIndex == 1)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(13);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                }
                if (Tujuan.SelectedIndex == 1)
                {
                    if (Waktu.SelectedIndex == 0)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(17);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                    else if (Waktu.SelectedIndex == 1)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(16);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                }
            }
            if (Opr.SelectedIndex == 2)
            {
                if (Tujuan.SelectedIndex == 0)
                {
                    if (Waktu.SelectedIndex == 0)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(12);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                    else if (Waktu.SelectedIndex == 1)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(9);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                }
                if (Tujuan.SelectedIndex == 1)
                {
                    if (Waktu.SelectedIndex == 0)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(14);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                    else if (Waktu.SelectedIndex == 1)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(10);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                }
            }
            if (Opr.SelectedIndex == 3)
            {
                if (Tujuan.SelectedIndex == 0)
                {
                    if (Waktu.SelectedIndex == 0)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(8);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                    else if (Waktu.SelectedIndex == 1)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(6);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                }
                if (Tujuan.SelectedIndex == 1)
                {
                    if (Waktu.SelectedIndex == 0)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(11);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                    else if (Waktu.SelectedIndex == 1)
                    {
                        Data objek = new Tugas_Akhir.Data();
                        menit = Convert.ToInt16(Menit.Text);
                        detik = Convert.ToInt16(Detik.Text);
                        objek.setBiaya(9);
                        biaya = objek.getBiaya();
                        objek.setTotal(biaya * ((menit * 60) + detik));
                        total = objek.getTotal();

                        TotalBiaya.Text = "Total biaya panggilan Anda selama " + menit + " menit " + detik + " detik adalah " + total + " rupiah. Terima Kasih.";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opr.Text = "--Silahkan Pilih--";
            Tujuan.Text = "--Silahkan Pilih--";
            Waktu.Text = "--Silahkan Pilih--";
            Menit.Text = "0";
            Detik.Text = "0";
            Telkomsel.Checked = false;
            Indosat.Checked = false;
            XL.Checked = false;
            Three.Checked = false;
            Informasi.Text = "--Informasi--";
            TotalBiaya.Text = "--Silahkan klik tombol Hitung--";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Opsi;
            Opsi = MessageBox.Show("Apakah Anda Ingin Keluar?", "Pilihan", MessageBoxButtons.YesNo);

            if (Opsi == DialogResult.Yes)
            {
                Opsi = MessageBox.Show("Terima kasih telah menggunakan program ini", "Terima Kasih");

                if (Opsi == DialogResult.OK)
                    Application.Exit();
            }
        }

        private void Telkomsel_CheckedChanged(object sender, EventArgs e)
        {
            Informasi.Text =
            "Ke Sesama Operator (00.00 - 16.59) : 18 (17.00 - 23.59) : 16 Ke Operator Lain (00.00 - 16.59) : 22 (17.00 - 23.59) : 20";
        }

        private void Indosat_CheckedChanged(object sender, EventArgs e)
        {
            Informasi.Text = 
            "Ke Sesama Operator (00.00 - 16.59) : 15 (17.00 - 23.59) : 13 Ke Operator Lain \n(00.00 - 16.59) : 17 (17.00 - 23.59) : 16";
        }

        private void XL_CheckedChanged(object sender, EventArgs e)
        {
            Informasi.Text =
            "Ke Sesama Operator (00.00 - 16.59) : 12 (17.00 - 23.59) : 9   Ke Operator Lain (00.00 - 16.59) : 14 (17.00 - 23.59) : 10";
        }

        private void Three_CheckedChanged(object sender, EventArgs e)
        {
            Informasi.Text =
            "Ke Sesama Operator (00.00 - 16.59) : 8  (17.00 - 23.59) : 6   Ke Operator Lain (00.00 - 16.59) : 11 (17.00 - 23.59) : 9";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}