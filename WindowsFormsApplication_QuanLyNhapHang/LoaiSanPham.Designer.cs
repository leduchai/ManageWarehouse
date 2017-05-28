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
            this.btnluu_edit = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.chitietkho = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_loaisp = new System.Windows.Forms.DataGridView();
            this.maloaisp = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.cbbkho = new System.Windows.Forms.ComboBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblbaogom = new System.Windows.Forms.Label();
            this.errpro_nv2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errpro_nv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chitietsp = new System.Windows.Forms.LinkLabel();
            this.txtslsp = new System.Windows.Forms.TextBox();
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
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(472, 49);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 23);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(472, 230);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            // 
            // btnluu_add
            // 
            this.btnluu_add.Location = new System.Drawing.Point(472, 107);
            this.btnluu_add.Name = "btnluu_add";
            this.btnluu_add.Size = new System.Drawing.Size(113, 23);
            this.btnluu_add.TabIndex = 22;
            this.btnluu_add.Text = "Lưu";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(370, 15);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(215, 20);
            this.txttimkiem.TabIndex = 9;
            // 
            // btnluu_edit
            // 
            this.btnluu_edit.Location = new System.Drawing.Point(560, 303);
            this.btnluu_edit.Name = "btnluu_edit";
            this.btnluu_edit.Size = new System.Drawing.Size(113, 23);
            this.btnluu_edit.TabIndex = 19;
            this.btnluu_edit.Text = "Lưu";
            this.btnluu_edit.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtslsp);
            this.panel2.Controls.Add(this.chitietsp);
            this.panel2.Controls.Add(this.txtmanv);
            this.panel2.Controls.Add(this.chitietkho);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.maloaisp);
            this.panel2.Controls.Add(this.lblhoten);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnluu_edit);
            this.panel2.Controls.Add(this.btnluu_add);
            this.panel2.Controls.Add(this.cbbkho);
            this.panel2.Controls.Add(this.txtluong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblbaogom);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 628);
            this.panel2.TabIndex = 27;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(498, 306);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(59, 20);
            this.txtmanv.TabIndex = 26;
            this.txtmanv.Visible = false;
            // 
            // chitietkho
            // 
            this.chitietkho.AutoSize = true;
            this.chitietkho.Location = new System.Drawing.Point(374, 175);
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
            // 
            // maloaisp
            // 
            this.maloaisp.Location = new System.Drawing.Point(168, 52);
            this.maloaisp.Name = "maloaisp";
            this.maloaisp.Size = new System.Drawing.Size(200, 20);
            this.maloaisp.TabIndex = 0;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(90, 59);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(62, 13);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "Mã Loại SP";
            // 
            // cbbkho
            // 
            this.cbbkho.FormattingEnabled = true;
            this.cbbkho.Location = new System.Drawing.Point(168, 172);
            this.cbbkho.Name = "cbbkho";
            this.cbbkho.Size = new System.Drawing.Size(200, 21);
            this.cbbkho.TabIndex = 17;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(168, 110);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(200, 20);
            this.txtluong.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên Loại SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thuộc Kho";
            // 
            // lblbaogom
            // 
            this.lblbaogom.AutoSize = true;
            this.lblbaogom.Location = new System.Drawing.Point(90, 239);
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
            // chitietsp
            // 
            this.chitietsp.AutoSize = true;
            this.chitietsp.Location = new System.Drawing.Point(374, 235);
            this.chitietsp.Name = "chitietsp";
            this.chitietsp.Size = new System.Drawing.Size(60, 13);
            this.chitietsp.TabIndex = 27;
            this.chitietsp.TabStop = true;
            this.chitietsp.Text = "xem chi tiết";
            // 
            // txtslsp
            // 
            this.txtslsp.Location = new System.Drawing.Point(168, 232);
            this.txtslsp.Name = "txtslsp";
            this.txtslsp.Size = new System.Drawing.Size(200, 20);
            this.txtslsp.TabIndex = 28;
            // 
            // LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoaiSanPham";
            this.Size = new System.Drawing.Size(678, 684);
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
        private DevExpress.XtraEditors.SimpleButton btnluu_edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.LinkLabel chitietkho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_loaisp;
        private System.Windows.Forms.TextBox maloaisp;
        private System.Windows.Forms.Label lblhoten;
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
    }
}
