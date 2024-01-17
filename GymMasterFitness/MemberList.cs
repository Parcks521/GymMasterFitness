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
    public partial class MemberList : Form
    {
        public MemberList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void MemberList_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void memberListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a search query.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\GymMasterDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    string query = "SELECT * FROM AddMember WHERE GName LIKE @SearchQuery OR GNumber LIKE @SearchQuery";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        memberListGrid.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching records found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching members: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            MessageBox.Show("Sucessfully Cleared");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
