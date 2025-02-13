namespace OkulProje
{
    partial class FrmOgrenciNotlar
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
            this.dgvOgrenciNotlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenciNotlar
            // 
            this.dgvOgrenciNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenciNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciNotlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOgrenciNotlar.Location = new System.Drawing.Point(0, 0);
            this.dgvOgrenciNotlar.Name = "dgvOgrenciNotlar";
            this.dgvOgrenciNotlar.RowHeadersWidth = 51;
            this.dgvOgrenciNotlar.RowTemplate.Height = 24;
            this.dgvOgrenciNotlar.Size = new System.Drawing.Size(1236, 609);
            this.dgvOgrenciNotlar.TabIndex = 0;
            // 
            // FrmOgrenciNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1236, 609);
            this.Controls.Add(this.dgvOgrenciNotlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOgrenciNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Ekranı";
            this.Load += new System.EventHandler(this.FrmOgrenciNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciNotlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenciNotlar;
    }
}