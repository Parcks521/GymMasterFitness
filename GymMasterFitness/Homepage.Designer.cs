namespace GymMasterFitness
{
    partial class Homepage
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
            panel1 = new Panel();
            label3 = new Label();
            btnAddMember = new Button();
            btnViewMem = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            btnLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAddMember);
            panel1.Controls.Add(btnViewMem);
            panel1.Controls.Add(btnUpdate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1331, 90);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Russo One", 39.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Chocolate;
            label3.Location = new Point(35, 12);
            label3.Name = "label3";
            label3.Size = new Size(396, 64);
            label3.TabIndex = 3;
            label3.Text = "GYM MASTER";
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.Chocolate;
            btnAddMember.Font = new Font("Impact", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(547, 9);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(189, 67);
            btnAddMember.TabIndex = 3;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += btnAddMember_Click_1;
            // 
            // btnViewMem
            // 
            btnViewMem.BackColor = Color.Chocolate;
            btnViewMem.Font = new Font("Impact", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewMem.ForeColor = Color.White;
            btnViewMem.Location = new Point(1057, 9);
            btnViewMem.Name = "btnViewMem";
            btnViewMem.Size = new Size(189, 67);
            btnViewMem.TabIndex = 1;
            btnViewMem.Text = "View Members";
            btnViewMem.UseVisualStyleBackColor = false;
            btnViewMem.Click += btnViewMem_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Chocolate;
            btnUpdate.Font = new Font("Impact", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(805, 9);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 67);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update Member";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Russo One", 71.99999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(304, 314);
            label1.Name = "label1";
            label1.Size = new Size(704, 116);
            label1.TabIndex = 1;
            label1.Text = "GYM MASTER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(531, 430);
            label2.Name = "label2";
            label2.Size = new Size(228, 58);
            label2.TabIndex = 2;
            label2.Text = "FITNESS";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Chocolate;
            btnLogout.Font = new Font("Impact", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 793);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(168, 43);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5469582;
            ClientSize = new Size(1331, 848);
            Controls.Add(btnLogout);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnUpdate;
        private Button btnAddMember;
        private Button btnViewMem;
        private Label label3;
        private Button btnLogout;
    }
}