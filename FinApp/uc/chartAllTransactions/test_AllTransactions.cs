using System;
using System.ComponentModel;
using System.Data;
using FinApp.entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinApp.uc.chartAllTransactions
{
    [TestClass]
    public class UnitTest_AllTrans
    {
        [TestMethod]
        public void TableToBindlist()
        {
            // GET data from table "Transactions"
            FinApp.ds.dsTransactions.TransactionsDataTable ds = new FinApp.ds.dsTransactions.TransactionsDataTable();
            ds.dsTransactionsTableAdapters.TransactionsTableAdapter tba = new ds.dsTransactionsTableAdapters.TransactionsTableAdapter();
            tba.Fill(ds);

            // TableToBindingList
            BindingList<Transaction> bl = new BindingList<Transaction>();
            foreach (DataRow row in ds)
            {
                bl.Add(new Transaction()
                {
                    DATE = row["DATE"].ToString(),
                    AMOUNT = Convert.ToDouble(row["AMOUNT"])
                });
                Console.WriteLine($" {row["DATE"]} | {row["AMOUNT"]}");
            }
        }



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
               
            }

        }





    }
}
