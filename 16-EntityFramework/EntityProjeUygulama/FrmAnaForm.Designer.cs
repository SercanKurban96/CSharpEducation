namespace EntityProjeUygulama
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.pctCikis = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(12, 123);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(229, 181);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "KATEGORİ İŞLEMLERİ";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.Location = new System.Drawing.Point(247, 123);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(229, 181);
            this.btnUrun.TabIndex = 1;
            this.btnUrun.Text = "ÜRÜN İŞLEMLERİ";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(482, 123);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(229, 181);
            this.btnIstatistik.TabIndex = 2;
            this.btnIstatistik.Text = "İSTATİSTİKLER";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // pctCikis
            // 
            this.pctCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCikis.Image = ((System.Drawing.Image)(resources.GetObject("pctCikis.Image")));
            this.pctCikis.Location = new System.Drawing.Point(647, 2);
            this.pctCikis.Name = "pctCikis";
            this.pctCikis.Size = new System.Drawing.Size(71, 61);
            this.pctCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCikis.TabIndex = 7;
            this.pctCikis.TabStop = false;
            this.pctCikis.Click += new System.EventHandler(this.pctCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "ENTITY ÜRÜN";
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(720, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctCikis);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.btnKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pctCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.PictureBox pctCikis;
        private System.Windows.Forms.Label label1;
    }
}