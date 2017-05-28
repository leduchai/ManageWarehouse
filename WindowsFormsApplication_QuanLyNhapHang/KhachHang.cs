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
    public partial class KhachHang : UserControl
    {
<<<<<<< HEAD
=======
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GQ1HP6Q\SQLEXPRESS;Initial Catalog=ManageWarehouse;Integrated Security=True");
        SqlCommand comm;
        SqlDataAdapter sda;
        DataSet ds;
        SqlDataReader sdr;

>>>>>>> 3b0b7fe0145634a8d8755d54f98f624841f7be88
        public KhachHang()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

=======
        public void masterpage(Boolean hien)
        {
            txttenkh.Enabled = hien;
            txtsdt.Enabled = hien;
            txtdiachi.Enabled = hien;
        }
>>>>>>> 3b0b7fe0145634a8d8755d54f98f624841f7be88
        private void label2_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
    }
}
=======

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void chitietdonhang_thang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        public void GiaoDienDatagridview()
        {
             dtgv_kh.Columns["makh"].HeaderText="Mã khách hàng";
            dtgv_kh.Columns["makh"].Width = 10;
            dtgv_kh.Columns["tenkh"].HeaderText = "Họ Tên";
            dtgv_kh.Columns["tenkh"].Width = 160;

            dtgv_kh.Columns["sdtkh"].HeaderText = "Số điện thoại";
            dtgv_kh.Columns["sdtkh"].Width = 130;

            dtgv_kh.Columns["diachikh"].HeaderText = "Địa chỉ";
            dtgv_kh.Columns["diachikh"].Width = 297;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            
            string sql = "select * from KhachHang";
            conn.Open();
            comm = new SqlCommand(sql,conn);
            sda = new SqlDataAdapter(comm);
            ds = new DataSet();
            sda.Fill(ds);
            dtgv_kh.DataSource = ds.Tables[0];
            GiaoDienDatagridview();
            dtgv_kh.Columns[0].Visible = false;
            masterpage(false);
            sldonhang_hien(false);
            txtsldonhang_thang.Enabled = false;
            txtsldonhang_nam.Enabled = false;
            btnluu_add.Enabled = false;
            conn.Close();
        }
        public void sldonhang_hien(Boolean hien)
        {
            chitietdonhang_thang.Visible = hien;
            labtrongnam.Enabled = hien;
            labsl1thang.Enabled = hien;
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

        private void dtgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sldonhang_hien(true);
            int t = dtgv_kh.CurrentRow.Index;
            txtmakh.Text= dtgv_kh.Rows[t].Cells[0].Value.ToString();
            txttenkh.Text = dtgv_kh.Rows[t].Cells[1].Value.ToString();
            txtsdt.Text = dtgv_kh.Rows[t].Cells[2].Value.ToString();
            txtdiachi.Text = dtgv_kh.Rows[t].Cells[3].Value.ToString();
            conn.Open();
            string sql1 = "select count(mahdx) from HoaDonXuat where ngayxuat between (GETDATE()-30) and GETDATE() and makh='"+ dtgv_kh.Rows[t].Cells[0].Value.ToString()+"'";
            comm = new SqlCommand(sql1,conn);
            SqlDataReader sdr = comm.ExecuteReader();
            if (sdr.Read()) txtsldonhang_thang.Text = sdr[0].ToString();
            conn.Close();

            conn.Open();
            string sql2 = "select count(mahdx) from HoaDonXuat where YEAR(ngayxuat)=YEAR(GETDATE()) and makh='" + dtgv_kh.Rows[t].Cells[0].Value.ToString() + "'";
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
            if (txtmakh.Text == "")
            {
                sql = "insert into KhachHang values(N'" + txttenkh.Text + "','" + txtsdt.Text + "',N'" + txtdiachi.Text + "')";
            }
            else
            {
                sql = "update KhachHang set tenkh=N'" + txttenkh.Text + "', sdtkh='" + txtsdt.Text + "',diachikh=N'" + txtdiachi.Text + "' where makh='" + txtmakh.Text + "'";
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
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Click vào khách hàng cần thay đổi thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public void LoadLaiTrang()
        {
            string sql = "select * from KhachHang";
            comm = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(comm);
            ds = new DataSet();
            sda.Fill(ds);
            dtgv_kh.DataSource = ds.Tables[0];
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
            txttenkh.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtmakh.Clear();
            txtsldonhang_thang.Clear();
            txtsldonhang_nam.Clear();
            sldonhang_hien(false);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Click vào khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          else  if (MessageBox.Show("Bạn có thực sự muốn xóa", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string sql = "delete KhachHang where makh='" + txtmakh.Text + "'";
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
            string sql = "select * from KhachHang where tenkh like N'%"+txttimkiem.Text+"%'";
            comm = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(comm);
            ds = new DataSet();
            sda.Fill(ds);
            dtgv_kh.DataSource = ds.Tables[0];
        }
    }
}
>>>>>>> 3b0b7fe0145634a8d8755d54f98f624841f7be88
