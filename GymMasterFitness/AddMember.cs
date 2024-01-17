using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymMasterFitness
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Miguel\Documents\GymMasterDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtNumber.Text == "" || txtAge.Text == "" || txtPayment.Text == "" || cmbGender.SelectedItem == null || cmbPlan.SelectedItem == null)
            {
                MessageBox.Show("Fill all the boxes!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO AddMember (GName, GNumber, GAge, GPayment, GGender, GPlan) VALUES (@Name, @Number, @Age, @Payment, @Gender, @Plan)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Number", txtNumber.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Payment", txtPayment.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Plan", cmbPlan.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }


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
    }
}
