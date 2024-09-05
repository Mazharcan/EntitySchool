namespace EntitySchool
{
    partial class frmNotlar
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
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnNotListesi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNotID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizleSınav = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSınavOrt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 366);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 55);
            this.label4.TabIndex = 28;
            this.label4.Text = "NOTLAR";
            // 
            // btnProcedure
            // 
            this.btnProcedure.BackColor = System.Drawing.Color.DarkGray;
            this.btnProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcedure.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcedure.Location = new System.Drawing.Point(542, 665);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(270, 48);
            this.btnProcedure.TabIndex = 27;
            this.btnProcedure.Text = "PROSEDÜR";
            this.btnProcedure.UseVisualStyleBackColor = false;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkGray;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(668, 611);
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
            this.btnGüncelle.Location = new System.Drawing.Point(668, 557);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(176, 48);
            this.btnGüncelle.TabIndex = 24;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnNotListesi
            // 
            this.btnNotListesi.BackColor = System.Drawing.Color.DarkGray;
            this.btnNotListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotListesi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNotListesi.Location = new System.Drawing.Point(486, 557);
            this.btnNotListesi.Name = "btnNotListesi";
            this.btnNotListesi.Size = new System.Drawing.Size(176, 48);
            this.btnNotListesi.TabIndex = 30;
            this.btnNotListesi.Text = "NOT LİSTESİ";
            this.btnNotListesi.UseVisualStyleBackColor = false;
            this.btnNotListesi.Click += new System.EventHandler(this.btnNotListesi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.txtNotID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnTemizleSınav);
            this.groupBox2.Controls.Add(this.txtDurum);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtSınav2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSınavOrt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSınav3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSınav1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(41, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 309);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOTLAR";
            // 
            // txtNotID
            // 
            this.txtNotID.Location = new System.Drawing.Point(163, 32);
            this.txtNotID.Name = "txtNotID";
            this.txtNotID.Size = new System.Drawing.Size(231, 20);
            this.txtNotID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Not ID :";
            // 
            // btnTemizleSınav
            // 
            this.btnTemizleSınav.BackColor = System.Drawing.Color.DarkGray;
            this.btnTemizleSınav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizleSınav.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTemizleSınav.Location = new System.Drawing.Point(273, 266);
            this.btnTemizleSınav.Name = "btnTemizleSınav";
            this.btnTemizleSınav.Size = new System.Drawing.Size(121, 37);
            this.btnTemizleSınav.TabIndex = 24;
            this.btnTemizleSınav.Text = "TEMİZLE";
            this.btnTemizleSınav.UseVisualStyleBackColor = false;
            this.btnTemizleSınav.Click += new System.EventHandler(this.btnTemizleSınav_Click);
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(163, 234);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(231, 20);
            this.txtDurum.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(55, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "DURUM :";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(163, 109);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(231, 20);
            this.txtSınav2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "SINAV 2:";
            // 
            // txtSınavOrt
            // 
            this.txtSınavOrt.Location = new System.Drawing.Point(163, 192);
            this.txtSınavOrt.Name = "txtSınavOrt";
            this.txtSınavOrt.Size = new System.Drawing.Size(231, 20);
            this.txtSınavOrt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "ORTALAMA :";
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(163, 152);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(231, 20);
            this.txtSınav3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(59, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "SINAV 3:";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(163, 69);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(231, 20);
            this.txtSınav1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(59, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "SINAV 1:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkGray;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHesapla.Location = new System.Drawing.Point(486, 611);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(176, 48);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // frmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(910, 851);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNotListesi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTLAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNotlar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnNotListesi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemizleSınav;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSınavOrt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtNotID;
        private System.Windows.Forms.Label label2;
    }
}