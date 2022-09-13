using System;
using System.ComponentModel;
using System.Windows.Forms;
using FinApp.entity;

namespace FinApp.uc.importCSV
{
    public partial class ucLoadCSV : UserControl
    {
        BindingList<Transaction> bl = new BindingList<Transaction>();

        public ucLoadCSV()
        {
            InitializeComponent(); 
        }

        private void ucLoadCSV_Load(object sender, EventArgs e)
        {

        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            bl = mod_LoadCSVs.CsvToGridControl();
            gridControl1.DataSource = bl;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mod_LoadCSVs.BindlistToDatabase(bl);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tag") + "");
        }
    }
}
