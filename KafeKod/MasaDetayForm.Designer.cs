namespace KafeKod
{
    partial class MasaDetayForm
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
            this.nudMasaAdet = new System.Windows.Forms.NumericUpDown();
            this.lblMasaTutar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasaAnaSayfa = new System.Windows.Forms.Button();
            this.btnMasaOdemeAl = new System.Windows.Forms.Button();
            this.btnMasaSiparisIptal = new System.Windows.Forms.Button();
            this.cboMasaUrun = new System.Windows.Forms.ComboBox();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.lblMasaNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasaAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMasaAdet
            // 
            this.nudMasaAdet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudMasaAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudMasaAdet.Location = new System.Drawing.Point(193, 41);
            this.nudMasaAdet.Name = "nudMasaAdet";
            this.nudMasaAdet.Size = new System.Drawing.Size(120, 26);
            this.nudMasaAdet.TabIndex = 16;
            this.nudMasaAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMasaAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMasaTutar
            // 
            this.lblMasaTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaTutar.AutoSize = true;
            this.lblMasaTutar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaTutar.Location = new System.Drawing.Point(761, 300);
            this.lblMasaTutar.Name = "lblMasaTutar";
            this.lblMasaTutar.Size = new System.Drawing.Size(51, 23);
            this.lblMasaTutar.TabIndex = 15;
            this.lblMasaTutar.Text = "0.00₺";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(554, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ödeme Tutarı:";
            // 
            // btnMasaAnaSayfa
            // 
            this.btnMasaAnaSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaAnaSayfa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMasaAnaSayfa.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaAnaSayfa.Location = new System.Drawing.Point(558, 412);
            this.btnMasaAnaSayfa.Name = "btnMasaAnaSayfa";
            this.btnMasaAnaSayfa.Size = new System.Drawing.Size(267, 48);
            this.btnMasaAnaSayfa.TabIndex = 12;
            this.btnMasaAnaSayfa.Text = "ANA SAYFAYA DÖN";
            this.btnMasaAnaSayfa.UseVisualStyleBackColor = false;
            this.btnMasaAnaSayfa.Click += new System.EventHandler(this.btnMasaAnaSayfa_Click);
            // 
            // btnMasaOdemeAl
            // 
            this.btnMasaOdemeAl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMasaOdemeAl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMasaOdemeAl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaOdemeAl.Location = new System.Drawing.Point(694, 344);
            this.btnMasaOdemeAl.Name = "btnMasaOdemeAl";
            this.btnMasaOdemeAl.Size = new System.Drawing.Size(131, 46);
            this.btnMasaOdemeAl.TabIndex = 11;
            this.btnMasaOdemeAl.Text = "ÖDEME AL";
            this.btnMasaOdemeAl.UseVisualStyleBackColor = false;
            this.btnMasaOdemeAl.Click += new System.EventHandler(this.btnMasaOdemeAl_Click);
            // 
            // btnMasaSiparisIptal
            // 
            this.btnMasaSiparisIptal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMasaSiparisIptal.BackColor = System.Drawing.Color.Brown;
            this.btnMasaSiparisIptal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaSiparisIptal.Location = new System.Drawing.Point(558, 344);
            this.btnMasaSiparisIptal.Name = "btnMasaSiparisIptal";
            this.btnMasaSiparisIptal.Size = new System.Drawing.Size(130, 46);
            this.btnMasaSiparisIptal.TabIndex = 10;
            this.btnMasaSiparisIptal.Text = "SİPARİŞ İPTAL";
            this.btnMasaSiparisIptal.UseVisualStyleBackColor = false;
            this.btnMasaSiparisIptal.Click += new System.EventHandler(this.btnMasaSiparisIptal_Click);
            // 
            // cboMasaUrun
            // 
            this.cboMasaUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboMasaUrun.FormattingEnabled = true;
            this.cboMasaUrun.Location = new System.Drawing.Point(2, 41);
            this.cboMasaUrun.Name = "cboMasaUrun";
            this.cboMasaUrun.Size = new System.Drawing.Size(170, 28);
            this.cboMasaUrun.TabIndex = 17;
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMasaEkle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaEkle.Location = new System.Drawing.Point(332, 36);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(97, 59);
            this.btnMasaEkle.TabIndex = 18;
            this.btnMasaEkle.Text = "EKLE";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            this.btnMasaEkle.Click += new System.EventHandler(this.btnMasaEkle_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ürün";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(189, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(566, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Masa No:";
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(570, 36);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(141, 28);
            this.cboMasaNo.TabIndex = 22;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMasaTasi.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaTasi.Location = new System.Drawing.Point(717, 36);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(102, 59);
            this.btnMasaTasi.TabIndex = 23;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSiparisDetaylari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisDetaylari.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSiparisDetaylari.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(2, 106);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(550, 356);
            this.dgvSiparisDetaylari.TabIndex = 24;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Font = new System.Drawing.Font("Arial Narrow", 100.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMasaNo.Location = new System.Drawing.Point(603, 106);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(187, 153);
            this.lblMasaNo.TabIndex = 25;
            this.lblMasaNo.Text = "01";
            // 
            // MasaDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 469);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMasaEkle);
            this.Controls.Add(this.cboMasaUrun);
            this.Controls.Add(this.nudMasaAdet);
            this.Controls.Add(this.lblMasaTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMasaAnaSayfa);
            this.Controls.Add(this.btnMasaOdemeAl);
            this.Controls.Add(this.btnMasaSiparisIptal);
            this.MaximizeBox = false;
            this.Name = "MasaDetayForm";
            this.Text = "Masa Detay";
            ((System.ComponentModel.ISupportInitialize)(this.nudMasaAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMasaAdet;
        private System.Windows.Forms.Label lblMasaTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasaAnaSayfa;
        private System.Windows.Forms.Button btnMasaOdemeAl;
        private System.Windows.Forms.Button btnMasaSiparisIptal;
        private System.Windows.Forms.ComboBox cboMasaUrun;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.Label lblMasaNo;
    }
}