namespace GymMasterFitness
{
    partial class MemberList
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
            label2 = new Label();
            label1 = new Label();
            memberListGrid = new DataGridView();
            pictureBox1 = new PictureBox();
            txtSearch = new RichTextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            label3 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)memberListGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(583, 122);
            label2.Name = "label2";
            label2.Size = new Size(127, 33);
            label2.TabIndex = 23;
            label2.Text = "FITNESS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Russo One", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(416, 43);
            label1.Name = "label1";
            label1.Size = new Size(475, 77);
            label1.TabIndex = 22;
            label1.Text = "GYM MASTER";
            // 
            // memberListGrid
            // 
            memberListGrid.BackgroundColor = SystemColors.ControlDarkDark;
            memberListGrid.BorderStyle = BorderStyle.None;
            memberListGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            memberListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberListGrid.GridColor = Color.Chocolate;
            memberListGrid.Location = new Point(289, 224);
            memberListGrid.Name = "memberListGrid";
            memberListGrid.RowTemplate.Height = 25;
            memberListGrid.Size = new Size(740, 574);
            memberListGrid.TabIndex = 25;
            memberListGrid.CellContentClick += memberListGrid_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(557, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(589, 189);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 29);
            txtSearch.TabIndex = 27;
            txtSearch.Text = "";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Chocolate;
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(821, 188);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Chocolate;
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(917, 188);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.TabIndex = 31;
            btnRefresh.Text = "Clear";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Chocolate;
            label3.Location = new Point(313, 189);
            label3.Name = "label3";
            label3.Size = new Size(238, 29);
            label3.TabIndex = 32;
            label3.Text = "LIST OF MEMBERS";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Chocolate;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1166, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 36);
            btnBack.TabIndex = 33;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MemberList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5469582;
            ClientSize = new Size(1331, 848);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(pictureBox1);
            Controls.Add(memberListGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MemberList";
            Text = "MemberList";
            Load += MemberList_Load;
            ((System.ComponentModel.ISupportInitialize)memberListGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView memberListGrid;
        private PictureBox pictureBox1;
        private RichTextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private Label label3;
        private Button btnBack;
    }
}