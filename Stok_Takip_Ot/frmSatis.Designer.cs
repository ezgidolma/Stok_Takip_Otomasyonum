namespace Stok_Takip_Ot
{
    partial class frmSatis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtMiktarı = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSatışlarıListeleme = new System.Windows.Forms.Button();
            this.btnÜrünListeleme = new System.Windows.Forms.Button();
            this.btnÜrünEkleme = new System.Windows.Forms.Button();
            this.btnMüşteriListeleme = new System.Windows.Forms.Button();
            this.btnMüşteriEkleme = new System.Windows.Forms.Button();
            this.lblgeneltoplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Location = new System.Drawing.Point(28, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 117);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(94, 77);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(94, 37);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 0;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.txtSatışFiyatı);
            this.groupBox2.Controls.Add(this.txtMiktarı);
            this.groupBox2.Controls.Add(this.txtÜrünAdı);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Location = new System.Drawing.Point(28, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 228);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Toplam Fiyat";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Barkod No";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(94, 189);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtToplamFiyat.TabIndex = 4;
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(94, 151);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(100, 22);
            this.txtSatışFiyatı.TabIndex = 3;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // txtMiktarı
            // 
            this.txtMiktarı.Location = new System.Drawing.Point(94, 113);
            this.txtMiktarı.Name = "txtMiktarı";
            this.txtMiktarı.Size = new System.Drawing.Size(100, 22);
            this.txtMiktarı.TabIndex = 2;
            this.txtMiktarı.Text = "1";
            this.txtMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktarı.TextChanged += new System.EventHandler(this.txtMiktarı_TextChanged);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(94, 75);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünAdı.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(94, 37);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 22);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(293, 466);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 43);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.ForeColor = System.Drawing.Color.Black;
            this.btnSatışYap.Location = new System.Drawing.Point(754, 455);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(93, 43);
            this.btnSatışYap.TabIndex = 4;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = true;
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(854, 170);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 41);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.ForeColor = System.Drawing.Color.Black;
            this.btnSatışİptal.Location = new System.Drawing.Point(854, 232);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(85, 40);
            this.btnSatışİptal.TabIndex = 6;
            this.btnSatışİptal.Text = "Satış İptal";
            this.btnSatışİptal.UseVisualStyleBackColor = true;
            this.btnSatışİptal.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSatışlarıListeleme);
            this.panel1.Controls.Add(this.btnÜrünListeleme);
            this.panel1.Controls.Add(this.btnÜrünEkleme);
            this.panel1.Controls.Add(this.btnMüşteriListeleme);
            this.panel1.Controls.Add(this.btnMüşteriEkleme);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 113);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(755, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kategori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(836, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Marka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSatışlarıListeleme
            // 
            this.btnSatışlarıListeleme.ForeColor = System.Drawing.Color.Black;
            this.btnSatışlarıListeleme.Location = new System.Drawing.Point(599, 44);
            this.btnSatışlarıListeleme.Name = "btnSatışlarıListeleme";
            this.btnSatışlarıListeleme.Size = new System.Drawing.Size(150, 37);
            this.btnSatışlarıListeleme.TabIndex = 4;
            this.btnSatışlarıListeleme.Text = "Satışları Listeleme";
            this.btnSatışlarıListeleme.UseVisualStyleBackColor = true;
            this.btnSatışlarıListeleme.Click += new System.EventHandler(this.btnSatışlarıListeleme_Click);
            // 
            // btnÜrünListeleme
            // 
            this.btnÜrünListeleme.ForeColor = System.Drawing.Color.Black;
            this.btnÜrünListeleme.Location = new System.Drawing.Point(443, 44);
            this.btnÜrünListeleme.Name = "btnÜrünListeleme";
            this.btnÜrünListeleme.Size = new System.Drawing.Size(117, 37);
            this.btnÜrünListeleme.TabIndex = 3;
            this.btnÜrünListeleme.Text = "Ürün Listeleme";
            this.btnÜrünListeleme.UseVisualStyleBackColor = true;
            this.btnÜrünListeleme.Click += new System.EventHandler(this.btnÜrünListeleme_Click);
            // 
            // btnÜrünEkleme
            // 
            this.btnÜrünEkleme.ForeColor = System.Drawing.Color.Black;
            this.btnÜrünEkleme.Location = new System.Drawing.Point(321, 44);
            this.btnÜrünEkleme.Name = "btnÜrünEkleme";
            this.btnÜrünEkleme.Size = new System.Drawing.Size(117, 37);
            this.btnÜrünEkleme.TabIndex = 2;
            this.btnÜrünEkleme.Text = "Ürün Ekleme";
            this.btnÜrünEkleme.UseVisualStyleBackColor = true;
            this.btnÜrünEkleme.Click += new System.EventHandler(this.btnÜrünEkleme_Click);
            // 
            // btnMüşteriListeleme
            // 
            this.btnMüşteriListeleme.ForeColor = System.Drawing.Color.Black;
            this.btnMüşteriListeleme.Location = new System.Drawing.Point(149, 44);
            this.btnMüşteriListeleme.Name = "btnMüşteriListeleme";
            this.btnMüşteriListeleme.Size = new System.Drawing.Size(141, 37);
            this.btnMüşteriListeleme.TabIndex = 1;
            this.btnMüşteriListeleme.Text = "Müşteri Listeleme";
            this.btnMüşteriListeleme.UseVisualStyleBackColor = true;
            this.btnMüşteriListeleme.Click += new System.EventHandler(this.btnMüşteriListeleme_Click);
            // 
            // btnMüşteriEkleme
            // 
            this.btnMüşteriEkleme.ForeColor = System.Drawing.Color.Black;
            this.btnMüşteriEkleme.Location = new System.Drawing.Point(26, 44);
            this.btnMüşteriEkleme.Name = "btnMüşteriEkleme";
            this.btnMüşteriEkleme.Size = new System.Drawing.Size(117, 37);
            this.btnMüşteriEkleme.TabIndex = 0;
            this.btnMüşteriEkleme.Text = "Müşteri Ekleme";
            this.btnMüşteriEkleme.UseVisualStyleBackColor = true;
            this.btnMüşteriEkleme.Click += new System.EventHandler(this.btnMüşteriEkleme_Click);
            // 
            // lblgeneltoplam
            // 
            this.lblgeneltoplam.AutoSize = true;
            this.lblgeneltoplam.Location = new System.Drawing.Point(517, 482);
            this.lblgeneltoplam.Name = "lblgeneltoplam";
            this.lblgeneltoplam.Size = new System.Drawing.Size(93, 16);
            this.lblgeneltoplam.TabIndex = 9;
            this.lblgeneltoplam.Text = "Genel Toplam";
            // 
            // frmSatis
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 572);
            this.Controls.Add(this.lblgeneltoplam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtMiktarı;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatışİptal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatışlarıListeleme;
        private System.Windows.Forms.Button btnÜrünListeleme;
        private System.Windows.Forms.Button btnÜrünEkleme;
        private System.Windows.Forms.Button btnMüşteriListeleme;
        private System.Windows.Forms.Button btnMüşteriEkleme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblgeneltoplam;
    }
}

