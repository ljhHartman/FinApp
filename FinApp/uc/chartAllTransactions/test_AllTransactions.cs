using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinApp.uc.chartAllTransactions
{
    [TestClass]
    public class UnitTest_AllTrans
    {
        [TestMethod]
        public void GetSqlTable()
        {
            // GET data from table "Transactions"
            FinApp.ds.dsTransactions.TransactionsDataTable ds = new FinApp.ds.dsTransactions.TransactionsDataTable();
            ds.dsTransactionsTableAdapters.TransactionsTableAdapter tba = new ds.dsTransactionsTableAdapters.TransactionsTableAdapter();
            tba.Fill(ds);

            // PRINT
            foreach (DataRow row in ds)
            {
                Console.WriteLine($" {row["DATE"]} | {row["AMOUNT"]}");
            }

        }





    }
}
