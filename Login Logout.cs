using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Membership_System_wDesign
{
    public partial class Login_Logout : Form
    {
        public Login_Logout()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnShow.Visible = true;
            btnHide.Visible = false;

        }

        private void Login_Logout_Load(object sender, EventArgs e)
        {
            btnShow.Location = new Point(388, 237);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '*';
            btnShow.Visible = false;
            btnHide.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Login Successfully");
                Form1 dashboard = new Form1();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password \n" +
                    "Wrong Username");
                return;
            }
        }
    }
}
