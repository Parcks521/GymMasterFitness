using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMasterFitness
{
    public partial class UpdatePage : Form
    {
        public UpdatePage()
        {
            InitializeComponent();
        }
        int key = 0;
        private void memberListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = memberListGrid.Rows[e.RowIndex];
                key = Convert.ToInt32(selectedRow.Cells[0].Value?.ToString() ?? "");
                txtName.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                txtAge.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                txtNumber.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                cmbGender.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                cmbPlan.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                txtPayment.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
            }

        }
        private void populate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\GymMasterDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string query = "select * from AddMember";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        var parcks = new DataSet();
                        adapter.Fill(parcks);

                        using (SqlCommandBuilder builder = new SqlCommandBuilder(adapter))
                        {
                            memberListGrid.DataSource = parcks.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdatePage_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            if (homepage == null)
            {
                MessageBox.Show("No previous form available");
                return;
            }

            this.Hide();
            homepage.Show();
        }

        private void btnResetMem_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNumber.Text = "";
            txtAge.Text = "";
            txtPayment.Text = "";
            cmbGender.SelectedItem = null;
            cmbPlan.SelectedItem = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a member to be deleted! ");

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\GymMasterDB.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    string query = "delete from AddMember where GId =" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Deleted! ");
                    con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnUpdateMem_Click(object sender, EventArgs e)
        {
            if (key == 0 || txtName.Text == "" || txtAge.Text == "" || txtNumber.Text == "" || cmbGender.Text == "" || cmbPlan.Text == "" || txtPayment.Text == "")
            {
                MessageBox.Show("Please select an information to change!");

            } 
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\GymMasterDB.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    string query = "UPDATE AddMember SET GName = '" + txtName.Text + "', GAge = '" + txtAge.Text + "', GNumber = '" + txtNumber.Text + "', GGender = '" + cmbGender.Text + "', GPlan = '" + cmbPlan.Text + "', GPayment = '" + txtPayment.Text + "' WHERE GId = " + key;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Updated! ");
                    con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}

