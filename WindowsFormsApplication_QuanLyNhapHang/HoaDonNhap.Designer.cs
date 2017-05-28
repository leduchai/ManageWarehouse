namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class HoaDonNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slnv = new System.Windows.Forms.Label();
            this.lblloaisp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chitiet_nvlap = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_hdn = new System.Windows.Forms.DataGridView();
            this.txttenhdn = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu_edit = new DevExpress.XtraEditors.SimpleButton();
            this.txtmahdn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbkhohang = new System.Windows.Forms.ComboBox();
            this.cbbnhacc = new System.Windows.Forms.ComboBox();
            this.cbbnvlap = new System.Windows.Forms.ComboBox();
            this.ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chitiet_hdn = new System.Windows.Forms.LinkLabel();
            this.chitiet_ncc = new System.Windows.Forms.LinkLabel();
            this.chitiet_kh = new System.Windows.Forms.LinkLabel();
            this.txttonggiatri = new System.Windows.Forms.TextBox();
            this.txttimkiem_mahdn = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hdn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 46);
            this.panel1.TabIndex = 26;
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
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Hóa Đơn Nhập";
            // 
            // slnv
            // 
            this.slnv.AutoSize = true;
            this.slnv.Location = new System.Drawing.Point(48, 273);
            this.slnv.Name = "slnv";
            this.slnv.Size = new System.Drawing.Size(60, 13);
            this.slnv.TabIndex = 30;
            this.slnv.Text = "Kho Khàng";
            // 
            // lblloaisp
            // 
            this.lblloaisp.AutoSize = true;
            this.lblloaisp.Location = new System.Drawing.Point(48, 171);
            this.lblloaisp.Name = "lblloaisp";
            this.lblloaisp.Size = new System.Drawing.Size(61, 13);
            this.lblloaisp.TabIndex = 28;
            this.lblloaisp.Text = "Ngày Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nhân Viên Lập";
            // 
            // chitiet_nvlap
            // 
            this.chitiet_nvlap.AutoSize = true;
            this.chitiet_nvlap.Location = new System.Drawing.Point(349, 219);
            this.chitiet_nvlap.Name = "chitiet_nvlap";
            this.chitiet_nvlap.Size = new System.Drawing.Size(60, 13);
            this.chitiet_nvlap.TabIndex = 25;
            this.chitiet_nvlap.TabStop = true;
            this.chitiet_nvlap.Text = "xem chi tiết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_hdn);
            this.panel3.Location = new System.Drawing.Point(0, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 278);
            this.panel3.TabIndex = 24;
            // 
            // dtgv_hdn
            // 
            this.dtgv_hdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hdn.Location = new System.Drawing.Point(0, 26);
            this.dtgv_hdn.Name = "dtgv_hdn";
            this.dtgv_hdn.Size = new System.Drawing.Size(661, 248);
            this.dtgv_hdn.TabIndex = 0;
            this.dtgv_hdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_hdn_CellClick);
            // 
            // txttenhdn
            // 
            this.txttenhdn.Location = new System.Drawing.Point(143, 75);
            this.txttenhdn.Name = "txttenhdn";
            this.txttenhdn.Size = new System.Drawing.Size(200, 20);
            this.txttenhdn.TabIndex = 0;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(48, 82);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(74, 13);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "Tên HD Nhập";
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
            this.btnthem.Text = "Lập Hóa Đơn";
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
            // txtmahdn
            // 
            this.txtmahdn.Enabled = false;
            this.txtmahdn.Location = new System.Drawing.Point(143, 120);
            this.txtmahdn.Name = "txtmahdn";
            this.txtmahdn.Size = new System.Drawing.Size(200, 20);
            this.txtmahdn.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã HD Nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbkhohang);
            this.panel2.Controls.Add(this.cbbnhacc);
            this.panel2.Controls.Add(this.cbbnvlap);
            this.panel2.Controls.Add(this.ngaynhap);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.slnv);
            this.panel2.Controls.Add(this.lblloaisp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chitiet_hdn);
            this.panel2.Controls.Add(this.chitiet_ncc);
            this.panel2.Controls.Add(this.chitiet_kh);
            this.panel2.Controls.Add(this.chitiet_nvlap);
            this.panel2.Controls.Add(this.txttonggiatri);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txttimkiem_mahdn);
            this.panel2.Controls.Add(this.txttenhdn);
            this.panel2.Controls.Add(this.lblhoten);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnluu_edit);
            this.panel2.Controls.Add(this.txtmahdn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 684);
            this.panel2.TabIndex = 29;
            // 
            // cbbkhohang
            // 
            this.cbbkhohang.FormattingEnabled = true;
            this.cbbkhohang.Location = new System.Drawing.Point(143, 265);
            this.cbbkhohang.Name = "cbbkhohang";
            this.cbbkhohang.Size = new System.Drawing.Size(200, 21);
            this.cbbkhohang.TabIndex = 36;
            // 
            // cbbnhacc
            // 
            this.cbbnhacc.FormattingEnabled = true;
            this.cbbnhacc.Location = new System.Drawing.Point(143, 304);
            this.cbbnhacc.Name = "cbbnhacc";
            this.cbbnhacc.Size = new System.Drawing.Size(200, 21);
            this.cbbnhacc.TabIndex = 36;
            // 
            // cbbnvlap
            // 
            this.cbbnvlap.FormattingEnabled = true;
            this.cbbnvlap.Location = new System.Drawing.Point(143, 213);
            this.cbbnvlap.Name = "cbbnvlap";
            this.cbbnvlap.Size = new System.Drawing.Size(200, 21);
            this.cbbnvlap.TabIndex = 36;
            // 
            // ngaynhap
            // 
            this.ngaynhap.Location = new System.Drawing.Point(143, 163);
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Size = new System.Drawing.Size(200, 20);
            this.ngaynhap.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tổng Giá Trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nhà Cung Cấp";
            // 
            // chitiet_hdn
            // 
            this.chitiet_hdn.AutoSize = true;
            this.chitiet_hdn.Location = new System.Drawing.Point(349, 340);
            this.chitiet_hdn.Name = "chitiet_hdn";
            this.chitiet_hdn.Size = new System.Drawing.Size(60, 13);
            this.chitiet_hdn.TabIndex = 25;
            this.chitiet_hdn.TabStop = true;
            this.chitiet_hdn.Text = "xem chi tiết";
            // 
            // chitiet_ncc
            // 
            this.chitiet_ncc.AutoSize = true;
            this.chitiet_ncc.Location = new System.Drawing.Point(349, 307);
            this.chitiet_ncc.Name = "chitiet_ncc";
            this.chitiet_ncc.Size = new System.Drawing.Size(60, 13);
            this.chitiet_ncc.TabIndex = 25;
            this.chitiet_ncc.TabStop = true;
            this.chitiet_ncc.Text = "xem chi tiết";
            // 
            // chitiet_kh
            // 
            this.chitiet_kh.AutoSize = true;
            this.chitiet_kh.Location = new System.Drawing.Point(349, 269);
            this.chitiet_kh.Name = "chitiet_kh";
            this.chitiet_kh.Size = new System.Drawing.Size(60, 13);
            this.chitiet_kh.TabIndex = 25;
            this.chitiet_kh.TabStop = true;
            this.chitiet_kh.Text = "xem chi tiết";
            // 
            // txttonggiatri
            // 
            this.txttonggiatri.Enabled = false;
            this.txttonggiatri.Location = new System.Drawing.Point(143, 337);
            this.txttonggiatri.Name = "txttonggiatri";
            this.txttonggiatri.Size = new System.Drawing.Size(200, 20);
            this.txttonggiatri.TabIndex = 26;
            // 
            // txttimkiem_mahdn
            // 
            this.txttimkiem_mahdn.Location = new System.Drawing.Point(522, 351);
            this.txttimkiem_mahdn.Name = "txttimkiem_mahdn";
            this.txttimkiem_mahdn.Size = new System.Drawing.Size(35, 20);
            this.txttimkiem_mahdn.TabIndex = 0;
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "HoaDonNhap";
            this.Size = new System.Drawing.Size(678, 684);
            this.Load += new System.EventHandler(this.HoaDonNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hdn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label slnv;
        private System.Windows.Forms.Label lblloaisp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel chitiet_nvlap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_hdn;
        private System.Windows.Forms.TextBox txttenhdn;
        private System.Windows.Forms.Label lblhoten;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu_edit;
        private System.Windows.Forms.TextBox txtmahdn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker ngaynhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel chitiet_hdn;
        private System.Windows.Forms.LinkLabel chitiet_ncc;
        private System.Windows.Forms.LinkLabel chitiet_kh;
        private System.Windows.Forms.TextBox txttonggiatri;
        private System.Windows.Forms.ComboBox cbbkhohang;
        private System.Windows.Forms.ComboBox cbbnhacc;
        private System.Windows.Forms.ComboBox cbbnvlap;
        private System.Windows.Forms.TextBox txttimkiem_mahdn;
    }
}
