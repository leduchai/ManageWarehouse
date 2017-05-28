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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication_QuanLyNhapHang
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection sconn;

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
            sconn = new SqlConnection(@"server=DESKTOP-RJ3K5CJ; database = QuanLyNhapHang; trusted_connection=true");
            sconn.Open();


            txttaikhoan.ForeColor = System.Drawing.SystemColors.ControlDark;
            txtmatkhau.ForeColor = System.Drawing.SystemColors.ControlDark;
            txttaikhoan.Text = "Tên Đăng Nhập...";
            txtmatkhau.Text = "Mật khẩu...";

            errorProvider1.Clear(); //boi vi luc load len minh thay doi text cua no.co dau cach
            errorProvider2.Clear();
        }

    
        private void txttaikhoan_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.ForeColor == System.Drawing.SystemColors.ControlDark)
                  txttaikhoan.Text = "";
            txttaikhoan.ForeColor = System.Drawing.SystemColors.WindowText;
            lblthongbao.Text = "";
        }

        private void txtmatkhau_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.ForeColor == System.Drawing.SystemColors.ControlDark)
                 txtmatkhau.Text = "";
            txtmatkhau.ForeColor = System.Drawing.SystemColors.WindowText;
            lblthongbao.Text = "";
        }

      //  private int kiemtradangnhap()
        //{
            //SqlDataAdapter sda = new SqlDataAdapter("select * from TaiKhoanLogin where taikhoan= '" + txttaikhoan.Text + "' and matkhau= '"+txtmatkhau.Text+"'  ", sconn);
            //DataTable dt = new DataTable();

            //sda.Fill(dt);
            //cbbtrunggian.DataSource = dt;
            //cbbtrunggian.DisplayMember = "taikhoan";
            //cbbtrunggian.ValueMember = "matkhau";

            //OI ME OI:..loi sai la trong dau ' ' cua dieu kien where m viet them dau cach nhin cho thoang!!!dm
            //phai cong nhan cho nay minh thong minh..cho no visible len de lay gia tri text r lai cho an di ngay lam nguoi dung ko he nhin thay
            //cbbtrunggian.Visible = true;

            //if (cbbtrunggian.Text == "")
            //{
            //    cbbtrunggian.ResetText();
            //    cbbtrunggian.Visible = false;
            //    return 0;
            //}
            //else
            //{
            //    cbbtrunggian.ResetText();
            //    cbbtrunggian.Visible = false;
            //    return 1;
            //}

            //????TAI SAO KIEM TRA BANG CACH NAY LAI KO DC?????
            //SqlCommand scom = new SqlCommand("kiemtrataikhoan", sconn);
            //scom.CommandType = CommandType.StoredProcedure;

            //SqlParameter sp = new SqlParameter("@tk", txttaikhoan.Text);
            //scom.Parameters.Add(sp);
            //sp = new SqlParameter("@mk", txtmatkhau.Text);
            //scom.Parameters.Add(sp);

            //if (scom.ExecuteNonQuery() > 0)
            //{
            //    this.Close();
            //    FormStart fs = new FormStart();
            //    fs.giavoloadprocess();

            //}
            //else
            //{
            //    
            //    label1.Text = "Usernam or Password is not correct. Please check again!";
            //    label1.Visible = true;

            //}

//        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

           //// if(kiemtradangnhap()==1)
           // //{
           //     //this.Close();
           //     // Form_Start fs = new Form_Start();
           //   //  fs.loadformafterlogin();
                
                
           // //}

           // else
           // {
          
           //     lblthongbao.Text = "Usernam or Password is not correct. Please check again!";
           //     lblthongbao.Visible = true;
           // }


        }

        public bool IsUsername(string s)      //kiem tra 1 chuoi co phai kieu so ko
        {
            Regex rg = new Regex(@"^[A-Za-z0-9_\.]{6,35}$");
            return rg.IsMatch(s);
        }

        public bool IsPassword(string s)      //kiem tra 1 chuoi co phai kieu so ko
        {
            Regex rg = new Regex(@"^([a-zA-Z]){1,}([A-Za-z0-9_\.]){7,24}$");
            return rg.IsMatch(s);
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {
            if (IsUsername(txttaikhoan.Text) == false && txttaikhoan.Text!="" && txttaikhoan.TextLength>=6)  //boi vi trong luc nhap minh co the backspace het hoac la luc moi click vao n se xoa het
                                                                                                             //boi vi dang trong qua trinh nhap thi no <6 thi bao loi deo gi
                errorProvider1.SetError(txttaikhoan, "tên đăng nhập có độ dài: 6-35, có thể chứa kí tự '_' hoặc '.'");
            else
                errorProvider1.Clear();
        }

        private void txttaikhoan_Leave(object sender, EventArgs e)
        {
            if (IsUsername(txttaikhoan.Text) == false)      //can them su kien leave boi vi o tren minh da sd txttaikhoan.text!=""
                errorProvider1.SetError(txttaikhoan, "tên đăng nhập có độ dài: 6-35, có thể chứa kí tự '_' hoặc '.'");
            else
                errorProvider1.Clear();
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            if (IsPassword(txtmatkhau.Text) == false && txtmatkhau.Text != "" &&txtmatkhau.TextLength>=8)  //boi vi trong luc nhap minh co the backspace het hoac la luc moi click vao n se xoa het
                errorProvider2.SetError(txtmatkhau, "mật khẩu có độ dài: 8-25, có thể chứa kí tự '.', kí tự đầu tiên bắt buộc là chữ cái");
            else
                errorProvider2.Clear();
        }

        private void txtmatkhau_Leave(object sender, EventArgs e)
        {

            if (IsPassword(txtmatkhau.Text) == false)      //can them su kien leave boi vi o tren minh da sd txttaikhoan.text!=""
                errorProvider2.SetError(txtmatkhau, "mật khẩu có độ dài: 8-25, có thể chứa kí tự '.', kí tự đầu tiên bắt buộc là chữ cái");
            else
                errorProvider2.Clear();
        }
    }
}
