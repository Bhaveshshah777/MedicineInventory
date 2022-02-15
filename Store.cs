using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine_Inventory_using_Core
{
    public partial class Store : Form
    {
        List<Medicine> medicines = Medicine.GetData();
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public Store()
        {
            InitializeComponent();

            gridViewAllData.DataSource = medicines;
            foreach(var med in medicines)
            {
                cmbMedicineName.Items.Add(med.Name);
            }
        }

        private void cmbMedicineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cmbMedicineName.Text;
            decimal price = 0;
            foreach(var med in medicines)
            {
                if (med.Name == selection)
                    price = med.Price; 
            }
            lblFetchedPrice.Text = price.ToString();
        }

        

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int rowEffected = 0;
            using(SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("Update Medicine Set Quantity = Quantity + @Quantity Where Name = @Name", con))
                    {
                        cmd.Parameters.AddWithValue("@Name", cmbMedicineName.Text);
                        cmd.Parameters.AddWithValue("Quantity", txtQuantity.Text);
                        con.Open();
                        rowEffected = cmd.ExecuteNonQuery();
                        con.Close();
                    }
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

            cmbMedicineName.Items.Clear();
            lblFetchedPrice.Text = "";
            txtQuantity.Clear();
            lblRowEffected.ForeColor = System.Drawing.Color.Green;
            lblRowEffected.Text = $"{rowEffected} database updated";


            gridViewAllData.DataSource = Medicine.GetData();

            foreach (var med in medicines)
            {
                cmbMedicineName.Items.Add(med.Name);
            }

        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }
    }
}
