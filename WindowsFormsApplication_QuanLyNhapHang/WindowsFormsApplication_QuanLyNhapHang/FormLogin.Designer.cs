namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.linkdangki = new System.Windows.Forms.LinkLabel();
            this.linkquenmatkhau = new System.Windows.Forms.LinkLabel();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.btndangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnlogingoogle = new DevExpress.XtraEditors.SimpleButton();
            this.btnloginfb = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblthongbao);
            this.panel1.Controls.Add(this.linkdangki);
            this.panel1.Controls.Add(this.linkquenmatkhau);
            this.panel1.Controls.Add(this.txtmatkhau);
            this.panel1.Controls.Add(this.txttaikhoan);
            this.panel1.Controls.Add(this.btndangnhap);
            this.panel1.Controls.Add(this.btnlogingoogle);
            this.panel1.Controls.Add(this.btnloginfb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 357);
            this.panel1.TabIndex = 0;
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthongbao.ForeColor = System.Drawing.Color.Red;
            this.lblthongbao.Location = new System.Drawing.Point(3, 23);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(46, 17);
            this.lblthongbao.TabIndex = 10;
            this.lblthongbao.Text = "label1";
            this.lblthongbao.Visible = false;
            // 
            // linkdangki
            // 
            this.linkdangki.AutoSize = true;
            this.linkdangki.Location = new System.Drawing.Point(80, 194);
            this.linkdangki.Name = "linkdangki";
            this.linkdangki.Size = new System.Drawing.Size(56, 17);
            this.linkdangki.TabIndex = 9;
            this.linkdangki.TabStop = true;
            this.linkdangki.Text = "Đăng kí";
            // 
            // linkquenmatkhau
            // 
            this.linkquenmatkhau.AutoSize = true;
            this.linkquenmatkhau.Location = new System.Drawing.Point(196, 194);
            this.linkquenmatkhau.Name = "linkquenmatkhau";
            this.linkquenmatkhau.Size = new System.Drawing.Size(105, 17);
            this.linkquenmatkhau.TabIndex = 9;
            this.linkquenmatkhau.TabStop = true;
            this.linkquenmatkhau.Text = "Quên mật khẩu";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(29, 101);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(320, 26);
            this.txtmatkhau.TabIndex = 8;
            this.txtmatkhau.Click += new System.EventHandler(this.txtmatkhau_Click);
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            this.txtmatkhau.Leave += new System.EventHandler(this.txtmatkhau_Leave);
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txttaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaikhoan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txttaikhoan.Location = new System.Drawing.Point(29, 60);
            this.txttaikhoan.Multiline = true;
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(320, 26);
            this.txttaikhoan.TabIndex = 8;
            this.txttaikhoan.Click += new System.EventHandler(this.txttaikhoan_Click);
            this.txttaikhoan.TextChanged += new System.EventHandler(this.txttaikhoan_TextChanged);
            this.txttaikhoan.Leave += new System.EventHandler(this.txttaikhoan_Leave);
            // 
            // btndangnhap
            // 
            this.btndangnhap.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btndangnhap.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btndangnhap.Appearance.Options.UseFont = true;
            this.btndangnhap.Appearance.Options.UseForeColor = true;
            this.btndangnhap.Location = new System.Drawing.Point(29, 151);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(320, 40);
            this.btndangnhap.TabIndex = 7;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnlogingoogle
            // 
            this.btnlogingoogle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btnlogingoogle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.btnlogingoogle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnlogingoogle.Appearance.Options.UseBackColor = true;
            this.btnlogingoogle.Appearance.Options.UseFont = true;
            this.btnlogingoogle.Appearance.Options.UseForeColor = true;
            this.btnlogingoogle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnlogingoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnlogingoogle.Image")));
            this.btnlogingoogle.Location = new System.Drawing.Point(83, 286);
            this.btnlogingoogle.Name = "btnlogingoogle";
            this.btnlogingoogle.Size = new System.Drawing.Size(218, 32);
            this.btnlogingoogle.TabIndex = 7;
            this.btnlogingoogle.Text = "Đăng nhập bằng Google      ";
            // 
            // btnloginfb
            // 
            this.btnloginfb.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnloginfb.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.btnloginfb.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnloginfb.Appearance.Options.UseBackColor = true;
            this.btnloginfb.Appearance.Options.UseFont = true;
            this.btnloginfb.Appearance.Options.UseForeColor = true;
            this.btnloginfb.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnloginfb.Image = ((System.Drawing.Image)(resources.GetObject("btnloginfb.Image")));
            this.btnloginfb.Location = new System.Drawing.Point(83, 248);
            this.btnloginfb.Name = "btnloginfb";
            this.btnloginfb.Size = new System.Drawing.Size(218, 32);
            this.btnloginfb.TabIndex = 7;
            this.btnloginfb.Text = "Đăng nhập bằng  Facebook";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 357);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnlogingoogle;
        private DevExpress.XtraEditors.SimpleButton btnloginfb;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private DevExpress.XtraEditors.SimpleButton btndangnhap;
        private System.Windows.Forms.LinkLabel linkdangki;
        private System.Windows.Forms.LinkLabel linkquenmatkhau;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}