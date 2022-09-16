using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinApp.entity;
using DevExpress.XtraCharts;

namespace FinApp.uc.chartAllTransactions
{
    public partial class uc_AllTransactions : UserControl
    {
        public uc_AllTransactions()
        {
            InitializeComponent();
            DataTable chartData = ChartData();
            ChartSettings(ccAllTransactions, chartData);
        }



        private void tlpContainer_Paint(object sender, PaintEventArgs e)
        {

        }



        private static DataTable ChartData()
        {
            // GET data from table "Transactions"
            FinApp.ds.dsTransactions.TransactionsDataTable ds = new FinApp.ds.dsTransactions.TransactionsDataTable();
            ds.dsTransactionsTableAdapters.TransactionsTableAdapter tba = new ds.dsTransactionsTableAdapters.TransactionsTableAdapter();
            tba.Fill(ds);

            // DECLARE DatTable
            DataTable table = new DataTable("Table1");
            table.Columns.Add("DATE", typeof(String));
            table.Columns.Add("AMOUNT", typeof(Double));

            // ADD data rows to the table.
            foreach (DataRow row in ds)
            {  
                table.Rows.Add(new object[] {
                    row["DATE"].ToString(),
                    Convert.ToDouble(row["AMOUNT"])
                    });
                Console.WriteLine($" {row["DATE"]} | {row["AMOUNT"]}");
            }
            return table;
        }



        private static void ChartSettings(ChartControl chart, DataTable chartData)
        {
            // Bind data to chart
            chart.DataSource = chartData;

            // Specify data members to bind the chart's series template.
            chart.SeriesDataMember = "DATE";
            chart.SeriesTemplate.ArgumentDataMember = "AMOUNT";
            chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "AMOUNT" });

            // View type
            chart.SeriesTemplate.View = new AreaSeriesView();
            //chart.SeriesTemplate.View = new StackedBarSeriesView();
        }




    }
}
