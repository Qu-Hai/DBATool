using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBATool
{
    public class TransactionModel
    {
        public string TimeEnd { get; set; }
        public int Transact { get; set; }
        public decimal NetTotal { get; set; }
        public decimal FinalTotal { get; set; }
        public string WhoOpen { get; set; }
        public string WhoClose { get; set; }
        public decimal SVC { get; set; }
        public decimal VAT { get; set; }
    }
}
