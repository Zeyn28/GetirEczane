
namespace ProjeDeneme_2
{
    partial class hasta_girisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hasta_girisi));
            this.label1 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnhastaKaydol = new System.Windows.Forms.Button();
            this.btnhastagiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(156, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Girişi";
            // 
            // mskTC
            // 
            this.mskTC.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(163, 128);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(208, 38);
            this.mskTC.TabIndex = 1;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(163, 188);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(208, 38);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnhastaKaydol
            // 
            this.btnhastaKaydol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btnhastaKaydol.FlatAppearance.BorderSize = 0;
            this.btnhastaKaydol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnhastaKaydol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnhastaKaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhastaKaydol.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastaKaydol.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnhastaKaydol.Location = new System.Drawing.Point(123, 262);
            this.btnhastaKaydol.Name = "btnhastaKaydol";
            this.btnhastaKaydol.Size = new System.Drawing.Size(115, 40);
            this.btnhastaKaydol.TabIndex = 4;
            this.btnhastaKaydol.Text = "Kaydol";
            this.btnhastaKaydol.UseVisualStyleBackColor = false;
            this.btnhastaKaydol.Click += new System.EventHandler(this.btnhastaKaydol_Click);
            // 
            // btnhastagiris
            // 
            this.btnhastagiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btnhastagiris.FlatAppearance.BorderSize = 0;
            this.btnhastagiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnhastagiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnhastagiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhastagiris.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastagiris.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnhastagiris.Location = new System.Drawing.Point(265, 262);
            this.btnhastagiris.Name = "btnhastagiris";
            this.btnhastagiris.Size = new System.Drawing.Size(121, 40);
            this.btnhastagiris.TabIndex = 3;
            this.btnhastagiris.Text = "Giriş";
            this.btnhastagiris.UseVisualStyleBackColor = false;
            this.btnhastagiris.Click += new System.EventHandler(this.btnhastagiris_Click_1);
            // 
            // hasta_girisi
            // 
            this.AcceptButton = this.btnhastagiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(505, 365);
            this.Controls.Add(this.btnhastagiris);
            this.Controls.Add(this.btnhastaKaydol);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "hasta_girisi";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.hasta_girisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnhastaKaydol;
        private System.Windows.Forms.Button btnhastagiris;
    }
}