
namespace ProjeDeneme_2
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnEczacıG = new System.Windows.Forms.Button();
            this.btnHastaG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEczacıG
            // 
            this.btnEczacıG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btnEczacıG.FlatAppearance.BorderSize = 0;
            this.btnEczacıG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnEczacıG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnEczacıG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEczacıG.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnEczacıG.Location = new System.Drawing.Point(385, 352);
            this.btnEczacıG.Name = "btnEczacıG";
            this.btnEczacıG.Size = new System.Drawing.Size(175, 40);
            this.btnEczacıG.TabIndex = 1;
            this.btnEczacıG.Text = "Eczacı Giriş";
            this.btnEczacıG.UseVisualStyleBackColor = false;
            this.btnEczacıG.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHastaG
            // 
            this.btnHastaG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(49)))));
            this.btnHastaG.FlatAppearance.BorderSize = 0;
            this.btnHastaG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnHastaG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnHastaG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaG.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnHastaG.Location = new System.Drawing.Point(613, 352);
            this.btnHastaG.Name = "btnHastaG";
            this.btnHastaG.Size = new System.Drawing.Size(173, 40);
            this.btnHastaG.TabIndex = 2;
            this.btnHastaG.Text = "Hasta Giriş";
            this.btnHastaG.UseVisualStyleBackColor = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 478);
            this.Controls.Add(this.btnHastaG);
            this.Controls.Add(this.btnEczacıG);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.Text = "Giriş Paneli";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEczacıG;
        private System.Windows.Forms.Button btnHastaG;
    }
}