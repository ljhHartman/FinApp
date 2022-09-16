using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.entity
{

    public class Transaction
    {
        /*
         DATE
         NAME
         ACCOUNT
         CONTRAACCOUNT
         CODE
         ADDSUB
         AMOUNT
         CURRENCY
         MUTATIONTYPE
         STATEMENT
         BALANCEAFTERCHANGE
         TAG
         */
        public string DATE { get; set; }
        public string NAME { get; set; }
        public string ACCOUNT { get; set; }
        public string CONTRAACCOUNT { get; set; }
        public string CODE { get; set; }
        public string ADDSUB { get; set; }
        public double AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public string MUTATIONTYPE { get; set; }
        public string STATEMENT { get; set; }
        public double BALANCEAFTERCHANGE { get; set; }
        public string TAG { get; set; }
    }
}
