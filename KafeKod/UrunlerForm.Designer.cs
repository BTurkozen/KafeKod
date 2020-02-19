namespace KafeKod
{
    partial class UrunlerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUrunlerEkle = new System.Windows.Forms.Button();
            this.txtUrunlerUrunAdi = new System.Windows.Forms.TextBox();
            this.nudUrunlerBirim = new System.Windows.Forms.NumericUpDown();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.clmUrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunlerBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(284, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birim Fiyatı (₺)";
            // 
            // btnUrunlerEkle
            // 
            this.btnUrunlerEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunlerEkle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunlerEkle.Location = new System.Drawing.Point(514, 36);
            this.btnUrunlerEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunlerEkle.Name = "btnUrunlerEkle";
            this.btnUrunlerEkle.Size = new System.Drawing.Size(199, 72);
            this.btnUrunlerEkle.TabIndex = 3;
            this.btnUrunlerEkle.Text = "EKLE";
            this.btnUrunlerEkle.UseVisualStyleBackColor = true;
            this.btnUrunlerEkle.Click += new System.EventHandler(this.btnUrunlerEkle_Click);
            // 
            // txtUrunlerUrunAdi
            // 
            this.txtUrunlerUrunAdi.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunlerUrunAdi.Location = new System.Drawing.Point(18, 60);
            this.txtUrunlerUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunlerUrunAdi.Name = "txtUrunlerUrunAdi";
            this.txtUrunlerUrunAdi.Size = new System.Drawing.Size(259, 29);
            this.txtUrunlerUrunAdi.TabIndex = 4;
            // 
            // nudUrunlerBirim
            // 
            this.nudUrunlerBirim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudUrunlerBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUrunlerBirim.Location = new System.Drawing.Point(287, 60);
            this.nudUrunlerBirim.Margin = new System.Windows.Forms.Padding(4);
            this.nudUrunlerBirim.Name = "nudUrunlerBirim";
            this.nudUrunlerBirim.Size = new System.Drawing.Size(220, 26);
            this.nudUrunlerBirim.TabIndex = 5;
            this.nudUrunlerBirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUrunler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUrunler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUrunAd,
            this.clmBirimFiyat});
            this.dgvUrunler.Location = new System.Drawing.Point(12, 125);
            this.dgvUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(716, 548);
            this.dgvUrunler.TabIndex = 26;
            this.dgvUrunler.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvUrunler_CellValidating);
            this.dgvUrunler.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvUrunler_DataError);
            // 
            // clmUrunAd
            // 
            this.clmUrunAd.DataPropertyName = "UrunAd";
            this.clmUrunAd.HeaderText = "Ürün Adı";
            this.clmUrunAd.Name = "clmUrunAd";
            // 
            // clmBirimFiyat
            // 
            this.clmBirimFiyat.DataPropertyName = "BirimFiyat";
            this.clmBirimFiyat.HeaderText = "Birim Fiyatı";
            this.clmBirimFiyat.Name = "clmBirimFiyat";
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 690);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.nudUrunlerBirim);
            this.Controls.Add(this.txtUrunlerUrunAdi);
            this.Controls.Add(this.btnUrunlerEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunlerForm";
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunlerBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUrunlerEkle;
        private System.Windows.Forms.TextBox txtUrunlerUrunAdi;
        private System.Windows.Forms.NumericUpDown nudUrunlerBirim;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBirimFiyat;
    }
}