
namespace AmiralBatti
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label4 = new System.Windows.Forms.Label();
            this.MenuyeDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.label4.TabIndex = 9;
            this.label4.Text = "Menüye Dön";
            // 
            // MenuyeDon
            // 
            this.MenuyeDon.BackColor = System.Drawing.Color.Gold;
            this.MenuyeDon.BackgroundImage = global::AmiralBatti.Properties.Resources.menüye_dön;
            this.MenuyeDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuyeDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuyeDon.Location = new System.Drawing.Point(25, 12);
            this.MenuyeDon.Name = "MenuyeDon";
            this.MenuyeDon.Size = new System.Drawing.Size(100, 100);
            this.MenuyeDon.TabIndex = 8;
            this.MenuyeDon.TabStop = false;
            this.MenuyeDon.UseVisualStyleBackColor = false;
            this.MenuyeDon.Click += new System.EventHandler(this.MenuyeDon_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 160);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 404);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "-OYNANIŞ-";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AmiralBatti.Properties.Resources.oynanış_arkaplan1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MenuyeDon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Amiral Battı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MenuyeDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}