﻿namespace GymMasterFitness
{
    partial class UpdatePage
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
            btnBack = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            btnResetMem = new Button();
            btnUpdateMem = new Button();
            txtPayment = new RichTextBox();
            cmbPlan = new ComboBox();
            cmbGender = new ComboBox();
            txtNumber = new RichTextBox();
            txtAge = new RichTextBox();
            txtName = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            memberListGrid = new DataGridView();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberListGrid).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Chocolate;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1166, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 36);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(178, 149);
            label2.Name = "label2";
            label2.Size = new Size(127, 33);
            label2.TabIndex = 21;
            label2.Text = "FITNESS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Russo One", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(11, 70);
            label1.Name = "label1";
            label1.Size = new Size(475, 77);
            label1.TabIndex = 20;
            label1.Text = "GYM MASTER";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnResetMem);
            panel1.Controls.Add(btnUpdateMem);
            panel1.Controls.Add(txtPayment);
            panel1.Controls.Add(cmbPlan);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(24, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 578);
            panel1.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Chocolate;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(154, 462);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 36);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnResetMem
            // 
            btnResetMem.BackColor = Color.Chocolate;
            btnResetMem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetMem.ForeColor = Color.White;
            btnResetMem.Location = new Point(266, 462);
            btnResetMem.Name = "btnResetMem";
            btnResetMem.Size = new Size(109, 36);
            btnResetMem.TabIndex = 18;
            btnResetMem.Text = "Reset";
            btnResetMem.UseVisualStyleBackColor = false;
            btnResetMem.Click += btnResetMem_Click;
            // 
            // btnUpdateMem
            // 
            btnUpdateMem.BackColor = Color.Chocolate;
            btnUpdateMem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateMem.ForeColor = Color.White;
            btnUpdateMem.Location = new Point(43, 462);
            btnUpdateMem.Name = "btnUpdateMem";
            btnUpdateMem.Size = new Size(109, 36);
            btnUpdateMem.TabIndex = 17;
            btnUpdateMem.Text = "Update";
            btnUpdateMem.UseVisualStyleBackColor = false;
            btnUpdateMem.Click += btnUpdateMem_Click;
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(43, 420);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(332, 36);
            txtPayment.TabIndex = 16;
            txtPayment.Text = "";
            // 
            // cmbPlan
            // 
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "Monthly - 2000", "Quarterly - 4000", "Semi-Anually - 6000", "Anually - 8000" });
            cmbPlan.Location = new Point(43, 370);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(132, 23);
            cmbPlan.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(43, 320);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(132, 23);
            cmbGender.TabIndex = 14;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(43, 247);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(332, 36);
            txtNumber.TabIndex = 13;
            txtNumber.Text = "";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(43, 172);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(332, 36);
            txtAge.TabIndex = 12;
            txtAge.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(332, 36);
            txtName.TabIndex = 11;
            txtName.Text = "";
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(43, 396);
            label9.Name = "label9";
            label9.Size = new Size(78, 21);
            label9.TabIndex = 10;
            label9.Text = "Payment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(43, 346);
            label8.Name = "label8";
            label8.Size = new Size(44, 21);
            label8.TabIndex = 9;
            label8.Text = "Plan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 148);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 8;
            label7.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(133, 16);
            label3.Name = "label3";
            label3.Size = new Size(175, 33);
            label3.TabIndex = 4;
            label3.Text = "MEMBERSHIP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(43, 295);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 7;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 223);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 6;
            label5.Text = "Mobile Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 73);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // memberListGrid
            // 
            memberListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberListGrid.Location = new Point(517, 202);
            memberListGrid.Name = "memberListGrid";
            memberListGrid.Size = new Size(746, 574);
            memberListGrid.TabIndex = 24;
            memberListGrid.CellContentClick += memberListGrid_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.OrangeRed;
            label10.Location = new Point(830, 166);
            label10.Name = "label10";
            label10.Size = new Size(127, 33);
            label10.TabIndex = 19;
            label10.Text = "MEMBERS";
            // 
            // UpdatePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5469582;
            ClientSize = new Size(1331, 848);
            Controls.Add(label10);
            Controls.Add(memberListGrid);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UpdatePage";
            Text = "UpdatePage";
            Load += UpdatePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memberListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnResetMem;
        private Button btnUpdateMem;
        private RichTextBox txtPayment;
        private ComboBox cmbPlan;
        private ComboBox cmbGender;
        private RichTextBox txtNumber;
        private RichTextBox txtAge;
        private RichTextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView memberListGrid;
        private Label label10;
        private Button btnDelete;
    }
}