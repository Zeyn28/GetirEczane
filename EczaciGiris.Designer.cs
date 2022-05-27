
namespace ProjeDeneme_2
{
    partial class EczaciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EczaciGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eczmskTC = new System.Windows.Forms.MaskedTextBox();
            this.ecztxtSifre = new System.Windows.Forms.TextBox();
            this.btnEczacıG = new System.Windows.Forms.Button();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(155, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eczacı Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // eczmskTC
            // 
            this.eczmskTC.Location = new System.Drawing.Point(174, 123);
            this.eczmskTC.Mask = "00000000000";
            this.eczmskTC.Name = "eczmskTC";
            this.eczmskTC.Size = new System.Drawing.Size(189, 39);
            this.eczmskTC.TabIndex = 1;
            this.eczmskTC.ValidatingType = typeof(int);
            // 
            // ecztxtSifre
            // 
            this.ecztxtSifre.Location = new System.Drawing.Point(174, 176);
            this.ecztxtSifre.Name = "ecztxtSifre";
            this.ecztxtSifre.Size = new System.Drawing.Size(189, 39);
            this.ecztxtSifre.TabIndex = 2;
            this.ecztxtSifre.UseSystemPasswordChar = true;
            // 
            // btnEczacıG
            // 
            this.btnEczacıG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btnEczacıG.FlatAppearance.BorderSize = 0;
            this.btnEczacıG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnEczacıG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnEczacıG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEczacıG.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnEczacıG.Location = new System.Drawing.Point(242, 248);
            this.btnEczacıG.Name = "btnEczacıG";
            this.btnEczacıG.Size = new System.Drawing.Size(121, 40);
            this.btnEczacıG.TabIndex = 3;
            this.btnEczacıG.Text = "Giriş";
            this.btnEczacıG.UseVisualStyleBackColor = false;
            this.btnEczacıG.Click += new System.EventHandler(this.btnEczacıG_Click);
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btnKaydol.FlatAppearance.BorderSize = 0;
            this.btnKaydol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnKaydol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnKaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydol.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnKaydol.Location = new System.Drawing.Point(88, 248);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(115, 40);
            this.btnKaydol.TabIndex = 4;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = false;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // EczaciGiris
            // 
            this.AcceptButton = this.btnEczacıG;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(242)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(505, 365);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.btnEczacıG);
            this.Controls.Add(this.ecztxtSifre);
            this.Controls.Add(this.eczmskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "EczaciGiris";
            this.Text = "EczacıGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox eczmskTC;
        private System.Windows.Forms.TextBox ecztxtSifre;
        private System.Windows.Forms.Button btnEczacıG;
        private System.Windows.Forms.Button btnKaydol;
    }
}