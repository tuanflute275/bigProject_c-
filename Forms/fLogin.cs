using Project_App.DAO;
using Project_App.DTO;
using Project_App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_App
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = TxbUserName.Text;
            string passsword = txbPassword.Text;
            if(Login(userName, passsword))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableMange tableMange = new fTableMange(loginAccount);
                this.Hide();
                tableMange.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
