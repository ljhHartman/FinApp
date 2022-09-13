using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.entity
{

    public class Transaction
    {
        public string date { get; set; }
        public string description { get; set; }
        public string account { get; set; }
        public string contraAccount { get; set; }
        public string code { get; set; }
        public string addSub { get; set; }
        public string amount { get; set; }
        public string mutationType { get; set; }
        public string announcements { get; set; }
        public string newSaldo { get; set; }
        public string tag { get; set; }
    }
}
