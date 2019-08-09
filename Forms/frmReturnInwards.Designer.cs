﻿namespace Master.Forms
{
    partial class frmReturnInwards
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnInwards));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.spSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbAmountPaid = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.mmoRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.glCostCenter = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCompanyCostCentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReturnInwards = new Master.Class.DataSet.dsReturnInwards();
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCustomersWithInvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.glOrderNo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.spGetCustomerOrderNosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectCustomerOrderNosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemdescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtendedCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyReturned = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyToReturned = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spGetCustomersWithInvoicesTableAdapter = new Master.Class.DataSet.dsReturnInwardsTableAdapters.spGetCustomersWithInvoicesTableAdapter();
            this.spGetCompanyCostCentersTableAdapter = new Master.Class.DataSet.dsReturnInwardsTableAdapters.spGetCompanyCostCentersTableAdapter();
            this.spGetCustomerOrderNosTableAdapter = new Master.Class.DataSet.dsReturnInwardsTableAdapters.spGetCustomerOrderNosTableAdapter();
            this.spSelectCustomerOrderNosTableAdapter = new Master.Class.DataSet.dsReturnInwardsTableAdapters.spSelectCustomerOrderNosTableAdapter();
            this.chkAllowREfund = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReturnInwards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomersWithInvoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomerOrderNosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCustomerOrderNosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowREfund.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spSave,
            this.toolStripSeparator2,
            this.toolStripButton5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1075, 21);
            this.toolStrip2.TabIndex = 36;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // spSave
            // 
            this.spSave.Image = ((System.Drawing.Image)(resources.GetObject("spSave.Image")));
            this.spSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.spSave.Name = "spSave";
            this.spSave.Size = new System.Drawing.Size(51, 18);
            this.spSave.Text = "&Save";
            this.spSave.Click += new System.EventHandler(this.spSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 21);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 18);
            this.toolStripButton5.Text = "He&lp";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.Location = new System.Drawing.Point(7, 323);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.lbAmountPaid);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblOrderTotal);
            this.panelControl1.Controls.Add(this.lblTotal);
            this.panelControl1.Location = new System.Drawing.Point(246, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(829, 38);
            this.panelControl1.TabIndex = 34;
            // 
            // lbAmountPaid
            // 
            this.lbAmountPaid.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountPaid.Appearance.Options.UseFont = true;
            this.lbAmountPaid.Location = new System.Drawing.Point(611, 9);
            this.lbAmountPaid.Name = "lbAmountPaid";
            this.lbAmountPaid.Size = new System.Drawing.Size(10, 23);
            this.lbAmountPaid.TabIndex = 3;
            this.lbAmountPaid.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(472, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Amount Paid:";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.Appearance.Options.UseFont = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(198, 9);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(10, 23);
            this.lblOrderTotal.TabIndex = 1;
            this.lblOrderTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Appearance.Options.UseForeColor = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(108, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Order Total :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.layoutControl1);
            this.panel3.Location = new System.Drawing.Point(-5, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 278);
            this.panel3.TabIndex = 33;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.mmoRemarks);
            this.layoutControl1.Controls.Add(this.glCostCenter);
            this.layoutControl1.Controls.Add(this.glCustomer);
            this.layoutControl1.Controls.Add(this.glOrderNo);
            this.layoutControl1.Controls.Add(this.chkAllowREfund);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(248, 278);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // mmoRemarks
            // 
            this.mmoRemarks.Location = new System.Drawing.Point(12, 166);
            this.mmoRemarks.Name = "mmoRemarks";
            this.mmoRemarks.Size = new System.Drawing.Size(224, 77);
            this.mmoRemarks.StyleController = this.layoutControl1;
            this.mmoRemarks.TabIndex = 8;
            // 
            // glCostCenter
            // 
            this.glCostCenter.Location = new System.Drawing.Point(12, 28);
            this.glCostCenter.Name = "glCostCenter";
            this.glCostCenter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glCostCenter.Properties.Appearance.Options.UseFont = true;
            this.glCostCenter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCostCenter.Properties.DataSource = this.spGetCompanyCostCentersBindingSource;
            this.glCostCenter.Properties.DisplayMember = "ccname";
            this.glCostCenter.Properties.ValueMember = "cccode";
            this.glCostCenter.Properties.View = this.gridLookUpEdit3View;
            this.glCostCenter.Size = new System.Drawing.Size(224, 26);
            this.glCostCenter.StyleController = this.layoutControl1;
            this.glCostCenter.TabIndex = 7;
            this.glCostCenter.EditValueChanged += new System.EventHandler(this.glCostCenter_EditValueChanged);
            // 
            // spGetCompanyCostCentersBindingSource
            // 
            this.spGetCompanyCostCentersBindingSource.DataMember = "spGetCompanyCostCenters";
            this.spGetCompanyCostCentersBindingSource.DataSource = this.dsReturnInwards;
            // 
            // dsReturnInwards
            // 
            this.dsReturnInwards.DataSetName = "dsReturnInwards";
            this.dsReturnInwards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // glCustomer
            // 
            this.glCustomer.EditValue = "Select customer";
            this.glCustomer.Location = new System.Drawing.Point(12, 74);
            this.glCustomer.Name = "glCustomer";
            this.glCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glCustomer.Properties.Appearance.Options.UseFont = true;
            this.glCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glCustomer.Properties.DataSource = this.spGetCustomersWithInvoicesBindingSource;
            this.glCustomer.Properties.DisplayMember = "CustName";
            this.glCustomer.Properties.ValueMember = "CustCode";
            this.glCustomer.Properties.View = this.gridLookUpEdit1View;
            this.glCustomer.Size = new System.Drawing.Size(224, 26);
            this.glCustomer.StyleController = this.layoutControl1;
            this.glCustomer.TabIndex = 4;
            this.glCustomer.EditValueChanged += new System.EventHandler(this.glCustomer_EditValueChanged);
            // 
            // spGetCustomersWithInvoicesBindingSource
            // 
            this.spGetCustomersWithInvoicesBindingSource.DataMember = "spGetCustomersWithInvoices";
            this.spGetCustomersWithInvoicesBindingSource.DataSource = this.dsReturnInwards;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // glOrderNo
            // 
            this.glOrderNo.EditValue = "Select Invoice";
            this.glOrderNo.Location = new System.Drawing.Point(12, 120);
            this.glOrderNo.Name = "glOrderNo";
            this.glOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glOrderNo.Properties.Appearance.Options.UseFont = true;
            this.glOrderNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glOrderNo.Properties.DataSource = this.spGetCustomerOrderNosBindingSource;
            this.glOrderNo.Properties.DisplayMember = "InvoiceNo";
            this.glOrderNo.Properties.ValueMember = "InvoiceNo";
            this.glOrderNo.Properties.View = this.gridView2;
            this.glOrderNo.Size = new System.Drawing.Size(224, 26);
            this.glOrderNo.StyleController = this.layoutControl1;
            this.glOrderNo.TabIndex = 4;
            this.glOrderNo.EditValueChanged += new System.EventHandler(this.glOrderNo_EditValueChanged);
            // 
            // spGetCustomerOrderNosBindingSource
            // 
            this.spGetCustomerOrderNosBindingSource.DataMember = "spGetCustomerOrderNos";
            this.spGetCustomerOrderNosBindingSource.DataSource = this.dsReturnInwards;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(248, 278);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.glCustomer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem1.Text = "Customer";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.glCostCenter;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem4.Text = "CostCenter";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.glOrderNo;
            this.layoutControlItem3.CustomizationFormText = "Account No";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(228, 46);
            this.layoutControlItem3.Text = "Invoice No";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.mmoRemarks;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(228, 97);
            this.layoutControlItem2.Text = "Remarks";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(246, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 421);
            this.panel1.TabIndex = 32;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectCustomerOrderNosBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(829, 421);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spSelectCustomerOrderNosBindingSource
            // 
            this.spSelectCustomerOrderNosBindingSource.DataMember = "spSelectCustomerOrderNos";
            this.spSelectCustomerOrderNosBindingSource.DataSource = this.dsReturnInwards;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemdescription,
            this.colQty,
            this.colUnitCost,
            this.colExtendedCost,
            this.colCurrency,
            this.colQtyReturned,
            this.colQtyToReturned});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // colItemdescription
            // 
            this.colItemdescription.FieldName = "Itemdescription";
            this.colItemdescription.Name = "colItemdescription";
            this.colItemdescription.OptionsColumn.AllowEdit = false;
            this.colItemdescription.Visible = true;
            this.colItemdescription.VisibleIndex = 1;
            // 
            // colQty
            // 
            this.colQty.Caption = "Orig Qty";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.AllowEdit = false;
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 2;
            // 
            // colUnitCost
            // 
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.OptionsColumn.AllowEdit = false;
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 3;
            // 
            // colExtendedCost
            // 
            this.colExtendedCost.Caption = "Total Cost";
            this.colExtendedCost.FieldName = "ExtendedCost";
            this.colExtendedCost.Name = "colExtendedCost";
            this.colExtendedCost.OptionsColumn.AllowEdit = false;
            this.colExtendedCost.Visible = true;
            this.colExtendedCost.VisibleIndex = 4;
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "Currency";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.AllowEdit = false;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 5;
            // 
            // colQtyReturned
            // 
            this.colQtyReturned.FieldName = "QtyReturned";
            this.colQtyReturned.Name = "colQtyReturned";
            this.colQtyReturned.OptionsColumn.AllowEdit = false;
            this.colQtyReturned.Visible = true;
            this.colQtyReturned.VisibleIndex = 6;
            // 
            // colQtyToReturned
            // 
            this.colQtyToReturned.FieldName = "QtyToReturned";
            this.colQtyToReturned.Name = "colQtyToReturned";
            this.colQtyToReturned.Visible = true;
            this.colQtyToReturned.VisibleIndex = 7;
            // 
            // spGetCustomersWithInvoicesTableAdapter
            // 
            this.spGetCustomersWithInvoicesTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCompanyCostCentersTableAdapter
            // 
            this.spGetCompanyCostCentersTableAdapter.ClearBeforeFill = true;
            // 
            // spGetCustomerOrderNosTableAdapter
            // 
            this.spGetCustomerOrderNosTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectCustomerOrderNosTableAdapter
            // 
            this.spSelectCustomerOrderNosTableAdapter.ClearBeforeFill = true;
            // 
            // chkAllowREfund
            // 
            this.chkAllowREfund.Location = new System.Drawing.Point(12, 247);
            this.chkAllowREfund.Name = "chkAllowREfund";
            this.chkAllowREfund.Properties.Caption = "Allow Refund";
            this.chkAllowREfund.Size = new System.Drawing.Size(224, 19);
            this.chkAllowREfund.StyleController = this.layoutControl1;
            this.chkAllowREfund.TabIndex = 37;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkAllowREfund;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 235);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(228, 23);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmReturnInwards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 486);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmReturnInwards";
            this.Text = "Credit Note/Return Inwards";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReturnInwards_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmoRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCompanyCostCentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReturnInwards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomersWithInvoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCustomerOrderNosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectCustomerOrderNosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllowREfund.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton spSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblOrderTotal;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit glCostCenter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraEditors.GridLookUpEdit glCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit glOrderNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.MemoEdit mmoRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource spGetCompanyCostCentersBindingSource;
        private Class.DataSet.dsReturnInwards dsReturnInwards;
        private System.Windows.Forms.BindingSource spGetCustomersWithInvoicesBindingSource;
        private Class.DataSet.dsReturnInwardsTableAdapters.spGetCustomersWithInvoicesTableAdapter spGetCustomersWithInvoicesTableAdapter;
        private Class.DataSet.dsReturnInwardsTableAdapters.spGetCompanyCostCentersTableAdapter spGetCompanyCostCentersTableAdapter;
        private System.Windows.Forms.BindingSource spGetCustomerOrderNosBindingSource;
        private Class.DataSet.dsReturnInwardsTableAdapters.spGetCustomerOrderNosTableAdapter spGetCustomerOrderNosTableAdapter;
        private System.Windows.Forms.BindingSource spSelectCustomerOrderNosBindingSource;
        private Class.DataSet.dsReturnInwardsTableAdapters.spSelectCustomerOrderNosTableAdapter spSelectCustomerOrderNosTableAdapter;
        private DevExpress.XtraEditors.LabelControl lbAmountPaid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemdescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colExtendedCost;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyReturned;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyToReturned;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraEditors.CheckEdit chkAllowREfund;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}