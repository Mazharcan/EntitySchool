namespace EntitySchool
{
    partial class frmOgrenci
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizleOgr = new System.Windows.Forms.Button();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOgrenci = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btnTemizleOgr);
            this.groupBox1.Controls.Add(this.txtOgrenciAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOgrenciId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(43, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ";
            // 
            // btnTemizleOgr
            // 
            this.btnTemizleOgr.BackColor = System.Drawing.Color.DarkGray;
            this.btnTemizleOgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizleOgr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTemizleOgr.Location = new System.Drawing.Point(273, 169);
            this.btnTemizleOgr.Name = "btnTemizleOgr";
            this.btnTemizleOgr.Size = new System.Drawing.Size(121, 37);
            this.btnTemizleOgr.TabIndex = 11;
            this.btnTemizleOgr.Text = "TEMİZLE";
            this.btnTemizleOgr.UseVisualStyleBackColor = false;
            this.btnTemizleOgr.Click += new System.EventHandler(this.btnTemizleOgr_Click);
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(163, 59);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(231, 20);
            this.txtOgrenciAd.TabIndex = 2;
            this.txtOgrenciAd.TextChanged += new System.EventHandler(this.txtOgrenciAd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(104, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "AD :";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(163, 100);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(231, 20);
            this.txtOgrenciSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "SOYAD :";
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(163, 19);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.ReadOnly = true;
            this.txtOgrenciId.Size = new System.Drawing.Size(231, 20);
            this.txtOgrenciId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID :";
            // 
            // btnProcedure
            // 
            this.btnProcedure.BackColor = System.Drawing.Color.DarkGray;
            this.btnProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcedure.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcedure.Location = new System.Drawing.Point(569, 625);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(221, 48);
            this.btnProcedure.TabIndex = 19;
            this.btnProcedure.Text = "NOTLAR";
            this.btnProcedure.UseVisualStyleBackColor = false;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Location = new System.Drawing.Point(494, 571);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(176, 48);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkGray;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(676, 571);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(176, 48);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.DarkGray;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGüncelle.Location = new System.Drawing.Point(676, 517);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(176, 48);
            this.btnGüncelle.TabIndex = 14;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.BackColor = System.Drawing.Color.DarkGray;
            this.btnOgrenciListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrenciListele.Location = new System.Drawing.Point(494, 517);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(176, 48);
            this.btnOgrenciListele.TabIndex = 12;
            this.btnOgrenciListele.Text = "ÖĞRENCİ LİSTESİ";
            this.btnOgrenciListele.UseVisualStyleBackColor = false;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(39, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 55);
            this.label4.TabIndex = 20;
            this.label4.Text = "ÖĞRENCİ";
            // 
            // dgvOgrenci
            // 
            this.dgvOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenci.Location = new System.Drawing.Point(43, 111);
            this.dgvOgrenci.Name = "dgvOgrenci";
            this.dgvOgrenci.ReadOnly = true;
            this.dgvOgrenci.Size = new System.Drawing.Size(833, 366);
            this.dgvOgrenci.TabIndex = 21;
            this.dgvOgrenci.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(927, 755);
            this.Controls.Add(this.dgvOgrenci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRENCİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOgrenci_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTemizleOgr;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOgrenci;
    }
}