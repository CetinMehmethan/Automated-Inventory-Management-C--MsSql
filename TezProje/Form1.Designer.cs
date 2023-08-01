namespace TezProje
{
    partial class islem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(islem));
            this.txtMal = new System.Windows.Forms.TextBox();
            this.txtToplamB = new System.Windows.Forms.TextBox();
            this.txtKalanB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok2DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok2DataSet3 = new TezProje.Stok2DataSet3();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.kullanicilarTableAdapter = new TezProje.Stok2DataSet3TableAdapters.KullanicilarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.islemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alınanMalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTabloBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stok2DataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok2DataSet4 = new TezProje.Stok2DataSet4();
            this.islemTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.islemTabloTableAdapter = new TezProje.Stok2DataSet3TableAdapters.islemTabloTableAdapter();
            this.kullanicilarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.islemTabloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.islemTabloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.islemTabloTableAdapter1 = new TezProje.Stok2DataSet4TableAdapters.islemTabloTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ıslem1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemTabloBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemTabloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemTabloBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMal
            // 
            this.txtMal.Location = new System.Drawing.Point(532, 55);
            this.txtMal.Name = "txtMal";
            this.txtMal.Size = new System.Drawing.Size(204, 20);
            this.txtMal.TabIndex = 0;
            this.txtMal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtToplamB
            // 
            this.txtToplamB.Location = new System.Drawing.Point(532, 90);
            this.txtToplamB.Name = "txtToplamB";
            this.txtToplamB.Size = new System.Drawing.Size(204, 20);
            this.txtToplamB.TabIndex = 1;
            // 
            // txtKalanB
            // 
            this.txtKalanB.Location = new System.Drawing.Point(532, 129);
            this.txtKalanB.Name = "txtKalanB";
            this.txtKalanB.Size = new System.Drawing.Size(204, 20);
            this.txtKalanB.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kullanicilarBindingSource, "KullaniciID", true));
            this.comboBox1.DataSource = this.kullanicilarBindingSource;
            this.comboBox1.DisplayMember = "Ad";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(532, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "KullaniciID";
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "Kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.stok2DataSet3BindingSource;
            // 
            // stok2DataSet3BindingSource
            // 
            this.stok2DataSet3BindingSource.DataSource = this.stok2DataSet3;
            this.stok2DataSet3BindingSource.Position = 0;
            // 
            // stok2DataSet3
            // 
            this.stok2DataSet3.DataSetName = "Stok2DataSet3";
            this.stok2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(438, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(411, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alınan Mal  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(411, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kalan Borç  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(396, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam Borç  :";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Impact", 18F);
            this.button6.Location = new System.Drawing.Point(576, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 42);
            this.button6.TabIndex = 23;
            this.button6.Text = "KAYDET";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemIDDataGridViewTextBoxColumn,
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.alınanMalDataGridViewTextBoxColumn,
            this.toplamBorcDataGridViewTextBoxColumn,
            this.kalanBorcDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.islemTabloBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(293, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 253);
            this.dataGridView1.TabIndex = 24;
            // 
            // islemIDDataGridViewTextBoxColumn
            // 
            this.islemIDDataGridViewTextBoxColumn.DataPropertyName = "islemID";
            this.islemIDDataGridViewTextBoxColumn.HeaderText = "islemID";
            this.islemIDDataGridViewTextBoxColumn.Name = "islemIDDataGridViewTextBoxColumn";
            this.islemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            // 
            // alınanMalDataGridViewTextBoxColumn
            // 
            this.alınanMalDataGridViewTextBoxColumn.DataPropertyName = "AlınanMal";
            this.alınanMalDataGridViewTextBoxColumn.HeaderText = "AlınanMal";
            this.alınanMalDataGridViewTextBoxColumn.Name = "alınanMalDataGridViewTextBoxColumn";
            // 
            // toplamBorcDataGridViewTextBoxColumn
            // 
            this.toplamBorcDataGridViewTextBoxColumn.DataPropertyName = "ToplamBorc";
            this.toplamBorcDataGridViewTextBoxColumn.HeaderText = "ToplamBorc";
            this.toplamBorcDataGridViewTextBoxColumn.Name = "toplamBorcDataGridViewTextBoxColumn";
            // 
            // kalanBorcDataGridViewTextBoxColumn
            // 
            this.kalanBorcDataGridViewTextBoxColumn.DataPropertyName = "KalanBorc";
            this.kalanBorcDataGridViewTextBoxColumn.HeaderText = "KalanBorc";
            this.kalanBorcDataGridViewTextBoxColumn.Name = "kalanBorcDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // islemTabloBindingSource3
            // 
            this.islemTabloBindingSource3.DataMember = "islemTablo";
            this.islemTabloBindingSource3.DataSource = this.stok2DataSet4BindingSource;
            // 
            // stok2DataSet4BindingSource
            // 
            this.stok2DataSet4BindingSource.DataSource = this.stok2DataSet4;
            this.stok2DataSet4BindingSource.Position = 0;
            // 
            // stok2DataSet4
            // 
            this.stok2DataSet4.DataSetName = "Stok2DataSet4";
            this.stok2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islemTabloBindingSource
            // 
            this.islemTabloBindingSource.DataMember = "islemTablo";
            this.islemTabloBindingSource.DataSource = this.stok2DataSet3BindingSource;
            // 
            // islemTabloTableAdapter
            // 
            this.islemTabloTableAdapter.ClearBeforeFill = true;
            // 
            // kullanicilarBindingSource1
            // 
            this.kullanicilarBindingSource1.DataMember = "Kullanicilar";
            this.kullanicilarBindingSource1.DataSource = this.stok2DataSet3BindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(408, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "İşlem Tarihi  :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(536, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // islemTabloBindingSource1
            // 
            this.islemTabloBindingSource1.DataMember = "islemTablo";
            this.islemTabloBindingSource1.DataSource = this.stok2DataSet3BindingSource;
            // 
            // islemTabloBindingSource2
            // 
            this.islemTabloBindingSource2.DataMember = "islemTablo";
            this.islemTabloBindingSource2.DataSource = this.stok2DataSet3BindingSource;
            // 
            // islemTabloTableAdapter1
            // 
            this.islemTabloTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 18F);
            this.button1.Location = new System.Drawing.Point(774, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 42);
            this.button1.TabIndex = 27;
            this.button1.Text = "KAYIT DÜZELT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 18F);
            this.button2.Location = new System.Drawing.Point(774, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 42);
            this.button2.TabIndex = 28;
            this.button2.Text = "KAYIT SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ıslem1
            // 
            this.ıslem1.Location = new System.Drawing.Point(774, 53);
            this.ıslem1.Name = "ıslem1";
            this.ıslem1.Size = new System.Drawing.Size(160, 20);
            this.ıslem1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(804, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "İŞLEM ID:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 18F);
            this.button3.Location = new System.Drawing.Point(774, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 42);
            this.button3.TabIndex = 31;
            this.button3.Text = "KAYIT LİSTELE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(11, 462);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 82);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // islem
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(947, 556);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ıslem1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtKalanB);
            this.Controls.Add(this.txtToplamB);
            this.Controls.Add(this.txtMal);
            this.Name = "islem";
            this.Text = "islem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemTabloBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemTabloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemTabloBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMal;
        private System.Windows.Forms.TextBox txtToplamB;
        private System.Windows.Forms.TextBox txtKalanB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource stok2DataSet3BindingSource;
        private Stok2DataSet3 stok2DataSet3;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private Stok2DataSet3TableAdapters.KullanicilarTableAdapter kullanicilarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource islemTabloBindingSource;
        private Stok2DataSet3TableAdapters.islemTabloTableAdapter islemTabloTableAdapter;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource stok2DataSet4BindingSource;
        private Stok2DataSet4 stok2DataSet4;
        private System.Windows.Forms.BindingSource islemTabloBindingSource1;
        private System.Windows.Forms.BindingSource islemTabloBindingSource2;
        private System.Windows.Forms.BindingSource islemTabloBindingSource3;
        private Stok2DataSet4TableAdapters.islemTabloTableAdapter islemTabloTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alınanMalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ıslem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}