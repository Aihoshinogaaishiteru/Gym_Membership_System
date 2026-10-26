using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Membership_System_wDesign
{
    public partial class Register : Form
    {
        public Register()
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            dashboard.Show();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void LoadGrid()
        {
            dgvDisplay.Rows.Clear();

            for (int i = 0; i < MembersInfo.indexCounter; i++)
            {
                string fullname = MembersInfo.fName[i] + " " +
                                  MembersInfo.mName[i] + " " +
                                  MembersInfo.lName[i];

                dgvDisplay.Rows.Add(
                    MembersInfo.id[i],
                    fullname,
                    MembersInfo.birthDate[i].ToShortDateString(),
                    MembersInfo.gender[i],
                    MembersInfo.address[i],
                    MembersInfo.emailAdress[i],
                    MembersInfo.contactNum[i],
                    MembersInfo.height[i],
                    MembersInfo.weight[i],
                    MembersInfo.subs[i]
                );

                // idnum-Fullname-DateTimePicker - Gender - Address - Email Address - Contact Num - Height - Weight - Subs

            }
        }
        private void Register_Load(object sender, EventArgs e)
        {
            // Register Members
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            if (MembersInfo.indexCounter > 0)
                MembersInfo.idCounter = MembersInfo.id[MembersInfo.indexCounter - 1] + 1;
            else
                MembersInfo.idCounter = 501;

            lblIdNum.Text = MembersInfo.idCounter.ToString();
            dgvDisplay.Columns.Clear();
            dgvDisplay.Rows.Clear();
            dgvDisplay.ColumnCount = 10;
            string[] columnNames = new string[] {"Id Number", "Fullname", "BirthDate", "Gender", "Address","Email Address","Contact Num",
                "Heigth(cm)", "Weigth(kg)", "Subscription"};

            for (int x = 0; x < columnNames.Length; x++)
            {
                dgvDisplay.Columns[x].Name = columnNames[x];

            }
            LoadGrid();


        }



        private void cmbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbSubscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char controls = e.KeyChar;
            if (!char.IsDigit(controls) && controls != 8 && controls != 46)
            {
                e.Handled = true;
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char controls = e.KeyChar;
            if (!char.IsDigit(controls) && controls != 8 && controls != 46)
            {
                e.Handled = true;
            }
        }

        private void txtContactNum_TextChanged(object sender, EventArgs e)
        {
            txtcontactNum.MaxLength = 11;
        }

        private void txtContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char controls = e.KeyChar;
            if (!char.IsDigit(controls) && controls != 8 && controls != 46)
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update
            try
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
                    MessageBox.Show("Record not found");
                    return;
                }

                MembersInfo.fName[index] = txtfirstName.Text;
                MembersInfo.mName[index] = txtmiddleName.Text;
                MembersInfo.lName[index] = txtlastName.Text;
                MembersInfo.birthDate[index] = dtpbirthDate.Value;
                MembersInfo.gender[index] = cmbgender.Text;
                MembersInfo.address[index] = txtaddress.Text;
                MembersInfo.emailAdress[index] = txtemailAddress.Text;
                MembersInfo.contactNum[index] = txtcontactNum.Text;
                MembersInfo.height[index] = double.Parse(txtheight.Text);
                MembersInfo.weight[index] = double.Parse(txtweight.Text);
                MembersInfo.subs[index] = cmbsubscription.Text;


                MessageBox.Show("Credentials Updated");

                dgvDisplay.Rows.Clear();
                for (int i = 0; i < MembersInfo.indexCounter; i++)
                {
                    string fullname = MembersInfo.fName[i] + " " + MembersInfo.mName[i] + " " + MembersInfo.lName[i];
                    dgvDisplay.Rows.Add(
                         MembersInfo.id[i],
                        fullname,
                        MembersInfo.birthDate[i].ToShortDateString(),
                        MembersInfo.gender[i],
                        MembersInfo.address[i],
                        MembersInfo.emailAdress[i],
                        MembersInfo.contactNum[i],
                        MembersInfo.height[i],
                        MembersInfo.weight[i],
                        MembersInfo.subs[i]);

                }

                txtfirstName.Clear();
                txtmiddleName.Clear();
                txtlastName.Clear();
                txtaddress.Clear();
                cmbgender.SelectedIndex = -1;
                txtcontactNum.Clear();
                txtweight.Clear();
                txtemailAddress.Clear();
                txtheight.Clear();
                cmbsubscription.SelectedIndex = -1;


                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnSave.Visible = true;

            }



            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                double heigth = double.Parse(txtheight.Text);
                double weigth = double.Parse(txtweight.Text);
                if (txtfirstName.Text == "")
                {
                    MessageBox.Show("Invalid Credentials", "First Name");
                    return;
                }
                else if (txtmiddleName.Text == "")
                {
                    MessageBox.Show("Invalid Credentials", "Middle Name");
                    return;
                }
                if (txtmiddleName.Text == "")
                {
                    MessageBox.Show("Invalid Credentials", "Last Name");
                    return;
                }
                else if (cmbgender.Text == "")
                {
                    MessageBox.Show("Invalid Credentials", "Gender");
                    return;

                }
                else if (txtaddress.Text == "")
                {
                    MessageBox.Show("Invalid Credentials", "Address");
                    return;

                }
                else if (txtemailAddress.Text == "")
                {
                    MessageBox.Show("Invalid Credentials", "Email Adress");
                    return;
                }
                else if (cmbsubscription.Text == "")
                {
                    MessageBox.Show("Invalid Credentials", "Subscription");
                    return;

                }

                if ((heigth < 100 || heigth > 200 || weigth > 190 || weigth < 30))
                {
                    MessageBox.Show("Invalid Credentials", "Weight & Height");
                    return;
                }

                else
                {

                    MembersInfo.id[MembersInfo.indexCounter] = MembersInfo.idCounter;
                    MembersInfo.fName[MembersInfo.indexCounter] = txtfirstName.Text;
                    MembersInfo.mName[MembersInfo.indexCounter] = txtmiddleName.Text;
                    MembersInfo.lName[MembersInfo.indexCounter] = txtlastName.Text;
                    MembersInfo.birthDate[MembersInfo.indexCounter] = dtpbirthDate.Value;
                    MembersInfo.emailAdress[MembersInfo.indexCounter] = txtemailAddress.Text;
                    MembersInfo.contactNum[MembersInfo.indexCounter] = txtcontactNum.Text;
                    MembersInfo.gender[MembersInfo.indexCounter] = cmbgender.Text;
                    MembersInfo.address[MembersInfo.indexCounter] = txtaddress.Text;
                    MembersInfo.height[MembersInfo.indexCounter] = double.Parse(txtheight.Text);
                    MembersInfo.weight[MembersInfo.indexCounter] = double.Parse(txtweight.Text);
                    MembersInfo.subs[MembersInfo.indexCounter] = cmbsubscription.Text;


                }
                string fullname = MembersInfo.fName[MembersInfo.indexCounter] + " "
                + MembersInfo.mName[MembersInfo.indexCounter] + " " +
                    MembersInfo.lName[MembersInfo.indexCounter];




                dgvDisplay.Rows.Add(MembersInfo.idCounter, fullname, dtpbirthDate.Value.ToShortDateString(),
                    cmbgender.Text, txtaddress.Text, txtemailAddress.Text,
                    txtcontactNum.Text, txtheight.Text, txtweight.Text, cmbsubscription.Text);

                //    "Id Number", "Fullname", "Age", "Gender", "Address","Contact Num",
                //"Heigth", "Weigth", "Subscription"}
                //;

                MembersInfo.indexCounter++;
                MembersInfo.idCounter++;

                lblIdNum.Text = MembersInfo.idCounter.ToString();


                txtfirstName.Clear();
                txtmiddleName.Clear();
                txtlastName.Clear();
                cmbgender.SelectedIndex = -1;
                txtaddress.Clear();
                txtheight.Clear();
                txtemailAddress.Clear();
                txtweight.Clear();
                txtcontactNum.Clear();
                cmbsubscription.SelectedIndex = -1;

                DialogResult result = MessageBox.Show(
                    "Do you want to pay now?\n",
                    "Payment",
                    MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    Payment();
                }
                else
                {
                    MessageBox.Show("Recorded Successfully", "Pending Payment");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Valid Credentials for Age, Contact Num, Heigth and Weigth.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            //Payup payup = new Payup();
            //payup.Show();
            //this.Hide();
        }
        public void Payment()
        {
            Payup edit = new Payup();

            int index = MembersInfo.indexCounter - 1;
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
            edit.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete
            try
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
                    MessageBox.Show("Record not found");
                    return;
                }
                DialogResult result = MessageBox.Show(
                    "Do you want to Delete this Member?", "Delete",
                    MessageBoxButtons.YesNo
                    );
                if (result == DialogResult.No)
                {
                    return;
                }
                for (int x = index; x < MembersInfo.indexCounter - 1; x++)
                {
                    MembersInfo.id[x] = MembersInfo.id[x + 1];
                    MembersInfo.fName[x] = MembersInfo.fName[x + 1];
                    MembersInfo.mName[x] = MembersInfo.mName[x + 1];
                    MembersInfo.lName[x] = MembersInfo.lName[x + 1];
                    MembersInfo.birthDate[x] = MembersInfo.birthDate[x + 1];
                    MembersInfo.gender[x] = MembersInfo.gender[x + 1];
                    MembersInfo.address[x] = MembersInfo.address[x + 1];
                    MembersInfo.contactNum[x] = MembersInfo.contactNum[x + 1];
                    MembersInfo.weight[x] = MembersInfo.weight[x + 1];
                    MembersInfo.height[x] = MembersInfo.height[x + 1];
                    MembersInfo.subs[x] = MembersInfo.subs[x + 1];

                }
                MembersInfo.indexCounter--;
                MessageBox.Show("Record Deleted");

                dgvDisplay.Rows.Clear();
                for (int i = 0; i < MembersInfo.indexCounter; i++)
                {
                    string fullname = MembersInfo.fName[i] + " " + MembersInfo.mName[i] + " " + MembersInfo.lName[i];
                    dgvDisplay.Rows.Add(
                         MembersInfo.id[i],
                        fullname,
                        MembersInfo.birthDate[i].ToShortDateString(),
                        MembersInfo.gender[i],
                        MembersInfo.address[i],
                        MembersInfo.contactNum[i],
                        MembersInfo.height[i],
                        MembersInfo.weight[i],
                        MembersInfo.subs[i]

                   );
                }

                txtfirstName.Clear();
                txtmiddleName.Clear();
                txtlastName.Clear();
                txtaddress.Clear();
                cmbgender.SelectedIndex = -1;
                txtcontactNum.Clear();
                txtweight.Clear();
                txtemailAddress.Clear();
                txtheight.Clear();
                cmbsubscription.SelectedIndex = -1;


                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnSave.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (e.RowIndex >= 0)
                {

                    MembersInfo.cellClickIdHolder =
           Convert.ToInt32(dgvDisplay.Rows[e.RowIndex].Cells[0].Value);
                    DataGridViewRow row = dgvDisplay.Rows[e.RowIndex];

                    lblIdNum.Text = row.Cells[0].Value?.ToString();

                    string fullName = row.Cells[1].Value?.ToString();
                    string[] nameParts = fullName.Split(' ');

                    txtfirstName.Text = nameParts.Length > 0 ? nameParts[0] : "";
                    txtmiddleName.Text = nameParts.Length > 1 ? nameParts[1] : "";
                    txtlastName.Text = nameParts.Length > 2 ? nameParts[2] : "";

                    DateTime birthDate;
                    if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out birthDate))
                    {
                        dtpbirthDate.Value = birthDate;
                    }
                    else
                    {
                        dtpbirthDate.Value = DateTime.Today;

                    }

                    cmbgender.Text = row.Cells[3].Value?.ToString();
                    txtaddress.Text = row.Cells[4].Value?.ToString();
                    txtemailAddress.Text = row.Cells[5].Value?.ToString();
                    txtcontactNum.Text = row.Cells[6].Value?.ToString();
                    txtheight.Text = row.Cells[7].Value?.ToString();
                    txtweight.Text = row.Cells[8].Value?.ToString();
                    cmbsubscription.Text = row.Cells[9].Value?.ToString();
                    // idnum-Fullname-DateTimePicker - Gender - Address - Email Address - Contact Num - Height - Weight - Subs
                }

                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void cmbgender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                cmbgender.DroppedDown = true;
            }
        }

        private void cmbsubscription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                cmbsubscription.DroppedDown = true;
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {

            string input = txtNameSearch.Text;

            dgvDisplay.Rows.Clear();


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

                    dgvDisplay.Rows.Add(
                        MembersInfo.id[i],
                        fullname,
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
                    );
                }
            }
        }

        private void btnIdSearch_Click(object sender, EventArgs e)
        {

            try
            {
                int idSearch = int.Parse(txtIdSearch.Text);
                bool found = false;

                dgvDisplay.Rows.Clear();
                for (int x = 0; x < MembersInfo.indexCounter; x++)
                {


                    if (idSearch == MembersInfo.id[x])
                    {
                        string fullname = MembersInfo.fName[x] + " " + MembersInfo.mName[x] + " " + MembersInfo.lName[x];
                        dgvDisplay.Rows.Add(MembersInfo.id[x], fullname, MembersInfo.birthDate[x].ToShortDateString(),
                            MembersInfo.gender[x], MembersInfo.address[x], MembersInfo.emailAdress[x], MembersInfo.contactNum[x],
                            MembersInfo.height[x], MembersInfo.weight[x], MembersInfo.subs[x]);
                        found = true;
                        txtIdSearch.Clear();

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
            dgvDisplay.Rows.Clear();
            txtIdSearch.Clear();
            for (int i = 0; i < MembersInfo.indexCounter; i++)
            {
                string fullname = MembersInfo.fName[i] + " " +
                          MembersInfo.mName[i] + " " +
                          MembersInfo.lName[i];

                dgvDisplay.Rows.Add(
                    MembersInfo.id[i],
                    fullname,
                    MembersInfo.birthDate[i].ToShortDateString(),
                    MembersInfo.gender[i],
                    MembersInfo.address[i],
                    MembersInfo.emailAdress[i],
                    MembersInfo.contactNum[i],
                    MembersInfo.height[i],
                    MembersInfo.weight[i],
                    MembersInfo.subs[i]);
            }//Back / Reset Search Button
            dgvDisplay.Rows.Clear();
            txtIdSearch.Clear();
            for (int i = 0; i < MembersInfo.indexCounter; i++)
            {
                string fullname = MembersInfo.fName[i] + " " +
                          MembersInfo.mName[i] + " " +
                          MembersInfo.lName[i];

                dgvDisplay.Rows.Add(
                    MembersInfo.id[i],
                    fullname,
                    MembersInfo.birthDate[i].ToShortDateString(),
                    MembersInfo.gender[i],
                    MembersInfo.address[i],
                    MembersInfo.emailAdress[i],
                    MembersInfo.contactNum[i],
                    MembersInfo.height[i],
                    MembersInfo.weight[i],
                    MembersInfo.subs[i]);
            }

            btnBack.Visible = false;
        }

        private void dgvDisplay_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

