
namespace AmiralBatti
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OyunuBaslat = new System.Windows.Forms.Button();
            this.NasilOynanir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OyunuBaslat
            // 
            this.OyunuBaslat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.OyunuBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OyunuBaslat.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OyunuBaslat.ForeColor = System.Drawing.Color.White;
            this.OyunuBaslat.Location = new System.Drawing.Point(404, 404);
            this.OyunuBaslat.Name = "OyunuBaslat";
            this.OyunuBaslat.Size = new System.Drawing.Size(226, 79);
            this.OyunuBaslat.TabIndex = 0;
            this.OyunuBaslat.TabStop = false;
            this.OyunuBaslat.Text = "Oyna";
            this.OyunuBaslat.UseVisualStyleBackColor = false;
            this.OyunuBaslat.Click += new System.EventHandler(this.OyunuBaslat_Click);
            // 
            // NasilOynanir
            // 
            this.NasilOynanir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NasilOynanir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NasilOynanir.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NasilOynanir.ForeColor = System.Drawing.Color.White;
            this.NasilOynanir.Location = new System.Drawing.Point(404, 489);
            this.NasilOynanir.Name = "NasilOynanir";
            this.NasilOynanir.Size = new System.Drawing.Size(226, 79);
            this.NasilOynanir.TabIndex = 1;
            this.NasilOynanir.TabStop = false;
            this.NasilOynanir.Text = "Nasıl Oynanır?";
            this.NasilOynanir.UseVisualStyleBackColor = false;
            this.NasilOynanir.Click += new System.EventHandler(this.NasilOynanir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 40F);
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(209, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "AMİRAL BATTI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AmiralBatti.Properties.Resources.menü_arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NasilOynanir);
            this.Controls.Add(this.OyunuBaslat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Amiral Battı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OyunuBaslat;
        private System.Windows.Forms.Button NasilOynanir;
        private System.Windows.Forms.Label label1;
    }
}

