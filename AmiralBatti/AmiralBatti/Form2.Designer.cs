
namespace AmiralBatti
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SesAyarla = new System.Windows.Forms.PictureBox();
            this.MenuyeDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SesAyarla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hamle sayısı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(598, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Süre: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SesAyarla
            // 
            this.SesAyarla.BackColor = System.Drawing.Color.Transparent;
            this.SesAyarla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SesAyarla.BackgroundImage")));
            this.SesAyarla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SesAyarla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SesAyarla.Location = new System.Drawing.Point(920, 12);
            this.SesAyarla.Name = "SesAyarla";
            this.SesAyarla.Size = new System.Drawing.Size(100, 100);
            this.SesAyarla.TabIndex = 5;
            this.SesAyarla.TabStop = false;
            this.SesAyarla.Click += new System.EventHandler(this.SesAyarla_Click);
            // 
            // MenuyeDon
            // 
            this.MenuyeDon.BackColor = System.Drawing.Color.Gold;
            this.MenuyeDon.BackgroundImage = global::AmiralBatti.Properties.Resources.menüye_dön;
            this.MenuyeDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuyeDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuyeDon.Location = new System.Drawing.Point(27, 12);
            this.MenuyeDon.Name = "MenuyeDon";
            this.MenuyeDon.Size = new System.Drawing.Size(100, 100);
            this.MenuyeDon.TabIndex = 4;
            this.MenuyeDon.TabStop = false;
            this.MenuyeDon.UseVisualStyleBackColor = false;
            this.MenuyeDon.Click += new System.EventHandler(this.MenuyeDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yenile";
            // 
            // Yenile
            // 
            this.Yenile.BackColor = System.Drawing.Color.White;
            this.Yenile.BackgroundImage = global::AmiralBatti.Properties.Resources.yenile;
            this.Yenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Yenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yenile.Location = new System.Drawing.Point(27, 228);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(100, 100);
            this.Yenile.TabIndex = 0;
            this.Yenile.TabStop = false;
            this.Yenile.UseVisualStyleBackColor = false;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menüye Dön";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AmiralBatti.Properties.Resources.oyun_arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SesAyarla);
            this.Controls.Add(this.MenuyeDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yenile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Amiral Battı";
            ((System.ComponentModel.ISupportInitialize)(this.SesAyarla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox SesAyarla;
        private System.Windows.Forms.Button MenuyeDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.Label label4;
    }
}