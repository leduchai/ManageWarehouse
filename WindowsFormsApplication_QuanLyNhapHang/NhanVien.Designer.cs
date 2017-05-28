namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class NhanVien
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
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rabtnnam = new System.Windows.Forms.RadioButton();
            this.rabtnnu = new System.Windows.Forms.RadioButton();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbbkho = new System.Windows.Forms.ComboBox();
            this.cbbchucvu = new System.Windows.Forms.ComboBox();
            this.btnluu_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu_add = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.chitietkho = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_nv = new System.Windows.Forms.DataGridView();
            this.errpro_nv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errpro_nv2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv2)).BeginInit();
            this.SuspendLayout();
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(168, 38);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(200, 20);
            this.txthoten.TabIndex = 0;
            this.txthoten.TextChanged += new System.EventHandler(this.txthoten_TextChanged);
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(168, 185);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(200, 20);
            this.txtluong.TabIndex = 3;
            this.txtluong.TextChanged += new System.EventHandler(this.txtluong_TextChanged);
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(75, 45);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(43, 13);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giới Tính";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(75, 94);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chức Vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // rabtnnam
            // 
            this.rabtnnam.AutoSize = true;
            this.rabtnnam.Checked = true;
            this.rabtnnam.Location = new System.Drawing.Point(168, 141);
            this.rabtnnam.Name = "rabtnnam";
            this.rabtnnam.Size = new System.Drawing.Size(47, 17);
            this.rabtnnam.TabIndex = 9;
            this.rabtnnam.TabStop = true;
            this.rabtnnam.Text = "Nam";
            this.rabtnnam.UseVisualStyleBackColor = true;
            // 
            // rabtnnu
            // 
            this.rabtnnu.AutoSize = true;
            this.rabtnnu.Location = new System.Drawing.Point(283, 141);
            this.rabtnnu.Name = "rabtnnu";
            this.rabtnnu.Size = new System.Drawing.Size(39, 17);
            this.rabtnnu.TabIndex = 10;
            this.rabtnnu.TabStop = true;
            this.rabtnnu.Text = "Nữ";
            this.rabtnnu.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(168, 86);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtpngaysinh.TabIndex = 12;
            // 
            // cbbkho
            // 
            this.cbbkho.FormattingEnabled = true;
            this.cbbkho.Location = new System.Drawing.Point(168, 252);
            this.cbbkho.Name = "cbbkho";
            this.cbbkho.Size = new System.Drawing.Size(200, 21);
            this.cbbkho.TabIndex = 17;
            // 
            // cbbchucvu
            // 
            this.cbbchucvu.FormattingEnabled = true;
            this.cbbchucvu.Location = new System.Drawing.Point(168, 218);
            this.cbbchucvu.Name = "cbbchucvu";
            this.cbbchucvu.Size = new System.Drawing.Size(200, 21);
            this.cbbchucvu.TabIndex = 18;
            // 
            // btnluu_edit
            // 
            this.btnluu_edit.Location = new System.Drawing.Point(560, 303);
            this.btnluu_edit.Name = "btnluu_edit";
            this.btnluu_edit.Size = new System.Drawing.Size(113, 23);
            this.btnluu_edit.TabIndex = 19;
            this.btnluu_edit.Text = "Lưu";
            this.btnluu_edit.Visible = false;
            this.btnluu_edit.Click += new System.EventHandler(this.btnluu_edit_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(472, 251);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(472, 182);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(113, 23);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu_add
            // 
            this.btnluu_add.Location = new System.Drawing.Point(472, 110);
            this.btnluu_add.Name = "btnluu_add";
            this.btnluu_add.Size = new System.Drawing.Size(113, 23);
            this.btnluu_add.TabIndex = 22;
            this.btnluu_add.Text = "Lưu";
            this.btnluu_add.Click += new System.EventHandler(this.btnluu_add_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(472, 35);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 23);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 46);
            this.panel1.TabIndex = 24;
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
            this.panel2.Controls.Add(this.txtmanv);
            this.panel2.Controls.Add(this.chitietkho);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txthoten);
            this.panel2.Controls.Add(this.lblhoten);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.btnluu_edit);
            this.panel2.Controls.Add(this.btnluu_add);
            this.panel2.Controls.Add(this.cbbchucvu);
            this.panel2.Controls.Add(this.dtpngaysinh);
            this.panel2.Controls.Add(this.cbbkho);
            this.panel2.Controls.Add(this.txtluong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rabtnnu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rabtnnam);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 628);
            this.panel2.TabIndex = 25;
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
            this.chitietkho.Location = new System.Drawing.Point(374, 255);
            this.chitietkho.Name = "chitietkho";
            this.chitietkho.Size = new System.Drawing.Size(60, 13);
            this.chitietkho.TabIndex = 25;
            this.chitietkho.TabStop = true;
            this.chitietkho.Text = "xem chi tiết";
            this.chitietkho.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_nv);
            this.panel3.Location = new System.Drawing.Point(0, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 296);
            this.panel3.TabIndex = 24;
            // 
            // dtgv_nv
            // 
            this.dtgv_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nv.Location = new System.Drawing.Point(0, 26);
            this.dtgv_nv.Name = "dtgv_nv";
            this.dtgv_nv.Size = new System.Drawing.Size(661, 248);
            this.dtgv_nv.TabIndex = 0;
            this.dtgv_nv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_nv_CellClick);
            // 
            // errpro_nv
            // 
            this.errpro_nv.ContainerControl = this;
            // 
            // errpro_nv2
            // 
            this.errpro_nv2.ContainerControl = this;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(676, 674);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rabtnnam;
        private System.Windows.Forms.RadioButton rabtnnu;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.ComboBox cbbkho;
        private System.Windows.Forms.ComboBox cbbchucvu;
        private DevExpress.XtraEditors.SimpleButton btnluu_edit;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnluu_add;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_nv;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.LinkLabel chitietkho;
        private System.Windows.Forms.ErrorProvider errpro_nv;
        private System.Windows.Forms.ErrorProvider errpro_nv2;
        private System.Windows.Forms.TextBox txtmanv;
    }
}
