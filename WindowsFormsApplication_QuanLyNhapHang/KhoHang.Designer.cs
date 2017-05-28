namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class KhoHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttenkho = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.dtgv_kh = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu_add = new DevExpress.XtraEditors.SimpleButton();
            this.cbbloaisp = new System.Windows.Forms.ComboBox();
            this.cbbnvquanly = new System.Windows.Forms.ComboBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblslnv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slnv = new System.Windows.Forms.Label();
            this.chitietloaisp = new System.Windows.Forms.LinkLabel();
            this.lblloaisp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chitietnvql = new System.Windows.Forms.LinkLabel();
            this.txtdiadiem = new System.Windows.Forms.TextBox();
            this.txtmakho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttenkho
            // 
            this.txttenkho.Location = new System.Drawing.Point(143, 75);
            this.txttenkho.Name = "txttenkho";
            this.txttenkho.Size = new System.Drawing.Size(200, 20);
            this.txttenkho.TabIndex = 0;
            this.txttenkho.TextChanged += new System.EventHandler(this.txttenkho_TextChanged);
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(64, 82);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(48, 13);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "Tên Kho";
            this.lblhoten.Click += new System.EventHandler(this.lblhoten_Click);
            // 
            // dtgv_kh
            // 
            this.dtgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_kh.Location = new System.Drawing.Point(0, 26);
            this.dtgv_kh.Name = "dtgv_kh";
            this.dtgv_kh.Size = new System.Drawing.Size(661, 248);
            this.dtgv_kh.TabIndex = 0;
            this.dtgv_kh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_kh_CellClick);
            this.dtgv_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_kh_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_kh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 296);
            this.panel3.TabIndex = 24;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 46);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(370, 15);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(200, 20);
            this.txttimkiem.TabIndex = 9;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Kho Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(472, 194);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(98, 23);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(472, 72);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(98, 23);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(472, 250);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu_edit
            // 
            this.btnluu_edit.Location = new System.Drawing.Point(563, 349);
            this.btnluu_edit.Name = "btnluu_edit";
            this.btnluu_edit.Size = new System.Drawing.Size(98, 23);
            this.btnluu_edit.TabIndex = 19;
            this.btnluu_edit.Text = "Lưu";
            this.btnluu_edit.Visible = false;
            this.btnluu_edit.Click += new System.EventHandler(this.btnluu_edit_Click);
            // 
            // btnluu_add
            // 
            this.btnluu_add.Location = new System.Drawing.Point(472, 133);
            this.btnluu_add.Name = "btnluu_add";
            this.btnluu_add.Size = new System.Drawing.Size(98, 23);
            this.btnluu_add.TabIndex = 22;
            this.btnluu_add.Text = "Lưu";
            this.btnluu_add.Click += new System.EventHandler(this.btnluu_add_Click);
            // 
            // cbbloaisp
            // 
            this.cbbloaisp.FormattingEnabled = true;
            this.cbbloaisp.Location = new System.Drawing.Point(143, 163);
            this.cbbloaisp.Name = "cbbloaisp";
            this.cbbloaisp.Size = new System.Drawing.Size(200, 21);
            this.cbbloaisp.TabIndex = 18;
            this.cbbloaisp.SelectedIndexChanged += new System.EventHandler(this.cbbloaisp_SelectedIndexChanged);
            // 
            // cbbnvquanly
            // 
            this.cbbnvquanly.FormattingEnabled = true;
            this.cbbnvquanly.Location = new System.Drawing.Point(143, 208);
            this.cbbnvquanly.Name = "cbbnvquanly";
            this.cbbnvquanly.Size = new System.Drawing.Size(200, 21);
            this.cbbnvquanly.TabIndex = 17;
            this.cbbnvquanly.SelectedIndexChanged += new System.EventHandler(this.cbbnvquanly_SelectedIndexChanged);
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(143, 120);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(200, 20);
            this.txttinhtrang.TabIndex = 3;
            this.txttinhtrang.TextChanged += new System.EventHandler(this.txttinhtrang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tình Trạng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblslnv
            // 
            this.lblslnv.AutoSize = true;
            this.lblslnv.Location = new System.Drawing.Point(64, 290);
            this.lblslnv.Name = "lblslnv";
            this.lblslnv.Size = new System.Drawing.Size(73, 13);
            this.lblslnv.TabIndex = 7;
            this.lblslnv.Text = "SL Nhân Viên";
            this.lblslnv.Click += new System.EventHandler(this.lblslnv_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NV Quản Lý";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.slnv);
            this.panel2.Controls.Add(this.chitietloaisp);
            this.panel2.Controls.Add(this.lblloaisp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbbnvquanly);
            this.panel2.Controls.Add(this.chitietnvql);
            this.panel2.Controls.Add(this.txtdiadiem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtmakho);
            this.panel2.Controls.Add(this.txttenkho);
            this.panel2.Controls.Add(this.lblhoten);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnluu_edit);
            this.panel2.Controls.Add(this.btnluu_add);
            this.panel2.Controls.Add(this.cbbloaisp);
            this.panel2.Controls.Add(this.txttinhtrang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblslnv);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 674);
            this.panel2.TabIndex = 27;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // slnv
            // 
            this.slnv.AutoSize = true;
            this.slnv.Location = new System.Drawing.Point(232, 290);
            this.slnv.Name = "slnv";
            this.slnv.Size = new System.Drawing.Size(20, 13);
            this.slnv.TabIndex = 30;
            this.slnv.Text = "SL";
            this.slnv.Click += new System.EventHandler(this.slnv_Click);
            // 
            // chitietloaisp
            // 
            this.chitietloaisp.AutoSize = true;
            this.chitietloaisp.Location = new System.Drawing.Point(349, 166);
            this.chitietloaisp.Name = "chitietloaisp";
            this.chitietloaisp.Size = new System.Drawing.Size(60, 13);
            this.chitietloaisp.TabIndex = 29;
            this.chitietloaisp.TabStop = true;
            this.chitietloaisp.Text = "xem chi tiết";
            this.chitietloaisp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chitietloaisp_LinkClicked);
            // 
            // lblloaisp
            // 
            this.lblloaisp.AutoSize = true;
            this.lblloaisp.Location = new System.Drawing.Point(64, 171);
            this.lblloaisp.Name = "lblloaisp";
            this.lblloaisp.Size = new System.Drawing.Size(76, 13);
            this.lblloaisp.TabIndex = 28;
            this.lblloaisp.Text = "Các Mặt Hàng";
            this.lblloaisp.Click += new System.EventHandler(this.lblloaisp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Địa Điểm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chitietnvql
            // 
            this.chitietnvql.AutoSize = true;
            this.chitietnvql.Location = new System.Drawing.Point(349, 211);
            this.chitietnvql.Name = "chitietnvql";
            this.chitietnvql.Size = new System.Drawing.Size(60, 13);
            this.chitietnvql.TabIndex = 25;
            this.chitietnvql.TabStop = true;
            this.chitietnvql.Text = "xem chi tiết";
            this.chitietnvql.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chitietnvql_LinkClicked);
            // 
            // txtdiadiem
            // 
            this.txtdiadiem.Location = new System.Drawing.Point(143, 253);
            this.txtdiadiem.Name = "txtdiadiem";
            this.txtdiadiem.Size = new System.Drawing.Size(200, 20);
            this.txtdiadiem.TabIndex = 26;
            this.txtdiadiem.TextChanged += new System.EventHandler(this.txtdiadiem_TextChanged);
            // 
            // txtmakho
            // 
            this.txtmakho.Location = new System.Drawing.Point(494, 352);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.Size = new System.Drawing.Size(53, 20);
            this.txtmakho.TabIndex = 0;
            this.txtmakho.Visible = false;
            this.txtmakho.TextChanged += new System.EventHandler(this.txtmakho_TextChanged);
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "KhoHang";
            this.Size = new System.Drawing.Size(676, 674);
            this.Load += new System.EventHandler(this.KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txttenkho;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.DataGridView dtgv_kh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu_edit;
        private DevExpress.XtraEditors.SimpleButton btnluu_add;
        private System.Windows.Forms.ComboBox cbbloaisp;
        private System.Windows.Forms.ComboBox cbbnvquanly;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblslnv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel chitietnvql;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdiadiem;
        private System.Windows.Forms.Label slnv;
        private System.Windows.Forms.LinkLabel chitietloaisp;
        private System.Windows.Forms.Label lblloaisp;
        private System.Windows.Forms.TextBox txtmakho;
    }
}
