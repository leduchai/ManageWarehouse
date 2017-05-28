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
        public LoaiSanPham()
        {
            InitializeComponent();
        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnluu_add_Click(object sender, EventArgs e)
        {
            string sql = "";
            //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
            if (con.State != ConnectionState.Open)
                con.Open();
            sql = "INSERT INTO SanPham(tensp,malsp,slhientai,quycach,donvi,gia)VALUES (";
            sql += "N'" + txtslsp.Text + "',N'" + cbbkho.SelectedValue + "','" + txtslsp.Text + "','" + txtslsp.Text + "" + cbbkho.Text + "" + "/" + "" + txtslsp.Text + "',N'" + cbbkho.Text + "',N'" + int.Parse(txtslsp.Text) + "')";
            if (btnsua.Enabled == true)
            {
                
                    sql = "Update LoaiSanPham SET ";
                    sql += "tenlsp = N'" + txtslsp.Text + "',";
                    sql += "makho = '" + cbbkho.SelectedValue + "',";                   
                    sql += "Where malsp = N'" + int.Parse(txtslsp.Text) + "'";
                
            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnxoa.Enabled == true)
            {
                sql = "Delete From LoaiSanPham Where masp =N'" + int.Parse(txtslsp.Text) + "'";
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

        private void txtslsp_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
