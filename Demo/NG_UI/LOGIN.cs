using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;

namespace Demo.NG_UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassWord.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            USER user = BUSUser.Instance.SignIn(txtUserName.Text, txtPassWord.Text);
            if (user is null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BUSUser.Instance.RememberSignIn(txtUserName.Text, txtPassWord.Text, ckRemember.Checked);
            SignIn_Static_User.StaticUser.SignIn_User = user;

            DataSingleton.GetInstance().SetIdUser(user.ID);

            frmMain form = new frmMain();
            this.Hide();
            form.Show();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            USER user = BUSUser.Instance.CheckRememberUser(txtUserName.Text);
            if (!(user is null))
            {
                txtPassWord.Text = user.PASSWORD.Trim();
                ckRemember.Checked = true;
            }
            else {
                txtPassWord.Text = "";
                ckRemember.Checked = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (!(SignIn_Static_User.StaticUser.SignIn_User is null)) {
                USER user = BUSUser.Instance.CheckRememberUser(SignIn_Static_User.StaticUser.SignIn_User.USER_NAME);
                if (!(user is null))
                {
                    txtPassWord.Text = user.PASSWORD.Trim();
                    ckRemember.Checked = true;
                    txtUserName.Text = user.USER_NAME.Trim();
                }
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
