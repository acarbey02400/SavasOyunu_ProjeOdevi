namespace B201200046_IHalilAcar_ProjeOdevi
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
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.ucaksavarPanel = new System.Windows.Forms.Panel();
            this.savasAlaniPanel = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.hearth3 = new System.Windows.Forms.PictureBox();
            this.hearth4 = new System.Windows.Forms.PictureBox();
            this.hearth5 = new System.Windows.Forms.PictureBox();
            this.hearth1 = new System.Windows.Forms.PictureBox();
            this.hearth2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bilgiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.Transparent;
            this.bilgiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bilgiPanel.Controls.Add(this.pictureBox8);
            this.bilgiPanel.Controls.Add(this.hearth3);
            this.bilgiPanel.Controls.Add(this.hearth4);
            this.bilgiPanel.Controls.Add(this.hearth5);
            this.bilgiPanel.Controls.Add(this.hearth1);
            this.bilgiPanel.Controls.Add(this.hearth2);
            this.bilgiPanel.Controls.Add(this.pictureBox2);
            this.bilgiPanel.Controls.Add(this.pictureBox1);
            this.bilgiPanel.Controls.Add(this.scoreLabel);
            this.bilgiPanel.Controls.Add(this.sureLabel);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(827, 108);
            this.bilgiPanel.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.scoreLabel.Location = new System.Drawing.Point(523, 46);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(162, 51);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // sureLabel
            // 
            this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureLabel.BackColor = System.Drawing.Color.Transparent;
            this.sureLabel.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLabel.ForeColor = System.Drawing.Color.Maroon;
            this.sureLabel.Location = new System.Drawing.Point(715, 55);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(101, 31);
            this.sureLabel.TabIndex = 0;
            this.sureLabel.Text = "0:00";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sureLabel.Click += new System.EventHandler(this.sureLabel_Click);
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.BackColor = System.Drawing.Color.Transparent;
            this.bilgiLabel.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilgiLabel.ForeColor = System.Drawing.Color.DimGray;
            this.bilgiLabel.Location = new System.Drawing.Point(12, 9);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(499, 96);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "Oyuna başlamak için ENTER tuşuna basın.\r\nUçaksavarı hareket ettirmek için SAĞ/SOL" +
    " tuşlarını kullanın.\r\nAteş etmek için BOŞLUK tuşunu kullanın.\r\nOyunu duraklatmak" +
    " için \"P\" tuşunu kullanınız.";
            // 
            // ucaksavarPanel
            // 
            this.ucaksavarPanel.BackColor = System.Drawing.Color.Lavender;
            this.ucaksavarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucaksavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucaksavarPanel.Location = new System.Drawing.Point(0, 469);
            this.ucaksavarPanel.Name = "ucaksavarPanel";
            this.ucaksavarPanel.Size = new System.Drawing.Size(827, 69);
            this.ucaksavarPanel.TabIndex = 1;
            // 
            // savasAlaniPanel
            // 
            this.savasAlaniPanel.BackColor = System.Drawing.Color.Transparent;
            this.savasAlaniPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savasAlaniPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniPanel.Location = new System.Drawing.Point(0, 108);
            this.savasAlaniPanel.Name = "savasAlaniPanel";
            this.savasAlaniPanel.Size = new System.Drawing.Size(827, 361);
            this.savasAlaniPanel.TabIndex = 2;
            this.savasAlaniPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.savasAlaniPanel_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Image = global::B201200046_IHalilAcar_ProjeOdevi.Properties.Resources.Healt3;
            this.pictureBox8.Location = new System.Drawing.Point(429, 10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(113, 52);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // hearth3
            // 
            this.hearth3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hearth3.Image = global::B201200046_IHalilAcar_ProjeOdevi.Properties.Resources.Heart;
            this.hearth3.Location = new System.Drawing.Point(481, 62);
            this.hearth3.Name = "hearth3";
            this.hearth3.Size = new System.Drawing.Size(20, 23);
            this.hearth3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hearth3.TabIndex = 7;
            this.hearth3.TabStop = false;
            // 
            // hearth4
            // 
            this.hearth4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hearth4.Image = global::B201200046_IHalilAcar_ProjeOdevi.Properties.Resources.Heart;
            this.hearth4.Location = new System.Drawing.Point(508, 62);
            this.hearth4.Name = "hearth4";
            this.hearth4.Size = new System.Drawing.Size(20, 23);
            this.hearth4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hearth4.TabIndex = 6;
            this.hearth4.TabStop = false;
            // 
            // hearth5
            // 
            this.hearth5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hearth5.Image = global::B201200046_IHalilAcar_ProjeOdevi.Properties.Resources.Heart;
            this.hearth5.Location = new System.Drawing.Point(534, 62);
            this.hearth5.Name = "hearth5";
            this.hearth5.Size = new System.Drawing.Size(20, 23);
            this.hearth5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hearth5.TabIndex = 5;
            this.hearth5.TabStop = false;
            this.hearth5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // hearth1
            // 
            this.hearth1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hearth1.Image = global::B201200046_IHalilAcar_ProjeOdevi.Properties.Resources.Heart;
            this.hearth1.Location = new System.Drawing.Point(429, 62);
            this.hearth1.Name = "hearth1";
            this.hearth1.Size = new System.Drawing.Size(20, 23);
            this.hearth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hearth1.TabIndex = 4;
            this.hearth1.TabStop = false;
            // 
            // hearth2
            // 
            this.hearth2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hearth2.Image = global::B201200046_IHalilAcar_ProjeOdevi.Properties.Resources.Heart;
            this.hearth2.Location = new System.Drawing.Point(455, 62);
            this.hearth2.Name = "hearth2";
            this.hearth2.Size = new System.Drawing.Size(20, 23);
            this.hearth2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hearth2.TabIndex = 3;
            this.hearth2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::B201200046_IHalilAcar_ProjeOdevi.Properties.Resources.TİME;
            this.pictureBox2.Location = new System.Drawing.Point(726, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::B201200046_IHalilAcar_ProjeOdevi.Properties.Resources.Vanilla_1_1s_280px;
            this.pictureBox1.Location = new System.Drawing.Point(590, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 538);
            this.Controls.Add(this.savasAlaniPanel);
            this.Controls.Add(this.ucaksavarPanel);
            this.Controls.Add(this.bilgiPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel ucaksavarPanel;
        private System.Windows.Forms.Panel savasAlaniPanel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox hearth2;
        private System.Windows.Forms.PictureBox hearth3;
        private System.Windows.Forms.PictureBox hearth4;
        private System.Windows.Forms.PictureBox hearth5;
        private System.Windows.Forms.PictureBox hearth1;
    }
}

