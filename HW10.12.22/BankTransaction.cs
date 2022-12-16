using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10._12._22
{
    internal class BankTransaction
    {
        public DateTime date { get; set; }
        public double money { get; set; }
        public BankTransaction(double money)
        {
            this.money = money;
            this.date = DateTime.UtcNow;
        }
    }
}
