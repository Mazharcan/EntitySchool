namespace EntitySchool
{
    partial class frmLINQ
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
            this.rdbDataAdet = new System.Windows.Forms.RadioButton();
            this.rdbDegerVarMı = new System.Windows.Forms.RadioButton();
            this.txtAramaSon = new System.Windows.Forms.TextBox();
            this.rdbAramaSon = new System.Windows.Forms.RadioButton();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdbAra = new System.Windows.Forms.RadioButton();
            this.txtIdVeriGetir = new System.Windows.Forms.TextBox();
            this.rdbIdVeriGetir = new System.Windows.Forms.RadioButton();
            this.txtKayıt = new System.Windows.Forms.TextBox();
            this.rdbKayıtlar = new System.Windows.Forms.RadioButton();
            this.rdbDescendingOrder = new System.Windows.Forms.RadioButton();
            this.rdbOrder = new System.Windows.Forms.RadioButton();
            this.btnLINQ = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbSınav1Toplam = new System.Windows.Forms.RadioButton();
            this.rdbSınav1Ortalama = new System.Windows.Forms.RadioButton();
            this.rdbSınav3Ortalama = new System.Windows.Forms.RadioButton();
            this.rdbSınav3Toplam = new System.Windows.Forms.RadioButton();
            this.rdbSınav2Ortalama = new System.Windows.Forms.RadioButton();
            this.rdbSınav2Toplam = new System.Windows.Forms.RadioButton();
            this.rdbDersiGecenler = new System.Windows.Forms.RadioButton();
            this.rdbdersKaldı = new System.Windows.Forms.RadioButton();
            this.btnNotListesi = new System.Windows.Forms.Button();
            this.rdbOrtMax = new System.Windows.Forms.RadioButton();
            this.rdbOrtMin = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbDataAdet
            // 
            this.rdbDataAdet.AutoSize = true;
            this.rdbDataAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDataAdet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbDataAdet.Location = new System.Drawing.Point(30, 441);
            this.rdbDataAdet.Name = "rdbDataAdet";
            this.rdbDataAdet.Size = new System.Drawing.Size(259, 28);
            this.rdbDataAdet.TabIndex = 47;
            this.rdbDataAdet.TabStop = true;
            this.rdbDataAdet.Text = "TOPLAM ÖĞRENCİ SAYISI";
            this.rdbDataAdet.UseVisualStyleBackColor = true;
            // 
            // rdbDegerVarMı
            // 
            this.rdbDegerVarMı.AutoSize = true;
            this.rdbDegerVarMı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDegerVarMı.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbDegerVarMı.Location = new System.Drawing.Point(30, 384);
            this.rdbDegerVarMı.Name = "rdbDegerVarMı";
            this.rdbDegerVarMı.Size = new System.Drawing.Size(336, 28);
            this.rdbDegerVarMı.TabIndex = 46;
            this.rdbDegerVarMı.TabStop = true;
            this.rdbDegerVarMı.Text = "ÖĞRENCİ TABLO : DATA VAR MI ? ";
            this.rdbDegerVarMı.UseVisualStyleBackColor = true;
            // 
            // txtAramaSon
            // 
            this.txtAramaSon.Location = new System.Drawing.Point(311, 321);
            this.txtAramaSon.Name = "txtAramaSon";
            this.txtAramaSon.Size = new System.Drawing.Size(78, 20);
            this.txtAramaSon.TabIndex = 45;
            // 
            // rdbAramaSon
            // 
            this.rdbAramaSon.AutoSize = true;
            this.rdbAramaSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbAramaSon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbAramaSon.Location = new System.Drawing.Point(30, 321);
            this.rdbAramaSon.Name = "rdbAramaSon";
            this.rdbAramaSon.Size = new System.Drawing.Size(154, 28);
            this.rdbAramaSon.TabIndex = 44;
            this.rdbAramaSon.TabStop = true;
            this.rdbAramaSon.Text = "ARAMA (SON)";
            this.rdbAramaSon.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(311, 258);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(78, 20);
            this.txtAra.TabIndex = 43;
            // 
            // rdbAra
            // 
            this.rdbAra.AutoSize = true;
            this.rdbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbAra.Location = new System.Drawing.Point(30, 250);
            this.rdbAra.Name = "rdbAra";
            this.rdbAra.Size = new System.Drawing.Size(139, 28);
            this.rdbAra.TabIndex = 42;
            this.rdbAra.TabStop = true;
            this.rdbAra.Text = "ARAMA (İLK)";
            this.rdbAra.UseVisualStyleBackColor = true;
            // 
            // txtIdVeriGetir
            // 
            this.txtIdVeriGetir.Location = new System.Drawing.Point(311, 189);
            this.txtIdVeriGetir.Name = "txtIdVeriGetir";
            this.txtIdVeriGetir.Size = new System.Drawing.Size(78, 20);
            this.txtIdVeriGetir.TabIndex = 41;
            // 
            // rdbIdVeriGetir
            // 
            this.rdbIdVeriGetir.AutoSize = true;
            this.rdbIdVeriGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbIdVeriGetir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbIdVeriGetir.Location = new System.Drawing.Point(30, 186);
            this.rdbIdVeriGetir.Name = "rdbIdVeriGetir";
            this.rdbIdVeriGetir.Size = new System.Drawing.Size(214, 28);
            this.rdbIdVeriGetir.TabIndex = 40;
            this.rdbIdVeriGetir.TabStop = true;
            this.rdbIdVeriGetir.Text = "ID GÖRE VERİ GETİR";
            this.rdbIdVeriGetir.UseVisualStyleBackColor = true;
            // 
            // txtKayıt
            // 
            this.txtKayıt.Location = new System.Drawing.Point(311, 123);
            this.txtKayıt.Name = "txtKayıt";
            this.txtKayıt.Size = new System.Drawing.Size(78, 20);
            this.txtKayıt.TabIndex = 39;
            // 
            // rdbKayıtlar
            // 
            this.rdbKayıtlar.AutoSize = true;
            this.rdbKayıtlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKayıtlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbKayıtlar.Location = new System.Drawing.Point(30, 123);
            this.rdbKayıtlar.Name = "rdbKayıtlar";
            this.rdbKayıtlar.Size = new System.Drawing.Size(160, 28);
            this.rdbKayıtlar.TabIndex = 38;
            this.rdbKayıtlar.TabStop = true;
            this.rdbKayıtlar.Text = "KAYIT LİSTELE";
            this.rdbKayıtlar.UseVisualStyleBackColor = true;
            // 
            // rdbDescendingOrder
            // 
            this.rdbDescendingOrder.AutoSize = true;
            this.rdbDescendingOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDescendingOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbDescendingOrder.Location = new System.Drawing.Point(30, 70);
            this.rdbDescendingOrder.Name = "rdbDescendingOrder";
            this.rdbDescendingOrder.Size = new System.Drawing.Size(261, 28);
            this.rdbDescendingOrder.TabIndex = 37;
            this.rdbDescendingOrder.TabStop = true;
            this.rdbDescendingOrder.Text = "ADA GÖRE SIRALA (Z -- A)";
            this.rdbDescendingOrder.UseVisualStyleBackColor = true;
            // 
            // rdbOrder
            // 
            this.rdbOrder.AutoSize = true;
            this.rdbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbOrder.Location = new System.Drawing.Point(30, 21);
            this.rdbOrder.Name = "rdbOrder";
            this.rdbOrder.Size = new System.Drawing.Size(261, 28);
            this.rdbOrder.TabIndex = 36;
            this.rdbOrder.TabStop = true;
            this.rdbOrder.Text = "ADA GÖRE SIRALA (A -- Z)";
            this.rdbOrder.UseVisualStyleBackColor = true;
            // 
            // btnLINQ
            // 
            this.btnLINQ.BackColor = System.Drawing.Color.DarkGray;
            this.btnLINQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLINQ.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLINQ.Location = new System.Drawing.Point(8, 742);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new System.Drawing.Size(176, 48);
            this.btnLINQ.TabIndex = 48;
            this.btnLINQ.Text = "LINQ ENTITY";
            this.btnLINQ.UseVisualStyleBackColor = false;
            this.btnLINQ.Click += new System.EventHandler(this.btnLINQ_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1156, 473);
            this.dataGridView1.TabIndex = 49;
            // 
            // rdbSınav1Toplam
            // 
            this.rdbSınav1Toplam.AutoSize = true;
            this.rdbSınav1Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSınav1Toplam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSınav1Toplam.Location = new System.Drawing.Point(30, 494);
            this.rdbSınav1Toplam.Name = "rdbSınav1Toplam";
            this.rdbSınav1Toplam.Size = new System.Drawing.Size(239, 28);
            this.rdbSınav1Toplam.TabIndex = 50;
            this.rdbSınav1Toplam.TabStop = true;
            this.rdbSınav1Toplam.Text = "SINAV 1 TOPLAM PUAN";
            this.rdbSınav1Toplam.UseVisualStyleBackColor = true;
            // 
            // rdbSınav1Ortalama
            // 
            this.rdbSınav1Ortalama.AutoSize = true;
            this.rdbSınav1Ortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSınav1Ortalama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSınav1Ortalama.Location = new System.Drawing.Point(30, 528);
            this.rdbSınav1Ortalama.Name = "rdbSınav1Ortalama";
            this.rdbSınav1Ortalama.Size = new System.Drawing.Size(214, 28);
            this.rdbSınav1Ortalama.TabIndex = 51;
            this.rdbSınav1Ortalama.TabStop = true;
            this.rdbSınav1Ortalama.Text = "SINAV 1 ORTALAMA ";
            this.rdbSınav1Ortalama.UseVisualStyleBackColor = true;
            // 
            // rdbSınav3Ortalama
            // 
            this.rdbSınav3Ortalama.AutoSize = true;
            this.rdbSınav3Ortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSınav3Ortalama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSınav3Ortalama.Location = new System.Drawing.Point(818, 606);
            this.rdbSınav3Ortalama.Name = "rdbSınav3Ortalama";
            this.rdbSınav3Ortalama.Size = new System.Drawing.Size(214, 28);
            this.rdbSınav3Ortalama.TabIndex = 53;
            this.rdbSınav3Ortalama.TabStop = true;
            this.rdbSınav3Ortalama.Text = "SINAV 3 ORTALAMA ";
            this.rdbSınav3Ortalama.UseVisualStyleBackColor = true;
            // 
            // rdbSınav3Toplam
            // 
            this.rdbSınav3Toplam.AutoSize = true;
            this.rdbSınav3Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSınav3Toplam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSınav3Toplam.Location = new System.Drawing.Point(818, 572);
            this.rdbSınav3Toplam.Name = "rdbSınav3Toplam";
            this.rdbSınav3Toplam.Size = new System.Drawing.Size(239, 28);
            this.rdbSınav3Toplam.TabIndex = 52;
            this.rdbSınav3Toplam.TabStop = true;
            this.rdbSınav3Toplam.Text = "SINAV 3 TOPLAM PUAN";
            this.rdbSınav3Toplam.UseVisualStyleBackColor = true;
            // 
            // rdbSınav2Ortalama
            // 
            this.rdbSınav2Ortalama.AutoSize = true;
            this.rdbSınav2Ortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSınav2Ortalama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSınav2Ortalama.Location = new System.Drawing.Point(497, 606);
            this.rdbSınav2Ortalama.Name = "rdbSınav2Ortalama";
            this.rdbSınav2Ortalama.Size = new System.Drawing.Size(214, 28);
            this.rdbSınav2Ortalama.TabIndex = 55;
            this.rdbSınav2Ortalama.TabStop = true;
            this.rdbSınav2Ortalama.Text = "SINAV 2 ORTALAMA ";
            this.rdbSınav2Ortalama.UseVisualStyleBackColor = true;
            // 
            // rdbSınav2Toplam
            // 
            this.rdbSınav2Toplam.AutoSize = true;
            this.rdbSınav2Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSınav2Toplam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSınav2Toplam.Location = new System.Drawing.Point(497, 572);
            this.rdbSınav2Toplam.Name = "rdbSınav2Toplam";
            this.rdbSınav2Toplam.Size = new System.Drawing.Size(239, 28);
            this.rdbSınav2Toplam.TabIndex = 54;
            this.rdbSınav2Toplam.TabStop = true;
            this.rdbSınav2Toplam.Text = "SINAV 2 TOPLAM PUAN";
            this.rdbSınav2Toplam.UseVisualStyleBackColor = true;
            // 
            // rdbDersiGecenler
            // 
            this.rdbDersiGecenler.AutoSize = true;
            this.rdbDersiGecenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDersiGecenler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbDersiGecenler.Location = new System.Drawing.Point(1192, 572);
            this.rdbDersiGecenler.Name = "rdbDersiGecenler";
            this.rdbDersiGecenler.Size = new System.Drawing.Size(191, 28);
            this.rdbDersiGecenler.TabIndex = 57;
            this.rdbDersiGecenler.TabStop = true;
            this.rdbDersiGecenler.Text = "DERSİ GEÇENLER";
            this.rdbDersiGecenler.UseVisualStyleBackColor = true;
            // 
            // rdbdersKaldı
            // 
            this.rdbdersKaldı.AutoSize = true;
            this.rdbdersKaldı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbdersKaldı.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbdersKaldı.Location = new System.Drawing.Point(1192, 606);
            this.rdbdersKaldı.Name = "rdbdersKaldı";
            this.rdbdersKaldı.Size = new System.Drawing.Size(221, 28);
            this.rdbdersKaldı.TabIndex = 59;
            this.rdbdersKaldı.TabStop = true;
            this.rdbdersKaldı.Text = "DERSTEN KALANLAR";
            this.rdbdersKaldı.UseVisualStyleBackColor = true;
            // 
            // btnNotListesi
            // 
            this.btnNotListesi.BackColor = System.Drawing.Color.DarkGray;
            this.btnNotListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotListesi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNotListesi.Location = new System.Drawing.Point(8, 678);
            this.btnNotListesi.Name = "btnNotListesi";
            this.btnNotListesi.Size = new System.Drawing.Size(176, 48);
            this.btnNotListesi.TabIndex = 60;
            this.btnNotListesi.Text = "NOT LİSTESİ";
            this.btnNotListesi.UseVisualStyleBackColor = false;
            // 
            // rdbOrtMax
            // 
            this.rdbOrtMax.AutoSize = true;
            this.rdbOrtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOrtMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbOrtMax.Location = new System.Drawing.Point(1473, 572);
            this.rdbOrtMax.Name = "rdbOrtMax";
            this.rdbOrtMax.Size = new System.Drawing.Size(244, 28);
            this.rdbOrtMax.TabIndex = 61;
            this.rdbOrtMax.TabStop = true;
            this.rdbOrtMax.Text = "EN YÜKSEK ORTALAMA";
            this.rdbOrtMax.UseVisualStyleBackColor = true;
            // 
            // rdbOrtMin
            // 
            this.rdbOrtMin.AutoSize = true;
            this.rdbOrtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOrtMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbOrtMin.Location = new System.Drawing.Point(1473, 606);
            this.rdbOrtMin.Name = "rdbOrtMin";
            this.rdbOrtMin.Size = new System.Drawing.Size(233, 28);
            this.rdbOrtMin.TabIndex = 62;
            this.rdbOrtMin.TabStop = true;
            this.rdbOrtMin.Text = "EN DÜŞÜK ORTALAMA";
            this.rdbOrtMin.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(487, 678);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(214, 28);
            this.radioButton1.TabIndex = 63;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SINAV 2 ORTALAMA ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.DarkGray;
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJoin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJoin.Location = new System.Drawing.Point(213, 709);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(176, 48);
            this.btnJoin.TabIndex = 64;
            this.btnJoin.Text = "JOIN İŞLEMİ";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // frmLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1875, 802);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdbOrtMin);
            this.Controls.Add(this.rdbOrtMax);
            this.Controls.Add(this.btnNotListesi);
            this.Controls.Add(this.rdbdersKaldı);
            this.Controls.Add(this.rdbDersiGecenler);
            this.Controls.Add(this.rdbSınav2Ortalama);
            this.Controls.Add(this.rdbSınav2Toplam);
            this.Controls.Add(this.rdbSınav3Ortalama);
            this.Controls.Add(this.rdbSınav3Toplam);
            this.Controls.Add(this.rdbSınav1Ortalama);
            this.Controls.Add(this.rdbSınav1Toplam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLINQ);
            this.Controls.Add(this.rdbDataAdet);
            this.Controls.Add(this.rdbDegerVarMı);
            this.Controls.Add(this.txtAramaSon);
            this.Controls.Add(this.rdbAramaSon);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.rdbAra);
            this.Controls.Add(this.txtIdVeriGetir);
            this.Controls.Add(this.rdbIdVeriGetir);
            this.Controls.Add(this.txtKayıt);
            this.Controls.Add(this.rdbKayıtlar);
            this.Controls.Add(this.rdbDescendingOrder);
            this.Controls.Add(this.rdbOrder);
            this.Name = "frmLINQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLINQ_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbDataAdet;
        private System.Windows.Forms.RadioButton rdbDegerVarMı;
        private System.Windows.Forms.TextBox txtAramaSon;
        private System.Windows.Forms.RadioButton rdbAramaSon;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.RadioButton rdbAra;
        private System.Windows.Forms.TextBox txtIdVeriGetir;
        private System.Windows.Forms.RadioButton rdbIdVeriGetir;
        private System.Windows.Forms.TextBox txtKayıt;
        private System.Windows.Forms.RadioButton rdbKayıtlar;
        private System.Windows.Forms.RadioButton rdbDescendingOrder;
        private System.Windows.Forms.RadioButton rdbOrder;
        private System.Windows.Forms.Button btnLINQ;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbSınav1Toplam;
        private System.Windows.Forms.RadioButton rdbSınav1Ortalama;
        private System.Windows.Forms.RadioButton rdbSınav3Ortalama;
        private System.Windows.Forms.RadioButton rdbSınav3Toplam;
        private System.Windows.Forms.RadioButton rdbSınav2Ortalama;
        private System.Windows.Forms.RadioButton rdbSınav2Toplam;
        private System.Windows.Forms.RadioButton rdbDersiGecenler;
        private System.Windows.Forms.RadioButton rdbdersKaldı;
        private System.Windows.Forms.Button btnNotListesi;
        private System.Windows.Forms.RadioButton rdbOrtMax;
        private System.Windows.Forms.RadioButton rdbOrtMin;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnJoin;
    }
}