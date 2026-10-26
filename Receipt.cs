using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace Gym_Membership_System_wDesign
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }
        PrintDocument printDoc = new PrintDocument();
        Bitmap panelImage;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }



        private void lblsubscription_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintReceiptPanel;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            // show print dialog — if user clicks OK it prints
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
                MessageBox.Show("Thank you\n" +
                    "Come Back Again");
            }
            //Members 

        }
        /*   PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintReceiptPanel;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            // show print dialog — if user clicks OK it prints
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
                MessageBox.Show("Thank you\n" +
                    "Come Back Again");
            } */

        private void PrintReceiptPanel(object sender, PrintPageEventArgs e)
        {
            // capture the panel as an image
            Bitmap bitmap = new Bitmap(pnlreceipt.Width, pnlreceipt.Height);
            pnlreceipt.DrawToBitmap(bitmap, new Rectangle(0, 0, pnlreceipt.Width, pnlreceipt.Height));

            // center it on the page
            float x = (e.PageBounds.Width - bitmap.Width) / 2;
            float y = (e.PageBounds.Height - bitmap.Height) / 2;

            e.Graphics.DrawImage(bitmap, x, y);
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintReceiptPanel;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            // show print dialog — if user clicks OK it prints
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
                MessageBox.Show("Thank you\n" +
                    "Come Back Again");
            }
            Members members = new Members();
            members.Show();
            this.Hide();
        }
    }

}
