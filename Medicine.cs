using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Medicine_Inventory_using_Core
{
    public class Medicine
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public static List<Medicine> GetData()
        {
            List<Medicine> medicines = new();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                using(SqlCommand cmd = new SqlCommand("Select * from Medicine", con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while(rdr.Read())
                        {
                            Medicine med = new Medicine();
                            med.Name = rdr["Name"].ToString();
                            med.Price = Convert.ToDecimal(rdr["Price"]);
                            med.Quantity = Convert.ToInt32(rdr["Quantity"]);
                            medicines.Add(med);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return medicines;

        }

        public void Buy(List<string> list)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection conn = new SqlConnection(cs))
            {
                try
                {
                    conn.Open();
                    foreach(string str in list)
                    {
                        using (SqlCommand cmd = new SqlCommand("Update Medicine Set Quantity = Quantity - 1 Where Name = @Name", conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", str);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                {
                    conn.Close();
                }
            }
        }
    }
}
