namespace OtoparkOtomasyonuEnSon
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.pnlCikisYap = new System.Windows.Forms.Panel();
            this.lblCikisYap = new System.Windows.Forms.Label();
            this.picCikisYap = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.@__groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlKayitlar = new System.Windows.Forms.Panel();
            this.lblKayitlar = new System.Windows.Forms.Label();
            this.picKayitlar = new System.Windows.Forms.PictureBox();
            this.pnlFiyatTarifesi = new System.Windows.Forms.Panel();
            this.lblFiyatTarifesi = new System.Windows.Forms.Label();
            this.picFiyatTarifesi = new System.Windows.Forms.PictureBox();
            this.@__label2 = new System.Windows.Forms.Label();
            this.@__label1 = new System.Windows.Forms.Label();
            this.@__groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlManuelGiris = new System.Windows.Forms.Panel();
            this.lblManuelGiris = new System.Windows.Forms.Label();
            this.picManuelGiris = new System.Windows.Forms.PictureBox();
            this.pnlOtomatikCikis = new System.Windows.Forms.Panel();
            this.lblOtomatikCikis = new System.Windows.Forms.Label();
            this.picOtomatikCikis = new System.Windows.Forms.PictureBox();
            this.@__pictureBox1 = new System.Windows.Forms.PictureBox();
            this.@__label3 = new System.Windows.Forms.Label();
            this.pnlOtomatikGiris = new System.Windows.Forms.Panel();
            this.lblOtomatikGiris = new System.Windows.Forms.Label();
            this.picOtomatikGiris = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlCikisYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.@__groupBox1.SuspendLayout();
            this.pnlKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKayitlar)).BeginInit();
            this.pnlFiyatTarifesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFiyatTarifesi)).BeginInit();
            this.@__groupBox2.SuspendLayout();
            this.pnlManuelGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManuelGiris)).BeginInit();
            this.pnlOtomatikCikis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOtomatikCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.@__pictureBox1)).BeginInit();
            this.pnlOtomatikGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOtomatikGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCikisYap
            // 
            this.pnlCikisYap.Controls.Add(this.lblCikisYap);
            this.pnlCikisYap.Controls.Add(this.picCikisYap);
            this.pnlCikisYap.Location = new System.Drawing.Point(8, 15);
            this.pnlCikisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCikisYap.Name = "pnlCikisYap";
            this.pnlCikisYap.Size = new System.Drawing.Size(177, 69);
            this.pnlCikisYap.TabIndex = 7;
            this.pnlCikisYap.Click += new System.EventHandler(this.PnlFiyatTarifesi_MouseLeave);
            this.pnlCikisYap.MouseEnter += new System.EventHandler(this.PanCikisYap_MouseEnter);
            this.pnlCikisYap.MouseLeave += new System.EventHandler(this.PanCikisYap_MouseLeave);
            // 
            // lblCikisYap
            // 
            this.lblCikisYap.AutoSize = true;
            this.lblCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisYap.ForeColor = System.Drawing.Color.White;
            this.lblCikisYap.Location = new System.Drawing.Point(79, 22);
            this.lblCikisYap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCikisYap.Name = "lblCikisYap";
            this.lblCikisYap.Size = new System.Drawing.Size(87, 24);
            this.lblCikisYap.TabIndex = 1;
            this.lblCikisYap.Text = "Çıkış Yap";
            this.lblCikisYap.Click += new System.EventHandler(this.LblCikisYap_Click);
            this.lblCikisYap.MouseEnter += new System.EventHandler(this.LblCikisYap_MouseEnter);
            this.lblCikisYap.MouseLeave += new System.EventHandler(this.LblCikisYap_MouseLeave);
            // 
            // picCikisYap
            // 
            this.picCikisYap.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_logout;
            this.picCikisYap.Location = new System.Drawing.Point(4, 4);
            this.picCikisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCikisYap.Name = "picCikisYap";
            this.picCikisYap.Size = new System.Drawing.Size(67, 62);
            this.picCikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCikisYap.TabIndex = 0;
            this.picCikisYap.TabStop = false;
            this.picCikisYap.Click += new System.EventHandler(this.PicCikisYap_Click);
            this.picCikisYap.MouseEnter += new System.EventHandler(this.PicCikisYap_MouseEnter);
            this.picCikisYap.MouseLeave += new System.EventHandler(this.PicCikisYap_MouseLeave);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(28)))), ((int)(((byte)(158)))));
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripKullanici,
            this.toolStripStatusLabel1,
            this.stripSaat});
            this.statusStrip.Location = new System.Drawing.Point(0, 545);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1059, 35);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 8;
            // 
            // stripKullanici
            // 
            this.stripKullanici.ForeColor = System.Drawing.Color.White;
            this.stripKullanici.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_admin;
            this.stripKullanici.Name = "stripKullanici";
            this.stripKullanici.Size = new System.Drawing.Size(87, 29);
            this.stripKullanici.Text = "Admin";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(827, 29);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // stripSaat
            // 
            this.stripSaat.BackColor = System.Drawing.Color.Transparent;
            this.stripSaat.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.stripSaat.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stripSaat.ForeColor = System.Drawing.Color.White;
            this.stripSaat.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_clock;
            this.stripSaat.Name = "stripSaat";
            this.stripSaat.Size = new System.Drawing.Size(125, 29);
            this.stripSaat.Text = "Saat: 12.00";
            // 
            // __groupBox1
            // 
            this.@__groupBox1.Controls.Add(this.pnlKayitlar);
            this.@__groupBox1.Controls.Add(this.pnlFiyatTarifesi);
            this.@__groupBox1.Controls.Add(this.@__label2);
            this.@__groupBox1.Controls.Add(this.@__label1);
            this.@__groupBox1.Controls.Add(this.pnlCikisYap);
            this.@__groupBox1.Location = new System.Drawing.Point(16, 15);
            this.@__groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.@__groupBox1.Name = "__groupBox1";
            this.@__groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.@__groupBox1.Size = new System.Drawing.Size(1035, 94);
            this.@__groupBox1.TabIndex = 9;
            this.@__groupBox1.TabStop = false;
            // 
            // pnlKayitlar
            // 
            this.pnlKayitlar.Controls.Add(this.lblKayitlar);
            this.pnlKayitlar.Controls.Add(this.picKayitlar);
            this.pnlKayitlar.Location = new System.Drawing.Point(403, 15);
            this.pnlKayitlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKayitlar.Name = "pnlKayitlar";
            this.pnlKayitlar.Size = new System.Drawing.Size(160, 69);
            this.pnlKayitlar.TabIndex = 9;
            this.pnlKayitlar.Click += new System.EventHandler(this.PnlKayitlar_Click);
            this.pnlKayitlar.MouseEnter += new System.EventHandler(this.PnlKayitlar_MouseEnter);
            this.pnlKayitlar.MouseLeave += new System.EventHandler(this.PnlKayitlar_MouseLeave);
            // 
            // lblKayitlar
            // 
            this.lblKayitlar.AutoSize = true;
            this.lblKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitlar.ForeColor = System.Drawing.Color.White;
            this.lblKayitlar.Location = new System.Drawing.Point(79, 22);
            this.lblKayitlar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKayitlar.Name = "lblKayitlar";
            this.lblKayitlar.Size = new System.Drawing.Size(69, 24);
            this.lblKayitlar.TabIndex = 1;
            this.lblKayitlar.Text = "Kayıtlar";
            this.lblKayitlar.Click += new System.EventHandler(this.LblKayitlar_Click);
            this.lblKayitlar.MouseEnter += new System.EventHandler(this.LblKayitlar_MouseEnter);
            this.lblKayitlar.MouseLeave += new System.EventHandler(this.LblKayitlar_MouseLeave);
            // 
            // picKayitlar
            // 
            this.picKayitlar.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_ledger;
            this.picKayitlar.Location = new System.Drawing.Point(4, 4);
            this.picKayitlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picKayitlar.Name = "picKayitlar";
            this.picKayitlar.Size = new System.Drawing.Size(67, 62);
            this.picKayitlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKayitlar.TabIndex = 0;
            this.picKayitlar.TabStop = false;
            this.picKayitlar.Click += new System.EventHandler(this.PicKayitlar_Click);
            this.picKayitlar.MouseEnter += new System.EventHandler(this.PicKayitlar_MouseEnter);
            this.picKayitlar.MouseLeave += new System.EventHandler(this.PicKayitlar_MouseLeave);
            // 
            // pnlFiyatTarifesi
            // 
            this.pnlFiyatTarifesi.Controls.Add(this.lblFiyatTarifesi);
            this.pnlFiyatTarifesi.Controls.Add(this.picFiyatTarifesi);
            this.pnlFiyatTarifesi.Location = new System.Drawing.Point(193, 15);
            this.pnlFiyatTarifesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFiyatTarifesi.Name = "pnlFiyatTarifesi";
            this.pnlFiyatTarifesi.Size = new System.Drawing.Size(201, 69);
            this.pnlFiyatTarifesi.TabIndex = 8;
            this.pnlFiyatTarifesi.Click += new System.EventHandler(this.PnlFiyatTarifesi_Click);
            this.pnlFiyatTarifesi.MouseEnter += new System.EventHandler(this.PnlFiyatTarifesi_MouseEnter);
            this.pnlFiyatTarifesi.MouseLeave += new System.EventHandler(this.PnlFiyatTarifesi_MouseLeave);
            // 
            // lblFiyatTarifesi
            // 
            this.lblFiyatTarifesi.AutoSize = true;
            this.lblFiyatTarifesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyatTarifesi.ForeColor = System.Drawing.Color.White;
            this.lblFiyatTarifesi.Location = new System.Drawing.Point(79, 22);
            this.lblFiyatTarifesi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyatTarifesi.Name = "lblFiyatTarifesi";
            this.lblFiyatTarifesi.Size = new System.Drawing.Size(114, 24);
            this.lblFiyatTarifesi.TabIndex = 1;
            this.lblFiyatTarifesi.Text = "Fiyat Tarifesi";
            this.lblFiyatTarifesi.Click += new System.EventHandler(this.LblFiyatTarifesi_Click);
            this.lblFiyatTarifesi.MouseEnter += new System.EventHandler(this.LblFiyatTarifesi_MouseEnter);
            this.lblFiyatTarifesi.MouseLeave += new System.EventHandler(this.LblFiyatTarifesi_MouseLeave);
            // 
            // picFiyatTarifesi
            // 
            this.picFiyatTarifesi.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_price;
            this.picFiyatTarifesi.Location = new System.Drawing.Point(4, 4);
            this.picFiyatTarifesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picFiyatTarifesi.Name = "picFiyatTarifesi";
            this.picFiyatTarifesi.Size = new System.Drawing.Size(67, 62);
            this.picFiyatTarifesi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFiyatTarifesi.TabIndex = 0;
            this.picFiyatTarifesi.TabStop = false;
            this.picFiyatTarifesi.Click += new System.EventHandler(this.PicFiyatTarifesi_Click);
            this.picFiyatTarifesi.MouseEnter += new System.EventHandler(this.PicFiyatTarifesi_MouseEnter);
            this.picFiyatTarifesi.MouseLeave += new System.EventHandler(this.PicFiyatTarifesi_MouseLeave);
            // 
            // __label2
            // 
            this.@__label2.AutoSize = true;
            this.@__label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label2.ForeColor = System.Drawing.Color.White;
            this.@__label2.Location = new System.Drawing.Point(868, 48);
            this.@__label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.@__label2.Name = "__label2";
            this.@__label2.Size = new System.Drawing.Size(150, 24);
            this.@__label2.TabIndex = 11;
            this.@__label2.Text = "versiyon 2023.01";
            // 
            // __label1
            // 
            this.@__label1.AutoSize = true;
            this.@__label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label1.ForeColor = System.Drawing.Color.White;
            this.@__label1.Location = new System.Drawing.Point(704, 18);
            this.@__label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.@__label1.Name = "__label1";
            this.@__label1.Size = new System.Drawing.Size(313, 29);
            this.@__label1.TabIndex = 10;
            this.@__label1.Text = "Otopark Otomasyon Sistemi";
            // 
            // __groupBox2
            // 
            this.@__groupBox2.Controls.Add(this.pnlManuelGiris);
            this.@__groupBox2.Controls.Add(this.pnlOtomatikCikis);
            this.@__groupBox2.Controls.Add(this.@__pictureBox1);
            this.@__groupBox2.Controls.Add(this.@__label3);
            this.@__groupBox2.Controls.Add(this.pnlOtomatikGiris);
            this.@__groupBox2.Location = new System.Drawing.Point(16, 116);
            this.@__groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.@__groupBox2.Name = "__groupBox2";
            this.@__groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.@__groupBox2.Size = new System.Drawing.Size(1035, 101);
            this.@__groupBox2.TabIndex = 10;
            this.@__groupBox2.TabStop = false;
            // 
            // pnlManuelGiris
            // 
            this.pnlManuelGiris.Controls.Add(this.lblManuelGiris);
            this.pnlManuelGiris.Controls.Add(this.picManuelGiris);
            this.pnlManuelGiris.Location = new System.Drawing.Point(552, 18);
            this.pnlManuelGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlManuelGiris.Name = "pnlManuelGiris";
            this.pnlManuelGiris.Size = new System.Drawing.Size(219, 69);
            this.pnlManuelGiris.TabIndex = 10;
            this.pnlManuelGiris.Click += new System.EventHandler(this.PnlManuelGiris_Click);
            this.pnlManuelGiris.MouseEnter += new System.EventHandler(this.PnlManuelGiris_MouseEnter);
            this.pnlManuelGiris.MouseLeave += new System.EventHandler(this.PnlManuelGiris_MouseLeave);
            // 
            // lblManuelGiris
            // 
            this.lblManuelGiris.AutoSize = true;
            this.lblManuelGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManuelGiris.ForeColor = System.Drawing.Color.White;
            this.lblManuelGiris.Location = new System.Drawing.Point(79, 22);
            this.lblManuelGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManuelGiris.Name = "lblManuelGiris";
            this.lblManuelGiris.Size = new System.Drawing.Size(115, 24);
            this.lblManuelGiris.TabIndex = 1;
            this.lblManuelGiris.Text = "Manuel Giriş";
            this.lblManuelGiris.Click += new System.EventHandler(this.LblManuelGiris_Click);
            this.lblManuelGiris.MouseEnter += new System.EventHandler(this.LblManuelGiris_MouseEnter);
            this.lblManuelGiris.MouseLeave += new System.EventHandler(this.LblManuelGiris_MouseLeave);
            // 
            // picManuelGiris
            // 
            this.picManuelGiris.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_mancar;
            this.picManuelGiris.Location = new System.Drawing.Point(4, 4);
            this.picManuelGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picManuelGiris.Name = "picManuelGiris";
            this.picManuelGiris.Size = new System.Drawing.Size(67, 62);
            this.picManuelGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picManuelGiris.TabIndex = 0;
            this.picManuelGiris.TabStop = false;
            this.picManuelGiris.Click += new System.EventHandler(this.PicManuelGiris_Click);
            this.picManuelGiris.MouseEnter += new System.EventHandler(this.PicManuelGiris_MouseEnter);
            this.picManuelGiris.MouseLeave += new System.EventHandler(this.PicManuelGiris_MouseLeave);
            // 
            // pnlOtomatikCikis
            // 
            this.pnlOtomatikCikis.Controls.Add(this.lblOtomatikCikis);
            this.pnlOtomatikCikis.Controls.Add(this.picOtomatikCikis);
            this.pnlOtomatikCikis.Location = new System.Drawing.Point(317, 18);
            this.pnlOtomatikCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOtomatikCikis.Name = "pnlOtomatikCikis";
            this.pnlOtomatikCikis.Size = new System.Drawing.Size(227, 69);
            this.pnlOtomatikCikis.TabIndex = 11;
            this.pnlOtomatikCikis.Click += new System.EventHandler(this.PnlOtomatikCikis_Click);
            this.pnlOtomatikCikis.MouseEnter += new System.EventHandler(this.PnlOtomatikCikis_MouseEnter);
            this.pnlOtomatikCikis.MouseLeave += new System.EventHandler(this.PnlOtomatikCikis_MouseLeave);
            // 
            // lblOtomatikCikis
            // 
            this.lblOtomatikCikis.AutoSize = true;
            this.lblOtomatikCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtomatikCikis.ForeColor = System.Drawing.Color.White;
            this.lblOtomatikCikis.Location = new System.Drawing.Point(79, 22);
            this.lblOtomatikCikis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtomatikCikis.Name = "lblOtomatikCikis";
            this.lblOtomatikCikis.Size = new System.Drawing.Size(127, 24);
            this.lblOtomatikCikis.TabIndex = 1;
            this.lblOtomatikCikis.Text = "Otomatik Çıkış";
            this.lblOtomatikCikis.Click += new System.EventHandler(this.LblOtomatikCikis_Click);
            this.lblOtomatikCikis.MouseEnter += new System.EventHandler(this.LblOtomatikCikis_MouseEnter);
            this.lblOtomatikCikis.MouseLeave += new System.EventHandler(this.LblOtomatikCikis_MouseLeave);
            // 
            // picOtomatikCikis
            // 
            this.picOtomatikCikis.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_otolev;
            this.picOtomatikCikis.Location = new System.Drawing.Point(4, 4);
            this.picOtomatikCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picOtomatikCikis.Name = "picOtomatikCikis";
            this.picOtomatikCikis.Size = new System.Drawing.Size(67, 62);
            this.picOtomatikCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOtomatikCikis.TabIndex = 0;
            this.picOtomatikCikis.TabStop = false;
            this.picOtomatikCikis.Click += new System.EventHandler(this.PicOtomatikCikis_Click);
            this.picOtomatikCikis.MouseEnter += new System.EventHandler(this.PicOtomatikCikis_MouseEnter);
            this.picOtomatikCikis.MouseLeave += new System.EventHandler(this.PicOtomatikCikis_MouseLeave);
            // 
            // __pictureBox1
            // 
            this.@__pictureBox1.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_car;
            this.@__pictureBox1.Location = new System.Drawing.Point(8, 22);
            this.@__pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.@__pictureBox1.Name = "__pictureBox1";
            this.@__pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.@__pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.@__pictureBox1.TabIndex = 2;
            this.@__pictureBox1.TabStop = false;
            // 
            // __label3
            // 
            this.@__label3.AutoSize = true;
            this.@__label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label3.ForeColor = System.Drawing.Color.White;
            this.@__label3.Location = new System.Drawing.Point(857, 18);
            this.@__label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.@__label3.Name = "__label3";
            this.@__label3.Size = new System.Drawing.Size(162, 29);
            this.@__label3.TabIndex = 12;
            this.@__label3.Text = "Araç Yönetimi";
            // 
            // pnlOtomatikGiris
            // 
            this.pnlOtomatikGiris.Controls.Add(this.lblOtomatikGiris);
            this.pnlOtomatikGiris.Controls.Add(this.picOtomatikGiris);
            this.pnlOtomatikGiris.Location = new System.Drawing.Point(91, 18);
            this.pnlOtomatikGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOtomatikGiris.Name = "pnlOtomatikGiris";
            this.pnlOtomatikGiris.Size = new System.Drawing.Size(219, 69);
            this.pnlOtomatikGiris.TabIndex = 9;
            this.pnlOtomatikGiris.Click += new System.EventHandler(this.PnlOtomatikGiris_Click);
            this.pnlOtomatikGiris.MouseEnter += new System.EventHandler(this.PnlOtomatikGiris_MouseEnter);
            this.pnlOtomatikGiris.MouseLeave += new System.EventHandler(this.PnlOtomatikGiris_MouseLeave);
            // 
            // lblOtomatikGiris
            // 
            this.lblOtomatikGiris.AutoSize = true;
            this.lblOtomatikGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtomatikGiris.ForeColor = System.Drawing.Color.White;
            this.lblOtomatikGiris.Location = new System.Drawing.Point(79, 22);
            this.lblOtomatikGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtomatikGiris.Name = "lblOtomatikGiris";
            this.lblOtomatikGiris.Size = new System.Drawing.Size(125, 24);
            this.lblOtomatikGiris.TabIndex = 1;
            this.lblOtomatikGiris.Text = "Otomatik Giriş";
            this.lblOtomatikGiris.Click += new System.EventHandler(this.LblOtomatikGiris_Click);
            this.lblOtomatikGiris.MouseEnter += new System.EventHandler(this.LblOtomatikGiris_MouseEnter);
            this.lblOtomatikGiris.MouseLeave += new System.EventHandler(this.LblOtomatikGiris_MouseLeave);
            // 
            // picOtomatikGiris
            // 
            this.picOtomatikGiris.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_otocar;
            this.picOtomatikGiris.Location = new System.Drawing.Point(4, 4);
            this.picOtomatikGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picOtomatikGiris.Name = "picOtomatikGiris";
            this.picOtomatikGiris.Size = new System.Drawing.Size(67, 62);
            this.picOtomatikGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOtomatikGiris.TabIndex = 0;
            this.picOtomatikGiris.TabStop = false;
            this.picOtomatikGiris.Click += new System.EventHandler(this.PicOtomatikGiris_Click);
            this.picOtomatikGiris.MouseEnter += new System.EventHandler(this.PicOtomatikGiris_MouseEnter);
            this.picOtomatikGiris.MouseLeave += new System.EventHandler(this.PicOtomatikGiris_MouseLeave);
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(33)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1059, 580);
            this.Controls.Add(this.@__groupBox2);
            this.Controls.Add(this.@__groupBox1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1077, 627);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGiris_FormClosed);
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.pnlCikisYap.ResumeLayout(false);
            this.pnlCikisYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.@__groupBox1.ResumeLayout(false);
            this.@__groupBox1.PerformLayout();
            this.pnlKayitlar.ResumeLayout(false);
            this.pnlKayitlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKayitlar)).EndInit();
            this.pnlFiyatTarifesi.ResumeLayout(false);
            this.pnlFiyatTarifesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFiyatTarifesi)).EndInit();
            this.@__groupBox2.ResumeLayout(false);
            this.@__groupBox2.PerformLayout();
            this.pnlManuelGiris.ResumeLayout(false);
            this.pnlManuelGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManuelGiris)).EndInit();
            this.pnlOtomatikCikis.ResumeLayout(false);
            this.pnlOtomatikCikis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOtomatikCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.@__pictureBox1)).EndInit();
            this.pnlOtomatikGiris.ResumeLayout(false);
            this.pnlOtomatikGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOtomatikGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
 
        private System.Windows.Forms.Panel pnlCikisYap;
        private System.Windows.Forms.PictureBox picCikisYap;
        private System.Windows.Forms.Label lblCikisYap;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stripSaat;

        #endregion

        private System.Windows.Forms.GroupBox __groupBox1;
        private System.Windows.Forms.Label __label1;
        private System.Windows.Forms.Label __label2;
        private System.Windows.Forms.Panel pnlFiyatTarifesi;
        private System.Windows.Forms.Label lblFiyatTarifesi;
        private System.Windows.Forms.PictureBox picFiyatTarifesi;
        private System.Windows.Forms.GroupBox __groupBox2;
        private System.Windows.Forms.Panel pnlOtomatikGiris;
        private System.Windows.Forms.Label lblOtomatikGiris;
        private System.Windows.Forms.PictureBox picOtomatikGiris;
        private System.Windows.Forms.Label __label3;
        private System.Windows.Forms.PictureBox __pictureBox1;
        private System.Windows.Forms.Panel pnlManuelGiris;
        private System.Windows.Forms.Label lblManuelGiris;
        private System.Windows.Forms.PictureBox picManuelGiris;
        private System.Windows.Forms.Panel pnlOtomatikCikis;
        private System.Windows.Forms.Label lblOtomatikCikis;
        private System.Windows.Forms.PictureBox picOtomatikCikis;
        private System.Windows.Forms.ToolStripStatusLabel stripKullanici;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlKayitlar;
        private System.Windows.Forms.Label lblKayitlar;
        private System.Windows.Forms.PictureBox picKayitlar;
    }
}