using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Membership_System_wDesign
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void Records_Load(object sender, EventArgs e)
        {

        }

        private void Records_Load_1(object sender, EventArgs e)
        {
            // DGV Records Load Form
            dgvRecords.ColumnCount = 15;
            string[] columnNames = new string[] {"Id Number", "Fullname","Member Name", "Birth Date", "Gender", "Address", "Email Address"
                ,"Contact Num",
                "Heigth(cm)", "Weigth(kg)", "Subscription", "Start Date", "Valid Until", "Price", "Status"};


            for (int x = 0; x < columnNames.Length; x++)
            {
                dgvRecords.Columns[x].Name = columnNames[x];
            }
            for (int y = 0; y < MembersInfo.indexCounter; y++)
            {
                string fullname = MembersInfo.fName[y] + " " + MembersInfo.mName[y] + " "
                + MembersInfo.lName[y];

                string status = "";
                if (MembersInfo.startDate[y] == DateTime.MinValue)
                {
                    status = "Pending";
                }
                else if (DateTime.Now <= MembersInfo.endDate[y])
                {
                    status = "Active";
                }
                else
                {
                    status = "Expired";
                }
                string memberDisplay;
                if (MembersInfo.startDate[y] == DateTime.MinValue)
                {
                    memberDisplay = "N/A";
                }
                else
                {
                    memberDisplay = MembersInfo.memberName[y];
                }

                dgvRecords.Rows.Add(MembersInfo.id[y], fullname, memberDisplay, MembersInfo.birthDate[y].ToShortDateString(), MembersInfo.gender[y],
                    MembersInfo.address[y], MembersInfo.emailAdress[y], MembersInfo.contactNum[y], MembersInfo.height[y], MembersInfo.weight[y], MembersInfo.subs[y], MembersInfo.startDate[y].ToShortDateString(),
                    MembersInfo.endDate[y].ToShortDateString(), MembersInfo.price[y].ToString(), status);
            }
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

        private void button9_Click(object sender, EventArgs e)
        {
            Subscriptions subs = new Subscriptions();
            subs.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.Show();
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

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string input = txtNameSearch.Text;

                dgvRecords.Rows.Clear();


                for (int i = 0; i < MembersInfo.indexCounter; i++)
                {
                    string fullname = (MembersInfo.fName[i] + " " +
                        MembersInfo.mName[i] + " " +
                        MembersInfo.lName[i]).ToLower();

                    if (fullname.Contains(input))
                    {
                        string status = "";
                        if (MembersInfo.endDate[i] <= DateTime.MinValue)
                            status = "No Record";
                        else if (DateTime.Now <= MembersInfo.endDate[i])
                            status = "Active";
                        else
                            status = "Expired";

                        dgvRecords.Rows.Add(
                            MembersInfo.id[i],
                            fullname,
                            MembersInfo.memberName[i],
                            MembersInfo.birthDate[i].ToShortDateString(),
                            MembersInfo.gender[i],
                            MembersInfo.address[i],
                            MembersInfo.emailAdress[i],
                            MembersInfo.contactNum[i],
                            MembersInfo.height[i],
                            MembersInfo.weight[i],
                            MembersInfo.subs[i],
                            MembersInfo.startDate[i].ToShortDateString(),
                            MembersInfo.endDate[i].ToShortDateString(),
                            MembersInfo.price[i],
                            status
                        /* {
                         /*"Id Number", "Fullname","Member Name", "Birth Date", "Gender", "Address", "Email Address"
             ,"Contact Num",
             "Heigth", "Weigth", "Subscription", "Start Date", "Valid Until", "Price", "Status"}
                     ; */
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnIdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int idSearch = int.Parse(txtIdSearch.Text);
                bool found = false;
                for (int x = 0; x < MembersInfo.indexCounter; x++)
                {

                    string status = "";
                    if (MembersInfo.endDate[x] <= DateTime.MinValue)
                        status = "No Record";
                    else if (DateTime.Now <= MembersInfo.endDate[x])
                        status = "Active";
                    else
                        status = "Expired";

                    dgvRecords.Rows.Clear();



                    if (idSearch == MembersInfo.id[x])
                    {
                        string fullname = MembersInfo.fName[x] + " " + MembersInfo.mName[x] + " " + MembersInfo.lName[x];
                        dgvRecords.Rows.Add(MembersInfo.id[x], fullname, MembersInfo.memberName[x], MembersInfo.birthDate[x].ToShortDateString(),
                            MembersInfo.gender[x], MembersInfo.address[x], MembersInfo.emailAdress[x], MembersInfo.contactNum[x],
                            MembersInfo.height[x], MembersInfo.weight[x], MembersInfo.subs[x], MembersInfo.startDate[x], MembersInfo.endDate[x],
                            MembersInfo.price[x], status);
                        found = true;
                        txtIdSearch.Clear();
                        /*
                          MembersInfo.id[i],
                            fullname,
                            MembersInfo.memberName[i],
                            MembersInfo.birthDate[i].ToShortDateString(),
                            MembersInfo.gender[i],
                            MembersInfo.address[i],
                            MembersInfo.emailAdress[i],
                            MembersInfo.contactNum[i],
                            MembersInfo.height[i],
                            MembersInfo.weight[i],
                            MembersInfo.subs[i],
                            MembersInfo.startDate[i].ToShortDateString(),
                            MembersInfo.endDate[i].ToShortDateString(),
                            MembersInfo.price[i],
                            status
                        */

                        break;

                    }


                }
                if (!found)
                {
                    MessageBox.Show("Id not Found");
                }
                btnBack.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input Valid ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back / Reset Search Button
            dgvRecords.Rows.Clear();
            txtIdSearch.Clear();
            for (int i = 0; i < MembersInfo.indexCounter; i++)
            {
                string status = "";
                if (MembersInfo.endDate[i] <= DateTime.MinValue)
                    status = "No Record";
                else if (DateTime.Now <= MembersInfo.endDate[i])
                    status = "Active";
                else
                    status = "Expired";

                string fullname = MembersInfo.fName[i] + " " +
                          MembersInfo.mName[i] + " " +
                          MembersInfo.lName[i];

                dgvRecords.Rows.Add(
                    MembersInfo.id[i],
                    fullname,
                    MembersInfo.memberName[i],
                    MembersInfo.birthDate[i].ToShortDateString(),
                    MembersInfo.gender[i],
                    MembersInfo.address[i],
                    MembersInfo.emailAdress[i],
                    MembersInfo.contactNum[i],
                    MembersInfo.height[i],
                    MembersInfo.weight[i],
                    MembersInfo.subs[i],
                     MembersInfo.startDate[i].ToShortDateString(),
                         MembersInfo.endDate[i].ToShortDateString(),
                         MembersInfo.price[i],
                         status);
                /*
                       MembersInfo.id[i],
                         fullname,
                         MembersInfo.memberName[i],
                         MembersInfo.birthDate[i].ToShortDateString(),
                         MembersInfo.gender[i],
                         MembersInfo.address[i],
                         MembersInfo.emailAdress[i],
                         MembersInfo.contactNum[i],
                         MembersInfo.height[i],
                         MembersInfo.weight[i],
                         MembersInfo.subs[i],
                         MembersInfo.startDate[i].ToShortDateString(),
                         MembersInfo.endDate[i].ToShortDateString(),
                         MembersInfo.price[i],
                         status
                     */
            }//Back / Reset Search Button

            btnBack.Visible = false;
        }

        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            MembersInfo.cellClickIdHolder = Convert.ToInt32(dgvRecords.Rows[e.RowIndex].Cells[0].Value);

            int selectedId = MembersInfo.cellClickIdHolder;
            int index = -1;

            for (int i = 0; i < MembersInfo.indexCounter; i++)
            {
                if (MembersInfo.id[i] == selectedId)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1) return;



            Payup edit = new Payup();
            edit.lblIdNum.Text = MembersInfo.id[index].ToString();
            edit.lblmemberId.Text = MembersInfo.id[index].ToString();
            edit.txtmemberName.Text = MembersInfo.fName[index] + " " +
                                      MembersInfo.mName[index] + " " +
                                      MembersInfo.lName[index];
            edit.cmbsubscription.Text = MembersInfo.subs[index];

            int price =
                MembersInfo.subs[index] == "Daily" ? 50 :
                MembersInfo.subs[index] == "Weekly" ? 300 :
                MembersInfo.subs[index] == "Monthly" ? 1300 :
                MembersInfo.subs[index] == "Yearly" ? 8000 : 0;

            edit.lblprice.Text = price.ToString();

            //  ALREADY REGISTERED — show edit button, hide save
            if (MembersInfo.startDate[index] != DateTime.MinValue)
            {
                DialogResult result = MessageBox.Show(
                    "This member is already registered.\n\n" +
                    "YES = Edit \n" +
                    "NO = Cancel",
                    "Member Already Registered",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No) return;



                edit.txtmemberName.Text = MembersInfo.memberName[index];
                edit.cmbsubscription.Text = MembersInfo.subs[index];
                edit.btnEdit.Visible = true;  // show edit
                edit.btnSave.Visible = false;       // hide save until they click edit
            }
            else
            {
                // NOT YET REGISTERED — show save, hide edit
                edit.btnEdit.Visible = false;
                edit.btnSave.Visible = true;
            }

            edit.Show();
            this.Hide();

        }

        private void txtmemberNameSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
