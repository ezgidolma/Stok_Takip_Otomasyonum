namespace Stok_Takip_Ot
{
    partial class frmÜrünListele
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
            this.label15 = new System.Windows.Forms.Label();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.ÜrünAdıtxt = new System.Windows.Forms.TextBox();
            this.Miktarıtxt = new System.Windows.Forms.TextBox();
            this.AlışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.SatışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.MarkaGüncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(482, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(64, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 32;
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(58, 384);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 16);
            this.lblMiktari.TabIndex = 31;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(137, 384);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(86, 28);
            this.btnGüncelle.TabIndex = 19;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(123, 111);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 22);
            this.BarkodNotxt.TabIndex = 30;
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(123, 148);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(100, 22);
            this.Kategoritxt.TabIndex = 29;
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(123, 185);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(100, 22);
            this.Markatxt.TabIndex = 28;
            this.Markatxt.TextChanged += new System.EventHandler(this.Markatxt_TextChanged);
            // 
            // ÜrünAdıtxt
            // 
            this.ÜrünAdıtxt.Location = new System.Drawing.Point(123, 222);
            this.ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            this.ÜrünAdıtxt.Size = new System.Drawing.Size(100, 22);
            this.ÜrünAdıtxt.TabIndex = 27;
            // 
            // Miktarıtxt
            // 
            this.Miktarıtxt.Location = new System.Drawing.Point(123, 259);
            this.Miktarıtxt.Name = "Miktarıtxt";
            this.Miktarıtxt.Size = new System.Drawing.Size(100, 22);
            this.Miktarıtxt.TabIndex = 26;
            // 
            // AlışFiyatıtxt
            // 
            this.AlışFiyatıtxt.Location = new System.Drawing.Point(123, 296);
            this.AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            this.AlışFiyatıtxt.Size = new System.Drawing.Size(100, 22);
            this.AlışFiyatıtxt.TabIndex = 25;
            // 
            // SatışFiyatıtxt
            // 
            this.SatışFiyatıtxt.Location = new System.Drawing.Point(123, 333);
            this.SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            this.SatışFiyatıtxt.Size = new System.Drawing.Size(100, 22);
            this.SatışFiyatıtxt.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Satış Fiyatı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Alış Fiyatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ürün Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Barkod No";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(757, 111);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(584, 57);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(100, 22);
            this.txtBarkodNoAra.TabIndex = 34;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "BarkodNo\'ya Göre Ara";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(307, 460);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(121, 24);
            this.comboKategori.TabIndex = 36;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(307, 504);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 24);
            this.comboMarka.TabIndex = 37;
            // 
            // MarkaGüncelle
            // 
            this.MarkaGüncelle.Location = new System.Drawing.Point(449, 460);
            this.MarkaGüncelle.Name = "MarkaGüncelle";
            this.MarkaGüncelle.Size = new System.Drawing.Size(86, 68);
            this.MarkaGüncelle.TabIndex = 38;
            this.MarkaGüncelle.Text = "Marka Güncelle";
            this.MarkaGüncelle.UseVisualStyleBackColor = true;
            this.MarkaGüncelle.Click += new System.EventHandler(this.MarkaGüncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kategori";
            // 
            // frmÜrünListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarkaGüncelle);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblMiktari);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.BarkodNotxt);
            this.Controls.Add(this.Kategoritxt);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.ÜrünAdıtxt);
            this.Controls.Add(this.Miktarıtxt);
            this.Controls.Add(this.AlışFiyatıtxt);
            this.Controls.Add(this.SatışFiyatıtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmÜrünListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmÜrünListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMiktari;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox ÜrünAdıtxt;
        private System.Windows.Forms.TextBox Miktarıtxt;
        private System.Windows.Forms.TextBox AlışFiyatıtxt;
        private System.Windows.Forms.TextBox SatışFiyatıtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Button MarkaGüncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}