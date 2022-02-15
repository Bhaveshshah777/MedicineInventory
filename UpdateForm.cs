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
    public partial class UpdateForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public UpdateForm()
        {
            InitializeComponent();
            insertPanel.Enabled = false;
            insertPanel.Visible = false;
            panelDelete.Visible = false;
            panelDelete.Enabled = false;
            lblDeleteSuccess.Visible = false;
            lblInsertStatus.Visible = false;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insertPanel.Enabled = true;
            insertPanel.Visible = true;
            insertPanel.BringToFront();
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            string Name = txtInsertName.Text;
            decimal Price = 0;
            int Quantity = 0;
            try
            {
                Price = Convert.ToDecimal(txtInsertPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid price, please enter price in correct format");
                txtInsertName.Text = "";
                txtInsertPrice.Text = "";
                txtInsertQuantity.Text = "";
            }
            try
            {
                Quantity = Convert.ToInt32(txtInsertQuantity.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Invalid quantity, please enter quantity in correct format");
                txtInsertName.Text = "";
                txtInsertPrice.Text = "";
                txtInsertQuantity.Text = "";
            }
            if(txtInsertQuantity.Text != "" && txtInsertPrice.Text != "" && txtInsertName.Text != "")
            {
                using(SqlConnection con = new SqlConnection(cs))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Medicine (Name, Price, Quantity) Values (@Name, @Price, @Quantity)", con);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Price", Price);
                        cmd.Parameters.AddWithValue("@Quantity", Quantity);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        if(panelDelete.Visible||panelDelete.Enabled)
                        {
                            panelDelete.Visible = false;
                            panelDelete.Enabled = false;
                        }
                        insertPanel.Visible = false;
                        insertPanel.Enabled = false;
                        if(lblDeleteSuccess.Visible)
                            lblDeleteSuccess.Visible = false;
                        lblInsertStatus.Visible = true;

                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteEntry.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panelDelete.Enabled = true;
            panelDelete.Visible = true;
            panelDelete.BringToFront();
            btnDeleteEntry.Enabled = false;
            cmbDeleteList.Items.Clear();
            foreach(var item in Medicine.GetData())
            {
                cmbDeleteList.Items.Add(item.Name);
            }
        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            panelDelete.Enabled = false;
            panelDelete.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (insertPanel.Visible == true || insertPanel.Enabled == true)
            {
                insertPanel.Visible = false;
                insertPanel.Enabled = false; 
            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            string Name = cmbDeleteList.SelectedItem.ToString();
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete from Medicine Where Name = @Name", con);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    panelDelete.Enabled = false;
                    panelDelete.Visible = false;
                    if(insertPanel.Visible||insertPanel.Enabled)
                    {
                        insertPanel.Visible=false;
                        insertPanel.Enabled=false;
                    }
                    if(lblInsertStatus.Visible)
                        lblInsertStatus.Visible = false;
                    lblDeleteSuccess.Visible = true;

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

    }
}
