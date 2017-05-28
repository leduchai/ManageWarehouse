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

namespace WindowsFormsApplication_QuanLyNhapHang
{
    public partial class KhoHang : UserControl
    {
        SqlDataAdapter sqlda;
        DataSet ds;
        SqlConnection scon;

        public KhoHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cbbloaisp.Text = "";
            cbbloaisp.Enabled = true;
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            scon = new SqlConnection(@"server=DESKTOP-RJ3K5CJ; database = ManageWarehouse; trusted_connection=true");
            // co 2 override: 1 cai can tai khoan 1 cai ko

            scon.Open();            //  nen  kiem tra trang thai cua no da mo hay chua truoc khi mo
                                    //  ket noi

            //doc du lieu ra
            string command = "select * from KhoHang";
            sqlda = new SqlDataAdapter(command, scon);   // cau noi


            ds = new DataSet();     
            sqlda.Fill(ds, "NewKhoHang");  
         
            dtgv_kh.DataSource = ds.Tables["NewKhoHang"];



            GiaoDienDatagridview();

            //hien thi du lieu tren combobox
            SqlDataAdapter sda = new SqlDataAdapter("Select tennv,manv from NhanVien where chucvu=N'quản lý'", scon);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbbnvquanly.DataSource = dt;
            cbbnvquanly.DisplayMember = "tennv";
            cbbnvquanly.ValueMember = "manv";


            //hien thi du lieu tren combobox
            sda = new SqlDataAdapter("Select tenlsp,malsp from LoaiSanPham", scon);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            dt = new DataTable();
            sda.Fill(dt);
            cbbloaisp.DataSource = dt;
            cbbloaisp.DisplayMember = "tenlsp";
            cbbloaisp.ValueMember = "malsp";



            btnluu_add.Enabled = true;
        }

        public void GiaoDienDatagridview()
        {

            dtgv_kh.Columns["makho"].HeaderText = "Mã Kho";
            dtgv_kh.Columns["makho"].Width = 84;

            dtgv_kh.Columns["tenkho"].HeaderText = "Tên Kho";
            dtgv_kh.Columns["tenkho"].Width = 100;

            dtgv_kh.Columns["tinhtrang"].HeaderText = "Tình Trạng";
            dtgv_kh.Columns["tinhtrang"].Width = 150;


            //??? làm sao để lấy tên nv và thêm 1 số cột khác nữa
            dtgv_kh.Columns["manv"].HeaderText = "NV Quản Lý";
            dtgv_kh.Columns["manv"].Width = 84;

            
            dtgv_kh.Columns["diachi"].HeaderText = "Địa Điểm";
            dtgv_kh.Columns["diachi"].Width = 150;

        }

        public void LoadData()
        {

            string command = "select * from KhoHang";
            sqlda = new SqlDataAdapter(command, scon);   // cau noi


            ds = new DataSet();     //cac bang dc lay ra tu database se duoc luu tren bo nho
                                    //sau do tu dataset ta day ra giao dien nguoi dung
            sqlda.Fill(ds, "NewKhoHang");  
            dtgv_kh.DataSource = ds.Tables["NewKhoHang"];


        }

        private void dtgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtmakho.Text = Convert.ToString(dtgv_kh.CurrentRow.Cells["makho"].Value);



                txttenkho.Text = Convert.ToString(dtgv_kh.CurrentRow.Cells["tenkho"].Value);


                txttinhtrang.Text = Convert.ToString(dtgv_kh.CurrentRow.Cells["tinhtrang"].Value);

                txtdiadiem.Text = Convert.ToString(dtgv_kh.CurrentRow.Cells["diachi"].Value);



                SqlDataAdapter sda = new SqlDataAdapter("Select tennv,manv from NhanVien where manv='"+ Convert.ToInt32(dtgv_kh.CurrentRow.Cells["manv"].Value)+"'", scon);
                //LUY Y WHERE PHAI CO DAU NHAY DON '
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbbnvquanly.DataSource = dt;
                cbbnvquanly.DisplayMember = "tennv";
                cbbnvquanly.ValueMember = "manv";

