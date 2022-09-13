using DevExpress.XtraGrid;
using FinApp.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;


namespace FinApp.uc.importCSV
{
    class mod_LoadCSVs
    {

        public static BindingList<Transaction> CsvToGridControl(GridControl gc)
        {
            System.ComponentModel.BindingList<Transaction> bl = new System.ComponentModel.BindingList<Transaction>();

            // Get csv data
            using (var reader = new StreamReader(@"C:\Users\lucas.hartman\ING\NL46INGB0009272489_10-09-2022_10-09-2022.csv"))
            {
                List<string> listDate = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // Add to BindingList
                    bl.Add(new Transaction()
                    {
                        date = values[0].Replace("\"", ""),
                        description = values[1].Replace("\"", ""),
                        account = values[2].Replace("\"", ""),
                        contraAccount = values[3].Replace("\"", ""),
                        code = values[4].Replace("\"", ""),
                        addSub = values[5].Replace("\"", ""),
                        amount = values[6].Replace("\"", ""),
                        mutationType = values[7].Replace("\"", ""),
                        announcements = values[8].Replace("\"", ""),
                        newSaldo = values[9].Replace("\"", ""),
                        tag = values[10].Replace("\"", "")
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
                            $"annoucements={i.announcements},\n" +
                            $"newSaldo={i.newSaldo},\n" +
                            $"tag={i.tag}\n\n");
                    }
                }
            }

            //gc.DataSource = bl;
            return bl;
        }



    }
}
