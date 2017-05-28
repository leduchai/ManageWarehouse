namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class LoaiSanPham
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
            this.components = new System.ComponentModel.Container();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu_add = new DevExpress.XtraEditors.SimpleButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txtslsp = new System.Windows.Forms.TextBox();
            this.chitietsp = new System.Windows.Forms.LinkLabel();
            this.txtmalsp = new System.Windows.Forms.TextBox();
            this.chitietkho = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_loaisp = new System.Windows.Forms.DataGridView();
            this.cbbkho = new System.Windows.Forms.ComboBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblbaogom = new System.Windows.Forms.Label();
            this.errpro_nv2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errpro_nv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(472, 170);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(113, 23);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(472, 49);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 23);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(472, 230);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu_add
            // 
            this.btnluu_add.Location = new System.Drawing.Point(472, 107);
            this.btnluu_add.Name = "btnluu_add";
            this.btnluu_add.Size = new System.Drawing.Size(113, 23);
            this.btnluu_add.TabIndex = 22;
            this.btnluu_add.Text = "Lưu";
            this.btnluu_add.Click += new System.EventHandler(this.btnluu_add_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(370, 15);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(215, 20);
            this.txttimkiem.TabIndex = 9;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.txtslsp);
            this.panel2.Controls.Add(this.chitietsp);
            this.panel2.Controls.Add(this.txtmalsp);
            this.panel2.Controls.Add(this.chitietkho);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnluu_add);
            this.panel2.Controls.Add(this.cbbkho);
            this.panel2.Controls.Add(this.txtluong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblbaogom);
            this.panel2.Location = new System.Drawing.Point(-4, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 628);
            this.panel2.TabIndex = 27;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(560, 303);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 23);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtslsp
            // 
            this.txtslsp.Location = new System.Drawing.Point(168, 173);
            this.txtslsp.Name = "txtslsp";
            this.txtslsp.Size = new System.Drawing.Size(200, 20);
            this.txtslsp.TabIndex = 28;
            this.txtslsp.TextChanged += new System.EventHandler(this.txtslsp_TextChanged);
            // 
            // chitietsp
            // 
            this.chitietsp.AutoSize = true;
            this.chitietsp.Location = new System.Drawing.Point(374, 180);
            this.chitietsp.Name = "chitietsp";
            this.chitietsp.Size = new System.Drawing.Size(60, 13);
            this.chitietsp.TabIndex = 27;
            this.chitietsp.TabStop = true;
            this.chitietsp.Text = "xem chi tiết";
            this.chitietsp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chitietsp_LinkClicked);
            // 
            // txtmalsp
            // 
            this.txtmalsp.Location = new System.Drawing.Point(498, 306);
            this.txtmalsp.Name = "txtmalsp";
            this.txtmalsp.Size = new System.Drawing.Size(59, 20);
            this.txtmalsp.TabIndex = 26;
            this.txtmalsp.Visible = false;
            // 
            // chitietkho
            // 
            this.chitietkho.AutoSize = true;
            this.chitietkho.Location = new System.Drawing.Point(374, 125);
            this.chitietkho.Name = "chitietkho";
            this.chitietkho.Size = new System.Drawing.Size(60, 13);
            this.chitietkho.TabIndex = 25;
            this.chitietkho.TabStop = true;
            this.chitietkho.Text = "xem chi tiết";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_loaisp);
            this.panel3.Location = new System.Drawing.Point(0, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 296);
            this.panel3.TabIndex = 24;
            // 
            // dtgv_loaisp
            // 
            this.dtgv_loaisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_loaisp.Location = new System.Drawing.Point(0, 26);
            this.dtgv_loaisp.Name = "dtgv_loaisp";
            this.dtgv_loaisp.Size = new System.Drawing.Size(661, 248);
            this.dtgv_loaisp.TabIndex = 0;
            this.dtgv_loaisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_loaisp_CellContentClick);
            // 
            // cbbkho
            // 
            this.cbbkho.FormattingEnabled = true;
            this.cbbkho.Location = new System.Drawing.Point(168, 117);
            this.cbbkho.Name = "cbbkho";
            this.cbbkho.Size = new System.Drawing.Size(200, 21);
            this.cbbkho.TabIndex = 17;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(168, 59);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(200, 20);
            this.txtluong.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên Loại SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thuộc Kho";
            // 
            // lblbaogom
            // 
            this.lblbaogom.AutoSize = true;
            this.lblbaogom.Location = new System.Drawing.Point(90, 180);
            this.lblbaogom.Name = "lblbaogom";
            this.lblbaogom.Size = new System.Drawing.Size(51, 13);
            this.lblbaogom.TabIndex = 7;
            this.lblbaogom.Text = "Bao Gồm";
            // 
            // errpro_nv2
            // 
            this.errpro_nv2.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Loại Sản Phẩm";
            // 
            // errpro_nv
            // 
            this.errpro_nv.ContainerControl = this;
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
            // LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoaiSanPham";
            this.Size = new System.Drawing.Size(678, 684);
            this.Load += new System.EventHandler(this.LoaiSanPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu_add;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmalsp;
        private System.Windows.Forms.LinkLabel chitietkho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_loaisp;
        private System.Windows.Forms.ComboBox cbbkho;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblbaogom;
        private System.Windows.Forms.ErrorProvider errpro_nv2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errpro_nv;
        private System.Windows.Forms.LinkLabel chitietsp;
        private System.Windows.Forms.TextBox txtslsp;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}
