namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class LapHoaDonNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errpro_nv2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errpro_nv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_loaisp = new System.Windows.Forms.DataGridView();
            this.slhientai = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.txtslnhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chuacosp = new System.Windows.Forms.LinkLabel();
            this.txtsltong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaisp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 51);
            this.panel1.TabIndex = 28;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(384, 15);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(215, 20);
            this.txttimkiem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thêm Sản Phẩm Vào Hóa Đơn";
            // 
            // errpro_nv2
            // 
            this.errpro_nv2.ContainerControl = this;
            // 
            // errpro_nv
            // 
            this.errpro_nv.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_loaisp);
            this.panel3.Location = new System.Drawing.Point(0, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 382);
            this.panel3.TabIndex = 24;
            // 
            // dtgv_loaisp
            // 
            this.dtgv_loaisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_loaisp.Location = new System.Drawing.Point(0, 26);
            this.dtgv_loaisp.Name = "dtgv_loaisp";
            this.dtgv_loaisp.Size = new System.Drawing.Size(661, 335);
            this.dtgv_loaisp.TabIndex = 0;
            // 
            // slhientai
            // 
            this.slhientai.Location = new System.Drawing.Point(168, 52);
            this.slhientai.Name = "slhientai";
            this.slhientai.Size = new System.Drawing.Size(200, 20);
            this.slhientai.TabIndex = 0;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(46, 59);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(116, 13);
            this.lblhoten.TabIndex = 7;
            this.lblhoten.Text = "SL Hiện Tại Trong Kho";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(384, 110);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 20);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            // 
            // txtslnhap
            // 
            this.txtslnhap.Location = new System.Drawing.Point(168, 110);
            this.txtslnhap.Name = "txtslnhap";
            this.txtslnhap.Size = new System.Drawing.Size(200, 20);
            this.txtslnhap.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SL Nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chuacosp);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.slhientai);
            this.panel2.Controls.Add(this.lblhoten);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.txtsltong);
            this.panel2.Controls.Add(this.txtslnhap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 627);
            this.panel2.TabIndex = 29;
            // 
            // chuacosp
            // 
            this.chuacosp.AutoSize = true;
            this.chuacosp.Location = new System.Drawing.Point(560, 221);
            this.chuacosp.Name = "chuacosp";
            this.chuacosp.Size = new System.Drawing.Size(101, 13);
            this.chuacosp.TabIndex = 25;
            this.chuacosp.TabStop = true;
            this.chuacosp.Text = "chưa có sản phẩm?";
            // 
            // txtsltong
            // 
            this.txtsltong.Location = new System.Drawing.Point(167, 157);
            this.txtsltong.Name = "txtsltong";
            this.txtsltong.Size = new System.Drawing.Size(200, 20);
            this.txtsltong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SL Tổng";
            // 
            // LapHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "LapHoaDonNhap";
            this.Size = new System.Drawing.Size(678, 684);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpro_nv)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaisp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errpro_nv2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv_loaisp;
        private System.Windows.Forms.TextBox slhientai;
        private System.Windows.Forms.Label lblhoten;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.TextBox txtslnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errpro_nv;
        private System.Windows.Forms.LinkLabel chuacosp;
        private System.Windows.Forms.TextBox txtsltong;
        private System.Windows.Forms.Label label2;
    }
}
