using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for InvoiceReport
/// </summary>
public class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
	private XRLabel xrLabel4;
	private XRLabel xrLabel3;
	private XRLabel xrLabel2;
	private XRLabel xrLabel1;
	private XRLabel lbName;
	private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
	private XRLabel xrLabel7;
	private XRLabel xrLabel6;
	private XRLabel xrLabel5;
	private XRLabel xrLabel24;
	private GroupHeaderBand GroupHeader1;
	private GroupHeaderBand GroupHeader2;
	private XRPictureBox xrPictureBox1;
	private XRLabel xrLabel41;
	private XRLabel xrLabel42;
	private XRLabel xrLabel26;
	private XRLabel xrLabel35;
	private XRLine xrLine1;
	private XRLabel xrLabel40;
	private XRLabel xrLabel39;
	private XRLabel xrLabel38;
	private XRLabel xrLabel37;
	private XRLabel xrLabel36;
	private XRLabel xrLabel34;
	private XRLabel xrLabel33;
	private XRLabel xrLabel32;
	private XRLabel xrLabel31;
	private XRLabel xrLabel30;
	private XRLabel xrLabel29;
	private XRLabel xrLabel28;
	private XRLabel xrLabel27;
	private XRLabel xrLabel25;
	private XRLabel xrLabel8;
	private XRLabel xrLabel9;
	private XRLabel xrLabel10;
	private XRLabel xrLabel11;
	private XRLabel xrLabel12;
	private XRLabel xrLabel13;
	private XRLabel xrLabel14;
	private XRLabel xrLabel15;
	private XRLabel xrLabel16;
	private XRLabel xrLabel17;
	private XRLabel xrLabel18;
	private XRLabel xrLabel19;
	private XRLabel xrLabel20;
	private XRLabel xrLabel21;
	private XRLabel xrLabel22;
	private XRLabel xrLabel23;

	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public InvoiceReport()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}

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

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.components = new System.ComponentModel.Container();
			DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
			DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
			DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.AllColumns allColumns2 = new DevExpress.DataAccess.Sql.AllColumns();
			DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.AllColumns allColumns3 = new DevExpress.DataAccess.Sql.AllColumns();
			DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.AllColumns allColumns4 = new DevExpress.DataAccess.Sql.AllColumns();
			DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.AllColumns allColumns5 = new DevExpress.DataAccess.Sql.AllColumns();
			DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Join join5 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReport));
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.lbName = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.HeightF = 316.6667F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// TopMargin
			// 
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel24,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.lbName});
			this.TopMargin.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.TopMargin.HeightF = 166F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.StylePriority.UseFont = false;
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel4
			// 
			this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(509.375F, 116.543F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(29F, 20.54036F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.Text = "No:";
			// 
			// xrLabel3
			// 
			this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(509.375F, 79.37502F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(49.36132F, 20.54036F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.Text = "Series:";
			// 
			// xrLabel2
			// 
			this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(509.375F, 41.25001F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(55.83919F, 20.54036F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.Text = "Pattern:";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(245.8333F, 58.93338F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(40.06204F, 20.52498F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.Text = "Date:";
			// 
			// lbName
			// 
			this.lbName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
			this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.lbName.LocationFloat = new DevExpress.Utils.PointFloat(250.4168F, 10F);
			this.lbName.Multiline = true;
			this.lbName.Name = "lbName";
			this.lbName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbName.SizeF = new System.Drawing.SizeF(199.4999F, 32.84505F);
			this.lbName.StylePriority.UseFont = false;
			this.lbName.StylePriority.UseForeColor = false;
			this.lbName.StylePriority.UseTextAlignment = false;
			this.lbName.Text = "VAT INVOICE";
			this.lbName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 363F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "InvoiceEntities (EInvoice.Web)";
			this.sqlDataSource1.Name = "sqlDataSource1";
			table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"476\" />";
			table1.Name = "Invoices";
			allColumns1.Table = table1;
			table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"248\" />";
			table2.Name = "Items";
			allColumns2.Table = table2;
			table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"134\" />";
			table3.Name = "Patterns";
			allColumns3.Table = table3;
			table4.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"248\" />";
			table4.Name = "PurchaserCustomers";
			allColumns4.Table = table4;
			table5.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"362\" />";
			table5.Name = "Companies";
			allColumns5.Table = table5;
			selectQuery1.Columns.Add(allColumns1);
			selectQuery1.Columns.Add(allColumns2);
			selectQuery1.Columns.Add(allColumns3);
			selectQuery1.Columns.Add(allColumns4);
			selectQuery1.Columns.Add(allColumns5);
			selectQuery1.Name = "Invoices";
			relationColumnInfo1.NestedKeyColumn = "InvoiceId";
			relationColumnInfo1.ParentKeyColumn = "ID";
			join1.KeyColumns.Add(relationColumnInfo1);
			join1.Nested = table2;
			join1.Parent = table1;
			relationColumnInfo2.NestedKeyColumn = "ID";
			relationColumnInfo2.ParentKeyColumn = "PatternId";
			join2.KeyColumns.Add(relationColumnInfo2);
			join2.Nested = table3;
			join2.Parent = table1;
			relationColumnInfo3.NestedKeyColumn = "ID";
			relationColumnInfo3.ParentKeyColumn = "PaymentTypeID";
			join3.KeyColumns.Add(relationColumnInfo3);
			table6.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"96\" />";
			table6.Name = "PaymentMethods";
			join3.Nested = table6;
			join3.Parent = table1;
			relationColumnInfo4.NestedKeyColumn = "ID";
			relationColumnInfo4.ParentKeyColumn = "PurchaserCustomerID";
			join4.KeyColumns.Add(relationColumnInfo4);
			join4.Nested = table4;
			join4.Parent = table1;
			relationColumnInfo5.NestedKeyColumn = "ID";
			relationColumnInfo5.ParentKeyColumn = "CompanyId";
			join5.KeyColumns.Add(relationColumnInfo5);
			join5.Nested = table5;
			join5.Parent = table1;
			selectQuery1.Relations.Add(join1);
			selectQuery1.Relations.Add(join2);
			selectQuery1.Relations.Add(join3);
			selectQuery1.Relations.Add(join4);
			selectQuery1.Relations.Add(join5);
			selectQuery1.Tables.Add(table1);
			selectQuery1.Tables.Add(table2);
			selectQuery1.Tables.Add(table3);
			selectQuery1.Tables.Add(table6);
			selectQuery1.Tables.Add(table4);
			selectQuery1.Tables.Add(table5);
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// xrLabel5
			// 
			this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Invoices].[ReleaseDate]")});
			this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(299.9167F, 56.45836F);
			this.xrLabel5.Multiline = true;
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(150F, 23F);
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "xrLabel5";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel5.TextFormatString = "{0:d}";
			// 
			// xrLabel6
			// 
			this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[No]")});
			this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(577.0001F, 114.0834F);
			this.xrLabel6.Multiline = true;
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel6.StylePriority.UseFont = false;
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "xrLabel6";
			this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel7
			// 
			this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Series]")});
			this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(577F, 76.90001F);
			this.xrLabel7.Multiline = true;
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel7.StylePriority.UseFont = false;
			this.xrLabel7.StylePriority.UseTextAlignment = false;
			this.xrLabel7.Text = "p";
			this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel24
			// 
			this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ID]")});
			this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(577F, 38.79037F);
			this.xrLabel24.Multiline = true;
			this.xrLabel24.Name = "xrLabel24";
			this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel24.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel24.StylePriority.UseFont = false;
			this.xrLabel24.StylePriority.UseTextAlignment = false;
			this.xrLabel24.Text = "xrLabel24";
			this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel41,
            this.xrLabel42,
            this.xrLabel26,
            this.xrLabel35,
            this.xrLine1,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel25});
			this.GroupHeader1.HeightF = 400.2083F;
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// GroupHeader2
			// 
			this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel23});
			this.GroupHeader2.HeightF = 287.7084F;
			this.GroupHeader2.Level = 1;
			this.GroupHeader2.Name = "GroupHeader2";
			// 
			// xrLabel40
			// 
			this.xrLabel40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BankName]")});
			this.xrLabel40.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(497.7082F, 298.0417F);
			this.xrLabel40.Multiline = true;
			this.xrLabel40.Name = "xrLabel40";
			this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel40.SizeF = new System.Drawing.SizeF(151.0417F, 23F);
			this.xrLabel40.StylePriority.UseFont = false;
			this.xrLabel40.StylePriority.UseTextAlignment = false;
			this.xrLabel40.Text = "xrLabel23";
			this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel39
			// 
			this.xrLabel39.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BankAccountID]")});
			this.xrLabel39.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(199.7916F, 298.0417F);
			this.xrLabel39.Multiline = true;
			this.xrLabel39.Name = "xrLabel39";
			this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel39.SizeF = new System.Drawing.SizeF(187.5F, 23F);
			this.xrLabel39.StylePriority.UseFont = false;
			this.xrLabel39.StylePriority.UseTextAlignment = false;
			this.xrLabel39.Text = "xrLabel22";
			this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel38
			// 
			this.xrLabel38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Fax]")});
			this.xrLabel38.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(497.7083F, 252.2916F);
			this.xrLabel38.Multiline = true;
			this.xrLabel38.Name = "xrLabel38";
			this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel38.SizeF = new System.Drawing.SizeF(151.0417F, 23F);
			this.xrLabel38.StylePriority.UseFont = false;
			this.xrLabel38.StylePriority.UseTextAlignment = false;
			this.xrLabel38.Text = "xrLabel21";
			this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel37
			// 
			this.xrLabel37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")});
			this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(199.7916F, 252.2916F);
			this.xrLabel37.Multiline = true;
			this.xrLabel37.Name = "xrLabel37";
			this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel37.SizeF = new System.Drawing.SizeF(187.5F, 23F);
			this.xrLabel37.StylePriority.UseFont = false;
			this.xrLabel37.StylePriority.UseTextAlignment = false;
			this.xrLabel37.Text = "xrLabel20";
			this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel36
			// 
			this.xrLabel36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")});
			this.xrLabel36.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(199.7916F, 155.1833F);
			this.xrLabel36.Multiline = true;
			this.xrLabel36.Name = "xrLabel36";
			this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel36.SizeF = new System.Drawing.SizeF(448.9583F, 23.00002F);
			this.xrLabel36.StylePriority.UseFont = false;
			this.xrLabel36.StylePriority.UseTextAlignment = false;
			this.xrLabel36.Text = "xrLabel19";
			this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel34
			// 
			this.xrLabel34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
			this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(199.7916F, 203.3333F);
			this.xrLabel34.Multiline = true;
			this.xrLabel34.Name = "xrLabel34";
			this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel34.SizeF = new System.Drawing.SizeF(448.9583F, 23F);
			this.xrLabel34.StylePriority.UseFont = false;
			this.xrLabel34.StylePriority.UseTextAlignment = false;
			this.xrLabel34.Text = "xrLabel17";
			this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel33
			// 
			this.xrLabel33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Purchaser]")});
			this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(199.7918F, 17.70833F);
			this.xrLabel33.Multiline = true;
			this.xrLabel33.Name = "xrLabel33";
			this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel33.SizeF = new System.Drawing.SizeF(448.9583F, 23F);
			this.xrLabel33.StylePriority.UseFont = false;
			this.xrLabel33.StylePriority.UseTextAlignment = false;
			this.xrLabel33.Text = "p";
			this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel32
			// 
			this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(399.5833F, 299.8093F);
			this.xrLabel32.Multiline = true;
			this.xrLabel32.Name = "xrLabel32";
			this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel32.SizeF = new System.Drawing.SizeF(84.00326F, 21.2324F);
			this.xrLabel32.StylePriority.UseFont = false;
			this.xrLabel32.Text = "Bank name:\r\n";
			// 
			// xrLabel31
			// 
			this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(48.95827F, 300.5166F);
			this.xrLabel31.Multiline = true;
			this.xrLabel31.Name = "xrLabel31";
			this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel31.SizeF = new System.Drawing.SizeF(99.72094F, 20.52498F);
			this.xrLabel31.StylePriority.UseFont = false;
			this.xrLabel31.Text = "Bank account:";
			// 
			// xrLabel30
			// 
			this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(399.5833F, 254.7666F);
			this.xrLabel30.Multiline = true;
			this.xrLabel30.Name = "xrLabel30";
			this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel30.SizeF = new System.Drawing.SizeF(33.60584F, 20.52498F);
			this.xrLabel30.StylePriority.UseFont = false;
			this.xrLabel30.Text = "Fax:";
			// 
			// xrLabel29
			// 
			this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(48.95827F, 254.7666F);
			this.xrLabel29.Multiline = true;
			this.xrLabel29.Name = "xrLabel29";
			this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel29.SizeF = new System.Drawing.SizeF(50.25861F, 20.52498F);
			this.xrLabel29.StylePriority.UseFont = false;
			this.xrLabel29.Text = "Phone:";
			// 
			// xrLabel28
			// 
			this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(48.95827F, 205.8083F);
			this.xrLabel28.Multiline = true;
			this.xrLabel28.Name = "xrLabel28";
			this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel28.SizeF = new System.Drawing.SizeF(48.39656F, 20.52498F);
			this.xrLabel28.StylePriority.UseFont = false;
			this.xrLabel28.Text = "Email:";
			// 
			// xrLabel27
			// 
			this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(48.95827F, 155.1833F);
			this.xrLabel27.Multiline = true;
			this.xrLabel27.Name = "xrLabel27";
			this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel27.SizeF = new System.Drawing.SizeF(63.20354F, 20.52498F);
			this.xrLabel27.StylePriority.UseFont = false;
			this.xrLabel27.Text = "Address:";
			// 
			// xrLabel25
			// 
			this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(48.95846F, 20.18331F);
			this.xrLabel25.Multiline = true;
			this.xrLabel25.Name = "xrLabel25";
			this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel25.SizeF = new System.Drawing.SizeF(74.28642F, 20.52498F);
			this.xrLabel25.StylePriority.UseFont = false;
			this.xrLabel25.Text = "Purchaser:";
			// 
			// xrLabel8
			// 
			this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 2.475006F);
			this.xrLabel8.Multiline = true;
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(117.3088F, 20.52498F);
			this.xrLabel8.StylePriority.UseFont = false;
			this.xrLabel8.Text = "Company Name:";
			// 
			// xrLabel9
			// 
			this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 52.05834F);
			this.xrLabel9.Multiline = true;
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(70.1151F, 20.52498F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.Text = "Tax code:";
			// 
			// xrLabel10
			// 
			this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 103.1F);
			this.xrLabel10.Multiline = true;
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(63.20354F, 20.52498F);
			this.xrLabel10.StylePriority.UseFont = false;
			this.xrLabel10.Text = "Address:";
			// 
			// xrLabel11
			// 
			this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 153.725F);
			this.xrLabel11.Multiline = true;
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(48.39656F, 20.52498F);
			this.xrLabel11.StylePriority.UseFont = false;
			this.xrLabel11.Text = "Email:";
			// 
			// xrLabel12
			// 
			this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 202.6833F);
			this.xrLabel12.Multiline = true;
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(50.25861F, 20.52498F);
			this.xrLabel12.StylePriority.UseFont = false;
			this.xrLabel12.Text = "Phone:";
			// 
			// xrLabel13
			// 
			this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(399.5834F, 202.6833F);
			this.xrLabel13.Multiline = true;
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(33.60584F, 20.52498F);
			this.xrLabel13.StylePriority.UseFont = false;
			this.xrLabel13.Text = "Fax:";
			// 
			// xrLabel14
			// 
			this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 248.4334F);
			this.xrLabel14.Multiline = true;
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(99.72094F, 20.52498F);
			this.xrLabel14.StylePriority.UseFont = false;
			this.xrLabel14.Text = "Bank account:";
			// 
			// xrLabel15
			// 
			this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(399.5834F, 247.726F);
			this.xrLabel15.Multiline = true;
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(84.00326F, 21.2324F);
			this.xrLabel15.StylePriority.UseFont = false;
			this.xrLabel15.Text = "Bank name:\r\n";
			// 
			// xrLabel16
			// 
			this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Name]")});
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(199.7917F, 0F);
			this.xrLabel16.Multiline = true;
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(448.9583F, 23F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "xrLabel16";
			this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel17
			// 
			this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Email]")});
			this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(199.7917F, 151.25F);
			this.xrLabel17.Multiline = true;
			this.xrLabel17.Name = "xrLabel17";
			this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel17.SizeF = new System.Drawing.SizeF(448.9583F, 23F);
			this.xrLabel17.StylePriority.UseFont = false;
			this.xrLabel17.StylePriority.UseTextAlignment = false;
			this.xrLabel17.Text = "xrLabel17";
			this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel18
			// 
			this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_TaxCode]")});
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(199.7917F, 52.05834F);
			this.xrLabel18.Multiline = true;
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(448.9584F, 23F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "xrLabel18";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel19
			// 
			this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Address]")});
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(199.7917F, 103.1F);
			this.xrLabel19.Multiline = true;
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(448.9583F, 23.00002F);
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.StylePriority.UseTextAlignment = false;
			this.xrLabel19.Text = "xrLabel19";
			this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel20
			// 
			this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Phone]")});
			this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(199.7917F, 200.2083F);
			this.xrLabel20.Multiline = true;
			this.xrLabel20.Name = "xrLabel20";
			this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel20.SizeF = new System.Drawing.SizeF(187.5F, 23F);
			this.xrLabel20.StylePriority.UseFont = false;
			this.xrLabel20.StylePriority.UseTextAlignment = false;
			this.xrLabel20.Text = "xrLabel20";
			this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel21
			// 
			this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Fax]")});
			this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(497.7083F, 200.2083F);
			this.xrLabel21.Multiline = true;
			this.xrLabel21.Name = "xrLabel21";
			this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel21.SizeF = new System.Drawing.SizeF(151.0417F, 23F);
			this.xrLabel21.StylePriority.UseFont = false;
			this.xrLabel21.StylePriority.UseTextAlignment = false;
			this.xrLabel21.Text = "xrLabel21";
			this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel22
			// 
			this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BankAccountID]")});
			this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(199.7917F, 245.9584F);
			this.xrLabel22.Multiline = true;
			this.xrLabel22.Name = "xrLabel22";
			this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel22.SizeF = new System.Drawing.SizeF(187.5F, 23F);
			this.xrLabel22.StylePriority.UseFont = false;
			this.xrLabel22.StylePriority.UseTextAlignment = false;
			this.xrLabel22.Text = "xrLabel22";
			this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel23
			// 
			this.xrLabel23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BankName]")});
			this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(497.7083F, 245.9584F);
			this.xrLabel23.Multiline = true;
			this.xrLabel23.Name = "xrLabel23";
			this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel23.SizeF = new System.Drawing.SizeF(151.0417F, 23F);
			this.xrLabel23.StylePriority.UseFont = false;
			this.xrLabel23.StylePriority.UseTextAlignment = false;
			this.xrLabel23.Text = "xrLabel23";
			this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLine1
			// 
			this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 0F);
			this.xrLine1.Name = "xrLine1";
			this.xrLine1.SizeF = new System.Drawing.SizeF(618.75F, 2F);
			// 
			// xrLabel26
			// 
			this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(48.95846F, 114.5583F);
			this.xrLabel26.Multiline = true;
			this.xrLabel26.Name = "xrLabel26";
			this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel26.SizeF = new System.Drawing.SizeF(70.1151F, 20.52498F);
			this.xrLabel26.StylePriority.UseFont = false;
			this.xrLabel26.Text = "Tax code:";
			// 
			// xrLabel35
			// 
			this.xrLabel35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TaxCode]")});
			this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(199.7915F, 112.0832F);
			this.xrLabel35.Multiline = true;
			this.xrLabel35.Name = "xrLabel35";
			this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel35.SizeF = new System.Drawing.SizeF(448.9584F, 23F);
			this.xrLabel35.StylePriority.UseFont = false;
			this.xrLabel35.StylePriority.UseTextAlignment = false;
			this.xrLabel35.Text = "xrLabel18";
			this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel41
			// 
			this.xrLabel41.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(48.95811F, 66.64162F);
			this.xrLabel41.Multiline = true;
			this.xrLabel41.Name = "xrLabel41";
			this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel41.SizeF = new System.Drawing.SizeF(112.6577F, 20.52498F);
			this.xrLabel41.StylePriority.UseFont = false;
			this.xrLabel41.Text = "Enterprise name";
			// 
			// xrLabel42
			// 
			this.xrLabel42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EnterpriseName]")});
			this.xrLabel42.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(199.7915F, 64.16667F);
			this.xrLabel42.Multiline = true;
			this.xrLabel42.Name = "xrLabel42";
			this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel42.SizeF = new System.Drawing.SizeF(448.9583F, 23F);
			this.xrLabel42.StylePriority.UseFont = false;
			this.xrLabel42.StylePriority.UseTextAlignment = false;
			this.xrLabel42.Text = "p";
			this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(22.93663F, 19.84505F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(138.6792F, 117.2383F);
			this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
			// 
			// InvoiceReport
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupHeader2});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
			this.DataMember = "Invoices";
			this.DataSource = this.sqlDataSource1;
			this.Margins = new System.Drawing.Printing.Margins(69, 70, 166, 363);
			this.PageHeight = 1169;
			this.PageWidth = 827;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Version = "18.1";
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
}
