using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using System.Data.SqlClient;
>>>>>>> 3b0b7fe0145634a8d8755d54f98f624841f7be88

namespace WindowsFormsApplication_QuanLyNhapHang
{
    public partial class NhaCungCap : UserControl
    {
<<<<<<< HEAD
=======
        SqlConnection conn = new SqlConnection(@"Data Source=KHANGTRAN\SQLEXPRESS;Initial Catalog=ManageWarehouse;Integrated Security=True");
        SqlCommand comm;
        SqlDataAdapter sda;
        DataSet ds;

>>>>>>> 3b0b7fe0145634a8d8755d54f98f624841f7be88
        public NhaCungCap()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

        public void masterpage(Boolean hien)
        {
            txttennhacc.Enabled = hien;
            txtsdt.Enabled = hien;
            txtdiachi.Enabled = hien;
        }

        public void GiaoDienDatagridview()
        {
            dtgv_ncc.Columns["mancc"].HeaderText = "Mã";
            dtgv_ncc.Columns["mancc"].Width = 10;
            dtgv_ncc.Columns["tenncc"].HeaderText = "Tên Nhà Cung Cấp";
            dtgv_ncc.Columns["tenncc"].Width = 160;

            dtgv_ncc.Columns["sdtncc"].HeaderText = "Số điện thoại";
            dtgv_ncc.Columns["sdtncc"].Width = 130;

            dtgv_ncc.Columns["diachincc"].HeaderText = "Địa chỉ";
            dtgv_ncc.Columns["diachincc"].Width = 297;
        }

        public void LoadLaiTrang()
        {
            string sql = "select * from NhaCungCap";
            comm = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(comm);
            ds = new DataSet();
            sda.Fill(ds);
            dtgv_ncc.DataSource = ds.Tables[0];
            GiaoDienDatagridview();
            masterpage(false);
            sldonhang_hien(false);
            txtsldonhang_thang.Enabled = false;
            txtsldonhang_nam.Enabled = false;
            btnluu_add.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        public void XoaTrangChiTiet()
        {
            txttennhacc.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtmancc.Clear();
            txtsldonhang_thang.Clear();
            txtsldonhang_nam.Clear();
            sldonhang_hien(false);
        }


        public void sldonhang_hien(Boolean hien)
        {
            chitietdonhang_thang.Visible = hien;
            labtrongnam.Enabled = hien;
            labsl1thang.Enabled = hien;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

            string sql = "select * from NhaCungCap";
            conn.Open();
            comm = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(comm);
            ds = new DataSet();
            sda.Fill(ds);
            dtgv_ncc.DataSource = ds.Tables[0];
            GiaoDienDatagridview();
            dtgv_ncc.Columns[0].Visible = false;
            masterpage(false);
            sldonhang_hien(false);
            txtsldonhang_thang.Enabled = false;
            txtsldonhang_nam.Enabled = false;
            btnluu_add.Enabled = false;
            conn.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            XoaTrangChiTiet();
            masterpage(true);
            btnluu_add.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
        }

        private void dtgv_ncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sldonhang_hien(true);
            int t = dtgv_ncc.CurrentRow.Index;
            txtmancc.Text = dtgv_ncc.Rows[t].Cells[0].Value.ToString();
            txttennhacc.Text = dtgv_ncc.Rows[t].Cells[1].Value.ToString();
            txtsdt.Text = dtgv_ncc.Rows[t].Cells[2].Value.ToString();
            txtdiachi.Text = dtgv_ncc.Rows[t].Cells[3].Value.ToString();
            conn.Open();
            string sql1 = "select count(mahdn) from HoaDonNhap where ngaynhap between (GETDATE()-30) and GETDATE() and mancc='" + dtgv_ncc.Rows[t].Cells[0].Value.ToString() + "'";
            comm = new SqlCommand(sql1, conn);
            SqlDataReader sdr = comm.ExecuteReader();
            if (sdr.Read()) txtsldonhang_thang.Text = sdr[0].ToString();
            conn.Close();

            conn.Open();
            string sql2 = "select count(mahdn) from HoaDonNhap where YEAR(ngaynhap)=YEAR(GETDATE()) and mancc='" + dtgv_ncc.Rows[t].Cells[0].Value.ToString() + "'";
            comm = new SqlCommand(sql2, conn);
            SqlDataReader sdr2 = comm.ExecuteReader();
            if (sdr2.Read()) txtsldonhang_nam.Text = sdr2[0].ToString();
            conn.Close();
        }

        private void btnluu_add_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string sql;
            if (txtmancc.Text == "")
            {
                sql = "insert into NhaCungCap values(N'" + txttennhacc.Text + "','" + txtsdt.Text + "',N'" + txtdiachi.Text + "')";
            }
            else
            {
                sql = "update NhaCungCap set tenncc=N'" + txttennhacc.Text + "', sdtncc='" + txtsdt.Text + "',diachincc=N'" + txtdiachi.Text + "' where mancc='" + txtmancc.Text + "'";
            }
            try
            {
                comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công !", "Thông báo");
                XoaTrangChiTiet();
                LoadLaiTrang();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Click vào nhà cung cấp cần thay đổi thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                masterpage(true);
                btnluu_add.Enabled = true;
                btnthem.Enabled = false;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Click vào nhà cung cấp cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có thực sự muốn xóa", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string sql = "delete nccachHang where mancc='" + txtmancc.Text + "'";
                    comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Thành công !", "Thông báo");
                    XoaTrangChiTiet();
                    LoadLaiTrang();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from NhaCungCap where tenncc like N'%" + txttimkiem.Text + "%'";
            comm = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(comm);
            ds = new DataSet();
            sda.Fill(ds);
            dtgv_ncc.DataSource = ds.Tables[0];
        }
>>>>>>> 3b0b7fe0145634a8d8755d54f98f624841f7be88
    }
}
