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
    public partial class SanPham : UserControl
    {
        //Khai báo các biến toàn cục
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local
        public SanPham()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_add_Click(object sender, EventArgs e)
        {
            string sql = "";
            //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
            if (con.State != ConnectionState.Open)
                con.Open();
            sql = "INSERT INTO SanPham(tensp,malsp,slhientai,quycach,donvi,gia)VALUES (";
            sql += "N'" + txthoten.Text + "',N'" + cbbloaisp.SelectedValue + "','" + txtsoluonght.Text + "','" + txtsoluong_quycach.Text + ""+cbbdonvitinh2.Text+ "" + "/" + "" + txtQuyC.Text+"',N'" + cbbdonvitinh1.Text + "',N'" + int.Parse(txtgia.Text) + "')";
            if (btnsua.Enabled == true)
            {
                if (txtsoluong_quycach.Text.Length == 0 && cbbdonvitinh2.Text.Length == 0)
                {
                    sql = "Update SanPham SET ";
                    sql += "tensp = N'" + txthoten.Text + "',";
                    sql += "malsp = '" + cbbloaisp.SelectedValue + "',";
                    sql += "slhientai = '" + txtsoluonght.Text + "',";
                    sql += "gia = N'" + txtgia.Text + "' ";
                    sql += "Where masp = N'" + int.Parse(txtmasp.Text) + "'";
                }
                else
                {
                    sql = "Update SanPham SET ";
                    sql += "tensp = N'" + txthoten.Text + "',";
                    sql += "malsp = '" + cbbloaisp.SelectedValue + "',";
                    sql += "slhientai = '" + txtsoluonght.Text + "',";
                    sql += "quycach = N'" + txtsoluong_quycach.Text + "" + cbbdonvitinh2.Text + "" + "/" + "" + txtQuyC.Text + "',";
                    sql += "donvi = '" + cbbdonvitinh1.Text + "',";
                    sql += "gia = N'" + txtgia.Text + "' ";
                    sql += "Where masp = N'" + int.Parse(txtmasp.Text) + "'";
                }
            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnxoa.Enabled == true)
            {
                sql = "Delete From SanPham Where masp =N'" + int.Parse(txtmasp.Text) + "'";
            }
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from SanPham";
            LoadDuLieu(sql);
            //dong ket noi
            con.Close();
            //Ẩn hiện các nút phù hợp chức năng
            HienChiTiet(false);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnluu_edit_Click(object sender, EventArgs e)
        {

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = @"Data Source=DESKTOP-GQ1HP6Q\SQLEXPRESS;Initial Catalog=ManageWarehouse;Integrated Security=True";
            //Gọi phương thức Load dự liệu
            LoadDuLieu("Select * from SanPham");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            txtQuyC.Enabled = false;
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
            dtgv_sp.DataSource = ds.Tables[0];
            GiaoDienDatagridview();
        }
        public void GiaoDienDatagridview()
        {



            dtgv_sp.Columns["tensp"].HeaderText = "Tên Sản Phẩm";
            dtgv_sp.Columns["tensp"].Width = 160;

            dtgv_sp.Columns["malsp"].HeaderText = "Mã loại SP";
            dtgv_sp.Columns["malsp"].Width = 100;

            dtgv_sp.Columns["slhientai"].HeaderText = "Số lượng";
            dtgv_sp.Columns["slhientai"].Width = 80;

            dtgv_sp.Columns["QuyCach"].HeaderText = "Quy cách";
            dtgv_sp.Columns["QuyCach"].Width = 91;

            dtgv_sp.Columns["donvi"].HeaderText = "Đơn Vị";
            dtgv_sp.Columns["donvi"].Width = 84;

            //LÀM SAO ĐỂ HIỆN TÊN KHdO
            dtgv_sp.Columns["gia"].HeaderText = "Giá";
            dtgv_sp.Columns["gia"].Width = 84;




            dtgv_sp.Columns["masp"].Visible = false;
        }
        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            txtmasp.Enabled = hien;
            txthoten.Enabled = hien;
            txtQuyC.Enabled = hien;
            txtsoluong_quycach.Enabled = hien;
            txtsoluonght.Enabled = hien;
            txtgia.Enabled = hien;
            cbbdonvitinh1.Enabled = hien;
            cbbdonvitinh2.Enabled = hien;
            cbbloaisp.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnluu_add.Enabled = hien;

        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {

        }
        private void XoaTrangChiTiet()
        {
            txtmasp.Clear();
            txtQuyC.Clear();
            txthoten.Clear();
            txtsoluonght.Clear();
            cbbdonvitinh1.DataBindings.Clear();
            txtgia.Clear();
            cbbdonvitinh2.DataBindings.Clear();
            txtsoluong_quycach.Clear();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            XoaTrangChiTiet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from LoaiSanPham", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbbloaisp.DataSource = dt;
            cbbloaisp.DisplayMember = "tenlsp";
            cbbloaisp.ValueMember = "malsp";
            SqlDataAdapter sda1 = new SqlDataAdapter("Select * from DonViTinh", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            cbbdonvitinh1.DataSource = dt1;
            cbbdonvitinh1.DisplayMember = "donvi";
            cbbdonvitinh1.ValueMember = "id";
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
            SqlDataAdapter sda = new SqlDataAdapter("Select * from LoaiSanPham ", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbbloaisp.DataSource = dt;
            cbbloaisp.DisplayMember = "tenlsp";
            cbbloaisp.ValueMember = "malsp";
            SqlDataAdapter sda1 = new SqlDataAdapter("Select * from DonViTinh", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            cbbdonvitinh1.DataSource = dt1;
            cbbdonvitinh1.DisplayMember = "donvi";
            cbbdonvitinh1.ValueMember = "donvi";
            //Hiện gropbox chi tiết
            HienChiTiet(true);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            //Bật Message Box cảnh báo người sử dụng
            if (MessageBox.Show("Bạn có chắc chắn xóa Sản Phẩm " + txtmasp.Text + " không? Nếu có ấn nút Lưu, không thì ấn nút Hủy", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnthem.Enabled = false;
                btnsua.Enabled = false;
                //Hiện gropbox chi tiết
                HienChiTiet(true);
            }
        }

        private void dtgv_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    txthoten.Text = Convert.ToString(dtgv_sp.CurrentRow.Cells["tensp"].Value);
                    txtmasp.Text = Convert.ToString(dtgv_sp.CurrentRow.Cells["masp"].Value);


                    cbbloaisp.Text = Convert.ToString(dtgv_sp.CurrentRow.Cells["malsp"].Value);

                    txtsoluonght.Text = Convert.ToString(dtgv_sp.CurrentRow.Cells["slhientai"].Value);

                    cbbdonvitinh1.Text = Convert.ToString(dtgv_sp.CurrentRow.Cells["donvi"].Value);


                    txtgia.Text = Convert.ToString(dtgv_sp.CurrentRow.Cells["gia"].Value);

                }
            }
                catch (Exception ex)
                            {
                            }

            //cbbloaisp.Text = this.layTenKho(cbbloaisp.Text);
            //btnsua.Enabled = true;
            //btnxoa.Enabled = true;
            //btnthem.Enabled = false;
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            //try
            //{
            //  txtmasp.Text = dtgv_sp[0, e.RowIndex].Value.ToString();
            //txthoten.Text = dtgv_sp[1, e.RowIndex].Value.ToString();
            //cbbloaisp.Text = dtgv_sp[2, e.RowIndex].Value.ToString();
            //txtsoluonght.Text = dtgv_sp[3, e.RowIndex].Value.ToString();               
            //cbbdonvitinh1.Text = dtgv_sp[5, e.RowIndex].Value.ToString();
            //txtgia.Text = dtgv_sp[6, e.RowIndex].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //}
            SqlDataAdapter sda = new SqlDataAdapter("Select * from LoaiSanPham WHERE malsp = '"+cbbloaisp.Text+"'", con);
                //LUY Y WHERE PHAI CO DAU NHAY DON '
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbbloaisp.DataSource = dt;
                cbbloaisp.DisplayMember = "tenlsp";
                cbbloaisp.ValueMember = "malsp";
                SqlDataAdapter sda1 = new SqlDataAdapter("Select * from DonViTinh WHERE donvi='"+cbbdonvitinh1.Text+"'", con);
                //LUY Y WHERE PHAI CO DAU NHAY DON '
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                cbbdonvitinh1.DataSource = dt1;
                cbbdonvitinh1.DisplayMember = "donvi";
                cbbdonvitinh1.ValueMember = "donvi";
            
        }
        public string layTenKho(string makho)
        {
            string s = "";
            SqlCommand sc = new SqlCommand("select * from LoaiSanPham where malsp='" + makho + "'", con);

            DbDataReader ddr = sc.ExecuteReader();
            if (ddr.HasRows)
            {
                while (ddr.Read())
                {
                    //vi tri cua cot tenkho trong cau lenh sql o tren
                    int x = ddr.GetOrdinal("tenlsp");

                    s = ddr.GetString(x);
                }
                //cai nay no bat phai huy doi tuong...khi ra khoi ham no phai tu huy chu???
                ddr.Dispose();
            }

            return s;
        }
        private void cbbdonvitinh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuyC.Text = cbbdonvitinh1.Text;
        }

        private void cbbdonvitinh2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            LoadDuLieu("SELECT * FROM SanPham");
            HienChiTiet(false);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string s = string.Format("tensp like '%{0}%'", txttimkiem.Text);
            ds.Tables[0].DefaultView.RowFilter = s;
        }

        private void chitietloaisp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbbloaisp.Text.Length == 0)
            {
                ds.Clear();
                ds = new DataSet();


                //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
                dap = new SqlDataAdapter("SELECT * FROM LoaiSanPham ", con);
                //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
                dap.Fill(ds);
                //Gắn dữ liệu từ DataSet lên DataGridView
                dtgv_sp.DataSource = ds.Tables[0];
                //Gắn dữ liệu từ DataSet lên DataGridView
                dtgv_sp.DataSource = ds.Tables[0];
            }
            else
            {
                ds.Clear();
                ds = new DataSet();


                //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
                dap = new SqlDataAdapter("SELECT * FROM LoaiSanPham WHERE malsp = " + cbbloaisp.SelectedValue + "", con);
                //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
                dap.Fill(ds);
                //Gắn dữ liệu từ DataSet lên DataGridView
                dtgv_sp.DataSource = ds.Tables[0];
                //Gắn dữ liệu từ DataSet lên DataGridView
                dtgv_sp.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SqlDataAdapter sda = new SqlDataAdapter("Select * from LoaiSanPham Where malsp = '" + cbbloaisp.SelectedValue + "'", con);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dtgv_sp.DataSource = ds.Tables[0];
        }
    }
}
