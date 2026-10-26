using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Numerics;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Membership_System_wDesign
{
    public partial class Payup : Form
    {
        public Payup()
        {
            InitializeComponent();
        }

        private void Payup_Load(object sender, EventArgs e)
        {
            btnEdit.Location = new Point(357, 473);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Records record = new Records();
            record.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = DateTime.Now;
                DateTime endDate = DateTime.Now;
                string subs = cmbsubscription.Text;
                double price = double.Parse(lblprice.Text);
                MembersInfo.totalRevenue += price;
                string memberName = txtmemberName.Text;


                switch (subs)
                {
                    case "Daily":
                        endDate = startDate.AddDays(1);
                        break;
                    case "Weekly":
                        endDate = startDate.AddDays(7);
                        break;
                    case "Monthly":
                        endDate = startDate.AddMonths(1);
                        break;
                    case "Yearly":
                        endDate = startDate.AddYears(1);
                        break;
                }

                double cash = double.Parse(txtcash.Text);

                if (cash < price)
                {
                    MessageBox.Show("Insufficient Funds");
                    return;
                }

                //int index = -1;
                //for (int i = 0; i < MembersInfo.indexCounter; i++)
                //{
                //    if (MembersInfo.id[i] == MembersInfo.cellClickIdHolder)
                //    {
                //        index = i;
                //        break;
                //    }
                //}

                //if (index == -1)
                //{
                //    MessageBox.Show("Member not found");
                //    return;
                //}
                int index = MembersInfo.indexCounter - 1;

                MembersInfo.startDate[index] = startDate;
                MembersInfo.endDate[index] = endDate;
                MembersInfo.price[index] = price;
                MembersInfo.memberName[index] = memberName;

                double change = cash - price;
                MembersInfo.change[index] = change;
                lblchange.Text = change.ToString();


                MessageBox.Show("Transaction Complete");
                this.Hide();
                Receipt receipt = new Receipt();
                receipt.lblmemberId.Text = lblmemberId.Text;
                receipt.lblmemberName.Text = txtmemberName.Text;
                receipt.lblsubscription.Text = cmbsubscription.Text;
                receipt.lblprice.Text = "₱" + lblprice.Text;
                receipt.lblamountPaid.Text = "₱" + txtcash.Text;
                receipt.lblchange.Text = "₱" + lblchange.Text;



                //lblmemberId.Text = lblmemberId.Text;
                //txtmemberName.Text = lblmemberName.Text;
                //cmbsubscription.Text = lblsubscription.Text;
                //lblprice.Text = lblprice.Text;
                //txtcash.Text = receipt.lblamountPaid.Text;
                //lblchange.Text = lblchange.Text;

                //Register register = new Register();
                //register.cmbgender.Text = lblgender.Text;

                receipt.Show();
                //Records record = new Records();
                //record.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid cash amount.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int index = -1;

            for (int i = 0; i < MembersInfo.indexCounter; i++)
            {
                if (MembersInfo.id[i] == MembersInfo.cellClickIdHolder)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                MessageBox.Show("Members not Found");
            }
            // allow editing of member name and subscription
            txtmemberName.ReadOnly = false;
            cmbsubscription.Enabled = true;

            // pre-fill with current data
            txtmemberName.Text = MembersInfo.memberName[index];
            cmbsubscription.Text = MembersInfo.subs[index];

            // update price based on current subscription
            switch (cmbsubscription.Text)
            {
                case "Daily": lblprice.Text = "50"; break;
                case "Weekly": lblprice.Text = "300"; break;
                case "Monthly": lblprice.Text = "1300"; break;
                case "Yearly": lblprice.Text = "8000"; break;
                default: lblprice.Text = "0"; break;
            }

            // show save, hide edit button
            btnSave.Visible = true;
            btnEdit.Visible = false;

            MessageBox.Show("You can now edit the member name and subscription.");
        }

        private void txtcash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cash = double.Parse(txtcash.Text);
                double price = double.Parse(lblprice.Text);


                double change = cash - price;

                lblchange.Text = change.ToString();

                Form1 dashboard = new Form1();



            }
            catch
            {
                lblchange.Text = "Invalid Input";
            }

        }

        private void cmbsubscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbsubscription_SelectedIndexChanged(object sender, EventArgs e)
        {

            string subs = cmbsubscription.Text;

            if (subs == "Daily")
            {
                lblprice.Text = 50.ToString();
            }
            else if (subs == "Weekly")
            {
                lblprice.Text = 300.ToString();
            }
            else if (subs == "Monthly")
            {
                lblprice.Text = 1300.ToString();
            }
            else if (subs == "Yearly")
            {
                lblprice.Text = 8000.ToString();
            }

        }

        private void lblchange_Click(object sender, EventArgs e)
        {

        }

        private void txtcash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char controls = e.KeyChar;
            if (!char.IsDigit(controls) && controls != 8 && controls != 46)
            {
                e.Handled = true;
            }
        }
    }
}
