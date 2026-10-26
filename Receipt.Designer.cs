namespace Gym_Membership_System_wDesign
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            pnlreceipt = new Panel();
            label6 = new Label();
            lblprice = new Label();
            label10 = new Label();
            lblchange = new Label();
            lblamountPaid = new Label();
            lblsubscription = new Label();
            lblmemberName = new Label();
            lblmemberId = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnprint = new Button();
            pnlreceipt.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 18);
            label1.Name = "label1";
            label1.Size = new Size(455, 72);
            label1.TabIndex = 0;
            label1.Text = "Hinundayan Gym";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14F);
            label2.Location = new Point(60, 263);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 2;
            label2.Text = "Member Name:";
            // 
            // pnlreceipt
            // 
            pnlreceipt.BackColor = Color.Transparent;
            pnlreceipt.Controls.Add(label6);
            pnlreceipt.Controls.Add(lblprice);
            pnlreceipt.Controls.Add(label10);
            pnlreceipt.Controls.Add(lblchange);
            pnlreceipt.Controls.Add(lblamountPaid);
            pnlreceipt.Controls.Add(lblsubscription);
            pnlreceipt.Controls.Add(lblmemberName);
            pnlreceipt.Controls.Add(lblmemberId);
            pnlreceipt.Controls.Add(label8);
            pnlreceipt.Controls.Add(label7);
            pnlreceipt.Controls.Add(label5);
            pnlreceipt.Controls.Add(label4);
            pnlreceipt.Controls.Add(label3);
            pnlreceipt.Controls.Add(label1);
            pnlreceipt.Controls.Add(label2);
            pnlreceipt.Location = new Point(74, 66);
            pnlreceipt.Name = "pnlreceipt";
            pnlreceipt.Size = new Size(749, 708);
            pnlreceipt.TabIndex = 4;
            pnlreceipt.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(231, 664);
            label6.Name = "label6";
            label6.Size = new Size(324, 27);
            label6.TabIndex = 17;
            label6.Text = "\"Train Hard Stay Strong\"";
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblprice.Location = new Point(259, 373);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(77, 27);
            lblprice.TabIndex = 16;
            lblprice.Text = "Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 14F);
            label10.Location = new Point(60, 373);
            label10.Name = "label10";
            label10.Size = new Size(90, 28);
            label10.TabIndex = 15;
            label10.Text = "Price:";
            // 
            // lblchange
            // 
            lblchange.AutoSize = true;
            lblchange.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblchange.Location = new Point(259, 497);
            lblchange.Name = "lblchange";
            lblchange.Size = new Size(90, 27);
            lblchange.TabIndex = 14;
            lblchange.Text = "Change";
            // 
            // lblamountPaid
            // 
            lblamountPaid.AutoSize = true;
            lblamountPaid.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblamountPaid.Location = new Point(259, 431);
            lblamountPaid.Name = "lblamountPaid";
            lblamountPaid.Size = new Size(155, 27);
            lblamountPaid.TabIndex = 13;
            lblamountPaid.Text = "Amount Paid";
            // 
            // lblsubscription
            // 
            lblsubscription.AutoSize = true;
            lblsubscription.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsubscription.Location = new Point(259, 317);
            lblsubscription.Name = "lblsubscription";
            lblsubscription.Size = new Size(168, 27);
            lblsubscription.TabIndex = 11;
            lblsubscription.Text = "Subscription";
            lblsubscription.Click += lblsubscription_Click;
            // 
            // lblmemberName
            // 
            lblmemberName.AutoSize = true;
            lblmemberName.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmemberName.Location = new Point(259, 264);
            lblmemberName.Name = "lblmemberName";
            lblmemberName.Size = new Size(168, 27);
            lblmemberName.TabIndex = 10;
            lblmemberName.Text = "Member Name:";
            // 
            // lblmemberId
            // 
            lblmemberId.AutoSize = true;
            lblmemberId.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmemberId.Location = new Point(259, 211);
            lblmemberId.Name = "lblmemberId";
            lblmemberId.Size = new Size(142, 27);
            lblmemberId.TabIndex = 9;
            lblmemberId.Text = "Member ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 14F);
            label8.Location = new Point(60, 211);
            label8.Name = "label8";
            label8.Size = new Size(142, 28);
            label8.TabIndex = 8;
            label8.Text = "Member ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(231, 90);
            label7.Name = "label7";
            label7.Size = new Size(292, 41);
            label7.TabIndex = 7;
            label7.Text = "Membership Receipt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14F);
            label5.Location = new Point(60, 497);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 5;
            label5.Text = "Change:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14F);
            label4.Location = new Point(60, 431);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 4;
            label4.Text = "Amount Paid:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14F);
            label3.Location = new Point(60, 316);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 3;
            label3.Text = "Subscription:";
            // 
            // btnprint
            // 
            btnprint.Location = new Point(407, 791);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(122, 29);
            btnprint.TabIndex = 5;
            btnprint.Text = "Print";
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click_1;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 832);
            Controls.Add(btnprint);
            Controls.Add(pnlreceipt);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            pnlreceipt.ResumeLayout(false);
            pnlreceipt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnprint;
        private Label label2;
        private Panel pnlreceipt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        public Label lblchange;
        public Label lblamountPaid;
        public Label lblsubscription;
        public Label lblmemberName;
        public Label lblmemberId;
        public Label lblprice;
        private Label label10;
        public Label label6;
    }
}