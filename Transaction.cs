using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine_Inventory_using_Core
{
    public class Transaction
    {
        public string PtName { get; set; }
        public string MedName { get; set; }
        public decimal Balance { get; set; }
        public void TransactIn(decimal amount, string note)
        {

        }
        public void TransactOut(decimal amount, string note)
        {

        }
        public void Buy(string ptName, string medName)
        {
            PtName = ptName;
            MedName = medName;
        }
    }
}
