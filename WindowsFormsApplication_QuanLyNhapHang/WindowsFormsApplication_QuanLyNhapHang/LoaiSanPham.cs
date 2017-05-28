using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data.Common;

namespace WindowsFormsApplication_QuanLyNhapHang
{
    public partial class LoaiSanPham : UserControl
    {
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local
        SqlDataReader sdr;
        public LoaiSanPham()
        {
            InitializeComponent();
        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = @"Data Source=DESKTOP-GQ1HP6Q\SQLEXPRESS;Initial Catalog=ManageWarehouse;Integrated Security=True";
            //Gọi phương thức Load dự liệu
            LoadDuLieu("Select * from LoaiSanPham");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            txtslsp.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            //An groupbox chi tiet
            HienChiTiet(false);
        }
        private void LoadDuLieu(String sql)
        {

            //tạo đối tượng DataSet
            ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dtgv_loaisp.DataSource = ds.Tables[0];
            GiaoDienDatagridview();
        }
        public void GiaoDienDatagridview()
        {



            dtgv_loaisp.Columns["tenlsp"].HeaderText = "Tên Loại Sản Phẩm";
            dtgv_loaisp.Columns["tenlsp"].Width = 500;

          
            dtgv_loaisp.Columns["makho"].HeaderText = "Kho";
            dtgv_loaisp.Columns["makho"].Width = 500;


            //LÀM SAO ĐỂ HIỆN TÊN KHdO




            dtgv_loaisp.Columns["makho"].Visible = false;
        }
        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            txtmalsp.Enabled = hien;
            txtluong.Enabled = hien;
            cbbkho.Enabled = hien;
            
            //Ẩn hiện 2 nút Lưu và Hủy
            btnluu_add.Enabled = hien;

        }

        private void btnluu_add_Click(object sender, EventArgs e)
        {
            string sql = "";
            //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
            if (con.State != ConnectionState.Open)
                con.Open();
            sql = "INSERT INTO LoaiSanPham(tenlsp,makho)VALUES (";
            sql += "N'" + txtluong.Text + "'," + int.Parse(cbbkho.SelectedValue) + ")";
            if (btnsua.Enabled == true)
            {
                
                    sql = "Update LoaiSanPham SET ";
                    sql += "tenlsp = N'" + txtluong.Text + "',";
                    sql += "makho = '" + cbbkho.SelectedValue + "',";                   
                    sql += "Where malsp = " + int.Parse(txtmalsp.Text) + "";
                
            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnxoa.Enabled == true)
            {
                sql = "Delete From LoaiSanPham Where malsp =" + int.Parse(txtmalsp.Text) + "";
            }
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from SanPham";
            //LoadDuLieu(sql);
            //dong ket noi
            con.Close();
            //Ẩn hiện các nút phù hợp chức năng
            //HienChiTiet(false);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        private void XoaTrangChiTiet()
        {
            txtmalsp.Clear();
            txtluong.Clear();
            txtslsp.Clear();
            cbbkho.DataBindings.Clear();

        }
        private void txtslsp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            XoaTrangChiTiet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from KhoHang", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbbkho.DataSource = dt;
            cbbkho.DisplayMember = "tenkho";
            cbbkho.ValueMember = "makho";

            //Cam nut sua xoa
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            SqlDataAdapter sda = new SqlDataAdapter("Select * from KhoHang", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbbkho.DataSource = dt;
            cbbkho.DisplayMember = "tenkho";
            cbbkho.ValueMember = "makho";

            //Hiện gropbox chi tiết
            HienChiTiet(true);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            //Bật Message Box cảnh báo người sử dụng
            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " + txtmalsp.Text + " không? Nếu có ấn nút Lưu, không thì ấn nút Hủy", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnthem.Enabled = false;
                btnsua.Enabled = false;
                //Hiện gropbox chi tiết
                HienChiTiet(true);
            }
        }

        private void dtgv_loaisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txtluong.Text = Convert.ToString(dtgv_loaisp.CurrentRow.Cells["tenlsp"].Value);
                    cbbkho.Text = Convert.ToString(dtgv_loaisp.CurrentRow.Cells["makho"].Value);


                    txtmalsp.Text = Convert.ToString(dtgv_loaisp.CurrentRow.Cells["malsp"].Value);

                   


                    

                }
            }
            catch (Exception ex)
            {
            }

            SqlDataAdapter sda = new SqlDataAdapter("Select * from KhoHang WHERE makho = '" + cbbkho.Text + "'", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbbkho.DataSource = dt;
            cbbkho.DisplayMember = "tenkho";
            cbbkho.ValueMember = "makho";
            // SqlDataAdapter sda1 = new SqlDataAdapter("Select Count(masp) from SanPham Group by malsp='" + txtslsp.Text + "'", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            //DataTable dt1 = new DataTable();
            //sda1.Fill(dt1);



            con.Open();
            string sql2 = "Select count(masp) from SanPham Where malsp = '" + txtmalsp.Text + "'";
            SqlCommand com = new SqlCommand(sql2, con);
            SqlDataReader sdr2 = com.ExecuteReader();
                       if (sdr2.Read()) txtslsp.Text = sdr2[0].ToString();
            con.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnthem.Enabled = true;
            //xoa trang
            XoaTrangChiTiet();
            //Cam nhap
            ds.Clear();
            LoadDuLieu("SELECT * FROM LoaiSanPham");
            HienChiTiet(false);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string s = string.Format("tenlsp like '%{0}%'", txttimkiem.Text);
            ds.Tables[0].DefaultView.RowFilter = s;
        }

        private void chitietsp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtslsp.Text.Length == 0)
            {
                ds.Clear();
                ds = new DataSet();


                //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
                dap = new SqlDataAdapter("SELECT * FROM LoaiSanPham ", con);
                //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
                dap.Fill(ds);
                //Gắn dữ liệu từ DataSet lên DataGridView
                dtgv_loaisp.DataSource = ds.Tables[0];
                //Gắn dữ liệu từ DataSet lên DataGridView
                dtgv_loaisp.DataSource = ds.Tables[0];
            }
            else
            {
                ds.Clear();
                ds = new DataSet();


                //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
                dap = new SqlDataAdapter("SELECT * FROM SanPham WHERE malsp = " + txtmalsp.Text + "", con);
                //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
                dap.Fill(ds);
                //Gắn dữ liệu từ DataSet lên DataGridView
                dtgv_loaisp.DataSource = ds.Tables[0];
                //Gắn dữ liệu từ DataSet lên DataGridView
                dtgv_loaisp.DataSource = ds.Tables[0];
            }
        }
    }
}
