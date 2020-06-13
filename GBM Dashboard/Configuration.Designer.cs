namespace GBM_Dashboard
{
    partial class Configuration
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbm_iva_navigator = new DevExpress.XtraEditors.ControlNavigator();
            this.gbmivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dashboardDataSet = new GBM_Dashboard.dashboardDataSet();
            this.gbm_ivaTableAdapter = new GBM_Dashboard.dashboardDataSetTableAdapters.gbm_ivaTableAdapter();
            this.gbmivaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dashboardDataSet1 = new GBM_Dashboard.dashboardDataSet1();
            this.gbmivaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gbm_ivaTableAdapter1 = new GBM_Dashboard.dashboardDataSet1TableAdapters.gbm_ivaTableAdapter();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage_path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive_fld = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage_path1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive_fld1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbmivaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivaBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbm_iva_navigator);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1798, 286);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbm_iva_navigator
            // 
            this.gbm_iva_navigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbm_iva_navigator.Location = new System.Drawing.Point(0, 0);
            this.gbm_iva_navigator.Name = "gbm_iva_navigator";
            this.gbm_iva_navigator.Size = new System.Drawing.Size(1798, 40);
            this.gbm_iva_navigator.TabIndex = 0;
            this.gbm_iva_navigator.Text = "controlNavigator1";
            // 
            // gbmivaBindingSource
            // 
            this.gbmivaBindingSource.DataMember = "gbm_iva";
            this.gbmivaBindingSource.DataSource = this.dashboardDataSet;
            // 
            // dashboardDataSet
            // 
            this.dashboardDataSet.DataSetName = "dashboardDataSet";
            this.dashboardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbm_ivaTableAdapter
            // 
            this.gbm_ivaTableAdapter.ClearBeforeFill = true;
            // 
            // gbmivaBindingSource1
            // 
            this.gbmivaBindingSource1.DataMember = "gbm_iva";
            this.gbmivaBindingSource1.DataSource = this.dashboardDataSet;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.gbmivaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1798, 242);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colImage_path,
            this.colactive_fld});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // dashboardDataSet1
            // 
            this.dashboardDataSet1.DataSetName = "dashboardDataSet1";
            this.dashboardDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbmivaBindingSource2
            // 
            this.gbmivaBindingSource2.DataMember = "gbm_iva";
            this.gbmivaBindingSource2.DataSource = this.dashboardDataSet1;
            // 
            // gbm_ivaTableAdapter1
            // 
            this.gbm_ivaTableAdapter1.ClearBeforeFill = true;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colImage_path
            // 
            this.colImage_path.FieldName = "Image_path";
            this.colImage_path.MinWidth = 25;
            this.colImage_path.Name = "colImage_path";
            this.colImage_path.Visible = true;
            this.colImage_path.VisibleIndex = 1;
            this.colImage_path.Width = 94;
            // 
            // colactive_fld
            // 
            this.colactive_fld.FieldName = "active_fld";
            this.colactive_fld.MinWidth = 25;
            this.colactive_fld.Name = "colactive_fld";
            this.colactive_fld.Visible = true;
            this.colactive_fld.VisibleIndex = 2;
            this.colactive_fld.Width = 94;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 286);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridControl2);
            this.splitContainer2.Size = new System.Drawing.Size(1798, 210);
            this.splitContainer2.SplitterDistance = 52;
            this.splitContainer2.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.gbmivaBindingSource3;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1798, 154);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colImage_path1,
            this.colactive_fld1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.MinWidth = 25;
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 94;
            // 
            // colImage_path1
            // 
            this.colImage_path1.FieldName = "Image_path";
            this.colImage_path1.MinWidth = 25;
            this.colImage_path1.Name = "colImage_path1";
            this.colImage_path1.Visible = true;
            this.colImage_path1.VisibleIndex = 1;
            this.colImage_path1.Width = 94;
            // 
            // colactive_fld1
            // 
            this.colactive_fld1.FieldName = "active_fld";
            this.colactive_fld1.MinWidth = 25;
            this.colactive_fld1.Name = "colactive_fld1";
            this.colactive_fld1.Visible = true;
            this.colactive_fld1.VisibleIndex = 2;
            this.colactive_fld1.Width = 94;
            // 
            // gbmivaBindingSource3
            // 
            this.gbmivaBindingSource3.DataMember = "gbm_iva";
            this.gbmivaBindingSource3.DataSource = this.dashboardDataSet;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Configuration";
            this.Size = new System.Drawing.Size(1798, 803);
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbmivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivaBindingSource2)).EndInit();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbmivaBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.ControlNavigator gbm_iva_navigator;
        private System.Windows.Forms.BindingSource gbmivaBindingSource;
        private dashboardDataSet dashboardDataSet;
        private dashboardDataSetTableAdapters.gbm_ivaTableAdapter gbm_ivaTableAdapter;
        private System.Windows.Forms.BindingSource gbmivaBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource gbmivaBindingSource2;
        private dashboardDataSet1 dashboardDataSet1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colImage_path;
        private DevExpress.XtraGrid.Columns.GridColumn colactive_fld;
        private dashboardDataSet1TableAdapters.gbm_ivaTableAdapter gbm_ivaTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource gbmivaBindingSource3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colImage_path1;
        private DevExpress.XtraGrid.Columns.GridColumn colactive_fld1;
    }
}
