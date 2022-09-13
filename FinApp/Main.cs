using DevExpress.XtraBars.Docking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            // Init Document
            this.tabbedView1.QueryControl += tabbedView1_QueryControl;
        }

        // generated Document content (Dashboard)
        void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == ucDashboardDocument)
                e.Control = new FinApp.uc.uc_LoadCSV();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }



        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void userControl1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a panel and dock it to the right. 
            DockPanel pUserControl1 = dockManager1.AddPanel(DockingStyle.Right);
            pUserControl1.Text = "UserContrl1";
            uc.UserControl1 uc = new uc.UserControl1();
            pUserControl1.ControlContainer.Controls.Add(uc);

        }

        private void importCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a panel and dock it to the right. 
            DockPanel pImportCSV = dockManager1.AddPanel(DockingStyle.Right);
            pImportCSV.Text = "Import CSV";
            uc.importCSV.ucLoadCSV uc = new uc.importCSV.ucLoadCSV();
            pImportCSV.ControlContainer.Controls.Add(uc);
        }
    }
}
