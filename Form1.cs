namespace Gym_Membership_System_wDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.Show();
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lblRegisteredMembers.Text = MembersInfo.indexCounter.ToString();
                lblTotalMembers.Text = MembersInfo.indexCounter.ToString();

                int activeMembers = 0;
                for (int x = 0; x < MembersInfo.indexCounter; x++)
                {
                    if (DateTime.Now <= MembersInfo.endDate[x])
                    {
                        activeMembers++;
                    }

                }

                double revenue = 0;

                for (int i = 0; i < MembersInfo.indexCounter; i++)
                {
                    revenue += MembersInfo.price[i];
                }

                int pendingMembers = 0;
                for (int x = 0; x < MembersInfo.indexCounter; x++)
                {
                    if (MembersInfo.endDate[x] == DateTime.MinValue)
                    {
                        pendingMembers++;
                    }
                }

                int dailyCount = 0;

                for (int x = 0; x <MembersInfo.indexCounter; x++)
                {

                    if (MembersInfo.subs[x] == "Daily")
                    {
                        dailyCount++;
                    }
                }


                int weeklyCount = 0;

                for (int x = 0; x < MembersInfo.indexCounter; x++)
                {

                    if (MembersInfo.subs[x] == "Weekly")
                    {
                        weeklyCount++;
                    }
                }

                int monthlyCount = 0;

                for (int x = 0; x < MembersInfo.indexCounter; x++)
                {

                    if (MembersInfo.subs[x] == "Monthly")
                    {
                        monthlyCount++;
                    }
                }

                int yearlyCount = 0;

                for (int x = 0; x < MembersInfo.indexCounter; x++)
                {

                    if (MembersInfo.subs[x] == "Yearly")
                    {
                        yearlyCount++;
                    }
                }

                lblDailyMembers.Text = dailyCount.ToString();
                lblWeeklyMembers.Text = weeklyCount.ToString();
                lblMonthlyMembers.Text = monthlyCount.ToString();
                lblYearlyMembers.Text = yearlyCount.ToString();
                lblPendingPayments.Text = pendingMembers.ToString();
                lblRevenue.Text = "₱" + revenue.ToString("N2");
                lblRevenue.Text = "₱" + MembersInfo.totalRevenue.ToString("N2");
                lblActiveMembers.Text = activeMembers.ToString();


            } catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
