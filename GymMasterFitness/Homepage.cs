using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMasterFitness
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnAddMember_Click_1(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePage update = new UpdatePage();
            update.Show();
            this.Hide();
        }

        private void btnViewMem_Click(object sender, EventArgs e)
        {
            MemberList list = new MemberList();
            list.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
