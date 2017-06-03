using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication_QuanLyNhapHang
{
    public partial class FormChiTietDonHang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=KHANGTRAN\SQLEXPRESS;Initial Catalog=ManageWarehouse;Integrated Security=True");
        SqlCommand comm;
        SqlDataAdapter sda;
        DataSet ds;
        public FormChiTietDonHang()
        {
            InitializeComponent();
        }
        public string ten
        {
            get { return labTen.Text; }
            set { labTen.Text = value; }
        }
       
        public void LoadDataGridView_KH()
        {
            string sql = "select  KhoHang.tenkho,ngayxuat,tonggiatri,nv.tennv from HoaDonXuat hdx,NhanVien nv, KhoHang where nv.manv = hdx.manv and  KhoHang.makho = hdx.makho and ngayxuat between (GETDATE()-30) and GETDATE() and makh = '" + labTen.Text+"'";
            conn.Open();
            comm = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(comm);
            ds = new DataSet();
            sda.Fill(ds);
            dgtXemChiTiet.DataSource = ds.Tables[0];
            dgtXemChiTiet.Columns[0].HeaderText = "Tên kho";
            dgtXemChiTiet.Columns[0].Width = 100;

            dgtXemChiTiet.Columns[1].HeaderText = "Ngày Xuất";
            dgtXemChiTiet.Columns[1].Width = 80;
            dgtXemChiTiet.Columns[2].HeaderText = "Tổng giá trị";
            dgtXemChiTiet.Columns[2].Width = 70;

            dgtXemChiTiet.Columns[3].HeaderText = "nhân viên xuất";
            dgtXemChiTiet.Columns[3].Width = 170;
        }
        public void LoadDataGridView_NCC()
        {
            string sql = "select  ngaynhap,KhoHang.tenkho,tonggiatri,nv.tennv from HoaDonNhap hdn,NhanVien nv, KhoHang where  nv.manv = hdn.manv  and KhoHang.makho = hdn.makho and ngaynhap between (GETDATE()-30) and GETDATE() and mancc='"+labTen.Text+"'";
            comm = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(comm);
            ds = new DataSet();
            sda.Fill(ds);
            dgtXemChiTiet.DataSource = ds.Tables[0];
            dgtXemChiTiet.Columns[0].HeaderText = "Ngày Nhập";
            dgtXemChiTiet.Columns[0].Width = 70;
            dgtXemChiTiet.Columns[1].HeaderText = "Tên Kho";
            dgtXemChiTiet.Columns[1].Width = 130;
            dgtXemChiTiet.Columns[2].HeaderText = "Tổng Giá Trị";
            dgtXemChiTiet.Columns[2].Width = 70;

            dgtXemChiTiet.Columns[3].HeaderText = "Nhân Viên";
            dgtXemChiTiet.Columns[3].Width = 170;
        }
        private void FormChiTietDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
