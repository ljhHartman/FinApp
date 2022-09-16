namespace FinApp.uc.chartAllTransactions
{
    partial class uc_AllTransactions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpChart = new System.Windows.Forms.TableLayoutPanel();
            this.rcTimeLine = new DevExpress.XtraEditors.RangeControl();
            this.ccAllTransactions = new DevExpress.XtraCharts.ChartControl();
            this.transactionsTableAdapter = new FinApp.DataSet1TableAdapters.TransactionsTableAdapter();
            this.transactionsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcAllTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dsTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FinApp.DataSet1();
            this.transactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.tlpContainer.SuspendLayout();
            this.tlpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcTimeLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccAllTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAllTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            // 
            // tlpContainer
            // 
            this.tlpContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainer.Controls.Add(this.tlpChart, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Size = new System.Drawing.Size(900, 500);
            this.tlpContainer.TabIndex = 0;
            this.tlpContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpContainer_Paint);
            // 
            // tlpChart
            // 
            this.tlpChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tlpChart.ColumnCount = 1;
            this.tlpChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChart.Controls.Add(this.rcTimeLine, 0, 1);
            this.tlpChart.Controls.Add(this.ccAllTransactions, 0, 0);
            this.tlpChart.Controls.Add(this.gcAllTransactions, 0, 2);
            this.tlpChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpChart.Location = new System.Drawing.Point(9, 9);
            this.tlpChart.Margin = new System.Windows.Forms.Padding(9);
            this.tlpChart.Name = "tlpChart";
            this.tlpChart.RowCount = 3;
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpChart.Size = new System.Drawing.Size(882, 482);
            this.tlpChart.TabIndex = 0;
            // 
            // rcTimeLine
            // 
            this.rcTimeLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcTimeLine.Location = new System.Drawing.Point(3, 292);
            this.rcTimeLine.Name = "rcTimeLine";
            this.rcTimeLine.Size = new System.Drawing.Size(876, 26);
            this.rcTimeLine.TabIndex = 1;
            this.rcTimeLine.Text = "rangeControl1";
            // 
            // ccAllTransactions
            // 
            this.ccAllTransactions.DataAdapter = this.transactionsTableAdapter;
            this.ccAllTransactions.DataBindings = null;
            this.ccAllTransactions.DataSource = this.transactionsDataTableBindingSource;
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.ccAllTransactions.Diagram = swiftPlotDiagram1;
            this.ccAllTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ccAllTransactions.Legend.Name = "Default Legend";
            this.ccAllTransactions.Location = new System.Drawing.Point(3, 3);
            this.ccAllTransactions.Name = "ccAllTransactions";
            series1.ArgumentDataMember = "account";
            series1.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            new DevExpress.XtraCharts.DataFilter("amount", "System.Double", DevExpress.XtraCharts.DataFilterCondition.Equal, 9D)});
            series1.DataSource = this.transactionsBindingSource;
            series1.Name = "Transactions";
            series1.View = swiftPlotSeriesView1;
            this.ccAllTransactions.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ccAllTransactions.Size = new System.Drawing.Size(876, 283);
            this.ccAllTransactions.TabIndex = 2;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // transactionsDataTableBindingSource
            // 
            this.transactionsDataTableBindingSource.DataSource = typeof(FinApp.DataSet1.TransactionsDataTable);
            // 
            // gcAllTransactions
            // 
            this.gcAllTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAllTransactions.Location = new System.Drawing.Point(3, 324);
            this.gcAllTransactions.MainView = this.gridView1;
            this.gcAllTransactions.Name = "gcAllTransactions";
            this.gcAllTransactions.Size = new System.Drawing.Size(876, 155);
            this.gcAllTransactions.TabIndex = 3;
            this.gcAllTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcAllTransactions;
            this.gridView1.Name = "gridView1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource1
            // 
            this.transactionsBindingSource1.DataMember = "Transactions";
            this.transactionsBindingSource1.DataSource = this.dataSet1;
            // 
            // uc_AllTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpContainer);
            this.Name = "uc_AllTransactions";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.tlpContainer.ResumeLayout(false);
            this.tlpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rcTimeLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccAllTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAllTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tlpChart;
        private DevExpress.XtraEditors.RangeControl rcTimeLine;
        private DevExpress.XtraCharts.ChartControl ccAllTransactions;
        private DevExpress.XtraGrid.GridControl gcAllTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private System.Windows.Forms.BindingSource dsTransactionsBindingSource;
        private DataSet1TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.BindingSource transactionsBindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource transactionsDataTableBindingSource;
    }
}
