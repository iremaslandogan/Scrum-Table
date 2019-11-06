namespace Scrum_Yapısı
{
    partial class FrmScrum
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHikayeOlusturmaSilme = new System.Windows.Forms.TabPage();
            this.btnHikayeSil = new System.Windows.Forms.Button();
            this.txtSilinecekHikayeNo = new System.Windows.Forms.TextBox();
            this.lblSilinecekHikayeNo = new System.Windows.Forms.Label();
            this.btnHikayeOl = new System.Windows.Forms.Button();
            this.txtHikaye = new System.Windows.Forms.TextBox();
            this.lblHikaye = new System.Windows.Forms.Label();
            this.tabPageGorevOlusturmaTasimaSilme = new System.Windows.Forms.TabPage();
            this.cBoxSonrakiBitti = new System.Windows.Forms.CheckBox();
            this.cBoxSonrakiDevam = new System.Windows.Forms.CheckBox();
            this.cBoxOncekiDevam = new System.Windows.Forms.CheckBox();
            this.cBoxOncekiBaslatilmadi = new System.Windows.Forms.CheckBox();
            this.txtTasinacakGorevNo = new System.Windows.Forms.TextBox();
            this.lblTasinacakGorevNo = new System.Windows.Forms.Label();
            this.btnGorevTasi = new System.Windows.Forms.Button();
            this.lblSonrakiKonum = new System.Windows.Forms.Label();
            this.lblOncekiKonum = new System.Windows.Forms.Label();
            this.lblGorevTasi = new System.Windows.Forms.Label();
            this.btnGorevSil = new System.Windows.Forms.Button();
            this.txtSilinecekGorevNo = new System.Windows.Forms.TextBox();
            this.lblSilinecekGorenNo = new System.Windows.Forms.Label();
            this.btnGorevOlustur = new System.Windows.Forms.Button();
            this.rdbtnBitti = new System.Windows.Forms.RadioButton();
            this.rdbtnDevam = new System.Windows.Forms.RadioButton();
            this.rdbtnBaslamadi = new System.Windows.Forms.RadioButton();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.lblGorev = new System.Windows.Forms.Label();
            this.tabPageScrum = new System.Windows.Forms.TabPage();
            this.btnYenile = new System.Windows.Forms.Button();
            this.grBoxBaslatilmadi = new System.Windows.Forms.GroupBox();
            this.flowPanelBaslatilmadi = new System.Windows.Forms.FlowLayoutPanel();
            this.grBoxDevam = new System.Windows.Forms.GroupBox();
            this.flowPanelDevam = new System.Windows.Forms.FlowLayoutPanel();
            this.grBoxBitti = new System.Windows.Forms.GroupBox();
            this.flowPanelBitti = new System.Windows.Forms.FlowLayoutPanel();
            this.grBoxHikayeler = new System.Windows.Forms.GroupBox();
            this.flowPanelHikaye = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPageHikayeOlusturmaSilme.SuspendLayout();
            this.tabPageGorevOlusturmaTasimaSilme.SuspendLayout();
            this.tabPageScrum.SuspendLayout();
            this.grBoxBaslatilmadi.SuspendLayout();
            this.grBoxDevam.SuspendLayout();
            this.grBoxBitti.SuspendLayout();
            this.grBoxHikayeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHikayeOlusturmaSilme);
            this.tabControl1.Controls.Add(this.tabPageGorevOlusturmaTasimaSilme);
            this.tabControl1.Controls.Add(this.tabPageScrum);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1213, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageHikayeOlusturmaSilme
            // 
            this.tabPageHikayeOlusturmaSilme.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageHikayeOlusturmaSilme.Controls.Add(this.btnHikayeSil);
            this.tabPageHikayeOlusturmaSilme.Controls.Add(this.txtSilinecekHikayeNo);
            this.tabPageHikayeOlusturmaSilme.Controls.Add(this.lblSilinecekHikayeNo);
            this.tabPageHikayeOlusturmaSilme.Controls.Add(this.btnHikayeOl);
            this.tabPageHikayeOlusturmaSilme.Controls.Add(this.txtHikaye);
            this.tabPageHikayeOlusturmaSilme.Controls.Add(this.lblHikaye);
            this.tabPageHikayeOlusturmaSilme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageHikayeOlusturmaSilme.Location = new System.Drawing.Point(4, 25);
            this.tabPageHikayeOlusturmaSilme.Name = "tabPageHikayeOlusturmaSilme";
            this.tabPageHikayeOlusturmaSilme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHikayeOlusturmaSilme.Size = new System.Drawing.Size(1205, 542);
            this.tabPageHikayeOlusturmaSilme.TabIndex = 0;
            this.tabPageHikayeOlusturmaSilme.Text = "HİKAYE OLUŞTURMA VE SİLME";
            // 
            // btnHikayeSil
            // 
            this.btnHikayeSil.Location = new System.Drawing.Point(453, 164);
            this.btnHikayeSil.Name = "btnHikayeSil";
            this.btnHikayeSil.Size = new System.Drawing.Size(136, 49);
            this.btnHikayeSil.TabIndex = 7;
            this.btnHikayeSil.Text = "HİKAYE SİL";
            this.btnHikayeSil.UseVisualStyleBackColor = true;
            this.btnHikayeSil.Click += new System.EventHandler(this.btnHikayeSil_Click);
            // 
            // txtSilinecekHikayeNo
            // 
            this.txtSilinecekHikayeNo.Location = new System.Drawing.Point(453, 114);
            this.txtSilinecekHikayeNo.Name = "txtSilinecekHikayeNo";
            this.txtSilinecekHikayeNo.Size = new System.Drawing.Size(100, 22);
            this.txtSilinecekHikayeNo.TabIndex = 6;
            // 
            // lblSilinecekHikayeNo
            // 
            this.lblSilinecekHikayeNo.AutoSize = true;
            this.lblSilinecekHikayeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilinecekHikayeNo.Location = new System.Drawing.Point(450, 74);
            this.lblSilinecekHikayeNo.Name = "lblSilinecekHikayeNo";
            this.lblSilinecekHikayeNo.Size = new System.Drawing.Size(329, 25);
            this.lblSilinecekHikayeNo.TabIndex = 5;
            this.lblSilinecekHikayeNo.Text = "SİLİNECEK HİKAYE NUMARASI";
            // 
            // btnHikayeOl
            // 
            this.btnHikayeOl.Location = new System.Drawing.Point(124, 299);
            this.btnHikayeOl.Name = "btnHikayeOl";
            this.btnHikayeOl.Size = new System.Drawing.Size(131, 49);
            this.btnHikayeOl.TabIndex = 4;
            this.btnHikayeOl.Text = "HİKAYE OLUŞTUR";
            this.btnHikayeOl.UseVisualStyleBackColor = true;
            this.btnHikayeOl.Click += new System.EventHandler(this.btnHikayeOl_Click);
            // 
            // txtHikaye
            // 
            this.txtHikaye.Location = new System.Drawing.Point(102, 103);
            this.txtHikaye.Multiline = true;
            this.txtHikaye.Name = "txtHikaye";
            this.txtHikaye.Size = new System.Drawing.Size(256, 158);
            this.txtHikaye.TabIndex = 2;
            // 
            // lblHikaye
            // 
            this.lblHikaye.AutoSize = true;
            this.lblHikaye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHikaye.Location = new System.Drawing.Point(121, 63);
            this.lblHikaye.Name = "lblHikaye";
            this.lblHikaye.Size = new System.Drawing.Size(91, 25);
            this.lblHikaye.TabIndex = 0;
            this.lblHikaye.Text = "HİKAYE";
            // 
            // tabPageGorevOlusturmaTasimaSilme
            // 
            this.tabPageGorevOlusturmaTasimaSilme.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.cBoxSonrakiBitti);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.cBoxSonrakiDevam);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.cBoxOncekiDevam);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.cBoxOncekiBaslatilmadi);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.txtTasinacakGorevNo);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.lblTasinacakGorevNo);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.btnGorevTasi);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.lblSonrakiKonum);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.lblOncekiKonum);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.lblGorevTasi);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.btnGorevSil);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.txtSilinecekGorevNo);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.lblSilinecekGorenNo);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.btnGorevOlustur);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.rdbtnBitti);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.rdbtnDevam);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.rdbtnBaslamadi);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.txtGorev);
            this.tabPageGorevOlusturmaTasimaSilme.Controls.Add(this.lblGorev);
            this.tabPageGorevOlusturmaTasimaSilme.Location = new System.Drawing.Point(4, 25);
            this.tabPageGorevOlusturmaTasimaSilme.Name = "tabPageGorevOlusturmaTasimaSilme";
            this.tabPageGorevOlusturmaTasimaSilme.Size = new System.Drawing.Size(1205, 542);
            this.tabPageGorevOlusturmaTasimaSilme.TabIndex = 2;
            this.tabPageGorevOlusturmaTasimaSilme.Text = "GÖREV OLUŞTURMA TAŞIMA VE SİLME";
            // 
            // cBoxSonrakiBitti
            // 
            this.cBoxSonrakiBitti.AutoSize = true;
            this.cBoxSonrakiBitti.Location = new System.Drawing.Point(409, 343);
            this.cBoxSonrakiBitti.Name = "cBoxSonrakiBitti";
            this.cBoxSonrakiBitti.Size = new System.Drawing.Size(63, 21);
            this.cBoxSonrakiBitti.TabIndex = 40;
            this.cBoxSonrakiBitti.Text = "BİTTİ";
            this.cBoxSonrakiBitti.UseVisualStyleBackColor = true;
            // 
            // cBoxSonrakiDevam
            // 
            this.cBoxSonrakiDevam.AutoSize = true;
            this.cBoxSonrakiDevam.Location = new System.Drawing.Point(409, 308);
            this.cBoxSonrakiDevam.Name = "cBoxSonrakiDevam";
            this.cBoxSonrakiDevam.Size = new System.Drawing.Size(147, 21);
            this.cBoxSonrakiDevam.TabIndex = 39;
            this.cBoxSonrakiDevam.Text = "DEVAM ETMEKTE";
            this.cBoxSonrakiDevam.UseVisualStyleBackColor = true;
            // 
            // cBoxOncekiDevam
            // 
            this.cBoxOncekiDevam.AutoSize = true;
            this.cBoxOncekiDevam.Location = new System.Drawing.Point(409, 222);
            this.cBoxOncekiDevam.Name = "cBoxOncekiDevam";
            this.cBoxOncekiDevam.Size = new System.Drawing.Size(147, 21);
            this.cBoxOncekiDevam.TabIndex = 38;
            this.cBoxOncekiDevam.Text = "DEVAM ETMEKTE";
            this.cBoxOncekiDevam.UseVisualStyleBackColor = true;
            // 
            // cBoxOncekiBaslatilmadi
            // 
            this.cBoxOncekiBaslatilmadi.AutoSize = true;
            this.cBoxOncekiBaslatilmadi.Location = new System.Drawing.Point(409, 190);
            this.cBoxOncekiBaslatilmadi.Name = "cBoxOncekiBaslatilmadi";
            this.cBoxOncekiBaslatilmadi.Size = new System.Drawing.Size(127, 21);
            this.cBoxOncekiBaslatilmadi.TabIndex = 37;
            this.cBoxOncekiBaslatilmadi.Text = "BAŞLATILMADI";
            this.cBoxOncekiBaslatilmadi.UseVisualStyleBackColor = true;
            // 
            // txtTasinacakGorevNo
            // 
            this.txtTasinacakGorevNo.Location = new System.Drawing.Point(409, 115);
            this.txtTasinacakGorevNo.Name = "txtTasinacakGorevNo";
            this.txtTasinacakGorevNo.Size = new System.Drawing.Size(100, 22);
            this.txtTasinacakGorevNo.TabIndex = 36;
            // 
            // lblTasinacakGorevNo
            // 
            this.lblTasinacakGorevNo.AutoSize = true;
            this.lblTasinacakGorevNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTasinacakGorevNo.Location = new System.Drawing.Point(406, 83);
            this.lblTasinacakGorevNo.Name = "lblTasinacakGorevNo";
            this.lblTasinacakGorevNo.Size = new System.Drawing.Size(237, 17);
            this.lblTasinacakGorevNo.TabIndex = 35;
            this.lblTasinacakGorevNo.Text = "TAŞINACAK GÖREV NUMARASI";
            // 
            // btnGorevTasi
            // 
            this.btnGorevTasi.Location = new System.Drawing.Point(409, 387);
            this.btnGorevTasi.Name = "btnGorevTasi";
            this.btnGorevTasi.Size = new System.Drawing.Size(136, 49);
            this.btnGorevTasi.TabIndex = 34;
            this.btnGorevTasi.Text = "GÖREV TAŞI";
            this.btnGorevTasi.UseVisualStyleBackColor = true;
            this.btnGorevTasi.Click += new System.EventHandler(this.btnGorevTasi_Click);
            // 
            // lblSonrakiKonum
            // 
            this.lblSonrakiKonum.AutoSize = true;
            this.lblSonrakiKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonrakiKonum.Location = new System.Drawing.Point(406, 267);
            this.lblSonrakiKonum.Name = "lblSonrakiKonum";
            this.lblSonrakiKonum.Size = new System.Drawing.Size(137, 17);
            this.lblSonrakiKonum.TabIndex = 33;
            this.lblSonrakiKonum.Text = "SONRAKİ KONUM";
            // 
            // lblOncekiKonum
            // 
            this.lblOncekiKonum.AutoSize = true;
            this.lblOncekiKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOncekiKonum.Location = new System.Drawing.Point(406, 157);
            this.lblOncekiKonum.Name = "lblOncekiKonum";
            this.lblOncekiKonum.Size = new System.Drawing.Size(126, 17);
            this.lblOncekiKonum.TabIndex = 32;
            this.lblOncekiKonum.Text = "ÖNCEKİ KONUM";
            // 
            // lblGorevTasi
            // 
            this.lblGorevTasi.AutoSize = true;
            this.lblGorevTasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorevTasi.Location = new System.Drawing.Point(404, 47);
            this.lblGorevTasi.Name = "lblGorevTasi";
            this.lblGorevTasi.Size = new System.Drawing.Size(144, 25);
            this.lblGorevTasi.TabIndex = 31;
            this.lblGorevTasi.Text = "GÖREV TAŞI";
            // 
            // btnGorevSil
            // 
            this.btnGorevSil.Location = new System.Drawing.Point(686, 133);
            this.btnGorevSil.Name = "btnGorevSil";
            this.btnGorevSil.Size = new System.Drawing.Size(136, 49);
            this.btnGorevSil.TabIndex = 24;
            this.btnGorevSil.Text = "GÖREV SİL";
            this.btnGorevSil.UseVisualStyleBackColor = true;
            this.btnGorevSil.Click += new System.EventHandler(this.btnGorevSil_Click);
            // 
            // txtSilinecekGorevNo
            // 
            this.txtSilinecekGorevNo.Location = new System.Drawing.Point(686, 83);
            this.txtSilinecekGorevNo.Name = "txtSilinecekGorevNo";
            this.txtSilinecekGorevNo.Size = new System.Drawing.Size(100, 22);
            this.txtSilinecekGorevNo.TabIndex = 23;
            // 
            // lblSilinecekGorenNo
            // 
            this.lblSilinecekGorenNo.AutoSize = true;
            this.lblSilinecekGorenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilinecekGorenNo.Location = new System.Drawing.Point(681, 47);
            this.lblSilinecekGorenNo.Name = "lblSilinecekGorenNo";
            this.lblSilinecekGorenNo.Size = new System.Drawing.Size(326, 25);
            this.lblSilinecekGorenNo.TabIndex = 22;
            this.lblSilinecekGorenNo.Text = "SİLİNECEK GÖREV NUMARASI";
            // 
            // btnGorevOlustur
            // 
            this.btnGorevOlustur.Location = new System.Drawing.Point(47, 329);
            this.btnGorevOlustur.Name = "btnGorevOlustur";
            this.btnGorevOlustur.Size = new System.Drawing.Size(131, 46);
            this.btnGorevOlustur.TabIndex = 21;
            this.btnGorevOlustur.Text = "GÖREV OLUŞTUR";
            this.btnGorevOlustur.UseVisualStyleBackColor = true;
            this.btnGorevOlustur.Click += new System.EventHandler(this.btnGorevOlustur_Click);
            // 
            // rdbtnBitti
            // 
            this.rdbtnBitti.AutoSize = true;
            this.rdbtnBitti.Location = new System.Drawing.Point(47, 276);
            this.rdbtnBitti.Name = "rdbtnBitti";
            this.rdbtnBitti.Size = new System.Drawing.Size(62, 21);
            this.rdbtnBitti.TabIndex = 20;
            this.rdbtnBitti.Text = "BİTTİ";
            this.rdbtnBitti.UseVisualStyleBackColor = true;
            // 
            // rdbtnDevam
            // 
            this.rdbtnDevam.AutoSize = true;
            this.rdbtnDevam.Location = new System.Drawing.Point(47, 249);
            this.rdbtnDevam.Name = "rdbtnDevam";
            this.rdbtnDevam.Size = new System.Drawing.Size(146, 21);
            this.rdbtnDevam.TabIndex = 19;
            this.rdbtnDevam.Text = "DEVAM ETMEKTE";
            this.rdbtnDevam.UseVisualStyleBackColor = true;
            // 
            // rdbtnBaslamadi
            // 
            this.rdbtnBaslamadi.AutoSize = true;
            this.rdbtnBaslamadi.Location = new System.Drawing.Point(47, 222);
            this.rdbtnBaslamadi.Name = "rdbtnBaslamadi";
            this.rdbtnBaslamadi.Size = new System.Drawing.Size(126, 21);
            this.rdbtnBaslamadi.TabIndex = 18;
            this.rdbtnBaslamadi.Text = "BAŞLATILMADI";
            this.rdbtnBaslamadi.UseVisualStyleBackColor = true;
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(24, 83);
            this.txtGorev.Multiline = true;
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(325, 98);
            this.txtGorev.TabIndex = 16;
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorev.Location = new System.Drawing.Point(29, 47);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(88, 25);
            this.lblGorev.TabIndex = 15;
            this.lblGorev.Text = "GÖREV";
            // 
            // tabPageScrum
            // 
            this.tabPageScrum.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageScrum.Controls.Add(this.btnYenile);
            this.tabPageScrum.Controls.Add(this.grBoxBaslatilmadi);
            this.tabPageScrum.Controls.Add(this.grBoxDevam);
            this.tabPageScrum.Controls.Add(this.grBoxBitti);
            this.tabPageScrum.Controls.Add(this.grBoxHikayeler);
            this.tabPageScrum.Location = new System.Drawing.Point(4, 25);
            this.tabPageScrum.Name = "tabPageScrum";
            this.tabPageScrum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScrum.Size = new System.Drawing.Size(1205, 542);
            this.tabPageScrum.TabIndex = 1;
            this.tabPageScrum.Text = "SCRUM TABLOSU";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(957, 476);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(182, 43);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // grBoxBaslatilmadi
            // 
            this.grBoxBaslatilmadi.Controls.Add(this.flowPanelBaslatilmadi);
            this.grBoxBaslatilmadi.Location = new System.Drawing.Point(391, 26);
            this.grBoxBaslatilmadi.Name = "grBoxBaslatilmadi";
            this.grBoxBaslatilmadi.Size = new System.Drawing.Size(262, 444);
            this.grBoxBaslatilmadi.TabIndex = 1;
            this.grBoxBaslatilmadi.TabStop = false;
            this.grBoxBaslatilmadi.Text = "BAŞLATILMADI";
            // 
            // flowPanelBaslatilmadi
            // 
            this.flowPanelBaslatilmadi.BackColor = System.Drawing.Color.MistyRose;
            this.flowPanelBaslatilmadi.Location = new System.Drawing.Point(6, 22);
            this.flowPanelBaslatilmadi.Name = "flowPanelBaslatilmadi";
            this.flowPanelBaslatilmadi.Size = new System.Drawing.Size(250, 416);
            this.flowPanelBaslatilmadi.TabIndex = 3;
            // 
            // grBoxDevam
            // 
            this.grBoxDevam.Controls.Add(this.flowPanelDevam);
            this.grBoxDevam.Location = new System.Drawing.Point(659, 26);
            this.grBoxDevam.Name = "grBoxDevam";
            this.grBoxDevam.Size = new System.Drawing.Size(254, 444);
            this.grBoxDevam.TabIndex = 1;
            this.grBoxDevam.TabStop = false;
            this.grBoxDevam.Text = "DEVAM ETMEKTE";
            // 
            // flowPanelDevam
            // 
            this.flowPanelDevam.BackColor = System.Drawing.Color.MistyRose;
            this.flowPanelDevam.Location = new System.Drawing.Point(6, 22);
            this.flowPanelDevam.Name = "flowPanelDevam";
            this.flowPanelDevam.Size = new System.Drawing.Size(242, 416);
            this.flowPanelDevam.TabIndex = 4;
            // 
            // grBoxBitti
            // 
            this.grBoxBitti.Controls.Add(this.flowPanelBitti);
            this.grBoxBitti.Location = new System.Drawing.Point(919, 26);
            this.grBoxBitti.Name = "grBoxBitti";
            this.grBoxBitti.Size = new System.Drawing.Size(258, 444);
            this.grBoxBitti.TabIndex = 1;
            this.grBoxBitti.TabStop = false;
            this.grBoxBitti.Text = "BİTTİ";
            // 
            // flowPanelBitti
            // 
            this.flowPanelBitti.BackColor = System.Drawing.Color.MistyRose;
            this.flowPanelBitti.Location = new System.Drawing.Point(12, 22);
            this.flowPanelBitti.Name = "flowPanelBitti";
            this.flowPanelBitti.Size = new System.Drawing.Size(240, 416);
            this.flowPanelBitti.TabIndex = 4;
            // 
            // grBoxHikayeler
            // 
            this.grBoxHikayeler.Controls.Add(this.flowPanelHikaye);
            this.grBoxHikayeler.Location = new System.Drawing.Point(33, 26);
            this.grBoxHikayeler.Name = "grBoxHikayeler";
            this.grBoxHikayeler.Size = new System.Drawing.Size(228, 444);
            this.grBoxHikayeler.TabIndex = 0;
            this.grBoxHikayeler.TabStop = false;
            this.grBoxHikayeler.Text = "HİKAYELER";
            // 
            // flowPanelHikaye
            // 
            this.flowPanelHikaye.BackColor = System.Drawing.Color.MistyRose;
            this.flowPanelHikaye.Location = new System.Drawing.Point(6, 22);
            this.flowPanelHikaye.Name = "flowPanelHikaye";
            this.flowPanelHikaye.Size = new System.Drawing.Size(213, 416);
            this.flowPanelHikaye.TabIndex = 2;
            // 
            // FrmScrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmScrum";
            this.Text = "Scrum";
            this.Load += new System.EventHandler(this.FrmScrum_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHikayeOlusturmaSilme.ResumeLayout(false);
            this.tabPageHikayeOlusturmaSilme.PerformLayout();
            this.tabPageGorevOlusturmaTasimaSilme.ResumeLayout(false);
            this.tabPageGorevOlusturmaTasimaSilme.PerformLayout();
            this.tabPageScrum.ResumeLayout(false);
            this.grBoxBaslatilmadi.ResumeLayout(false);
            this.grBoxDevam.ResumeLayout(false);
            this.grBoxBitti.ResumeLayout(false);
            this.grBoxHikayeler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHikayeOlusturmaSilme;
        private System.Windows.Forms.TabPage tabPageScrum;
        private System.Windows.Forms.Button btnHikayeOl;
        private System.Windows.Forms.TextBox txtHikaye;
        private System.Windows.Forms.Label lblHikaye;
        private System.Windows.Forms.GroupBox grBoxHikayeler;
        private System.Windows.Forms.GroupBox grBoxBaslatilmadi;
        private System.Windows.Forms.GroupBox grBoxDevam;
        private System.Windows.Forms.GroupBox grBoxBitti;
        private System.Windows.Forms.FlowLayoutPanel flowPanelHikaye;
        private System.Windows.Forms.TabPage tabPageGorevOlusturmaTasimaSilme;
        private System.Windows.Forms.FlowLayoutPanel flowPanelBaslatilmadi;
        private System.Windows.Forms.FlowLayoutPanel flowPanelDevam;
        private System.Windows.Forms.FlowLayoutPanel flowPanelBitti;
        private System.Windows.Forms.RadioButton rdbtnBitti;
        private System.Windows.Forms.RadioButton rdbtnDevam;
        private System.Windows.Forms.RadioButton rdbtnBaslamadi;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnGorevOlustur;
        private System.Windows.Forms.Button btnHikayeSil;
        private System.Windows.Forms.TextBox txtSilinecekHikayeNo;
        private System.Windows.Forms.Label lblSilinecekHikayeNo;
        private System.Windows.Forms.Button btnGorevSil;
        private System.Windows.Forms.TextBox txtSilinecekGorevNo;
        private System.Windows.Forms.Label lblSilinecekGorenNo;
        private System.Windows.Forms.TextBox txtTasinacakGorevNo;
        private System.Windows.Forms.Label lblTasinacakGorevNo;
        private System.Windows.Forms.Button btnGorevTasi;
        private System.Windows.Forms.Label lblSonrakiKonum;
        private System.Windows.Forms.Label lblOncekiKonum;
        private System.Windows.Forms.Label lblGorevTasi;
        private System.Windows.Forms.CheckBox cBoxSonrakiBitti;
        private System.Windows.Forms.CheckBox cBoxSonrakiDevam;
        private System.Windows.Forms.CheckBox cBoxOncekiDevam;
        private System.Windows.Forms.CheckBox cBoxOncekiBaslatilmadi;
    }
}