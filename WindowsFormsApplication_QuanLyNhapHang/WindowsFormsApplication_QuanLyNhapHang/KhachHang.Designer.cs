namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class KhachHang
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
            this.chitietdonhang_thang = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_kh = new System.Windows.Forms.DataGridView();
            this.txtmakho = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtdiadiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttenkho = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu_add = new DevExpress.XtraEditors.SimpleButton();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsldonhang_hang = new System.Windows.Forms.TextBox();
            this.txtsldonhang_nam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(676, 46);
            this.panel1.TabIndex = 26;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(370, 15);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(200, 20);
            this.txttimkiem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Khách Hàng";
            // 
            // slnv
            // 
            this.slnv.AutoSize = true;
            this.slnv.Location = new System.Drawing.Point(48, 273);
            this.slnv.Name = "slnv";
            this.slnv.Size = new System.Drawing.Size(72, 13);
            this.slnv.TabIndex = 30;
            this.slnv.Text = "SL Đơn Hàng";
            // 
            // lblloaisp
            // 
            this.lblloaisp.AutoSize = true;
            this.lblloaisp.Location = new System.Drawing.Point(48, 171);
            this.lblloaisp.Name = "lblloaisp";
            this.lblloaisp.Size = new System.Drawing.Size(41, 13);
            this.lblloaisp.TabIndex = 28;
            this.lblloaisp.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "SL Đơn Hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chitietdonhang_thang
            // 
            this.chitietdonhang_thang.AutoSize = true;
            this.chitietdonhang_thang.Location = new System.Drawing.Point(349, 219);
            this.chitietdonhang_thang.Name = "chitietdonhang_thang";
            this.chitietdonhang_thang.Size = new System.Drawing.Size(60, 13);
            this.chitietdonhang_thang.TabIndex = 25;
            this.chitietdonhang_thang.TabStop = true;
            this.chitietdonhang_thang.Text = "xem chi tiết";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_kh);
            this.panel3.Location = new System.Drawing.Point(0, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 278);
            this.panel3.TabIndex = 24;
            // 
            // dtgv_kh
            // 
            this.dtgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_kh.Location = new System.Drawing.Point(0, 26);
            this.dtgv_kh.Name = "dtgv_kh";
            this.dtgv_kh.Size = new System.Drawing.Size(661, 248);
            this.dtgv_kh.TabIndex = 0;
            // 
            // txtmakho
            // 
            this.txtmakho.Location = new System.Drawing.Point(494, 352);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.Size = new System.Drawing.Size(53, 20);
            this.txtmakho.TabIndex = 0;
            this.txtmakho.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtsldonhang_nam);
            this.panel2.Controls.Add(this.txtsldonhang_hang);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.slnv);
            this.panel2.Controls.Add(this.lblloaisp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chitietdonhang_thang);
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
            this.panel2.Controls.Add(this.txttinhtrang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 676);
            this.panel2.TabIndex = 28;
            // 
            // txtdiadiem
            // 
            this.txtdiadiem.Location = new System.Drawing.Point(143, 164);
            this.txtdiadiem.Name = "txtdiadiem";
            this.txtdiadiem.Size = new System.Drawing.Size(200, 20);
            this.txtdiadiem.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // txttenkho
            // 
            this.txttenkho.Location = new System.Drawing.Point(143, 75);
            this.txttenkho.Name = "txttenkho";
            this.txttenkho.Size = new System.Drawing.Size(200, 20);
            this.txttenkho.TabIndex = 0;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(48, 82);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(89, 13);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "Tên Khách Hàng";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(472, 194);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(98, 23);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(472, 72);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(98, 23);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(472, 250);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            // 
            // btnluu_edit
            // 
            this.btnluu_edit.Location = new System.Drawing.Point(563, 349);
            this.btnluu_edit.Name = "btnluu_edit";
            this.btnluu_edit.Size = new System.Drawing.Size(98, 23);
            this.btnluu_edit.TabIndex = 19;
            this.btnluu_edit.Text = "Lưu";
            this.btnluu_edit.Visible = false;
            // 
            // btnluu_add
            // 
            this.btnluu_add.Location = new System.Drawing.Point(472, 133);
            this.btnluu_add.Name = "btnluu_add";
            this.btnluu_add.Size = new System.Drawing.Size(98, 23);
            this.btnluu_add.TabIndex = 22;
            this.btnluu_add.Text = "Lưu";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(143, 120);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(200, 20);
            this.txttinhtrang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Điện Thoại";
            // 
            // txtsldonhang_hang
            // 
            this.txtsldonhang_hang.Location = new System.Drawing.Point(143, 216);
            this.txtsldonhang_hang.Name = "txtsldonhang_hang";
            this.txtsldonhang_hang.Size = new System.Drawing.Size(200, 20);
            this.txtsldonhang_hang.TabIndex = 31;
            // 
            // txtsldonhang_nam
            // 
            this.txtsldonhang_nam.Location = new System.Drawing.Point(143, 266);
            this.txtsldonhang_nam.Name = "txtsldonhang_nam";
            this.txtsldonhang_nam.Size = new System.Drawing.Size(200, 20);
            this.txtsldonhang_nam.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "( trong 1 tháng trở lại đây)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "( trong năm nay)";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "KhachHang";
            this.Size = new System.Drawing.Size(678, 684);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).EndInit();
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
        private System.Windows.Forms.LinkLabel chitietdonhang_thang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_kh;
        private System.Windows.Forms.TextBox txtmakho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtdiadiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttenkho;
        private System.Windows.Forms.Label lblhoten;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu_edit;
        private DevExpress.XtraEditors.SimpleButton btnluu_add;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsldonhang_nam;
        private System.Windows.Forms.TextBox txtsldonhang_hang;
    }
}
