using MySql.Data.MySqlClient;
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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        MyDatabase db = new MyDatabase();
        int selectedUserID = -1;
        int selectedLoginID = -1;
        bool isUpdate = false;


        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            isUpdate = false;
            string query = "SELECT tbluserinformation.userID, tbllogincredentials.LoginID, tbluserinformation.firstname, " +
                "tbluserinformation.middlename, tbluserinformation.lastname, tbluserinformation.emailAddress," +
                " tbluserinformation.homeAddress, tbluserinformation.birthDate, tbllogincredentials.user_username as 'Username'," +
                " tbllogincredentials.user_password as 'Password' FROM tbllogincredentials INNER JOIN tbluserinformation" +
                " ON tbllogincredentials.userID = tbluserinformation.userID;";

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsers.DataSource = db.ExecuteReturnQuery(query);
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isUpdate == false)
            {
                string query = "INSERT INTO tbluserinformation (firstname, middlename, lastname, emailAddress, homeAddress, birthDate)" +
                " VALUES (@fname, @mname, @lname, @email, @hadd, @bDate);" +
                "SET @newUserID = LAST_INSERT_ID();" +
                "INSERT INTO tbllogincredentials (userID, user_username, user_password) VALUES (@newUserID, @username, @password);";

                int affectedRowCount = db.ExecuteNoReturnQuery(query,
                    new MySqlParameter("@fname", tbFirstname.Text),
                    new MySqlParameter("@mname", tbMiddleName.Text),
                    new MySqlParameter("@lname", tbLastname.Text),
                    new MySqlParameter("@email", tbEmailAddress.Text),
                    new MySqlParameter("@hadd", tbHomeAddress.Text),
                    new MySqlParameter("@bDate", dtpBirthDate.Value),
                    new MySqlParameter("@username", tbUsername.Text),
                    new MySqlParameter("@password", tbPassword.Text)
                    );

                if (affectedRowCount > 0)
                {
                    MessageBox.Show("Data Inserted!");
                    frmUsers_Load(null, null);
                }
            }
            else if (isUpdate == true)
            {
                //update process


                isUpdate = false;
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to deactivate this account?", "Account Deactivation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[1].Value);
                    string query = "UPDATE tbllogincredentials SET is_active = 0 where LoginID = @id";

                    int affectedRows = db.ExecuteNoReturnQuery(query,
                        new MySqlParameter("@id", id));
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Account is deactivated!");
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes made to this account?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    isUpdate = true;
                    selectedUserID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
                    selectedLoginID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[1].Value);
                    tbFirstname.Text = dgvUsers.SelectedRows[0].Cells[2].Value.ToString();
                    tbMiddleName.Text = dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
                    tbLastname.Text = dgvUsers.SelectedRows[0].Cells[4].Value.ToString();
                    tbEmailAddress.Text = dgvUsers.SelectedRows[0].Cells[5].Value.ToString();
                    tbHomeAddress.Text = dgvUsers.SelectedRows[0].Cells[6].Value.ToString();
                    dtpBirthDate.Value = Convert.ToDateTime(dgvUsers.SelectedRows[0].Cells[7].Value);
                    tbUsername.Text = dgvUsers.SelectedRows[0].Cells[8].Value.ToString();
                    tbPassword.Text = dgvUsers.SelectedRows[0].Cells[9].Value.ToString();
                }
            }
        }
    }
}

