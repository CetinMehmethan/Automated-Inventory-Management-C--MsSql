namespace TezProje
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioUrunAdi = new System.Windows.Forms.RadioButton();
            this.radioStokKodu = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategoriTabloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stok2DataSet2 = new TezProje.Stok2DataSet2();
            this.kategoriTabloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKategoriNo = new System.Windows.Forms.TextBox();
            this.txtKalanMiktar = new System.Windows.Forms.TextBox();
            this.txtStokAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stok2DataSet1 = new TezProje.Stok2DataSet1();
            this.kategoriTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriTabloTableAdapter = new TezProje.Stok2DataSet1TableAdapters.KategoriTabloTableAdapter();
            this.satıcıTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satıcıTabloTableAdapter = new TezProje.Stok2DataSet1TableAdapters.SatıcıTabloTableAdapter();
            this.satıcıTabloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.satıcıTabloTableAdapter1 = new TezProje.Stok2DataSet2TableAdapters.SatıcıTabloTableAdapter();
            this.kategoriTabloTableAdapter1 = new TezProje.Stok2DataSet2TableAdapters.KategoriTabloTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabloBindingSource2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıcıTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıcıTabloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(517, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Seçenekleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioUrunAdi);
            this.groupBox3.Controls.Add(this.radioStokKodu);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(191, 98);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama Kriteri";
            // 
            // radioUrunAdi
            // 
            this.radioUrunAdi.AutoSize = true;
            this.radioUrunAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioUrunAdi.Location = new System.Drawing.Point(4, 52);
            this.radioUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.radioUrunAdi.Name = "radioUrunAdi";
            this.radioUrunAdi.Size = new System.Drawing.Size(101, 26);
            this.radioUrunAdi.TabIndex = 2;
            this.radioUrunAdi.TabStop = true;
            this.radioUrunAdi.Text = "Ürün Adı";
            this.radioUrunAdi.UseVisualStyleBackColor = true;
            // 
            // radioStokKodu
            // 
            this.radioStokKodu.AutoSize = true;
            this.radioStokKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioStokKodu.Location = new System.Drawing.Point(4, 26);
            this.radioStokKodu.Margin = new System.Windows.Forms.Padding(2);
            this.radioStokKodu.Name = "radioStokKodu";
            this.radioStokKodu.Size = new System.Drawing.Size(115, 26);
            this.radioStokKodu.TabIndex = 0;
            this.radioStokKodu.TabStop = true;
            this.radioStokKodu.Text = "Stok Kodu";
            this.radioStokKodu.UseVisualStyleBackColor = true;
            this.radioStokKodu.CheckedChanged += new System.EventHandler(this.radioStokKodu_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 18F);
            this.button2.Location = new System.Drawing.Point(328, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "STOK ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(220, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(234, 83);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kategoriTabloBindingSource1, "KategoriNO", true));
            this.comboBox1.DataSource = this.kategoriTabloBindingSource2;
            this.comboBox1.DisplayMember = "Kategori";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 30);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "KategoriNO";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kategoriTabloBindingSource1
            // 
            this.kategoriTabloBindingSource1.DataMember = "KategoriTablo";
            this.kategoriTabloBindingSource1.DataSource = this.stok2DataSet2;
            // 
            // stok2DataSet2
            // 
            this.stok2DataSet2.DataSetName = "Stok2DataSet2";
            this.stok2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriTabloBindingSource2
            // 
            this.kategoriTabloBindingSource2.DataMember = "KategoriTablo";
            this.kategoriTabloBindingSource2.DataSource = this.stok2DataSet2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(14, 24);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(204, 26);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Seçili Kategoride Ara";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(297, 150);
            this.txtAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(189, 24);
            this.txtAra.TabIndex = 5;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtStokKod);
            this.groupBox4.Controls.Add(this.txtAlisFiyati);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtSatisFiyati);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtKategoriNo);
            this.groupBox4.Controls.Add(this.txtKalanMiktar);
            this.groupBox4.Controls.Add(this.txtStokAd);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(630, 42);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(330, 173);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilgiler";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtStokKod
            // 
            this.txtStokKod.Location = new System.Drawing.Point(154, 25);
            this.txtStokKod.Margin = new System.Windows.Forms.Padding(2);
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.Size = new System.Drawing.Size(164, 20);
            this.txtStokKod.TabIndex = 18;
            this.txtStokKod.TextChanged += new System.EventHandler(this.txtStokKod_TextChanged);
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(154, 138);
            this.txtAlisFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(164, 20);
            this.txtAlisFiyati.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(19, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Alış Fiyatı :";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(154, 116);
            this.txtSatisFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(164, 20);
            this.txtSatisFiyati.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(19, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Satış Fiyatı :";
            // 
            // txtKategoriNo
            // 
            this.txtKategoriNo.Location = new System.Drawing.Point(154, 93);
            this.txtKategoriNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategoriNo.Name = "txtKategoriNo";
            this.txtKategoriNo.Size = new System.Drawing.Size(164, 20);
            this.txtKategoriNo.TabIndex = 11;
            // 
            // txtKalanMiktar
            // 
            this.txtKalanMiktar.Location = new System.Drawing.Point(154, 69);
            this.txtKalanMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.txtKalanMiktar.Name = "txtKalanMiktar";
            this.txtKalanMiktar.Size = new System.Drawing.Size(164, 20);
            this.txtKalanMiktar.TabIndex = 8;
            // 
            // txtStokAd
            // 
            this.txtStokAd.Location = new System.Drawing.Point(154, 47);
            this.txtStokAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Size = new System.Drawing.Size(164, 20);
            this.txtStokAd.TabIndex = 7;
            this.txtStokAd.TextChanged += new System.EventHandler(this.txtStokAd_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label8.Location = new System.Drawing.Point(19, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kategori No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(19, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kalan Miktar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stok Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stok Kodu :";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(784, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 42);
            this.button4.TabIndex = 20;
            this.button4.Text = "STOK SİL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Impact", 18F);
            this.button5.Location = new System.Drawing.Point(630, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 42);
            this.button5.TabIndex = 21;
            this.button5.Text = "STOK DÜZELT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Impact", 18F);
            this.button6.Location = new System.Drawing.Point(784, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 42);
            this.button6.TabIndex = 22;
            this.button6.Text = "YENİ STOK ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 18F);
            this.button1.Location = new System.Drawing.Point(621, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 42);
            this.button1.TabIndex = 24;
            this.button1.Text = "KULLANICILAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stok2DataSet1
            // 
            this.stok2DataSet1.DataSetName = "Stok2DataSet1";
            this.stok2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriTabloBindingSource
            // 
            this.kategoriTabloBindingSource.DataMember = "KategoriTablo";
            this.kategoriTabloBindingSource.DataSource = this.stok2DataSet1;
            // 
            // kategoriTabloTableAdapter
            // 
            this.kategoriTabloTableAdapter.ClearBeforeFill = true;
            // 
            // satıcıTabloBindingSource
            // 
            this.satıcıTabloBindingSource.DataMember = "SatıcıTablo";
            this.satıcıTabloBindingSource.DataSource = this.stok2DataSet1;
            // 
            // satıcıTabloTableAdapter
            // 
            this.satıcıTabloTableAdapter.ClearBeforeFill = true;
            // 
            // satıcıTabloBindingSource1
            // 
            this.satıcıTabloBindingSource1.DataMember = "SatıcıTablo";
            this.satıcıTabloBindingSource1.DataSource = this.stok2DataSet2;
            // 
            // satıcıTabloTableAdapter1
            // 
            this.satıcıTabloTableAdapter1.ClearBeforeFill = true;
            // 
            // kategoriTabloTableAdapter1
            // 
            this.kategoriTabloTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 208);
            this.dataGridView1.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 18F);
            this.button3.Location = new System.Drawing.Point(455, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 42);
            this.button3.TabIndex = 26;
            this.button3.Text = "ÜRÜN LİSTELE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Impact", 18F);
            this.button7.Location = new System.Drawing.Point(289, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 42);
            this.button7.TabIndex = 27;
            this.button7.Text = "MUHASEBE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaSayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabloBindingSource2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıcıTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıcıTabloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioUrunAdi;
        private System.Windows.Forms.RadioButton radioStokKodu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKategoriNo;
        private System.Windows.Forms.TextBox txtKalanMiktar;
        private System.Windows.Forms.TextBox txtStokAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Stok2DataSet1 stok2DataSet1;
        private System.Windows.Forms.BindingSource kategoriTabloBindingSource;
        private Stok2DataSet1TableAdapters.KategoriTabloTableAdapter kategoriTabloTableAdapter;
        private System.Windows.Forms.TextBox txtStokKod;
        private System.Windows.Forms.BindingSource satıcıTabloBindingSource;
        private Stok2DataSet1TableAdapters.SatıcıTabloTableAdapter satıcıTabloTableAdapter;
        private Stok2DataSet2 stok2DataSet2;
        private System.Windows.Forms.BindingSource satıcıTabloBindingSource1;
        private Stok2DataSet2TableAdapters.SatıcıTabloTableAdapter satıcıTabloTableAdapter1;
        private System.Windows.Forms.BindingSource kategoriTabloBindingSource1;
        private Stok2DataSet2TableAdapters.KategoriTabloTableAdapter kategoriTabloTableAdapter1;
        private System.Windows.Forms.BindingSource kategoriTabloBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
    }
}

