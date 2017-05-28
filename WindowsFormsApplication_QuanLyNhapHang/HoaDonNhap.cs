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
    public partial class HoaDonNhap : UserControl
    {
        SqlDataAdapter sqlda;
        DataSet ds;
        SqlConnection scon;

        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            scon = new SqlConnection(@"server=DESKTOP-RJ3K5CJ; database = ManageWarehouse; trusted_connection=true");
            // co 2 override: 1 cai can tai khoan 1 cai ko

            scon.Open();            //  nen  kiem tra trang thai cua no da mo hay chua truoc khi mo
                                    //  ket noi

            //doc du lieu ra
            string command = "select * from HoaDonNhap";
            sqlda = new SqlDataAdapter(command, scon);   // cau noi


            ds = new DataSet();     //cac bang dc lay ra tu database se duoc luu tren bo nho
                                    //sau do tu dataset ta day ra giao dien nguoi dung
            sqlda.Fill(ds, "NewHoaDonNhap");  //do du lieu tu dataadapter vao dataset
                                            //sau do dat ten bang moi la: NewNhanVien..neu ko co,no se mac dinh ten nhu trong database

            //lay du lieu cua bang NewNhanVien trong dataset gan cho datagidview
            dtgv_hdn.DataSource = ds.Tables["NewHoaDonNhap"];

            //sqlda.SelectCommand.CommandText = "select * from NhanVien is Gioitinh is null";
            //sqlda.Fill(ds, "NewNhanVien3");
            //dtgv_hdn.DataSource = ds.Tables["NewNhanVien3"];   
            //tuc trong dataset bay gio co 2 bang NewNhanVien3 va NewNhanVien2....    ds.tables[cai nao thi no ra cai y]



            GiaoDienDatagridview();

           

        }

        public void GiaoDienDatagridview()
        {



            dtgv_hdn.Columns["mahdn"].HeaderText = "Mã HDN";
            dtgv_hdn.Columns["mahdn"].Width = 84;

            dtgv_hdn.Columns["tenhdn"].HeaderText = "Tên HDN";
            dtgv_hdn.Columns["tenhdn"].Width = 160;

            dtgv_hdn.Columns["ngaynhap"].HeaderText = "Ngày Nhập";
            dtgv_hdn.Columns["ngaynhap"].Width = 100;

            dtgv_hdn.Columns["manv"].HeaderText = "NV Lập";
            dtgv_hdn.Columns["manv"].Width = 80;

            dtgv_hdn.Columns["makho"].HeaderText = "Kho Hàng";
            dtgv_hdn.Columns["makho"].Width = 91;

            dtgv_hdn.Columns["mancc"].HeaderText = "Nhà CC";
            dtgv_hdn.Columns["mancc"].Width = 84;

            //LÀM SAO ĐỂ HIỆN TÊN KHO
            dtgv_hdn.Columns["tonggiatri"].HeaderText = "Tổng GT";
            dtgv_hdn.Columns["tonggiatri"].Width = 84;



        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Form_Start.laphoadon = true;
        }

        public void LoadData()
        {

            string command = "select * from HoaDonNhap";
            sqlda = new SqlDataAdapter(command, scon);   // cau noi


            ds = new DataSet();     //cac bang dc lay ra tu database se duoc luu tren bo nho
                                    //sau do tu dataset ta day ra giao dien nguoi dung
            sqlda.Fill(ds, "NewHoaDonNhap");  //do du lieu tu dataadapter vao dataset
                                            //sau do dat ten bang moi la: NewNhanVien..neu ko co,no se mac dinh ten nhu trong database

            //lay du lieu cua bang NewNhanVien trong dataset gan cho datagidview
            dtgv_hdn.DataSource = ds.Tables["NewHoaDonNhap"];

  
        }

        private void dtgv_hdn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtmahdn.Text = Convert.ToString(dtgv_hdn.CurrentRow.Cells["mahdn"].Value);



                txttenhdn.Text = Convert.ToString(dtgv_hdn.CurrentRow.Cells["tenhdn"].Value);


                ngaynhap.Text = Convert.ToString(dtgv_hdn.CurrentRow.Cells["ngaynhap"].Value);


                SqlDataAdapter sda = new SqlDataAdapter("Select tennv,manv from NhanVien where manv='" + Convert.ToInt32(dtgv_hdn.CurrentRow.Cells["manv"].Value) + "'", scon);
                //LUY Y WHERE PHAI CO DAU NHAY DON '
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbbnvlap.DataSource = dt;
                cbbnvlap.DisplayMember = "tennv";
                cbbnvlap.ValueMember = "manv";


                sda = new SqlDataAdapter("Select tenkho,makho from KhoHang where makho='" + Convert.ToInt32(dtgv_hdn.CurrentRow.Cells["makho"].Value) + "'", scon);
                //LUY Y WHERE PHAI CO DAU NHAY DON '
                dt = new DataTable();
                sda.Fill(dt);
                cbbkhohang.DataSource = dt;
                cbbkhohang.DisplayMember = "tenkho";
                cbbkhohang.ValueMember = "makho";


                sda = new SqlDataAdapter("Select tenncc,mancc from NhaCungCap where mancc='" + Convert.ToInt32(dtgv_hdn.CurrentRow.Cells["mancc"].Value) + "'", scon);
                //LUY Y WHERE PHAI CO DAU NHAY DON '
                dt = new DataTable();
                sda.Fill(dt);
                cbbkhohang.DataSource = dt;
                cbbkhohang.DisplayMember = "tenncc";
                cbbkhohang.ValueMember = "mancc";


                txttonggiatri.Text = Convert.ToString(dtgv_hdn.CurrentRow.Cells["tonggiatri"].Value);


                btnxoa.Enabled = true;
                btnsua.Enabled = true;

            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            
            string s = string.Format("tenhdn like '%{0}%'", txttimkiem.Text);
            ds.Tables["NewHoaDonNhap"].DefaultView.RowFilter = s;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hóa Đơn Nhập này sẽ bị xóa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                     == DialogResult.OK)
            {
                //khoi tao command va truyen vao ten thu tuc
                SqlCommand sc = new SqlCommand("xoahoadonnhap", scon);

                //khai bao kieu thuc thi la thuc thi thu tuc
                sc.CommandType = CommandType.StoredProcedure;

                //khai bao parameter va truyen tham so cho thu tuc
                SqlParameter sp = new SqlParameter("@mahdn", Convert.ToInt32(txtmahdn.Text));

                sc.Parameters.Add(sp);      //co bao nhieu tham so thi new roi add tung y lan

                sc.ExecuteNonQuery();

                LoadData();

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnluu_edit.Location = new Point(btnluu_add.Location.X, btnluu_add.Location.Y);

            btnluu_edit.Visible = true;
            btnluu_add.Visible = false;
        }

        private void btnluu_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                suahoadonnhap();
                LoadData();
            }



        }

        public void suahoadonnhap()
        {
            SqlCommand sc = new SqlCommand("suahoadonnhap", scon);

            //khai bao kieu thuc thi la thuc thi thu tuc
            sc.CommandType = CommandType.StoredProcedure;

            //khai bao parameter va truyen tham so cho thu tuc

            SqlParameter sp = new SqlParameter("@mahdn", Convert.ToInt32(txtmahdn.Text));
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@tennv", txttenhdn.Text);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@ngaynhap", Convert.ToDateTime(ngaynhap.Text));
            sc.Parameters.Add(sp);

        

            sp = new SqlParameter("@manv", cbbnvlap.SelectedValue);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@makho", cbbkhohang.SelectedValue);
            sc.Parameters.Add(sp);



            sp = new SqlParameter("@mancc", cbbnhacc.SelectedValue);
            sc.Parameters.Add(sp);


            //thuc thi
            sc.ExecuteNonQuery();
        }
    }
}
