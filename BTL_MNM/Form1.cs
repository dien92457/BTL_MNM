using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_MNM
{
    public partial class ĐN : Form
    {
        public ĐN()
        {
            InitializeComponent();
            AcceptButton = BTN_DN;
            CancelButton = BTN_DX;
        }

        private void BTN_DN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXT_TEN.Text) && !string.IsNullOrEmpty(TXT_MK.Text))
            {
                if (TXT_TEN.Text == "ADMIN" && TXT_MK.Text == "1234")
                {
                    this.Hide();
                    MAINFORM frm = new MAINFORM();
                    frm.Show();
                }
                else
                {
                    
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu!");
            }
        }

        private void BTN_DX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

    }
}
