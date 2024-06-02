namespace say_t_projesi
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
            this.pinTitle = new System.Windows.Forms.Panel();
            this.Hidebutton = new System.Windows.Forms.Button();
            this.Boyutlandırbutton = new System.Windows.Forms.Button();
            this.EXİTbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XOR = new System.Windows.Forms.Button();
            this.OR = new System.Windows.Forms.Button();
            this.Bag_Nokta = new System.Windows.Forms.Button();
            this.Cizgi = new System.Windows.Forms.Button();
            this.DURDUR = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.CALISTIR = new System.Windows.Forms.Button();
            this.Cikis_K = new System.Windows.Forms.Button();
            this.LED = new System.Windows.Forms.Button();
            this.Giris_K = new System.Windows.Forms.Button();
            this.BUFFER = new System.Windows.Forms.Button();
            this.AND = new System.Windows.Forms.Button();
            this.NAND = new System.Windows.Forms.Button();
            this.NOT = new System.Windows.Forms.Button();
            this.NOR = new System.Windows.Forms.Button();
            this.XNOR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formBorderDesign1 = new say_t_projesi.FormBorderDesign();
            this.panelMain = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.pinTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pinTitle
            // 
            this.pinTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pinTitle.Controls.Add(this.Hidebutton);
            this.pinTitle.Controls.Add(this.Boyutlandırbutton);
            this.pinTitle.Controls.Add(this.EXİTbutton);
            this.pinTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pinTitle.ForeColor = System.Drawing.Color.DimGray;
            this.pinTitle.Location = new System.Drawing.Point(0, 0);
            this.pinTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pinTitle.Name = "pinTitle";
            this.pinTitle.Size = new System.Drawing.Size(1200, 40);
            this.pinTitle.TabIndex = 0;
            // 
            // Hidebutton
            // 
            this.Hidebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Hidebutton.FlatAppearance.BorderSize = 0;
            this.Hidebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Hidebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hidebutton.Image = ((System.Drawing.Image)(resources.GetObject("Hidebutton.Image")));
            this.Hidebutton.Location = new System.Drawing.Point(1080, 0);
            this.Hidebutton.Margin = new System.Windows.Forms.Padding(0);
            this.Hidebutton.Name = "Hidebutton";
            this.Hidebutton.Size = new System.Drawing.Size(40, 40);
            this.Hidebutton.TabIndex = 2;
            this.Hidebutton.UseVisualStyleBackColor = true;
            this.Hidebutton.Click += new System.EventHandler(this.Hidebutton_Click);
            // 
            // Boyutlandırbutton
            // 
            this.Boyutlandırbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Boyutlandırbutton.FlatAppearance.BorderSize = 0;
            this.Boyutlandırbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Boyutlandırbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boyutlandırbutton.Image = ((System.Drawing.Image)(resources.GetObject("Boyutlandırbutton.Image")));
            this.Boyutlandırbutton.Location = new System.Drawing.Point(1120, 0);
            this.Boyutlandırbutton.Margin = new System.Windows.Forms.Padding(0);
            this.Boyutlandırbutton.Name = "Boyutlandırbutton";
            this.Boyutlandırbutton.Size = new System.Drawing.Size(40, 40);
            this.Boyutlandırbutton.TabIndex = 1;
            this.Boyutlandırbutton.UseVisualStyleBackColor = true;
            this.Boyutlandırbutton.Click += new System.EventHandler(this.Boyutlandırbutton_Click);
            // 
            // EXİTbutton
            // 
            this.EXİTbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.EXİTbutton.FlatAppearance.BorderSize = 0;
            this.EXİTbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.EXİTbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXİTbutton.Image = ((System.Drawing.Image)(resources.GetObject("EXİTbutton.Image")));
            this.EXİTbutton.Location = new System.Drawing.Point(1160, 0);
            this.EXİTbutton.Margin = new System.Windows.Forms.Padding(0);
            this.EXİTbutton.Name = "EXİTbutton";
            this.EXİTbutton.Size = new System.Drawing.Size(40, 40);
            this.EXİTbutton.TabIndex = 0;
            this.EXİTbutton.UseVisualStyleBackColor = true;
            this.EXİTbutton.Click += new System.EventHandler(this.EXİTbutton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.ColumnCount = 21;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.XOR, 15, 0);
            this.tableLayoutPanel1.Controls.Add(this.OR, 14, 0);
            this.tableLayoutPanel1.Controls.Add(this.Bag_Nokta, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cizgi, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.DURDUR, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.RESET, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CALISTIR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cikis_K, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.LED, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.Giris_K, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUFFER, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.AND, 16, 0);
            this.tableLayoutPanel1.Controls.Add(this.NAND, 17, 0);
            this.tableLayoutPanel1.Controls.Add(this.NOT, 13, 0);
            this.tableLayoutPanel1.Controls.Add(this.NOR, 18, 0);
            this.tableLayoutPanel1.Controls.Add(this.XNOR, 19, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 14, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(233, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giris-Cıkıs Araclari";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kontrol Tusları";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XOR
            // 
            this.XOR.Image = ((System.Drawing.Image)(resources.GetObject("XOR.Image")));
            this.XOR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XOR.Location = new System.Drawing.Point(805, 5);
            this.XOR.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(60, 46);
            this.XOR.TabIndex = 13;
            this.XOR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // OR
            // 
            this.OR.Image = ((System.Drawing.Image)(resources.GetObject("OR.Image")));
            this.OR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OR.Location = new System.Drawing.Point(735, 5);
            this.OR.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(60, 46);
            this.OR.TabIndex = 11;
            this.OR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OR.UseVisualStyleBackColor = true;
            this.OR.Click += new System.EventHandler(this.OR_Click);
            // 
            // Bag_Nokta
            // 
            this.Bag_Nokta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Bag_Nokta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Bag_Nokta.Image = ((System.Drawing.Image)(resources.GetObject("Bag_Nokta.Image")));
            this.Bag_Nokta.Location = new System.Drawing.Point(505, 5);
            this.Bag_Nokta.Margin = new System.Windows.Forms.Padding(5);
            this.Bag_Nokta.Name = "Bag_Nokta";
            this.Bag_Nokta.Size = new System.Drawing.Size(50, 50);
            this.Bag_Nokta.TabIndex = 7;
            this.Bag_Nokta.UseVisualStyleBackColor = true;
            // 
            // Cizgi
            // 
            this.Cizgi.Image = ((System.Drawing.Image)(resources.GetObject("Cizgi.Image")));
            this.Cizgi.Location = new System.Drawing.Point(445, 5);
            this.Cizgi.Margin = new System.Windows.Forms.Padding(5);
            this.Cizgi.Name = "Cizgi";
            this.Cizgi.Size = new System.Drawing.Size(50, 50);
            this.Cizgi.TabIndex = 6;
            this.Cizgi.UseVisualStyleBackColor = true;
            this.Cizgi.Click += new System.EventHandler(this.Cizgi_Click);
            // 
            // DURDUR
            // 
            this.DURDUR.ForeColor = System.Drawing.Color.Transparent;
            this.DURDUR.Image = ((System.Drawing.Image)(resources.GetObject("DURDUR.Image")));
            this.DURDUR.Location = new System.Drawing.Point(145, 5);
            this.DURDUR.Margin = new System.Windows.Forms.Padding(5);
            this.DURDUR.Name = "DURDUR";
            this.DURDUR.Size = new System.Drawing.Size(50, 50);
            this.DURDUR.TabIndex = 4;
            this.DURDUR.UseVisualStyleBackColor = true;
            // 
            // RESET
            // 
            this.RESET.ForeColor = System.Drawing.Color.Transparent;
            this.RESET.Image = ((System.Drawing.Image)(resources.GetObject("RESET.Image")));
            this.RESET.Location = new System.Drawing.Point(85, 5);
            this.RESET.Margin = new System.Windows.Forms.Padding(5);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(50, 50);
            this.RESET.TabIndex = 3;
            this.RESET.UseVisualStyleBackColor = true;
            // 
            // CALISTIR
            // 
            this.CALISTIR.ForeColor = System.Drawing.Color.Transparent;
            this.CALISTIR.Image = ((System.Drawing.Image)(resources.GetObject("CALISTIR.Image")));
            this.CALISTIR.Location = new System.Drawing.Point(25, 5);
            this.CALISTIR.Margin = new System.Windows.Forms.Padding(5);
            this.CALISTIR.Name = "CALISTIR";
            this.CALISTIR.Size = new System.Drawing.Size(50, 50);
            this.CALISTIR.TabIndex = 2;
            this.CALISTIR.UseVisualStyleBackColor = true;
            
            // 
            // Cikis_K
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Cikis_K, 2);
            this.Cikis_K.Image = ((System.Drawing.Image)(resources.GetObject("Cikis_K.Image")));
            this.Cikis_K.Location = new System.Drawing.Point(355, 5);
            this.Cikis_K.Margin = new System.Windows.Forms.Padding(5);
            this.Cikis_K.Name = "Cikis_K";
            this.Cikis_K.Size = new System.Drawing.Size(50, 50);
            this.Cikis_K.TabIndex = 2;
            this.Cikis_K.UseVisualStyleBackColor = true;
            this.Cikis_K.Click += new System.EventHandler(this.Cikis_K_Click);
            // 
            // LED
            // 
            this.LED.Image = ((System.Drawing.Image)(resources.GetObject("LED.Image")));
            this.LED.Location = new System.Drawing.Point(295, 5);
            this.LED.Margin = new System.Windows.Forms.Padding(5);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(50, 50);
            this.LED.TabIndex = 5;
            this.LED.UseVisualStyleBackColor = true;
            this.LED.Click += new System.EventHandler(this.LED_Click);
            // 
            // Giris_K
            // 
            this.Giris_K.Image = ((System.Drawing.Image)(resources.GetObject("Giris_K.Image")));
            this.Giris_K.Location = new System.Drawing.Point(235, 5);
            this.Giris_K.Margin = new System.Windows.Forms.Padding(5);
            this.Giris_K.Name = "Giris_K";
            this.Giris_K.Size = new System.Drawing.Size(50, 50);
            this.Giris_K.TabIndex = 3;
            this.Giris_K.UseVisualStyleBackColor = true;
            this.Giris_K.Click += new System.EventHandler(this.Giris_K_Click);
            // 
            // BUFFER
            // 
            this.BUFFER.Image = ((System.Drawing.Image)(resources.GetObject("BUFFER.Image")));
            this.BUFFER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUFFER.Location = new System.Drawing.Point(595, 5);
            this.BUFFER.Margin = new System.Windows.Forms.Padding(5);
            this.BUFFER.Name = "BUFFER";
            this.BUFFER.Size = new System.Drawing.Size(60, 46);
            this.BUFFER.TabIndex = 2;
            this.BUFFER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUFFER.UseVisualStyleBackColor = true;
            this.BUFFER.Click += new System.EventHandler(this.BUFFER_Click);
            // 
            // AND
            // 
            this.AND.Image = ((System.Drawing.Image)(resources.GetObject("AND.Image")));
            this.AND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AND.Location = new System.Drawing.Point(875, 5);
            this.AND.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(60, 46);
            this.AND.TabIndex = 9;
            this.AND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AND.UseVisualStyleBackColor = true;
            this.AND.Click += new System.EventHandler(this.AND_Click);
            // 
            // NAND
            // 
            this.NAND.Image = ((System.Drawing.Image)(resources.GetObject("NAND.Image")));
            this.NAND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAND.Location = new System.Drawing.Point(945, 5);
            this.NAND.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.NAND.Name = "NAND";
            this.NAND.Size = new System.Drawing.Size(60, 46);
            this.NAND.TabIndex = 12;
            this.NAND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NAND.UseVisualStyleBackColor = true;
            this.NAND.Click += new System.EventHandler(this.NAND_Click);
            // 
            // NOT
            // 
            this.NOT.Image = ((System.Drawing.Image)(resources.GetObject("NOT.Image")));
            this.NOT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NOT.Location = new System.Drawing.Point(665, 5);
            this.NOT.Margin = new System.Windows.Forms.Padding(5);
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(60, 46);
            this.NOT.TabIndex = 8;
            this.NOT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NOT.UseVisualStyleBackColor = true;
            this.NOT.Click += new System.EventHandler(this.NOT_Click);
            // 
            // NOR
            // 
            this.NOR.Image = ((System.Drawing.Image)(resources.GetObject("NOR.Image")));
            this.NOR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NOR.Location = new System.Drawing.Point(1015, 5);
            this.NOR.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.NOR.Name = "NOR";
            this.NOR.Size = new System.Drawing.Size(60, 46);
            this.NOR.TabIndex = 10;
            this.NOR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NOR.UseVisualStyleBackColor = true;
            this.NOR.Click += new System.EventHandler(this.NOR_Click);
            // 
            // XNOR
            // 
            this.XNOR.Image = ((System.Drawing.Image)(resources.GetObject("XNOR.Image")));
            this.XNOR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XNOR.Location = new System.Drawing.Point(1085, 5);
            this.XNOR.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.XNOR.Name = "XNOR";
            this.XNOR.Size = new System.Drawing.Size(60, 46);
            this.XNOR.TabIndex = 14;
            this.XNOR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.XNOR.UseVisualStyleBackColor = true;
            this.XNOR.Click += new System.EventHandler(this.XNOR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(443, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baglanti Araclari";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 4);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(733, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mantık Kapıları";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formBorderDesign1
            // 
            this.formBorderDesign1.CornerRedius = 20;
            this.formBorderDesign1.TargetControl = this;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.picBox);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 140);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(5);
            this.panelMain.Size = new System.Drawing.Size(1200, 560);
            this.panelMain.TabIndex = 2;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(5, 5);
            this.picBox.Margin = new System.Windows.Forms.Padding(0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1190, 550);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pinTitle);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pinTitle.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pinTitle;
        private System.Windows.Forms.Button EXİTbutton;
        private System.Windows.Forms.Button Boyutlandırbutton;
        private System.Windows.Forms.Button Hidebutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CALISTIR;
        private System.Windows.Forms.Button DURDUR;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button Cikis_K;
        private System.Windows.Forms.Button Giris_K;
        private System.Windows.Forms.Button LED;
        private System.Windows.Forms.Button Cizgi;
        private System.Windows.Forms.Button Bag_Nokta;
        private System.Windows.Forms.Button BUFFER;
        private System.Windows.Forms.Button NOR;
        private System.Windows.Forms.Button AND;
        private System.Windows.Forms.Button NOT;
        private System.Windows.Forms.Button XNOR;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Button NAND;
        private System.Windows.Forms.Button OR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FormBorderDesign formBorderDesign1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox picBox;
    }
}

