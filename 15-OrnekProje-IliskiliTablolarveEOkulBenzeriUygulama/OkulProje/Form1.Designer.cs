namespace OkulProje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pctOgrenci = new System.Windows.Forms.PictureBox();
            this.pctOgretmen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pctCikis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci";
            // 
            // pctOgrenci
            // 
            this.pctOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("pctOgrenci.Image")));
            this.pctOgrenci.Location = new System.Drawing.Point(148, 101);
            this.pctOgrenci.Name = "pctOgrenci";
            this.pctOgrenci.Size = new System.Drawing.Size(164, 100);
            this.pctOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOgrenci.TabIndex = 1;
            this.pctOgrenci.TabStop = false;
            this.pctOgrenci.Click += new System.EventHandler(this.pctOgrenci_Click);
            // 
            // pctOgretmen
            // 
            this.pctOgretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pctOgretmen.Image")));
            this.pctOgretmen.Location = new System.Drawing.Point(453, 101);
            this.pctOgretmen.Name = "pctOgretmen";
            this.pctOgretmen.Size = new System.Drawing.Size(164, 100);
            this.pctOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOgretmen.TabIndex = 2;
            this.pctOgretmen.TabStop = false;
            this.pctOgretmen.Click += new System.EventHandler(this.pctOgretmen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen";
            // 
            // txtNumara
            // 
            this.txtNumara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumara.Location = new System.Drawing.Point(148, 285);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(469, 30);
            this.txtNumara.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numara:";
            // 
            // pctCikis
            // 
            this.pctCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCikis.Image = ((System.Drawing.Image)(resources.GetObject("pctCikis.Image")));
            this.pctCikis.Location = new System.Drawing.Point(678, 3);
            this.pctCikis.Name = "pctCikis";
            this.pctCikis.Size = new System.Drawing.Size(71, 61);
            this.pctCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCikis.TabIndex = 6;
            this.pctCikis.TabStop = false;
            this.pctCikis.Click += new System.EventHandler(this.pctCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(751, 419);
            this.Controls.Add(this.pctCikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctOgretmen);
            this.Controls.Add(this.pctOgrenci);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctOgrenci;
        private System.Windows.Forms.PictureBox pctOgretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctCikis;
    }
}

