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
    public partial class NhanVien : UserControl
    {
        SqlDataAdapter sqlda;
        DataSet ds;
        SqlConnection scon;


        public NhanVien()
        {
            InitializeComponent();
        }

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            scon = new SqlConnection(@"server=DESKTOP-RJ3K5CJ; database = ManageWarehouse; trusted_connection=true");
            // co 2 override: 1 cai can tai khoan 1 cai ko

            scon.Open();            //  nen  kiem tra trang thai cua no da mo hay chua truoc khi mo
                                    //  ket noi

            //doc du lieu ra
            string command = "select * from NhanVien";
            sqlda = new SqlDataAdapter(command, scon);   // cau noi


            ds = new DataSet();     //cac bang dc lay ra tu database se duoc luu tren bo nho
                                    //sau do tu dataset ta day ra giao dien nguoi dung
            sqlda.Fill(ds, "NewNhanVien");  //do du lieu tu dataadapter vao dataset
                                             //sau do dat ten bang moi la: NewNhanVien..neu ko co,no se mac dinh ten nhu trong database

            //lay du lieu cua bang NewNhanVien trong dataset gan cho datagidview
            dtgv_nv.DataSource = ds.Tables["NewNhanVien"];

            //sqlda.SelectCommand.CommandText = "select * from NhanVien is Gioitinh is null";
            //sqlda.Fill(ds, "NewNhanVien3");
            //dtgv_nv.DataSource = ds.Tables["NewNhanVien3"];   
            //tuc trong dataset bay gio co 2 bang NewNhanVien3 va NewNhanVien2....    ds.tables[cai nao thi no ra cai y]



            GiaoDienDatagridview();

            //hien thi du lieu tren combobox
            SqlDataAdapter sda = new SqlDataAdapter("Select tenkho,makho from KhoHang", scon);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbbkho.DataSource = dt;
            cbbkho.DisplayMember = "tenkho";
            cbbkho.ValueMember = "makho";


            //hien thi du lieu tren combobox
             sda = new SqlDataAdapter("Select chucvu from ChucVu", scon);
            //LUY Y WHERE PHAI CO DAU NHAY DON '
             dt = new DataTable();
            sda.Fill(dt);
            cbbchucvu.DataSource = dt;
            cbbchucvu.DisplayMember = "chucvu";
            cbbchucvu.ValueMember = "chucvu";



            btnluu_add.Enabled = true;
        }

        public void GiaoDienDatagridview()
        {

            

            dtgv_nv.Columns["tennv"].HeaderText = "Họ Tên";
            dtgv_nv.Columns["tennv"].Width = 160;

            dtgv_nv.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dtgv_nv.Columns["ngaysinh"].Width = 100;

            dtgv_nv.Columns["gioitinh"].HeaderText = "Giới Tính";
            dtgv_nv.Columns["gioitinh"].Width = 80;

            dtgv_nv.Columns["luong"].HeaderText = "Lương";
            dtgv_nv.Columns["luong"].Width = 91;

            dtgv_nv.Columns["chucvu"].HeaderText = "Chức Vụ";
            dtgv_nv.Columns["chucvu"].Width = 84;

            //LÀM SAO ĐỂ HIỆN TÊN KHO
            dtgv_nv.Columns["makho"].HeaderText = "Kho";
            dtgv_nv.Columns["makho"].Width = 84;
            



            dtgv_nv.Columns["manv"].Visible = false;
        }

        public void LoadData()
        {

            string command = "select * from NhanVien";
            sqlda = new SqlDataAdapter(command, scon);   // cau noi


            ds = new DataSet();     //cac bang dc lay ra tu database se duoc luu tren bo nho
                                    //sau do tu dataset ta day ra giao dien nguoi dung
            sqlda.Fill(ds, "NewNhanVien");  //do du lieu tu dataadapter vao dataset
                                            //sau do dat ten bang moi la: NewNhanVien..neu ko co,no se mac dinh ten nhu trong database

            //lay du lieu cua bang NewNhanVien trong dataset gan cho datagidview
            dtgv_nv.DataSource = ds.Tables["NewNhanVien"];

            //sqlda.SelectCommand.CommandText = "select * from NhanVien is Gioitinh is null";
            //sqlda.Fill(ds, "NewNhanVien3");
            //dtgv_nv.DataSource = ds.Tables["NewNhanVien3"];   
            //tuc trong dataset bay gio co 2 bang NewNhanVien3 va NewNhanVien2....    ds.tables[cai nao thi no ra cai y]



            //Thuc ra co the dung DataTable nhung vi ly do TimKiem va FormLoad da su dung DataSet nen ta ko dung no nua
            //SqlDataAdapter sda = new SqlDataAdapter("select * from NhanVien", scon);
            //DataTable dt = new DataTable();

            //sda.Fill(dt);

            //dtgv_nv.DataSource = dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            NhanVien_Load(this, EventArgs.Empty);
        }

        private void dtgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtmanv.Text= Convert.ToString(dtgv_nv.CurrentRow.Cells["manv"].Value);



                txthoten.Text = Convert.ToString(dtgv_nv.CurrentRow.Cells["tennv"].Value);
               
                
                txtluong.Text = Convert.ToString(dtgv_nv.CurrentRow.Cells["luong"].Value);
                
                dtpngaysinh.Text = Convert.ToString(dtgv_nv.CurrentRow.Cells["ngaysinh"].Value);

                cbbchucvu.Text = Convert.ToString(dtgv_nv.CurrentRow.Cells["chucvu"].Value);

                string gioitinh= Convert.ToString(dtgv_nv.CurrentRow.Cells["gioitinh"].Value);
                if(gioitinh=="nam")
                {
                    rabtnnam.Checked = true;
                }
                else
                {
                    rabtnnu.Select();
                }

                cbbchucvu.Text= Convert.ToString(dtgv_nv.CurrentRow.Cells["chucvu"].Value);

                int makho = Convert.ToInt32(dtgv_nv.CurrentRow.Cells["makho"].Value);
                cbbkho.Text = this.layTenKho(makho);

                //hien thi du lieu tren combobox
                //SqlDataAdapter sda = new SqlDataAdapter("Select * from KhoHang where makho = '"
                //    + Convert.ToString(dtgv_nv.CurrentRow.Cells["makho"].Value) + "' ", scon);
                ////LUY Y WHERE PHAI CO DAU NHAY DON '
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //cbbkho.DataSource = dt;
                //cbbkho.DisplayMember = "tenkho";
                //cbbkho.ValueMember = "makho";


                btnxoa.Enabled = true;
                btnsua.Enabled = true;

            }
        }

        public string layTenKho(int makho)
        {
            string s="";
            SqlCommand sc = new SqlCommand("select tenkho from KhoHang where makho='" + makho + "'", scon);

            DbDataReader ddr = sc.ExecuteReader();
            if(ddr.HasRows)
            {
                while(ddr.Read())
                {
                    //vi tri cua cot tenkho trong cau lenh sql o tren
                    int x = ddr.GetOrdinal("tenkho");

                    s = ddr.GetString(x);
                }
                //cai nay no bat phai huy doi tuong...khi ra khoi ham no phai tu huy chu???
                ddr.Dispose();
            }
            
            return s;
        }

       


        public bool IsNumber(string s)      //kiem tra 1 chuoi co phai kieu so ko
        {
            Regex rg = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return rg.IsMatch(s);
        }


        public bool IsNamePerson(string s)      //kiem tra co thuc su phai ho ten cua 1 nguoi ko
        {
            Regex rg = new Regex(@"^[a-zA-Z\sáàãạăặẵắằảâẫậẩấầóòõọôốồỗộéèẽẹẻêếềễệúùũụưứừữựíìĩịđÁÀÃẠẢĂẮẰẴẶẲÂẤẦẪẬẨÓÒÕỌỎÔỐỒỖỘỔÉÈẼẸẺÊẾỀỄỆỂÚÙŨỤỦƯỨỪỮỰỬÍÌĨỊỈĐ]{0,50}$");
            return rg.IsMatch(s);
        }

        private void txtluong_TextChanged(object sender, EventArgs e)
        {
            if (txtluong.Text != "" && IsNumber(txtluong.Text) == false)    // !="" boi vi trong qua trinh nhap co the minh backspace het

                errpro_nv.SetError(txtluong, "định dạnh không đúng!");
            else
                errpro_nv.Clear();
        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {
            if (IsNamePerson(txthoten.Text) == false)
                errpro_nv2.SetError(txthoten, "Value of 'Họ Tên' is not correct!");
            else
                errpro_nv2.Clear();

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
          //  string a = txttimkiem.Text;
            //string b = txttimkiem.Text;
           // string s = string.Format("tennv like '%{0}%' or luong like '%{1}%' or gioitinh like N'%{2}%'", txttimkiem.Text,a,b );
            string s = string.Format("tennv like '%{0}%'", txttimkiem.Text);
            ds.Tables["NewNhanVien"].DefaultView.RowFilter = s;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Nhân viên này sẽ bị xóa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                     == DialogResult.OK)
            {
                //khoi tao command va truyen vao ten thu tuc
                SqlCommand sc = new SqlCommand("xoanhanvien", scon);

                //khai bao kieu thuc thi la thuc thi thu tuc
                sc.CommandType = CommandType.StoredProcedure;

                //khai bao parameter va truyen tham so cho thu tuc
               SqlParameter sp = new SqlParameter("@manv",Convert.ToInt32(txtmanv.Text));

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
    

            txthoten.Enabled = true;
           
            txtluong.Enabled = true;
            cbbchucvu.Enabled = true;
            rabtnnam.Enabled = true;
            rabtnnu.Enabled = true;
            cbbkho.Enabled = true;

            dtpngaysinh.Enabled = true;

        }

        private void btnluu_edit_Click(object sender, EventArgs e)
        {
         
                if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    suanhanvien();
                    LoadData();
                }

            
          
           // btntadd_Click(this, EventArgs.Empty);
        }

        public void suanhanvien()
        {
            SqlCommand sc = new SqlCommand("suanhanvien", scon);

            //khai bao kieu thuc thi la thuc thi thu tuc
            sc.CommandType = CommandType.StoredProcedure;

            //khai bao parameter va truyen tham so cho thu tuc

            SqlParameter sp = new SqlParameter("@manv", Convert.ToInt32(txtmanv.Text));
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@tennv", txthoten.Text);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@ngaysinh", Convert.ToDateTime(dtpngaysinh.Text));
            sc.Parameters.Add(sp);

            string gioitinh;
            

            if (rabtnnam.Checked = true)
                gioitinh = "nam";
            else
                gioitinh = "nữ";

            sp = new SqlParameter("@gioitinh", gioitinh);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@luong", Int32.Parse(txtluong.Text));
            sc.Parameters.Add(sp);



            sp = new SqlParameter("@chucvu", cbbchucvu.Text);
            sc.Parameters.Add(sp);


            
            sp = new SqlParameter("@makho", cbbkho.SelectedValue);
            sc.Parameters.Add(sp);



            //thuc thi
            sc.ExecuteNonQuery();
        }

        private void btnluu_add_Click(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand("themnhanvien", scon);

            //khai bao kieu thuc thi la thuc thi thu tuc
            sc.CommandType = CommandType.StoredProcedure;

            //khai bao parameter va truyen tham so cho thu tuc


            SqlParameter sp = new SqlParameter("@tennv", txthoten.Text);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@ngaysinh", Convert.ToDateTime(dtpngaysinh.Text));
            sc.Parameters.Add(sp);

            string gioitinh;


            if (rabtnnam.Checked == true)
                gioitinh = "nam";
            else
                gioitinh = "nữ";

            sp = new SqlParameter("@gioitinh", gioitinh);
            sc.Parameters.Add(sp);

            sp = new SqlParameter("@luong", Int32.Parse(txtluong.Text));
            sc.Parameters.Add(sp);



            sp = new SqlParameter("@chucvu", cbbchucvu.Text);
            sc.Parameters.Add(sp);



            sp = new SqlParameter("@makho",cbbkho.SelectedValue);
            sc.Parameters.Add(sp);



            //thuc thi
            sc.ExecuteNonQuery();

            LoadData();
        }
    }
}
