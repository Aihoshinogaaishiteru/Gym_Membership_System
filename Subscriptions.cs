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
    public partial class Subscriptions : Form
    {
        public Subscriptions()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Log out",
              "Confirm",
          MessageBoxButtons.YesNo
          );

            if (result == DialogResult.Yes)
            {
                Login_Logout logout = new Login_Logout();
                logout.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            records.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Members member = new Members();
            member.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();

        }

        private void gpbDaily_Enter(object sender, EventArgs e)
        {

        }

        private void pnlDaily_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Register for Daily Membership?",
                "Daily Memberrship",
                MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                Register register = new Register();
                register.cmbsubscription.Text = "Daily";
                register.Show();
                this.Hide();

            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pnlWeekly_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Register for Weekly Membership?",
                "Weekly Memberrship",
                MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                Register register = new Register();
                register.cmbsubscription.Text = "Weekly";
                register.Show();
                this.Hide();

            }
        }

        private void pnlMonthly_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Register for Monthly Membership?",
                "Monthly Memberrship",
                MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                Register register = new Register();
                register.cmbsubscription.Text = "Monthly";
                register.Show();
                this.Hide();

            }
        }

        private void pnlYearly_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Register for Yearly Membership?",
                "Yearly Memberrship",
                MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                Register register = new Register();
                register.cmbsubscription.Text = "Yearly";
                register.Show();
                this.Hide();

            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Register for Weekly Membership?",
               "Weekly Memberrship",
               MessageBoxButtons.YesNo
               );

            if (result == DialogResult.Yes)
            {
                Register register = new Register();
                register.cmbsubscription.Text = "Weekly";
                register.Show();
                this.Hide();

            }
        }

        private void Subscriptions_Load(object sender, EventArgs e)
        {

        }
    }
}
