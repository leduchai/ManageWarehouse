using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_QuanLyNhapHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = label1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Add(tabPage2);
          
            //this.tabControl1.SelectedIndex = 2;
            //NhanVien nv = new NhanVien();
            //tabPage2.Controls.Add(nv);
            //tabControl1.SelectedIndex = 1;
            // textBox1.Visible = true;


        }
    }
}
