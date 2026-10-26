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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Records record = new Records();
            record.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Subscriptions subs = new Subscriptions();
            subs.Show();
            this.Hide();

        }

        private void Members_Load(object sender, EventArgs e)
        {
            flpflowMembers.Controls.Clear();

            flpflowMembers.FlowDirection = FlowDirection.LeftToRight;
            flpflowMembers.WrapContents = true;
            flpflowMembers.AutoScroll = true;
            flpflowMembers.Padding = new Padding(20);
            flpflowMembers.BackColor = Color.FromArgb(10, 10, 35);

            flpflowMembers.Dock = DockStyle.Fill;

            for (int i = 0; i < MembersInfo.indexCounter; i++)
            {
                if (MembersInfo.startDate[i] == DateTime.MinValue) continue;

                string status = "";
                if (DateTime.Now <= MembersInfo.endDate[i])
                    status = "Active";
                else
                    status = "Expired";

                string fullName = MembersInfo.fName[i] + " " + MembersInfo.lName[i];

                Panel card = new Panel();
                card.Width = 280;
                card.Height = 190;
                card.Margin = new Padding(15);
                card.BackColor = Color.FromArgb(20, 20, 60);
                card.BorderStyle = BorderStyle.None;

                Panel topBar = new Panel();
                topBar.Width = 280;
                topBar.Height = 6;
                topBar.Location = new Point(0, 0);
                topBar.BackColor = status == "Active"
                    ? Color.FromArgb(39, 174, 96)
                    : Color.FromArgb(192, 57, 43);

                Label lblStatus = new Label();
                lblStatus.Text = status;
                lblStatus.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                lblStatus.ForeColor = Color.White;
                lblStatus.BackColor = status == "Active"
                    ? Color.FromArgb(39, 174, 96)
                    : Color.FromArgb(192, 57, 43);
                lblStatus.AutoSize = true;
                lblStatus.Padding = new Padding(6, 2, 6, 2);
                lblStatus.Location = new Point(185, 14);

                Label lblId = new Label();
                lblId.Text = "ID: " + MembersInfo.id[i].ToString();
                lblId.Font = new Font("Segoe UI", 8);
                lblId.ForeColor = Color.FromArgb(150, 150, 180);
                lblId.AutoSize = true;
                lblId.Location = new Point(15, 15);

                Label lblName = new Label();
                lblName.Text = fullName;
                lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblName.ForeColor = Color.White;
                lblName.AutoSize = true;
                lblName.Location = new Point(15, 38);
                
                Label lblMemberName = new Label();
                lblMemberName.Text = "👤 " + MembersInfo.memberName[i];
                lblMemberName.Font = new Font("Segoe UI", 9);
                lblMemberName.ForeColor = Color.FromArgb(180, 180, 210);
                lblMemberName.AutoSize = true;
                lblMemberName.Location = new Point(15, 68);

                Label lblSubs = new Label();
                lblSubs.Text = "📋 " + MembersInfo.subs[i];
                lblSubs.Font = new Font("Segoe UI", 9);
                lblSubs.ForeColor = Color.FromArgb(180, 180, 210);
                lblSubs.AutoSize = true;
                lblSubs.Location = new Point(15, 92);

                Panel divider = new Panel();
                divider.Width = 250;
                divider.Height = 1;
                divider.Location = new Point(15, 122);
                divider.BackColor = Color.FromArgb(60, 60, 90);

                Label lblExpiry = new Label();
                lblExpiry.Text = "⏰ " + MembersInfo.endDate[i].ToShortDateString();
                lblExpiry.Font = new Font("Segoe UI", 8);
                lblExpiry.ForeColor = status == "Active"
                    ? Color.FromArgb(39, 174, 96)
                    : Color.FromArgb(192, 57, 43);
                lblExpiry.AutoSize = true;
                lblExpiry.Location = new Point(15, 133);

                Label lblPrice = new Label();
                lblPrice.Text = "₱" + MembersInfo.price[i].ToString("N0");
                lblPrice.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblPrice.ForeColor = Color.FromArgb(255, 165, 0);
                lblPrice.AutoSize = true;
                lblPrice.Location = new Point(200, 130);

                Label lblSubsBadge = new Label();
                lblSubsBadge.Text = MembersInfo.subs[i].ToUpper();
                lblSubsBadge.Font = new Font("Segoe UI", 7, FontStyle.Bold);
                lblSubsBadge.ForeColor = Color.FromArgb(255, 165, 0);
                lblSubsBadge.BackColor = Color.FromArgb(60, 40, 0);
                lblSubsBadge.AutoSize = true;
                lblSubsBadge.Padding = new Padding(5, 2, 5, 2);
                lblSubsBadge.Location = new Point(15, 158);

                card.Controls.Add(topBar);
                card.Controls.Add(lblId);
                card.Controls.Add(lblStatus);
                card.Controls.Add(lblName);
                card.Controls.Add(lblMemberName);
                card.Controls.Add(lblSubs);
                card.Controls.Add(divider);
                card.Controls.Add(lblExpiry);
                card.Controls.Add(lblPrice);
                card.Controls.Add(lblSubsBadge);

                card.MouseEnter += (s, ev) =>
                {
                    card.BackColor = Color.FromArgb(30, 30, 80);
                };
                card.MouseLeave += (s, ev) =>
                {
                    card.BackColor = Color.FromArgb(20, 20, 60);
                };

                flpflowMembers.Controls.Add(card);
            }
        }
    }
        }

    