using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_MNM
{
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
        }

        private void MAINFORM_Load(object sender, EventArgs e)
        {

        }

        private void TT_TT_Click(object sender, EventArgs e)
        {
        
                INFORMATION frm = new INFORMATION();
                frm.ShowDialog();
            
        }
    }
}
