namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class SanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_sp = new System.Windows.Forms.DataGridView();
            this.lblhoten = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.errpro_nv2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbbloaisp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errpro_nv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQuyC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluong_quycach = new System.Windows.Forms.TextBox();
            this.txtsoluonght = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.cbbdonvitinh1 = new System.Windows.Forms.ComboBox();
            this.cbbdonvitinh2 = new System.Windows.Forms.TextBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.chitietloaisp = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(472, 202);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(113, 23);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(472, 55);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 23);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(472, 271);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu_add
            // 
            this.btnluu_add.Location = new System.Drawing.Point(472, 130);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Sản Phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_sp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 296);
            this.panel3.TabIndex = 24;
            // 
            // dtgv_sp
            // 
            this.dtgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sp.Location = new System.Drawing.Point(3, 25);
            this.dtgv_sp.Name = "dtgv_sp";
            this.dtgv_sp.Size = new System.Drawing.Size(661, 248);
            this.dtgv_sp.TabIndex = 0;
            this.dtgv_sp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sp_CellContentClick);
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(75, 65);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(43, 13);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "Tên SP";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(75, 114);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(23, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Giá";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(498, 306);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(59, 20);
            this.txtmasp.TabIndex = 26;
            this.txtmasp.Visible = false;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(168, 58);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(200, 20);
            this.txthoten.TabIndex = 0;
            this.txthoten.TextChanged += new System.EventHandler(this.txthoten_TextChanged);
            // 
            // errpro_nv2
            // 
            this.errpro_nv2.ContainerControl = this;
            // 
            // cbbloaisp
            // 
            this.cbbloaisp.FormattingEnabled = true;
            this.cbbloaisp.Location = new System.Drawing.Point(168, 272);
            this.cbbloaisp.Name = "cbbloaisp";
            this.cbbloaisp.Size = new System.Drawing.Size(200, 21);
            this.cbbloaisp.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SL Hiện Tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Vị Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quy Cách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Loại SP";
            // 
            // errpro_nv
            // 
            this.errpro_nv.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.cbbdonvitinh2);
            this.panel2.Controls.Add(this.txtQuyC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtsoluong_quycach);
            this.panel2.Controls.Add(this.txtmasp);
            this.panel2.Controls.Add(this.chitietloaisp);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtsoluonght);
            this.panel2.Controls.Add(this.txtgia);
            this.panel2.Controls.Add(this.txthoten);
            this.panel2.Controls.Add(this.lblhoten);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.btnluu_add);
            this.panel2.Controls.Add(this.cbbdonvitinh1);
            this.panel2.Controls.Add(this.cbbloaisp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 628);
            this.panel2.TabIndex = 27;
            // 
            // txtQuyC
            // 
            this.txtQuyC.Location = new System.Drawing.Point(295, 238);
            this.txtQuyC.Name = "txtQuyC";
            this.txtQuyC.Size = new System.Drawing.Size(73, 20);
            this.txtQuyC.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "/";
            // 
            // txtsoluong_quycach
            // 
            this.txtsoluong_quycach.Location = new System.Drawing.Point(168, 238);
            this.txtsoluong_quycach.Name = "txtsoluong_quycach";
            this.txtsoluong_quycach.Size = new System.Drawing.Size(28, 20);
            this.txtsoluong_quycach.TabIndex = 27;
            // 
            // txtsoluonght
            // 
            this.txtsoluonght.Location = new System.Drawing.Point(168, 159);
            this.txtsoluonght.Name = "txtsoluonght";
            this.txtsoluonght.Size = new System.Drawing.Size(200, 20);
            this.txtsoluonght.TabIndex = 0;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(168, 107);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(200, 20);
            this.txtgia.TabIndex = 0;
            // 
            // cbbdonvitinh1
            // 
            this.cbbdonvitinh1.FormattingEnabled = true;
            this.cbbdonvitinh1.Location = new System.Drawing.Point(168, 200);
            this.cbbdonvitinh1.Name = "cbbdonvitinh1";
            this.cbbdonvitinh1.Size = new System.Drawing.Size(200, 21);
            this.cbbdonvitinh1.TabIndex = 18;
            this.cbbdonvitinh1.SelectedIndexChanged += new System.EventHandler(this.cbbdonvitinh1_SelectedIndexChanged);
            // 
            // cbbdonvitinh2
            // 
            this.cbbdonvitinh2.Location = new System.Drawing.Point(202, 239);
            this.cbbdonvitinh2.Name = "cbbdonvitinh2";
            this.cbbdonvitinh2.Size = new System.Drawing.Size(73, 20);
            this.cbbdonvitinh2.TabIndex = 31;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(560, 306);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(76, 23);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // chitietloaisp
            // 
            this.chitietloaisp.AutoSize = true;
            this.chitietloaisp.Location = new System.Drawing.Point(374, 275);
            this.chitietloaisp.Name = "chitietloaisp";
            this.chitietloaisp.Size = new System.Drawing.Size(60, 13);
            this.chitietloaisp.TabIndex = 25;
            this.chitietloaisp.TabStop = true;
            this.chitietloaisp.Text = "xem chi tiết";
            this.chitietloaisp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chitietloaisp_LinkClicked);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(678, 684);
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu_add;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_sp;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.ErrorProvider errpro_nv2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbloaisp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errpro_nv;
        private System.Windows.Forms.TextBox txtsoluonght;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.ComboBox cbbdonvitinh1;
        private System.Windows.Forms.TextBox txtsoluong_quycach;
        private System.Windows.Forms.TextBox txtQuyC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cbbdonvitinh2;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.LinkLabel chitietloaisp;
    }
}
