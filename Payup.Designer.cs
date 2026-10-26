namespace Gym_Membership_System_wDesign
{
    partial class Payup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payup));
            panel1 = new Panel();
            btnBack = new Button();
            label7 = new Label();
            label6 = new Label();
            txtcash = new TextBox();
            label5 = new Label();
            label = new Label();
            lblIdNum = new Label();
            label4 = new Label();
            txtmemberName = new TextBox();
            label1 = new Label();
            lblmemberId = new Label();
            cmbsubscription = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            lblchange = new Label();
            lblprice = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 89);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 17F);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(63, 41);
            btnBack.TabIndex = 35;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 29.2F, FontStyle.Bold);
            label7.Location = new Point(243, 9);
            label7.Name = "label7";
            label7.Size = new Size(392, 66);
            label7.TabIndex = 35;
            label7.Text = "PAYMENT PAGE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(457, 279);
            label6.Name = "label6";
            label6.Size = new Size(52, 23);
            label6.TabIndex = 20;
            label6.Text = "Cash:";
            // 
            // txtcash
            // 
            txtcash.Font = new Font("Segoe UI", 17F);
            txtcash.Location = new Point(457, 308);
            txtcash.Multiline = true;
            txtcash.Name = "txtcash";
            txtcash.Size = new Size(265, 39);
            txtcash.TabIndex = 3;
            txtcash.TextChanged += txtcash_TextChanged;
            txtcash.KeyPress += txtcash_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(457, 189);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 18;
            label5.Text = "Price:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(148, 109);
            label.Name = "label";
            label.Size = new Size(105, 23);
            label.TabIndex = 17;
            label.Text = "ID Number:";
            // 
            // lblIdNum
            // 
            lblIdNum.BackColor = Color.White;
            lblIdNum.Font = new Font("Segoe UI", 17.2F, FontStyle.Bold);
            lblIdNum.Location = new Point(148, 135);
            lblIdNum.Name = "lblIdNum";
            lblIdNum.Size = new Size(265, 40);
            lblIdNum.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 280);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 14;
            label4.Text = "Member Name:";
            // 
            // txtmemberName
            // 
            txtmemberName.Font = new Font("Segoe UI", 17F);
            txtmemberName.Location = new Point(148, 309);
            txtmemberName.Multiline = true;
            txtmemberName.Name = "txtmemberName";
            txtmemberName.Size = new Size(265, 39);
            txtmemberName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 191);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 23;
            label1.Text = "Member ID:";
            // 
            // lblmemberId
            // 
            lblmemberId.BackColor = Color.White;
            lblmemberId.Font = new Font("Segoe UI", 17.2F, FontStyle.Bold);
            lblmemberId.Location = new Point(148, 217);
            lblmemberId.Name = "lblmemberId";
            lblmemberId.Size = new Size(265, 40);
            lblmemberId.TabIndex = 22;
            // 
            // cmbsubscription
            // 
            cmbsubscription.Font = new Font("Segoe UI", 13F);
            cmbsubscription.FormattingEnabled = true;
            cmbsubscription.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly" });
            cmbsubscription.Location = new Point(148, 400);
            cmbsubscription.Name = "cmbsubscription";
            cmbsubscription.Size = new Size(262, 38);
            cmbsubscription.TabIndex = 2;
            cmbsubscription.SelectedIndexChanged += cmbsubscription_SelectedIndexChanged;
            cmbsubscription.KeyPress += cmbsubscription_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(148, 371);
            label8.Name = "label8";
            label8.Size = new Size(116, 23);
            label8.TabIndex = 29;
            label8.Text = "Subscription:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(457, 364);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 31;
            label3.Text = "Change:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 17F);
            btnSave.Location = new Point(357, 473);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 56);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 17F);
            btnEdit.Location = new Point(186, 473);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 56);
            btnEdit.TabIndex = 34;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblchange
            // 
            lblchange.BackColor = Color.White;
            lblchange.Font = new Font("Segoe UI", 17.2F, FontStyle.Bold);
            lblchange.Location = new Point(457, 400);
            lblchange.Name = "lblchange";
            lblchange.Size = new Size(265, 40);
            lblchange.TabIndex = 36;
            lblchange.Click += lblchange_Click;
            // 
            // lblprice
            // 
            lblprice.BackColor = Color.White;
            lblprice.Font = new Font("Segoe UI", 17.2F, FontStyle.Bold);
            lblprice.Location = new Point(457, 212);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(265, 40);
            lblprice.TabIndex = 37;
            // 
            // Payup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 541);
            Controls.Add(lblprice);
            Controls.Add(lblchange);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(cmbsubscription);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(lblmemberId);
            Controls.Add(label6);
            Controls.Add(txtcash);
            Controls.Add(label5);
            Controls.Add(label);
            Controls.Add(lblIdNum);
            Controls.Add(label4);
            Controls.Add(txtmemberName);
            Controls.Add(panel1);
            Name = "Payup";
            Text = "Payup";
            Load += Payup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        public TextBox txtcash;
        private Label label5;
        private Label label;
        public Label lblIdNum;
        private Label label4;
        public TextBox txtmemberName;
        private Label label1;
        public Label lblmemberId;
        public ComboBox cmbsubscription;
        private Label label8;
        private Label label3;
        public Button btnSave;
        private Label label7;
        public Button btnEdit;
        private Button btnBack;
        public Label lblchange;
        public Label lblprice;
    }
}