using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using DevExpress.XtraLayout.Filtering.Templates;
using FinApp.ds.dsTransactionsTableAdapters;
using FinApp.entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinApp.uc.usercontrol
{
    [TestClass]
    public class UnitTest_ImportCSV
    {

        [TestMethod]
        public void CsvToBindingList()
        {
            BindingList<Transaction> bl = new BindingList<Transaction>();

            // CSV to BindingList
            using (var reader = new StreamReader(@"C:\Users\lucas.hartman\ING\NL46INGB0009272489_10-09-2022_10-09-2022.csv"))
            {
                List<string> listDate = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var v = line.Split(';');

                    bl.Add(new Transaction()
                    {
                        DATE = v[0].Replace("\"", ""),
                        NAME = v[1].Replace("\"", ""),
                        ACCOUNT = v[2].Replace("\"", ""),
                        CONTRAACCOUNT = v[3].Replace("\"", ""),
                        CODE = v[4].Replace("\"", ""),
                        ADDSUB = v[5].Replace("\"", ""),
                        AMOUNT = StrintToDoube(v[6]),
                        CURRENCY = "EUR",
                        MUTATIONTYPE = v[7].Replace("\"", ""),
                        STATEMENT = v[8].Replace("\"", ""),
                        BALANCEAFTERCHANGE = StrintToDoube(v[9]),
                        TAG = v[10].Replace("\"", "")
                    });

                }
            }

            //Remove first row
            bl.RemoveAt(0);

            //Print BindingList
            foreach (Transaction i in bl)
            {
                Console.WriteLine(
                    $"DATE = {i.DATE},\n" +
                    $"NAME = {i.NAME},\n" +
                    $"ACCOUNT ={i.ACCOUNT},\n" +
                    $"CONTRAACCOUNT = {i.CONTRAACCOUNT},\n" +
                    $"CODE = {i.CODE},\n" +
                    $"ADDSUB = {i.ADDSUB},\n" +
                    $"AMOUNT = {i.AMOUNT},\n" +
                    $"CURRENCY = {i.CURRENCY},\n" +
                    $"MUTATIONTYPE = {i.MUTATIONTYPE},\n" +
                    $"STATEMENT = {i.STATEMENT},\n" +
                    $"BALANCEAFTERCHANGE = {i.BALANCEAFTERCHANGE},\n" +
                    $"TAG = {i.TAG}\n\n");
            }

            // BindingList to SqlTable "Transaction"
            // Insert into Database
            foreach (Transaction i in bl)
            {
                ds.dsTransactionsTableAdapters.TransactionsTableAdapter obj = new ds.dsTransactionsTableAdapters.TransactionsTableAdapter();
                obj.InsertQuery(i.DATE,i.NAME,i.ACCOUNT,i.CONTRAACCOUNT,i.CODE,i.ADDSUB, (int)i.AMOUNT,i.CURRENCY,i.MUTATIONTYPE,i.STATEMENT,(int)i.BALANCEAFTERCHANGE,i.TAG);             
            }
        }

        public double StrintToDoube(String str)
        {
            // Convert String to Doube and alos remove "" from String
            String str1 = str.Replace("\"", "");
            Double get_number;

            if (Double.TryParse(str1, out get_number))
            {
                Console.WriteLine($"Parsed {str1}, to {get_number}");
            }
            else
            {
                Console.WriteLine($"Cant't Parse {str1}");
                get_number = 0;
            }
                return get_number;
        }


    

    

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("hello");
        }


        [TestMethod]
        public void ImportCSV()
        {
            using (var reader = new StreamReader(@"C:\Users\lucas.hartman\ING\NL46INGB0009272489_10-09-2022_10-09-2022.csv"))
            {
                List<string> listDate = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listDate.Add(values[0]);
                }

                // Print
                foreach (string i in listDate)
                {
                    Console.WriteLine(i);
                }
     
            }
        }


        [TestMethod]
        public void CSVtoTable()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Data");
            tbl.Columns.Add("Descrption");
            tbl.Columns.Add("Account");
            tbl.Columns.Add("ContraAccount");
            tbl.Columns.Add("Code");
            tbl.Columns.Add("AddSub");
            tbl.Columns.Add("Amount");
            tbl.Columns.Add("MutationType");
            tbl.Columns.Add("Announcements");
            tbl.Columns.Add("NewSaldo");
            tbl.Columns.Add("Tag");

            // PRINT COLUMN NAMES
            foreach (DataColumn column in tbl.Columns)
                Console.WriteLine(column.ColumnName);

            // SET CSV TO TABLE
            using (var reader = new StreamReader(@"C:\Users\lucas.hartman\ING\NL46INGB0009272489_10-09-2022_10-09-2022.csv"))
            {
                List<string> listDate = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // Add to Table
                    DataRow row;
                    row = tbl.NewRow();
                    row["Data"] = values[0];
                    row["Descrption"] = values[1];
                    row["Account"] = values[2];
                    row["ContraAccount"] = values[3];
                    row["Code"] = values[4];
                    row["AddSub"] = values[5];
                    row["Amount"] = values[6];
                    row["MutationType"] = values[7];
                    row["Announcements"] = values[8];
                    row["NewSaldo"] = values[9];
                    row["Tag"] = values[10];
                    tbl.Rows.Add(row);
                }
            }

            // PRINT TABLE
            foreach (DataRow row in tbl.Rows)
            {
                Console.WriteLine($"{row[0]}, {row[1]}, {row[2]}, {row[3]}, {row[4]}, {row[5]}, {row[6]}, {row[7]}, {row[8]}, {row[9]}, {row[10]}");
            }

            // Table to Dataset
            DataSet ds = new DataSet();
            ds.Tables.Add(tbl);
        }


     




        [TestMethod]
        public void CsvToDatabase()
        {
            BindingList<Transaction> bl = new BindingList<Transaction>();

            // Get csv data
            using (var reader = new StreamReader(@"C:\Users\lucas.hartman\ING\NL46INGB0009272489_10-09-2022_10-09-2022.csv"))
            {
                List<string> listDate = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // Add to BindingList
                    //bl.Add(new Transaction()
                    //{
                    //    date = values[0],
                    //    description = values[1],
                    //    account = values[2],
                    //    contraAccount = values[3],
                    //    code = values[4],
                    //    addSub = values[5],
                    //    amount = values[6],
                    //    mutationType = values[7],
                    //    announcements = values[8],
                    //    newSaldo = values[9],
                    //    tag = values[10],
                    //});
                }

                // Remove first row
                bl.RemoveAt(0);

                // Print BindingList
                foreach (Transaction i in bl)
                {
                    //Console.WriteLine(
                    //    $"date={i.date},\n" +
                    //    $"description={i.description},\n" +
                    //    $"account={i.account},\n" +
                    //    $"contraAcount={i.contraAccount},\n" +
                    //    $"code={i.code},\n" +
                    //    $"addSub={i.addSub},\n" +
                    //    $"amount={i.amount},\n" +
                    //    $"mutationType={i.mutationType},\n" +
                    //    $"announcements={i.announcements},\n" +
                    //    $"newSaldo={i.newSaldo},\n" +
                    //    $"tag={i.tag}\n\n");
                }

                // Insert into Database
                foreach (Transaction i in bl)
                {
                    TransactionsTableAdapter obj = new TransactionsTableAdapter();
                    //obj.InsertQuery(
                    //    i.date.Replace("\"", ""), 
                    //    i.description.Replace("\"", ""), 
                    //    i.account.Replace("\"", ""), 
                    //    i.contraAccount.Replace("\"", ""), 
                    //    i.code.Replace("\"", ""), 
                    //    i.addSub.Replace("\"", ""), 
                    //    i.account.Replace("\"", ""), 
                    //    i.mutationType.Replace("\"", ""), 
                    //    i.announcements.Replace("\"", ""),
                    //    i.newSaldo.Replace("\"", ""), 
                    //    i.tag.Replace("\"", ""));
                }
            }
        }




    }
}