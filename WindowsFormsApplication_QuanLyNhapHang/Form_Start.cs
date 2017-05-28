using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_QuanLyNhapHang
{
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }

        private void Form_Start_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            itemkhohang.Enabled = true;
            itemsp.Enabled = true;
            itemloaisp.Enabled = true;
            itemnv.Enabled = true;
            itemnhacc.Enabled = true;
            itemhdn.Enabled = true;
           // itemhome.Enabled = true;
            //stastr.BackColor = System.Drawing.Color.Orange;
            //toolstrstalbl.ForeColor = System.Drawing.SystemColors.Window;
            //stastr.BackColor = System.Drawing.Color.LightSkyBlue;
            toolstrprobar.Visible = false;
            
        }

        private void itemlogin_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
           // itemlogin.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            itemdatetime.Text = "<b><i>" + DateTime.Now.ToLongDateString() + "</b></i> <br><br> <b>" + DateTime.Now.ToLongTimeString() + "";

        }

        public void loadformafterlogin()
        {
            //this.Close();
            itemkhohang.Enabled = true;
            itemsp.Enabled = true;
            itemloaisp.Enabled = true;
            //MessageBox.Show("á");
            itemnv.Enabled = true;
            itemnhacc.Enabled = true;
            itemhdn.Enabled = true;
         //   itemhome.Enabled = true;
            //toolstrstalbl.ForeColor = System.Drawing.SystemColors.Window;
            toolstrstalbl.Text = "Ready";
            stastr.BackColor = System.Drawing.Color.LawnGreen;
           // toolstrprobar.Visible = false;
           
        }

        public void giavoloadprocess()
        {
            stastr.BackColor = System.Drawing.Color.Orange;
            MessageBox.Show("sa");
            toolstrprobar.Visible = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //de public de phuc vu cho giavoloadprocess();

            //if (toolstrprobar.Value >= 100)
            //{
            //    timer2.Stop();
            //    toolstrprobar.Value = 0;
            //    loadformafterlogin();
            //}
            //else
            //{
            //    toolstrprobar.Value += 2;
            //    toolstrstalbl.Text = toolstrprobar.Value.ToString() + " %";
            //}
        }

        private void itemkhohang_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPage1.Controls.Clear();
            KhoHang kh = new KhoHang();
            tabPage1.Controls.Add(kh);
        }

        private void itemnv_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPage1.Controls.Clear();
            NhanVien nv = new NhanVien();
            tabPage1.Controls.Add(nv);
        }
        private void itemnhacc_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           
            tabPage1.Controls.Clear();
            KhachHang nv = new KhachHang();
            tabPage1.Controls.Add(nv);
            tabPage1.Text = "Khách Hàng";
            

            tabPage2.Controls.Clear();
            NhaCungCap ncc = new NhaCungCap();
            tabPage2.Controls.Add(ncc);
            tabPage2.Text = "Nhà Cung Cấp";
            
        }
        private void itemhome_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void itemsp_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            tabPage1.Controls.Clear();
            SanPham sp = new SanPham();
            tabPage1.Controls.Add(sp);


            tabPage2.Controls.Clear();
            LoaiSanPham lsp = new LoaiSanPham();
            tabPage2.Controls.Add(lsp);

            this.tabControl1.SelectedIndex = 0;
        }
    }
}
