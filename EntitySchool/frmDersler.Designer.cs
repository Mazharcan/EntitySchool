namespace EntitySchool
{
    partial class frmDersler
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTemizleDers = new System.Windows.Forms.Button();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDersListesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 103);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(833, 366);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 55);
            this.label4.TabIndex = 28;
            this.label4.Text = "DERSLER";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Location = new System.Drawing.Point(462, 563);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(176, 48);
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkGray;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(644, 563);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(176, 48);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.DarkGray;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGüncelle.Location = new System.Drawing.Point(644, 509);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(176, 48);
            this.btnGüncelle.TabIndex = 24;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.btnTemizleDers);
            this.groupBox3.Controls.Add(this.txtDersAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDersId);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(35, 509);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 133);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DERSLER";
            // 
            // btnTemizleDers
            // 
            this.btnTemizleDers.BackColor = System.Drawing.Color.DarkGray;
            this.btnTemizleDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizleDers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTemizleDers.Location = new System.Drawing.Point(273, 90);
            this.btnTemizleDers.Name = "btnTemizleDers";
            this.btnTemizleDers.Size = new System.Drawing.Size(121, 37);
            this.btnTemizleDers.TabIndex = 23;
            this.btnTemizleDers.Text = "TEMİZLE";
            this.btnTemizleDers.UseVisualStyleBackColor = false;
            this.btnTemizleDers.Click += new System.EventHandler(this.btnTemizleDers_Click);
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(163, 59);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(231, 20);
            this.txtDersAd.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(104, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "AD :";
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(163, 19);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.ReadOnly = true;
            this.txtDersId.Size = new System.Drawing.Size(231, 20);
            this.txtDersId.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(113, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "ID :";
            // 
            // btnDersListesi
            // 
            this.btnDersListesi.BackColor = System.Drawing.Color.DarkGray;
            this.btnDersListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersListesi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDersListesi.Location = new System.Drawing.Point(462, 509);
            this.btnDersListesi.Name = "btnDersListesi";
            this.btnDersListesi.Size = new System.Drawing.Size(176, 48);
            this.btnDersListesi.TabIndex = 31;
            this.btnDersListesi.Text = "DERS LİSTESİ";
            this.btnDersListesi.UseVisualStyleBackColor = false;
            this.btnDersListesi.Click += new System.EventHandler(this.btnDersListesi_Click);
            // 
            // frmDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(897, 726);
            this.Controls.Add(this.btnDersListesi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDersler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DERSLER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDersler_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTemizleDers;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDersListesi;
    }
}