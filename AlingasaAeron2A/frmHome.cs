using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlingasaAeron2A
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }

        private void btnStoreStatus_Click(object sender, EventArgs e)
        {
            frmStoreStatus frm = new frmStoreStatus();
            frm.ShowDialog();
        }

        private void btnPricebook_Click(object sender, EventArgs e)
        {
            frmPricebook frm = new frmPricebook();
            frm.ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            frmVendors frm = new frmVendors();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }

        private void btnTimeClock_Click(object sender, EventArgs e)
        {
            frmTimeClock frm = new frmTimeClock();
            frm.ShowDialog();
        }
    }
}
