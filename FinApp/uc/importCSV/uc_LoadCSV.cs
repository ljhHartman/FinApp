using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinApp.uc.importCSV
{
    public partial class ucLoadCSV : UserControl
    {
        public ucLoadCSV()
        {
            InitializeComponent();
        }

        private void ucLoadCSV_Load(object sender, EventArgs e)
        {

        }

        private void btnImportCSV_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = uc.importCSV.mod_LoadCSVs.CsvToGridControl(gridControl1);

        }
    }
}
