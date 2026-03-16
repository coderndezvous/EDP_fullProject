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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        string[,] userCredentials =
        {
            { "admin", "cashier" },
            { "admin", "password" },
            { "Aeron Alingasa", "Marc Brian Papellero" },
            { "Admin Department", "Staff Department" },
        };

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username.", "Username Required!");
                tbUsername.Focus();
            }
            else if(tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password.", "Password Required!");
                tbPassword.Focus();
            }
            else
            {
                for (int x = 0; x < userCredentials.Length; x++)
                {
                    if (userCredentials[0,x] == tbUsername.Text)
                    {
                        if (userCredentials[1,x] == tbPassword.Text)
                        {
                            MessageBox.Show("Welcome " + userCredentials[2, x] + " from " + userCredentials[3,x]);
                            frmHome frm = new frmHome();
                            this.Hide();
                            frm.Show();
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                        break;
                    }
                }
            }
        }
    }
}