                sda = new SqlDataAdapter("Select tenlsp,malsp from LoaiSanPham where makho='"+Int32.Parse(txtmakho.Text)+"'", scon);
                //LUY Y WHERE PHAI CO DAU NHAY DON '
                 dt = new DataTable();
                sda.Fill(dt);
                cbbloaisp.DataSource = dt;
                cbbloaisp.DisplayMember = "tenlsp";
                cbbloaisp.ValueMember = "malsp";


                SqlCommand tongslnv = new SqlCommand("select * from NhanVien where makho='" + Int32.Parse( txtmakho.Text )+ "'", scon);
                int x = tongslnv.ExecuteNonQuery();

                slnv.Text= x.ToString();


                btnxoa.Enabled = true;
                btnsua.Enabled = true;

            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string s = string.Format("tenkho like '%{0}%'", txttimkiem.Text);
            ds.Tables["NewKhoHang"].DefaultView.RowFilter = s;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nhân viên này sẽ bị xóa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                   == DialogResult.OK)
            {
                //khoi tao command va truyen vao ten thu tuc
                SqlCommand sc = new SqlCommand("xoakhohang", scon);

                //khai bao kieu thuc thi la thuc thi thu tuc
                sc.CommandType = CommandType.StoredProcedure;

                //khai bao parameter va truyen tham so cho thu tuc
                SqlParameter sp = new SqlParameter("@makho", Convert.ToInt32(txtmakho.Text));

                sc.Parameters.Add(sp);      //co bao nhieu tham so thi new roi add tung y lan

                sc.ExecuteNonQuery();

                LoadData();

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //bam edit xong deo bam saveedit


            btnluu_edit.Location = new Point(btnluu_add.Location.X, btnluu_add.Location.Y);

            btnluu_edit.Visible = true;
            btnluu_add.Visible = false;


            txttenkho.Enabled = true;

            txttinhtrang.Enabled = true;
            cbbnvquanly.Enabled = true;
            cbbloaisp.Enabled = false;
            txtdiadiem.Enabled = true;
            slnv.Enabled = false; 

            
        }

        private void btnluu_edit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                suakhohang();
                LoadData();
            }

        }

        public void suakhohang()
        {
            SqlCommand sc = new SqlCommand("suakhohang", scon);

            //khai bao kieu thuc thi la thuc thi thu tuc
            sc.CommandType = CommandType.StoredProcedure;

            //khai bao parameter va truyen tham so cho thu tuc

            SqlParameter sp = new SqlParameter("@makho", Convert.ToInt32(txtmakho.Text));
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@tenkho", txttenkho.Text);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@tinhtrang", txttinhtrang.Text);
            sc.Parameters.Add(sp);

         

            sp = new SqlParameter("@manv",  cbbnvquanly.SelectedValue);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@diachi", txtdiadiem.Text);
            sc.Parameters.Add(sp);



            //thuc thi
            sc.ExecuteNonQuery();
        }

        private void btnluu_add_Click(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand("themkhohang", scon);

            //khai bao kieu thuc thi la thuc thi thu tuc
            sc.CommandType = CommandType.StoredProcedure;

            //khai bao parameter va truyen tham so cho thu tuc


            SqlParameter sp = new SqlParameter("@tenkho", txttenkho.Text);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@tinhtrang", txttinhtrang.Text);
            sc.Parameters.Add(sp);



            sp = new SqlParameter("@manv", cbbnvquanly.SelectedValue);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@diachi", txtdiadiem.Text);
            sc.Parameters.Add(sp);


            //thuc thi
            sc.ExecuteNonQuery();

            LoadData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttenkho_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblhoten_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbbloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbnvquanly_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txttinhtrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblslnv_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slnv_Click(object sender, EventArgs e)
        {

        }

        private void chitietloaisp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblloaisp_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chitietnvql_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtdiadiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmakho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
