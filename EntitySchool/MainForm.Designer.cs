namespace EntitySchool
{
    partial class MainForm
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
            this.btnOgr = new System.Windows.Forms.Button();
            this.btnDers = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnLINQ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOgr
            // 
            this.btnOgr.BackColor = System.Drawing.Color.DarkGray;
            this.btnOgr.ForeColor = System.Drawing.Color.Transparent;
            this.btnOgr.Location = new System.Drawing.Point(55, 145);
            this.btnOgr.Name = "btnOgr";
            this.btnOgr.Size = new System.Drawing.Size(263, 93);
            this.btnOgr.TabIndex = 0;
            this.btnOgr.Text = "ÖĞRENCİ";
            this.btnOgr.UseVisualStyleBackColor = false;
            this.btnOgr.Click += new System.EventHandler(this.btnOgr_Click);
            // 
            // btnDers
            // 
            this.btnDers.BackColor = System.Drawing.Color.DarkGray;
            this.btnDers.ForeColor = System.Drawing.Color.Transparent;
            this.btnDers.Location = new System.Drawing.Point(358, 145);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(263, 93);
            this.btnDers.TabIndex = 1;
            this.btnDers.Text = "DERSLER";
            this.btnDers.UseVisualStyleBackColor = false;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // btnNot
            // 
            this.btnNot.BackColor = System.Drawing.Color.DarkGray;
            this.btnNot.ForeColor = System.Drawing.Color.Transparent;
            this.btnNot.Location = new System.Drawing.Point(647, 145);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(263, 93);
            this.btnNot.TabIndex = 2;
            this.btnNot.Text = "NOTLAR";
            this.btnNot.UseVisualStyleBackColor = false;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnLINQ
            // 
            this.btnLINQ.BackColor = System.Drawing.Color.DarkGray;
            this.btnLINQ.ForeColor = System.Drawing.Color.Transparent;
            this.btnLINQ.Location = new System.Drawing.Point(927, 145);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new System.Drawing.Size(263, 93);
            this.btnLINQ.TabIndex = 3;
            this.btnLINQ.Text = "LINQ";
            this.btnLINQ.UseVisualStyleBackColor = false;
            this.btnLINQ.Click += new System.EventHandler(this.btnLINQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(437, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "ANA MENU";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1258, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLINQ);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnDers);
            this.Controls.Add(this.btnOgr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞLEMLER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgr;
        private System.Windows.Forms.Button btnDers;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnLINQ;
        private System.Windows.Forms.Label label1;
    }
}