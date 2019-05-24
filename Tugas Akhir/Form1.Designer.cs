namespace Tugas_Akhir
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Opr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tujuan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Waktu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Hitung = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalBiaya = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Menit = new System.Windows.Forms.NumericUpDown();
            this.Detik = new System.Windows.Forms.NumericUpDown();
            this.Telkomsel = new System.Windows.Forms.RadioButton();
            this.Indosat = new System.Windows.Forms.RadioButton();
            this.XL = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.Informasi = new System.Windows.Forms.TextBox();
            this.Three = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Menit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(176, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perhitungan Biaya Panggilan Telepon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Opr
            // 
            this.Opr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Opr.FormattingEnabled = true;
            this.Opr.Items.AddRange(new object[] {
            "Telkomsel",
            "Indosat",
            "XL",
            "Three"});
            this.Opr.Location = new System.Drawing.Point(807, 164);
            this.Opr.Name = "Opr";
            this.Opr.Size = new System.Drawing.Size(171, 24);
            this.Opr.TabIndex = 2;
            this.Opr.Text = "--Silahkan Pilih--";
            this.Opr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(616, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lama Panggilan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(984, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "detik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(616, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tujuan Panggilan";
            // 
            // Tujuan
            // 
            this.Tujuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tujuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tujuan.FormattingEnabled = true;
            this.Tujuan.Items.AddRange(new object[] {
            "Ke Sesama Operator",
            "Ke Operator Lain"});
            this.Tujuan.Location = new System.Drawing.Point(807, 207);
            this.Tujuan.Name = "Tujuan";
            this.Tujuan.Size = new System.Drawing.Size(171, 24);
            this.Tujuan.TabIndex = 7;
            this.Tujuan.Text = "--Silahkan Pilih--";
            this.Tujuan.SelectedIndexChanged += new System.EventHandler(this.Tujuan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(616, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Waktu Panggilan";
            // 
            // Waktu
            // 
            this.Waktu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Waktu.FormattingEnabled = true;
            this.Waktu.Items.AddRange(new object[] {
            "00.00 - 16.59",
            "17.00 - 23.59"});
            this.Waktu.Location = new System.Drawing.Point(807, 248);
            this.Waktu.Name = "Waktu";
            this.Waktu.Size = new System.Drawing.Size(171, 24);
            this.Waktu.TabIndex = 9;
            this.Waktu.Text = "--Silahkan Pilih--";
            this.Waktu.SelectedIndexChanged += new System.EventHandler(this.Waktu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(871, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "menit";
            // 
            // Hitung
            // 
            this.Hitung.BackColor = System.Drawing.Color.Transparent;
            this.Hitung.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Hitung.FlatAppearance.BorderSize = 3;
            this.Hitung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Hitung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Hitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hitung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Hitung.Location = new System.Drawing.Point(807, 344);
            this.Hitung.Name = "Hitung";
            this.Hitung.Size = new System.Drawing.Size(193, 59);
            this.Hitung.TabIndex = 12;
            this.Hitung.Text = "Hitung Biaya";
            this.Hitung.UseVisualStyleBackColor = false;
            this.Hitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(616, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Biaya";
            // 
            // TotalBiaya
            // 
            this.TotalBiaya.BackColor = System.Drawing.Color.Beige;
            this.TotalBiaya.Location = new System.Drawing.Point(807, 423);
            this.TotalBiaya.Multiline = true;
            this.TotalBiaya.Name = "TotalBiaya";
            this.TotalBiaya.ReadOnly = true;
            this.TotalBiaya.Size = new System.Drawing.Size(193, 79);
            this.TotalBiaya.TabIndex = 17;
            this.TotalBiaya.Text = "--Silahkan klik tombol Hitung--";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(23, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.ForestGreen;
            this.button3.Location = new System.Drawing.Point(893, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 48);
            this.button3.TabIndex = 21;
            this.button3.Text = "Keluar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(616, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pilih Operator";
            // 
            // Menit
            // 
            this.Menit.Location = new System.Drawing.Point(807, 288);
            this.Menit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Menit.Name = "Menit";
            this.Menit.Size = new System.Drawing.Size(58, 22);
            this.Menit.TabIndex = 26;
            // 
            // Detik
            // 
            this.Detik.Location = new System.Drawing.Point(924, 287);
            this.Detik.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Detik.Name = "Detik";
            this.Detik.Size = new System.Drawing.Size(54, 22);
            this.Detik.TabIndex = 27;
            // 
            // Telkomsel
            // 
            this.Telkomsel.AutoSize = true;
            this.Telkomsel.BackColor = System.Drawing.Color.Transparent;
            this.Telkomsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telkomsel.ForeColor = System.Drawing.Color.Lime;
            this.Telkomsel.Location = new System.Drawing.Point(320, 205);
            this.Telkomsel.Name = "Telkomsel";
            this.Telkomsel.Size = new System.Drawing.Size(102, 21);
            this.Telkomsel.TabIndex = 28;
            this.Telkomsel.Text = "Telkomsel";
            this.Telkomsel.UseVisualStyleBackColor = false;
            this.Telkomsel.CheckedChanged += new System.EventHandler(this.Telkomsel_CheckedChanged);
            // 
            // Indosat
            // 
            this.Indosat.AutoSize = true;
            this.Indosat.BackColor = System.Drawing.Color.Transparent;
            this.Indosat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indosat.ForeColor = System.Drawing.Color.Blue;
            this.Indosat.Location = new System.Drawing.Point(320, 246);
            this.Indosat.Name = "Indosat";
            this.Indosat.Size = new System.Drawing.Size(82, 21);
            this.Indosat.TabIndex = 29;
            this.Indosat.Text = "Indosat";
            this.Indosat.UseVisualStyleBackColor = false;
            this.Indosat.CheckedChanged += new System.EventHandler(this.Indosat_CheckedChanged);
            // 
            // XL
            // 
            this.XL.AutoSize = true;
            this.XL.BackColor = System.Drawing.Color.Transparent;
            this.XL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XL.ForeColor = System.Drawing.Color.Yellow;
            this.XL.Location = new System.Drawing.Point(320, 284);
            this.XL.Name = "XL";
            this.XL.Size = new System.Drawing.Size(48, 21);
            this.XL.TabIndex = 30;
            this.XL.Text = "XL";
            this.XL.UseVisualStyleBackColor = false;
            this.XL.CheckedChanged += new System.EventHandler(this.XL_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(267, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(277, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "Lihat Biaya Panggilan Per Detik";
            // 
            // Informasi
            // 
            this.Informasi.BackColor = System.Drawing.Color.Beige;
            this.Informasi.Location = new System.Drawing.Point(320, 372);
            this.Informasi.Multiline = true;
            this.Informasi.Name = "Informasi";
            this.Informasi.ReadOnly = true;
            this.Informasi.Size = new System.Drawing.Size(145, 111);
            this.Informasi.TabIndex = 32;
            this.Informasi.Text = "--Informasi--";
            // 
            // Three
            // 
            this.Three.AutoSize = true;
            this.Three.BackColor = System.Drawing.Color.Transparent;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Three.Location = new System.Drawing.Point(320, 326);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(72, 21);
            this.Three.TabIndex = 33;
            this.Three.Text = "Three";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.CheckedChanged += new System.EventHandler(this.Three_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(36, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 180);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.XL);
            this.Controls.Add(this.Informasi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Indosat);
            this.Controls.Add(this.Telkomsel);
            this.Controls.Add(this.Detik);
            this.Controls.Add(this.Menit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotalBiaya);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Waktu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tujuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Opr);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Perhitungan Biaya Panggilan Telepon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Menit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Tujuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Waktu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Hitung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Opr;
        public System.Windows.Forms.NumericUpDown Menit;
        public System.Windows.Forms.TextBox TotalBiaya;
        public System.Windows.Forms.NumericUpDown Detik;
        private System.Windows.Forms.RadioButton Telkomsel;
        private System.Windows.Forms.RadioButton Indosat;
        private System.Windows.Forms.RadioButton XL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Informasi;
        private System.Windows.Forms.RadioButton Three;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

