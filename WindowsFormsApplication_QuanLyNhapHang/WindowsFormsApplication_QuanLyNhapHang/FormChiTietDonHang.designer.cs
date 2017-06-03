namespace WindowsFormsApplication_QuanLyNhapHang
{
    partial class FormChiTietDonHang
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
            this.dgtXemChiTiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labNCC = new System.Windows.Forms.Label();
            this.labTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtXemChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtXemChiTiet
            // 
            this.dgtXemChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtXemChiTiet.Location = new System.Drawing.Point(0, 65);
            this.dgtXemChiTiet.Name = "dgtXemChiTiet";
            this.dgtXemChiTiet.Size = new System.Drawing.Size(457, 272);
            this.dgtXemChiTiet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Tiết Đơn Hàng";
            // 
            // labNCC
            // 
            this.labNCC.AutoSize = true;
            this.labNCC.Location = new System.Drawing.Point(25, 65);
            this.labNCC.Name = "labNCC";
            this.labNCC.Size = new System.Drawing.Size(0, 13);
            this.labNCC.TabIndex = 3;
            this.labNCC.Visible = false;
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Location = new System.Drawing.Point(25, 30);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(22, 13);
            this.labTen.TabIndex = 4;
            this.labTen.Text = "ten";
            this.labTen.Visible = false;
            // 
            // FormChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 343);
            this.Controls.Add(this.labTen);
            this.Controls.Add(this.labNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtXemChiTiet);
            this.Name = "FormChiTietDonHang";
            this.Text = "ChiTietDonHang";
            this.Load += new System.EventHandler(this.FormChiTietDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtXemChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtXemChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labNCC;
        private System.Windows.Forms.Label labTen;
    }
}