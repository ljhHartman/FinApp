using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using DevExpress.XtraLayout.Filtering.Templates;
using FinApp.entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinApp.uc.usercontrol
{
    [TestClass]
    public class UnitTest_ImportCSV
    {

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
        public void CsvToBindlist()
        {
            // Get csv data
            using (var reader = new StreamReader(@"C:\Users\lucas.hartman\ING\NL46INGB0009272489_10-09-2022_10-09-2022.csv"))
            {
                List<string> listDate = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // Add to BindingList
                    BindingList<Transaction> bl = new BindingList<Transaction>();
                    bl.Add(new Transaction()
                    {
                        date = values[0],
                        description = values[1],
                        account = values[2],
                        contraAccount = values[3],
                        code = values[4],
                        addSub = values[5],
                        amount = values[6],
                        mutationType = values[7],
                        newSaldo = values[8],
                        tag = values[9],
                    });

                    // Print BindingList
                    foreach (Transaction i in bl)
                    {
                        Console.WriteLine(
                            $"date={i.date},\n" +
                            $"description={i.description},\n" +
                            $"account={i.account},\n" +
                            $"contraAcount={i.contraAccount},\n" +
                            $"code={i.code},\n" +
                            $"addSub={i.addSub},\n" +
                            $"amount={i.amount},\n" +
                            $"mutationType={i.mutationType},\n" +
                            $"newSaldo={i.newSaldo},\n" +
                            $"tag={i.tag}\n\n");
                    }
                }
            }

        }






    }
}