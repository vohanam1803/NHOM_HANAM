using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM_NAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String user = txtUserName.Text;
            String pw = txtpassword.Text;
            if(user == "admin" && pw == "admin")
            {
                MessageBox.Show("Đăng Nhập thành công!!");
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập thất bại!!");
            }
        }
    }
}
