namespace Kim1TLister
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSoruHazirla = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSoruHazirlaBitir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinavBasla = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSoruHazirla = new System.Windows.Forms.GroupBox();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rbCevapD = new System.Windows.Forms.RadioButton();
            this.rbCevapC = new System.Windows.Forms.RadioButton();
            this.rbCevapB = new System.Windows.Forms.RadioButton();
            this.rbCevapA = new System.Windows.Forms.RadioButton();
            this.txtCevapD = new System.Windows.Forms.TextBox();
            this.txtCevapC = new System.Windows.Forms.TextBox();
            this.txtCevapB = new System.Windows.Forms.TextBox();
            this.txtCevapA = new System.Windows.Forms.TextBox();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSorular = new System.Windows.Forms.ListBox();
            this.grpSinav = new System.Windows.Forms.GroupBox();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.rbCevapD1 = new System.Windows.Forms.RadioButton();
            this.rbCevapC1 = new System.Windows.Forms.RadioButton();
            this.rbCevapB1 = new System.Windows.Forms.RadioButton();
            this.rbCevapA1 = new System.Windows.Forms.RadioButton();
            this.lblSoru = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpSoruHazirla.SuspendLayout();
            this.grpSinav.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAc,
            this.mnuKaydet,
            this.toolStripMenuItem1,
            this.mnuSoruHazirla,
            this.mnuSoruHazirlaBitir,
            this.mnuSinavBasla,
            this.toolStripMenuItem2,
            this.mnuCikis});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mnuSoruHazirla
            // 
            this.mnuSoruHazirla.Name = "mnuSoruHazirla";
            this.mnuSoruHazirla.Size = new System.Drawing.Size(161, 22);
            this.mnuSoruHazirla.Text = "Soru Hazırla";
            this.mnuSoruHazirla.Click += new System.EventHandler(this.soruHazırlaToolStripMenuItem_Click);
            // 
            // mnuSoruHazirlaBitir
            // 
            this.mnuSoruHazirlaBitir.Enabled = false;
            this.mnuSoruHazirlaBitir.Name = "mnuSoruHazirlaBitir";
            this.mnuSoruHazirlaBitir.Size = new System.Drawing.Size(161, 22);
            this.mnuSoruHazirlaBitir.Text = "Soru Hazırla Bitir";
            this.mnuSoruHazirlaBitir.Click += new System.EventHandler(this.mnuSoruHazirlaBitir_Click);
            // 
            // mnuSinavBasla
            // 
            this.mnuSinavBasla.Enabled = false;
            this.mnuSinavBasla.Name = "mnuSinavBasla";
            this.mnuSinavBasla.Size = new System.Drawing.Size(161, 22);
            this.mnuSinavBasla.Text = "Sınava Başla";
            this.mnuSinavBasla.Click += new System.EventHandler(this.mnuSinavBasla_Click);
            // 
            // grpSoruHazirla
            // 
            this.grpSoruHazirla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSoruHazirla.Controls.Add(this.btnDuzelt);
            this.grpSoruHazirla.Controls.Add(this.btnSil);
            this.grpSoruHazirla.Controls.Add(this.btnEkle);
            this.grpSoruHazirla.Controls.Add(this.rbCevapD);
            this.grpSoruHazirla.Controls.Add(this.rbCevapC);
            this.grpSoruHazirla.Controls.Add(this.rbCevapB);
            this.grpSoruHazirla.Controls.Add(this.rbCevapA);
            this.grpSoruHazirla.Controls.Add(this.txtCevapD);
            this.grpSoruHazirla.Controls.Add(this.txtCevapC);
            this.grpSoruHazirla.Controls.Add(this.txtCevapB);
            this.grpSoruHazirla.Controls.Add(this.txtCevapA);
            this.grpSoruHazirla.Controls.Add(this.txtSoru);
            this.grpSoruHazirla.Controls.Add(this.label1);
            this.grpSoruHazirla.Controls.Add(this.lstSorular);
            this.grpSoruHazirla.Enabled = false;
            this.grpSoruHazirla.Location = new System.Drawing.Point(13, 28);
            this.grpSoruHazirla.Name = "grpSoruHazirla";
            this.grpSoruHazirla.Size = new System.Drawing.Size(376, 263);
            this.grpSoruHazirla.TabIndex = 1;
            this.grpSoruHazirla.TabStop = false;
            this.grpSoruHazirla.Text = "Soru Ekleme";
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzelt.Location = new System.Drawing.Point(276, 223);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(47, 34);
            this.btnDuzelt.TabIndex = 4;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(329, 223);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(42, 34);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(228, 223);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(42, 34);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rbCevapD
            // 
            this.rbCevapD.AutoSize = true;
            this.rbCevapD.Location = new System.Drawing.Point(165, 131);
            this.rbCevapD.Name = "rbCevapD";
            this.rbCevapD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCevapD.Size = new System.Drawing.Size(33, 17);
            this.rbCevapD.TabIndex = 3;
            this.rbCevapD.Text = "D";
            this.rbCevapD.UseVisualStyleBackColor = true;
            // 
            // rbCevapC
            // 
            this.rbCevapC.AutoSize = true;
            this.rbCevapC.Location = new System.Drawing.Point(166, 105);
            this.rbCevapC.Name = "rbCevapC";
            this.rbCevapC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCevapC.Size = new System.Drawing.Size(32, 17);
            this.rbCevapC.TabIndex = 3;
            this.rbCevapC.Text = "C";
            this.rbCevapC.UseVisualStyleBackColor = true;
            // 
            // rbCevapB
            // 
            this.rbCevapB.AutoSize = true;
            this.rbCevapB.Location = new System.Drawing.Point(166, 79);
            this.rbCevapB.Name = "rbCevapB";
            this.rbCevapB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCevapB.Size = new System.Drawing.Size(32, 17);
            this.rbCevapB.TabIndex = 3;
            this.rbCevapB.Text = "B";
            this.rbCevapB.UseVisualStyleBackColor = true;
            // 
            // rbCevapA
            // 
            this.rbCevapA.AutoSize = true;
            this.rbCevapA.Checked = true;
            this.rbCevapA.Location = new System.Drawing.Point(166, 53);
            this.rbCevapA.Name = "rbCevapA";
            this.rbCevapA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCevapA.Size = new System.Drawing.Size(32, 17);
            this.rbCevapA.TabIndex = 3;
            this.rbCevapA.TabStop = true;
            this.rbCevapA.Text = "A";
            this.rbCevapA.UseVisualStyleBackColor = true;
            // 
            // txtCevapD
            // 
            this.txtCevapD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCevapD.Location = new System.Drawing.Point(203, 130);
            this.txtCevapD.Name = "txtCevapD";
            this.txtCevapD.Size = new System.Drawing.Size(166, 20);
            this.txtCevapD.TabIndex = 2;
            // 
            // txtCevapC
            // 
            this.txtCevapC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCevapC.Location = new System.Drawing.Point(203, 104);
            this.txtCevapC.Name = "txtCevapC";
            this.txtCevapC.Size = new System.Drawing.Size(166, 20);
            this.txtCevapC.TabIndex = 2;
            // 
            // txtCevapB
            // 
            this.txtCevapB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCevapB.Location = new System.Drawing.Point(203, 78);
            this.txtCevapB.Name = "txtCevapB";
            this.txtCevapB.Size = new System.Drawing.Size(166, 20);
            this.txtCevapB.TabIndex = 2;
            // 
            // txtCevapA
            // 
            this.txtCevapA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCevapA.Location = new System.Drawing.Point(203, 52);
            this.txtCevapA.Name = "txtCevapA";
            this.txtCevapA.Size = new System.Drawing.Size(166, 20);
            this.txtCevapA.TabIndex = 2;
            // 
            // txtSoru
            // 
            this.txtSoru.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoru.Location = new System.Drawing.Point(203, 16);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(166, 20);
            this.txtSoru.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru :";
            // 
            // lstSorular
            // 
            this.lstSorular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstSorular.FormattingEnabled = true;
            this.lstSorular.Location = new System.Drawing.Point(6, 19);
            this.lstSorular.Name = "lstSorular";
            this.lstSorular.Size = new System.Drawing.Size(150, 238);
            this.lstSorular.TabIndex = 0;
            this.lstSorular.SelectedIndexChanged += new System.EventHandler(this.lstSorular_SelectedIndexChanged);
            // 
            // grpSinav
            // 
            this.grpSinav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSinav.Controls.Add(this.btnSonraki);
            this.grpSinav.Controls.Add(this.btnBitir);
            this.grpSinav.Controls.Add(this.rbCevapD1);
            this.grpSinav.Controls.Add(this.rbCevapC1);
            this.grpSinav.Controls.Add(this.rbCevapB1);
            this.grpSinav.Controls.Add(this.rbCevapA1);
            this.grpSinav.Controls.Add(this.lblSoru);
            this.grpSinav.Enabled = false;
            this.grpSinav.Location = new System.Drawing.Point(395, 28);
            this.grpSinav.Name = "grpSinav";
            this.grpSinav.Size = new System.Drawing.Size(294, 263);
            this.grpSinav.TabIndex = 1;
            this.grpSinav.TabStop = false;
            this.grpSinav.Text = "Sınav";
            // 
            // btnSonraki
            // 
            this.btnSonraki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSonraki.Location = new System.Drawing.Point(233, 223);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(55, 34);
            this.btnSonraki.TabIndex = 2;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBitir.Location = new System.Drawing.Point(172, 223);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(55, 34);
            this.btnBitir.TabIndex = 2;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // rbCevapD1
            // 
            this.rbCevapD1.AutoSize = true;
            this.rbCevapD1.Location = new System.Drawing.Point(6, 133);
            this.rbCevapD1.Name = "rbCevapD1";
            this.rbCevapD1.Size = new System.Drawing.Size(93, 17);
            this.rbCevapD1.TabIndex = 1;
            this.rbCevapD1.TabStop = true;
            this.rbCevapD1.Tag = "D";
            this.rbCevapD1.Text = "asdasdsadsad";
            this.rbCevapD1.UseVisualStyleBackColor = true;
            // 
            // rbCevapC1
            // 
            this.rbCevapC1.AutoSize = true;
            this.rbCevapC1.Location = new System.Drawing.Point(6, 107);
            this.rbCevapC1.Name = "rbCevapC1";
            this.rbCevapC1.Size = new System.Drawing.Size(92, 17);
            this.rbCevapC1.TabIndex = 1;
            this.rbCevapC1.TabStop = true;
            this.rbCevapC1.Tag = "C";
            this.rbCevapC1.Text = "asdsadasdsds";
            this.rbCevapC1.UseVisualStyleBackColor = true;
            // 
            // rbCevapB1
            // 
            this.rbCevapB1.AutoSize = true;
            this.rbCevapB1.Location = new System.Drawing.Point(6, 81);
            this.rbCevapB1.Name = "rbCevapB1";
            this.rbCevapB1.Size = new System.Drawing.Size(98, 17);
            this.rbCevapB1.TabIndex = 1;
            this.rbCevapB1.TabStop = true;
            this.rbCevapB1.Tag = "B";
            this.rbCevapB1.Text = "asdsadasdsads";
            this.rbCevapB1.UseVisualStyleBackColor = true;
            // 
            // rbCevapA1
            // 
            this.rbCevapA1.AutoSize = true;
            this.rbCevapA1.Location = new System.Drawing.Point(6, 55);
            this.rbCevapA1.Name = "rbCevapA1";
            this.rbCevapA1.Size = new System.Drawing.Size(64, 17);
            this.rbCevapA1.TabIndex = 1;
            this.rbCevapA1.TabStop = true;
            this.rbCevapA1.Tag = "A";
            this.rbCevapA1.Text = "asdasds";
            this.rbCevapA1.UseVisualStyleBackColor = true;
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(6, 19);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(87, 13);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "asdadsdasdsa";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuAc
            // 
            this.mnuAc.Name = "mnuAc";
            this.mnuAc.Size = new System.Drawing.Size(161, 22);
            this.mnuAc.Text = "Aç";
            this.mnuAc.Click += new System.EventHandler(this.mnuAc_Click);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Name = "mnuKaydet";
            this.mnuKaydet.Size = new System.Drawing.Size(161, 22);
            this.mnuKaydet.Text = "Kaydet";
            this.mnuKaydet.Click += new System.EventHandler(this.mnuKaydet_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(161, 22);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 303);
            this.Controls.Add(this.grpSinav);
            this.Controls.Add(this.grpSoruHazirla);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kim 1 ₺ İster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSoruHazirla.ResumeLayout(false);
            this.grpSoruHazirla.PerformLayout();
            this.grpSinav.ResumeLayout(false);
            this.grpSinav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSoruHazirla;
        private System.Windows.Forms.ToolStripMenuItem mnuSoruHazirlaBitir;
        private System.Windows.Forms.GroupBox grpSoruHazirla;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rbCevapD;
        private System.Windows.Forms.RadioButton rbCevapC;
        private System.Windows.Forms.RadioButton rbCevapB;
        private System.Windows.Forms.RadioButton rbCevapA;
        private System.Windows.Forms.TextBox txtCevapD;
        private System.Windows.Forms.TextBox txtCevapC;
        private System.Windows.Forms.TextBox txtCevapB;
        private System.Windows.Forms.TextBox txtCevapA;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSorular;
        private System.Windows.Forms.GroupBox grpSinav;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.RadioButton rbCevapD1;
        private System.Windows.Forms.RadioButton rbCevapC1;
        private System.Windows.Forms.RadioButton rbCevapB1;
        private System.Windows.Forms.RadioButton rbCevapA1;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.ToolStripMenuItem mnuSinavBasla;
        private System.Windows.Forms.ToolStripMenuItem mnuAc;
        private System.Windows.Forms.ToolStripMenuItem mnuKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
    }
}

