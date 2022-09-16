using DevExpress.XtraGrid;
using FinApp.entity;
using FinApp.ds.dsTransactionsTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using FinApp.util;


namespace FinApp.uc.importCSV
{
    class mod_LoadCSVs
    {

        public static BindingList<Transaction> CsvToGridControl()
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
                        AMOUNT = Utility.StringToDouble(v[6]),
                        CURRENCY = "EUR",
                        MUTATIONTYPE = v[7].Replace("\"", ""),
                        STATEMENT = v[8].Replace("\"", ""),
                        BALANCEAFTERCHANGE = Utility.StringToDouble(v[9]),
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
            return bl;
        }


        //public static double StringToDouble(String str)
        //{
        //    // Convert String to Doube and alos remove "" from String
        //    String str1 = str.Replace("\"", "");
        //    Double get_number;

        //    if (Double.TryParse(str1, out get_number))
        //    {
        //        Console.WriteLine($"Parsed {str1}, to {get_number}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Cant't Parse {str1}");
        //        get_number = 0;
        //    }
        //    return get_number;
        //}


        public static void BindlistToDatabase(BindingList<Transaction> bl)
        {
            // BindingList to SqlTable "Transaction"
            // Insert into Database
            foreach (Transaction i in bl)
            {
                ds.dsTransactionsTableAdapters.TransactionsTableAdapter obj = new ds.dsTransactionsTableAdapters.TransactionsTableAdapter();
                obj.InsertQuery(i.DATE, i.NAME, i.ACCOUNT, i.CONTRAACCOUNT, i.CODE, i.ADDSUB, (int)i.AMOUNT, i.CURRENCY, i.MUTATIONTYPE, i.STATEMENT, (int)i.BALANCEAFTERCHANGE, i.TAG);
            }



        }
    }
}
