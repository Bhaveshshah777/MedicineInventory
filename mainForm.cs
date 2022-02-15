namespace Medicine_Inventory_using_Core
{
    public partial class mainForm : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        public mainForm()
        {
            InitializeComponent();
            foreach(var item in Medicine.GetData())
            {
                if (item.Quantity > 0)
                {
                    listMedicines.Items.Add(item.Name);
                    listMedicines.SelectedIndex = 0;
                    medicines.Add(item); 
                }

            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            decimal balance = 0;
            if (listCart.Items.Contains(listMedicines.SelectedItem))
                MessageBox.Show("Product already added!");
            else
            {
                listCart.Items.Add(listMedicines.SelectedItem);
            }
            listCart.SelectedIndex = 0;

            foreach (var item in medicines)
            {
                foreach (var cart in listCart.Items)
                    if (item.Name == cart.ToString())
                    {
                        balance += item.Price;
                        lblStatus.Text = $"{balance.ToString()}";
                    }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            decimal balance = Convert.ToDecimal(lblStatus.Text);

            if (listCart.Items.Count > 0)
            {
                foreach(var item in medicines)
                {
                    if(item.Name == listCart.SelectedItem.ToString())
                    {
                        balance -= item.Price;
                    }
                }
                listCart.Items.Remove(listCart.SelectedItem);
                lblStatus.Text = balance.ToString();
                if (listCart.Items.Count != 0)
                    listCart.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Nothing in the cart!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            listMedicines.Items.Clear();
            foreach(var item in medicines)
            {
                list.Add(item.Name);
            }
            foreach(string str in list)
            {
                if(str.Contains(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    listMedicines.Items.Add(str);
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Items purchased successfully";
            
            Medicine m = new Medicine();
            List<string> list = listCart.Items.Cast<string>().ToList();

            m.Buy(list); 
            
            listCart.Items.Clear();
            listMedicines.Items.Clear();
            foreach (var item in Medicine.GetData())
            {
                if (item.Quantity > 0)
                {
                    listMedicines.Items.Add(item.Name);
                    listMedicines.SelectedIndex = 0;
                    medicines.Add(item);
                }
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.ShowDialog();
            if(frmLogin.DialogResult == DialogResult.OK)
            {
                Store stForm = new Store();
                stForm.ShowDialog();
            }
        }
    }
}