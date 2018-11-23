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
	private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
	private GroupHeaderBand GroupHeader1;
	private GroupHeaderBand GroupHeader2;
	private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
	private BackgroundWorker backgroundWorker1;
	private XRTable xrTable1;
	private XRTableRow xrTableRow1;
	private XRTableCell xrTableCell12;
	private XRTableCell xrTableCell1;
	private XRTableCell xrTableCell2;
	private XRTableCell xrTableCell3;
	private XRTableCell xrTableCell4;
	private XRTableCell xrTableCell5;
	private XRLine xrLine2;
	private XRLabel xrLabel24;
	private XRLabel xrLabel43;
	private XRPictureBox xrPictureBox1;
	private XRLabel xrLabel7;
	private XRLabel xrLabel6;
	private XRLabel xrLabel5;
	private XRLabel xrLabel4;
	private XRLabel xrLabel3;
	private XRLabel xrLabel2;
	private XRLabel xrLabel1;
	private XRLabel lbName;
	private XRTable xrTable2;
	private XRTableRow xrTableRow2;
	private XRTableCell xrTableCell11;
	private XRTableCell xrTableCell6;
	private XRTableCell xrTableCell7;
	private XRTableCell xrTableCell8;
	private XRTableCell xrTableCell9;
	private XRTableCell xrTableCell10;
	private XRLine xrLine3;
	private XRLabel xrLabel32;
	private XRLabel xrLabel39;
	private XRLabel xrLabel31;
	private XRLabel xrLabel41;
	private XRLabel xrLabel42;
	private XRLabel xrLabel26;
	private XRLabel xrLabel35;
	private XRLine xrLine1;
	private XRLabel xrLabel38;
	private XRLabel xrLabel37;
	private XRLabel xrLabel36;
	private XRLabel xrLabel34;
	private XRLabel xrLabel33;
	private XRLabel xrLabel30;
	private XRLabel xrLabel29;
	private XRLabel xrLabel28;
	private XRLabel xrLabel27;
	private XRLabel xrLabel25;
	private XRLabel xrLabel14;
	private XRLabel xrLabel20;
	private XRLabel xrLabel19;
	private XRLabel xrLabel18;
	private XRLabel xrLabel17;
	private XRLabel xrLabel16;
	private XRLabel xrLabel13;
	private XRLabel xrLabel12;
	private XRLabel xrLabel11;
	private XRLabel xrLabel10;
	private XRLabel xrLabel9;
	private XRLabel xrLabel21;
	private XRCrossBandBox xrCrossBandBox1;
	private ReportFooterBand ReportFooter;

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
			DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column29 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression29 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column30 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression30 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column31 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression31 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column32 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression32 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column33 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression33 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column34 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression34 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column35 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression35 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column36 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression36 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column37 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression37 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column38 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression38 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column39 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression39 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column40 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression40 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column41 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression41 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column42 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression42 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Column column43 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression43 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Join join5 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReport));
			DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
			this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.lbName = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.Detail.HeightF = 25F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// TopMargin
			// 
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLabel24,
            this.xrLabel43,
            this.xrPictureBox1,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.lbName});
			this.TopMargin.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.TopMargin.ForeColor = System.Drawing.Color.Empty;
			this.TopMargin.HeightF = 178F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.StylePriority.UseFont = false;
			this.TopMargin.StylePriority.UseForeColor = false;
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 50F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "InvoiceEntities (EInvoice.Web)";
			this.sqlDataSource1.Name = "sqlDataSource1";
			table1.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"248\" />";
			table1.Name = "PurchaserCustomers";
			allColumns1.Table = table1;
			columnExpression1.ColumnName = "Series";
			table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"476\" />";
			table2.Name = "Invoices";
			columnExpression1.Table = table2;
			column1.Expression = columnExpression1;
			columnExpression2.ColumnName = "No";
			columnExpression2.Table = table2;
			column2.Expression = columnExpression2;
			columnExpression3.ColumnName = "PurchaserCustomerID";
			columnExpression3.Table = table2;
			column3.Expression = columnExpression3;
			columnExpression4.ColumnName = "Tax";
			columnExpression4.Table = table2;
			column4.Expression = columnExpression4;
			columnExpression5.ColumnName = "TaxAmount";
			columnExpression5.Table = table2;
			column5.Expression = columnExpression5;
			columnExpression6.ColumnName = "SubTotalAmount";
			columnExpression6.Table = table2;
			column6.Expression = columnExpression6;
			columnExpression7.ColumnName = "GrandTotalAmount";
			columnExpression7.Table = table2;
			column7.Expression = columnExpression7;
			columnExpression8.ColumnName = "CreatedDate";
			columnExpression8.Table = table2;
			column8.Expression = columnExpression8;
			columnExpression9.ColumnName = "ReleaseDate";
			columnExpression9.Table = table2;
			column9.Expression = columnExpression9;
			columnExpression10.ColumnName = "Status";
			columnExpression10.Table = table2;
			column10.Expression = columnExpression10;
			columnExpression11.ColumnName = "Quantity";
			table3.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"248\" />";
			table3.Name = "Items";
			columnExpression11.Table = table3;
			column11.Expression = columnExpression11;
			columnExpression12.ColumnName = "Discount";
			columnExpression12.Table = table3;
			column12.Expression = columnExpression12;
			columnExpression13.ColumnName = "DiscountAmount";
			columnExpression13.Table = table3;
			column13.Expression = columnExpression13;
			columnExpression14.ColumnName = "TotalAmount";
			columnExpression14.Table = table3;
			column14.Expression = columnExpression14;
			columnExpression15.ColumnName = "ItemName";
			columnExpression15.Table = table3;
			column15.Expression = columnExpression15;
			columnExpression16.ColumnName = "ItemPrice";
			columnExpression16.Table = table3;
			column16.Expression = columnExpression16;
			columnExpression17.ColumnName = "UnitName";
			columnExpression17.Table = table3;
			column17.Expression = columnExpression17;
			column18.Alias = "Patterns_Name";
			columnExpression18.ColumnName = "Name";
			table4.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"134\" />";
			table4.Name = "Patterns";
			columnExpression18.Table = table4;
			column18.Expression = columnExpression18;
			column19.Alias = "PaymentMethods_Name";
			columnExpression19.ColumnName = "Name";
			table5.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"96\" />";
			table5.Name = "PaymentMethods";
			columnExpression19.Table = table5;
			column19.Expression = columnExpression19;
			columnExpression20.ColumnName = "Code";
			columnExpression20.Table = table1;
			column20.Expression = columnExpression20;
			columnExpression21.ColumnName = "TaxCode";
			columnExpression21.Table = table1;
			column21.Expression = columnExpression21;
			columnExpression22.ColumnName = "EnterpriseName";
			columnExpression22.Table = table1;
			column22.Expression = columnExpression22;
			columnExpression23.ColumnName = "Email";
			columnExpression23.Table = table1;
			column23.Expression = columnExpression23;
			columnExpression24.ColumnName = "Address";
			columnExpression24.Table = table1;
			column24.Expression = columnExpression24;
			columnExpression25.ColumnName = "Phone";
			columnExpression25.Table = table1;
			column25.Expression = columnExpression25;
			columnExpression26.ColumnName = "Fax";
			columnExpression26.Table = table1;
			column26.Expression = columnExpression26;
			columnExpression27.ColumnName = "LegalPresenter";
			columnExpression27.Table = table1;
			column27.Expression = columnExpression27;
			column28.Alias = "Companies_TaxCode";
			columnExpression28.ColumnName = "TaxCode";
			table6.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"362\" />";
			table6.Name = "Companies";
			columnExpression28.Table = table6;
			column28.Expression = columnExpression28;
			column29.Alias = "Companies_Name";
			columnExpression29.ColumnName = "Name";
			columnExpression29.Table = table6;
			column29.Expression = columnExpression29;
			column30.Alias = "Companies_Address";
			columnExpression30.ColumnName = "Address";
			columnExpression30.Table = table6;
			column30.Expression = columnExpression30;
			column31.Alias = "Companies_Phone";
			columnExpression31.ColumnName = "Phone";
			columnExpression31.Table = table6;
			column31.Expression = columnExpression31;
			column32.Alias = "Companies_Fax";
			columnExpression32.ColumnName = "Fax";
			columnExpression32.Table = table6;
			column32.Expression = columnExpression32;
			columnExpression33.ColumnName = "Website";
			columnExpression33.Table = table6;
			column33.Expression = columnExpression33;
			column34.Alias = "Companies_LegalPresenter";
			columnExpression34.ColumnName = "LegalPresenter";
			columnExpression34.Table = table6;
			column34.Expression = columnExpression34;
			column35.Alias = "Companies_Email";
			columnExpression35.ColumnName = "Email";
			columnExpression35.Table = table6;
			column35.Expression = columnExpression35;
			column36.Alias = "Companies_BankAccountId";
			columnExpression36.ColumnName = "BankAccountID";
			columnExpression36.Table = table6;
			column36.Expression = columnExpression36;
			column37.Alias = "Companies_AccountHolder";
			columnExpression37.ColumnName = "AccountHolder";
			columnExpression37.Table = table6;
			column37.Expression = columnExpression37;
			column38.Alias = "Companies_BankName";
			columnExpression38.ColumnName = "BankName";
			columnExpression38.Table = table6;
			column38.Expression = columnExpression38;
			columnExpression39.ColumnName = "Agency";
			columnExpression39.Table = table6;
			column39.Expression = columnExpression39;
			columnExpression40.ColumnName = "AccountID";
			columnExpression40.Table = table6;
			column40.Expression = columnExpression40;
			columnExpression41.ColumnName = "Note";
			columnExpression41.Table = table6;
			column41.Expression = columnExpression41;
			column42.Alias = "PurchaserCustomers_Purchaser";
			columnExpression42.ColumnName = "Purchaser";
			columnExpression42.Table = table1;
			column42.Expression = columnExpression42;
			columnExpression43.ColumnName = "ID";
			columnExpression43.Table = table2;
			column43.Expression = columnExpression43;
			selectQuery1.Columns.Add(allColumns1);
			selectQuery1.Columns.Add(column1);
			selectQuery1.Columns.Add(column2);
			selectQuery1.Columns.Add(column3);
			selectQuery1.Columns.Add(column4);
			selectQuery1.Columns.Add(column5);
			selectQuery1.Columns.Add(column6);
			selectQuery1.Columns.Add(column7);
			selectQuery1.Columns.Add(column8);
			selectQuery1.Columns.Add(column9);
			selectQuery1.Columns.Add(column10);
			selectQuery1.Columns.Add(column11);
			selectQuery1.Columns.Add(column12);
			selectQuery1.Columns.Add(column13);
			selectQuery1.Columns.Add(column14);
			selectQuery1.Columns.Add(column15);
			selectQuery1.Columns.Add(column16);
			selectQuery1.Columns.Add(column17);
			selectQuery1.Columns.Add(column18);
			selectQuery1.Columns.Add(column19);
			selectQuery1.Columns.Add(column20);
			selectQuery1.Columns.Add(column21);
			selectQuery1.Columns.Add(column22);
			selectQuery1.Columns.Add(column23);
			selectQuery1.Columns.Add(column24);
			selectQuery1.Columns.Add(column25);
			selectQuery1.Columns.Add(column26);
			selectQuery1.Columns.Add(column27);
			selectQuery1.Columns.Add(column28);
			selectQuery1.Columns.Add(column29);
			selectQuery1.Columns.Add(column30);
			selectQuery1.Columns.Add(column31);
			selectQuery1.Columns.Add(column32);
			selectQuery1.Columns.Add(column33);
			selectQuery1.Columns.Add(column34);
			selectQuery1.Columns.Add(column35);
			selectQuery1.Columns.Add(column36);
			selectQuery1.Columns.Add(column37);
			selectQuery1.Columns.Add(column38);
			selectQuery1.Columns.Add(column39);
			selectQuery1.Columns.Add(column40);
			selectQuery1.Columns.Add(column41);
			selectQuery1.Columns.Add(column42);
			selectQuery1.Columns.Add(column43);
			selectQuery1.Name = "Invoices";
			relationColumnInfo1.NestedKeyColumn = "InvoiceId";
			relationColumnInfo1.ParentKeyColumn = "ID";
			join1.KeyColumns.Add(relationColumnInfo1);
			join1.Nested = table3;
			join1.Parent = table2;
			relationColumnInfo2.NestedKeyColumn = "ID";
			relationColumnInfo2.ParentKeyColumn = "PatternId";
			join2.KeyColumns.Add(relationColumnInfo2);
			join2.Nested = table4;
			join2.Parent = table2;
			relationColumnInfo3.NestedKeyColumn = "ID";
			relationColumnInfo3.ParentKeyColumn = "PaymentTypeID";
			join3.KeyColumns.Add(relationColumnInfo3);
			join3.Nested = table5;
			join3.Parent = table2;
			relationColumnInfo4.NestedKeyColumn = "ID";
			relationColumnInfo4.ParentKeyColumn = "PurchaserCustomerID";
			join4.KeyColumns.Add(relationColumnInfo4);
			join4.Nested = table1;
			join4.Parent = table2;
			relationColumnInfo5.NestedKeyColumn = "ID";
			relationColumnInfo5.ParentKeyColumn = "CompanyId";
			join5.KeyColumns.Add(relationColumnInfo5);
			join5.Nested = table6;
			join5.Parent = table2;
			selectQuery1.Relations.Add(join1);
			selectQuery1.Relations.Add(join2);
			selectQuery1.Relations.Add(join3);
			selectQuery1.Relations.Add(join4);
			selectQuery1.Relations.Add(join5);
			selectQuery1.Tables.Add(table2);
			selectQuery1.Tables.Add(table3);
			selectQuery1.Tables.Add(table4);
			selectQuery1.Tables.Add(table5);
			selectQuery1.Tables.Add(table1);
			selectQuery1.Tables.Add(table6);
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrLine3,
            this.xrLabel32,
            this.xrLabel39,
            this.xrLabel31,
            this.xrLabel41,
            this.xrLabel42,
            this.xrLabel26,
            this.xrLabel35,
            this.xrLine1,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel25});
			this.GroupHeader1.HeightF = 232.5F;
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// GroupHeader2
			// 
			this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel14,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel21});
			this.GroupHeader2.HeightF = 128.4167F;
			this.GroupHeader2.Level = 1;
			this.GroupHeader2.Name = "GroupHeader2";
			// 
			// excelDataSource1
			// 
			this.excelDataSource1.Name = "excelDataSource1";
			// 
			// xrTableCell10
			// 
			this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell10.Multiline = true;
			this.xrTableCell10.Name = "xrTableCell10";
			this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell10.StylePriority.UseFont = false;
			this.xrTableCell10.StylePriority.UsePadding = false;
			this.xrTableCell10.Text = "Total";
			this.xrTableCell10.Weight = 1.4299420185793843D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell9.Multiline = true;
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell9.StylePriority.UseFont = false;
			this.xrTableCell9.StylePriority.UsePadding = false;
			this.xrTableCell9.Text = "Quantity";
			this.xrTableCell9.Weight = 1.1375562548753271D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell8.Multiline = true;
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell8.StylePriority.UseFont = false;
			this.xrTableCell8.StylePriority.UseTextAlignment = false;
			this.xrTableCell8.Text = "Unit";
			this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell8.Weight = 0.96645217213272983D;
			// 
			// xrTableCell7
			// 
			this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell7.Multiline = true;
			this.xrTableCell7.Name = "xrTableCell7";
			this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell7.StylePriority.UseFont = false;
			this.xrTableCell7.Text = "Price";
			this.xrTableCell7.Weight = 1.2884081096514986D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell6.Multiline = true;
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell6.StylePriority.UseFont = false;
			this.xrTableCell6.Text = "Product Name";
			this.xrTableCell6.Weight = 4.6536193343609771D;
			// 
			// xrTableCell11
			// 
			this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell11.Multiline = true;
			this.xrTableCell11.Name = "xrTableCell11";
			this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell11.StylePriority.UseFont = false;
			this.xrTableCell11.StylePriority.UsePadding = false;
			this.xrTableCell11.Text = "No.";
			this.xrTableCell11.Weight = 0.533232500334059D;
			// 
			// xrTableRow2
			// 
			this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10});
			this.xrTableRow2.Name = "xrTableRow2";
			this.xrTableRow2.Weight = 1D;
			// 
			// xrTable2
			// 
			this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(2.08334F, 207.5F);
			this.xrTable2.Name = "xrTable2";
			this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.xrTable2.SizeF = new System.Drawing.SizeF(723.8333F, 25F);
			this.xrTable2.StylePriority.UseBorders = false;
			this.xrTable2.StylePriority.UseTextAlignment = false;
			this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLine3
			// 
			this.xrLine3.BackColor = System.Drawing.Color.Empty;
			this.xrLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 190.2083F);
			this.xrLine3.Name = "xrLine3";
			this.xrLine3.SizeF = new System.Drawing.SizeF(722.8333F, 6.25F);
			this.xrLine3.StylePriority.UseBackColor = false;
			this.xrLine3.StylePriority.UseForeColor = false;
			// 
			// xrLabel32
			// 
			this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 161.0001F);
			this.xrLabel32.Multiline = true;
			this.xrLabel32.Name = "xrLabel32";
			this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel32.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel32.StylePriority.UseFont = false;
			this.xrLabel32.StylePriority.UseForeColor = false;
			this.xrLabel32.StylePriority.UseTextAlignment = false;
			this.xrLabel32.Text = "Payment Type:";
			this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel39
			// 
			this.xrLabel39.BackColor = System.Drawing.Color.Empty;
			this.xrLabel39.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentMethods_Name]")});
			this.xrLabel39.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(119.7914F, 161.0001F);
			this.xrLabel39.Multiline = true;
			this.xrLabel39.Name = "xrLabel39";
			this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel39.SizeF = new System.Drawing.SizeF(187.5F, 23F);
			this.xrLabel39.StylePriority.UseBackColor = false;
			this.xrLabel39.StylePriority.UseFont = false;
			this.xrLabel39.StylePriority.UseForeColor = false;
			this.xrLabel39.StylePriority.UseTextAlignment = false;
			this.xrLabel39.Text = "xrLabel20";
			this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel31
			// 
			this.xrLabel31.BackColor = System.Drawing.Color.Empty;
			this.xrLabel31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomerID]")});
			this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(602.0896F, 161.0001F);
			this.xrLabel31.Multiline = true;
			this.xrLabel31.Name = "xrLabel31";
			this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel31.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel31.StylePriority.UseBackColor = false;
			this.xrLabel31.StylePriority.UseFont = false;
			this.xrLabel31.StylePriority.UseForeColor = false;
			this.xrLabel31.Text = "xrLabel31";
			this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel41
			// 
			this.xrLabel41.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 46.00003F);
			this.xrLabel41.Multiline = true;
			this.xrLabel41.Name = "xrLabel41";
			this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel41.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel41.StylePriority.UseFont = false;
			this.xrLabel41.StylePriority.UseForeColor = false;
			this.xrLabel41.StylePriority.UseTextAlignment = false;
			this.xrLabel41.Text = "Enterprise:";
			this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel42
			// 
			this.xrLabel42.BackColor = System.Drawing.Color.Empty;
			this.xrLabel42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_EnterpriseName]")});
			this.xrLabel42.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(119.791F, 46.00003F);
			this.xrLabel42.Multiline = true;
			this.xrLabel42.Name = "xrLabel42";
			this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel42.SizeF = new System.Drawing.SizeF(597.209F, 23F);
			this.xrLabel42.StylePriority.UseBackColor = false;
			this.xrLabel42.StylePriority.UseFont = false;
			this.xrLabel42.StylePriority.UseForeColor = false;
			this.xrLabel42.StylePriority.UseTextAlignment = false;
			this.xrLabel42.Text = "p";
			this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel26
			// 
			this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 69.00005F);
			this.xrLabel26.Multiline = true;
			this.xrLabel26.Name = "xrLabel26";
			this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel26.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel26.StylePriority.UseFont = false;
			this.xrLabel26.StylePriority.UseForeColor = false;
			this.xrLabel26.StylePriority.UseTextAlignment = false;
			this.xrLabel26.Text = "Tax code:";
			this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel35
			// 
			this.xrLabel35.BackColor = System.Drawing.Color.Empty;
			this.xrLabel35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_TaxCode]")});
			this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(119.791F, 69.00005F);
			this.xrLabel35.Multiline = true;
			this.xrLabel35.Name = "xrLabel35";
			this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel35.SizeF = new System.Drawing.SizeF(597.209F, 23F);
			this.xrLabel35.StylePriority.UseBackColor = false;
			this.xrLabel35.StylePriority.UseFont = false;
			this.xrLabel35.StylePriority.UseForeColor = false;
			this.xrLabel35.StylePriority.UseTextAlignment = false;
			this.xrLabel35.Text = "xrLabel18";
			this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLine1
			// 
			this.xrLine1.BackColor = System.Drawing.Color.Empty;
			this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(4.166603F, 9.999974F);
			this.xrLine1.Name = "xrLine1";
			this.xrLine1.SizeF = new System.Drawing.SizeF(720.75F, 13.00004F);
			this.xrLine1.StylePriority.UseBackColor = false;
			this.xrLine1.StylePriority.UseForeColor = false;
			// 
			// xrLabel38
			// 
			this.xrLabel38.BackColor = System.Drawing.Color.Empty;
			this.xrLabel38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Fax]")});
			this.xrLabel38.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(413.2137F, 161.0001F);
			this.xrLabel38.Multiline = true;
			this.xrLabel38.Name = "xrLabel38";
			this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel38.SizeF = new System.Drawing.SizeF(188.8759F, 23F);
			this.xrLabel38.StylePriority.UseBackColor = false;
			this.xrLabel38.StylePriority.UseFont = false;
			this.xrLabel38.StylePriority.UseForeColor = false;
			this.xrLabel38.StylePriority.UseTextAlignment = false;
			this.xrLabel38.Text = "xrLabel21";
			this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel37
			// 
			this.xrLabel37.BackColor = System.Drawing.Color.Empty;
			this.xrLabel37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Phone]")});
			this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(119.7912F, 138.0001F);
			this.xrLabel37.Multiline = true;
			this.xrLabel37.Name = "xrLabel37";
			this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel37.SizeF = new System.Drawing.SizeF(187.5F, 23F);
			this.xrLabel37.StylePriority.UseBackColor = false;
			this.xrLabel37.StylePriority.UseFont = false;
			this.xrLabel37.StylePriority.UseForeColor = false;
			this.xrLabel37.StylePriority.UseTextAlignment = false;
			this.xrLabel37.Text = "xrLabel20";
			this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel36
			// 
			this.xrLabel36.BackColor = System.Drawing.Color.Empty;
			this.xrLabel36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Address]")});
			this.xrLabel36.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(119.791F, 92.00007F);
			this.xrLabel36.Multiline = true;
			this.xrLabel36.Name = "xrLabel36";
			this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel36.SizeF = new System.Drawing.SizeF(597.2091F, 23.00002F);
			this.xrLabel36.StylePriority.UseBackColor = false;
			this.xrLabel36.StylePriority.UseFont = false;
			this.xrLabel36.StylePriority.UseForeColor = false;
			this.xrLabel36.StylePriority.UseTextAlignment = false;
			this.xrLabel36.Text = "xrLabel19";
			this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel34
			// 
			this.xrLabel34.BackColor = System.Drawing.Color.Empty;
			this.xrLabel34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Email]")});
			this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(119.791F, 115.0001F);
			this.xrLabel34.Multiline = true;
			this.xrLabel34.Name = "xrLabel34";
			this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel34.SizeF = new System.Drawing.SizeF(597.209F, 23F);
			this.xrLabel34.StylePriority.UseBackColor = false;
			this.xrLabel34.StylePriority.UseFont = false;
			this.xrLabel34.StylePriority.UseForeColor = false;
			this.xrLabel34.StylePriority.UseTextAlignment = false;
			this.xrLabel34.Text = "xrLabel17";
			this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel33
			// 
			this.xrLabel33.BackColor = System.Drawing.Color.Empty;
			this.xrLabel33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Purchaser]")});
			this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(119.7914F, 23.00002F);
			this.xrLabel33.Multiline = true;
			this.xrLabel33.Name = "xrLabel33";
			this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel33.SizeF = new System.Drawing.SizeF(597.2087F, 23F);
			this.xrLabel33.StylePriority.UseBackColor = false;
			this.xrLabel33.StylePriority.UseFont = false;
			this.xrLabel33.StylePriority.UseForeColor = false;
			this.xrLabel33.StylePriority.UseTextAlignment = false;
			this.xrLabel33.Text = "p";
			this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel30
			// 
			this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(360.1303F, 161.0001F);
			this.xrLabel30.Multiline = true;
			this.xrLabel30.Name = "xrLabel30";
			this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel30.SizeF = new System.Drawing.SizeF(40.70294F, 23F);
			this.xrLabel30.StylePriority.UseFont = false;
			this.xrLabel30.StylePriority.UseForeColor = false;
			this.xrLabel30.StylePriority.UseTextAlignment = false;
			this.xrLabel30.Text = "Fax:";
			this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel29
			// 
			this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 138.0001F);
			this.xrLabel29.Multiline = true;
			this.xrLabel29.Name = "xrLabel29";
			this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel29.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel29.StylePriority.UseFont = false;
			this.xrLabel29.StylePriority.UseForeColor = false;
			this.xrLabel29.StylePriority.UseTextAlignment = false;
			this.xrLabel29.Text = "Phone:";
			this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel28
			// 
			this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 115.0001F);
			this.xrLabel28.Multiline = true;
			this.xrLabel28.Name = "xrLabel28";
			this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel28.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel28.StylePriority.UseFont = false;
			this.xrLabel28.StylePriority.UseForeColor = false;
			this.xrLabel28.StylePriority.UseTextAlignment = false;
			this.xrLabel28.Text = "Email:";
			this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel27
			// 
			this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 92.00007F);
			this.xrLabel27.Multiline = true;
			this.xrLabel27.Name = "xrLabel27";
			this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel27.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel27.StylePriority.UseFont = false;
			this.xrLabel27.StylePriority.UseForeColor = false;
			this.xrLabel27.StylePriority.UseTextAlignment = false;
			this.xrLabel27.Text = "Address:";
			this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel25
			// 
			this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 23.00002F);
			this.xrLabel25.Multiline = true;
			this.xrLabel25.Name = "xrLabel25";
			this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel25.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel25.StylePriority.UseFont = false;
			this.xrLabel25.StylePriority.UseForeColor = false;
			this.xrLabel25.StylePriority.UseTextAlignment = false;
			this.xrLabel25.Text = "Purchaser:";
			this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel14
			// 
			this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 10.00001F);
			this.xrLabel14.Multiline = true;
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel14.StylePriority.UseFont = false;
			this.xrLabel14.StylePriority.UseForeColor = false;
			this.xrLabel14.StylePriority.UsePadding = false;
			this.xrLabel14.StylePriority.UseTextAlignment = false;
			this.xrLabel14.Text = "Company:";
			this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel20
			// 
			this.xrLabel20.BackColor = System.Drawing.Color.Empty;
			this.xrLabel20.CanGrow = false;
			this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Phone]")});
			this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(119.7914F, 102F);
			this.xrLabel20.Multiline = true;
			this.xrLabel20.Name = "xrLabel20";
			this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel20.SizeF = new System.Drawing.SizeF(187.5F, 23F);
			this.xrLabel20.StylePriority.UseBackColor = false;
			this.xrLabel20.StylePriority.UseFont = false;
			this.xrLabel20.StylePriority.UseForeColor = false;
			this.xrLabel20.StylePriority.UsePadding = false;
			this.xrLabel20.StylePriority.UseTextAlignment = false;
			this.xrLabel20.Text = "xrLabel20";
			this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel19
			// 
			this.xrLabel19.BackColor = System.Drawing.Color.Empty;
			this.xrLabel19.CanGrow = false;
			this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Address]")});
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(119.7905F, 55.99998F);
			this.xrLabel19.Multiline = true;
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(597.209F, 23.00002F);
			this.xrLabel19.StylePriority.UseBackColor = false;
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.StylePriority.UseForeColor = false;
			this.xrLabel19.StylePriority.UsePadding = false;
			this.xrLabel19.StylePriority.UseTextAlignment = false;
			this.xrLabel19.Text = "xrLabel19";
			this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel18
			// 
			this.xrLabel18.BackColor = System.Drawing.Color.Empty;
			this.xrLabel18.CanGrow = false;
			this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_TaxCode]")});
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(119.7914F, 32.99999F);
			this.xrLabel18.Multiline = true;
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(597.209F, 23F);
			this.xrLabel18.StylePriority.UseBackColor = false;
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseForeColor = false;
			this.xrLabel18.StylePriority.UsePadding = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "xrLabel18";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel17
			// 
			this.xrLabel17.BackColor = System.Drawing.Color.Empty;
			this.xrLabel17.CanGrow = false;
			this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Email]")});
			this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(119.7905F, 79F);
			this.xrLabel17.Multiline = true;
			this.xrLabel17.Name = "xrLabel17";
			this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel17.SizeF = new System.Drawing.SizeF(597.2089F, 22.99999F);
			this.xrLabel17.StylePriority.UseBackColor = false;
			this.xrLabel17.StylePriority.UseFont = false;
			this.xrLabel17.StylePriority.UseForeColor = false;
			this.xrLabel17.StylePriority.UsePadding = false;
			this.xrLabel17.StylePriority.UseTextAlignment = false;
			this.xrLabel17.Text = "xrLabel17";
			this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel16
			// 
			this.xrLabel16.BackColor = System.Drawing.Color.Empty;
			this.xrLabel16.CanGrow = false;
			this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Name]")});
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(119.7908F, 10.00001F);
			this.xrLabel16.Multiline = true;
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(597.2087F, 23F);
			this.xrLabel16.StylePriority.UseBackColor = false;
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseForeColor = false;
			this.xrLabel16.StylePriority.UsePadding = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "lbCompanyName";
			this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel13
			// 
			this.xrLabel13.CanGrow = false;
			this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(360.1303F, 105.9977F);
			this.xrLabel13.Multiline = true;
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(27.16132F, 19.00228F);
			this.xrLabel13.StylePriority.UseFont = false;
			this.xrLabel13.StylePriority.UseForeColor = false;
			this.xrLabel13.StylePriority.UsePadding = false;
			this.xrLabel13.StylePriority.UseTextAlignment = false;
			this.xrLabel13.Text = "Fax:";
			this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel12
			// 
			this.xrLabel12.CanGrow = false;
			this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 102F);
			this.xrLabel12.Multiline = true;
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel12.StylePriority.UseFont = false;
			this.xrLabel12.StylePriority.UseForeColor = false;
			this.xrLabel12.StylePriority.UsePadding = false;
			this.xrLabel12.StylePriority.UseTextAlignment = false;
			this.xrLabel12.Text = "Phone:";
			this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel11
			// 
			this.xrLabel11.CanGrow = false;
			this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 78.99996F);
			this.xrLabel11.Multiline = true;
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel11.StylePriority.UseFont = false;
			this.xrLabel11.StylePriority.UseForeColor = false;
			this.xrLabel11.StylePriority.UsePadding = false;
			this.xrLabel11.StylePriority.UseTextAlignment = false;
			this.xrLabel11.Text = "Email:";
			this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel10
			// 
			this.xrLabel10.CanGrow = false;
			this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 55.99998F);
			this.xrLabel10.Multiline = true;
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel10.StylePriority.UseFont = false;
			this.xrLabel10.StylePriority.UseForeColor = false;
			this.xrLabel10.StylePriority.UsePadding = false;
			this.xrLabel10.StylePriority.UseTextAlignment = false;
			this.xrLabel10.Text = "Address:";
			this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel9
			// 
			this.xrLabel9.CanGrow = false;
			this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(13.62454F, 32.99999F);
			this.xrLabel9.Multiline = true;
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.StylePriority.UseForeColor = false;
			this.xrLabel9.StylePriority.UsePadding = false;
			this.xrLabel9.StylePriority.UseTextAlignment = false;
			this.xrLabel9.Text = "Tax code:";
			this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel21
			// 
			this.xrLabel21.BackColor = System.Drawing.Color.Empty;
			this.xrLabel21.CanGrow = false;
			this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Fax]")});
			this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(413.2137F, 102F);
			this.xrLabel21.Multiline = true;
			this.xrLabel21.Name = "xrLabel21";
			this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel21.SizeF = new System.Drawing.SizeF(269.4113F, 23F);
			this.xrLabel21.StylePriority.UseBackColor = false;
			this.xrLabel21.StylePriority.UseFont = false;
			this.xrLabel21.StylePriority.UseForeColor = false;
			this.xrLabel21.StylePriority.UsePadding = false;
			this.xrLabel21.StylePriority.UseTextAlignment = false;
			this.xrLabel21.Text = "xrLabel21";
			this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrCrossBandBox1
			// 
			this.xrCrossBandBox1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
			this.xrCrossBandBox1.EndBand = this.BottomMargin;
			this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(2.083333F, 0.2652588F);
			this.xrCrossBandBox1.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 19.37498F);
			this.xrCrossBandBox1.Name = "xrCrossBandBox1";
			this.xrCrossBandBox1.StartBand = this.TopMargin;
			this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(2.083333F, 19.37498F);
			this.xrCrossBandBox1.WidthF = 725.9166F;
			// 
			// xrLine2
			// 
			this.xrLine2.BackColor = System.Drawing.Color.Empty;
			this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 153.2799F);
			this.xrLine2.Name = "xrLine2";
			this.xrLine2.SizeF = new System.Drawing.SizeF(722.8333F, 2.083344F);
			this.xrLine2.StylePriority.UseBackColor = false;
			this.xrLine2.StylePriority.UseForeColor = false;
			// 
			// xrLabel24
			// 
			this.xrLabel24.BackColor = System.Drawing.Color.Empty;
			this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ID]")});
			this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 71.34637F);
			this.xrLabel24.Multiline = true;
			this.xrLabel24.Name = "xrLabel24";
			this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel24.SizeF = new System.Drawing.SizeF(26.06163F, 22.99997F);
			this.xrLabel24.StylePriority.UseBackColor = false;
			this.xrLabel24.StylePriority.UseFont = false;
			this.xrLabel24.StylePriority.UseForeColor = false;
			this.xrLabel24.StylePriority.UseTextAlignment = false;
			this.xrLabel24.Text = "xrLabel24";
			this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel43
			// 
			this.xrLabel43.BackColor = System.Drawing.Color.Empty;
			this.xrLabel43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Patterns_Name]")});
			this.xrLabel43.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(582.625F, 45.88671F);
			this.xrLabel43.Multiline = true;
			this.xrLabel43.Name = "xrLabel43";
			this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel43.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel43.StylePriority.UseBackColor = false;
			this.xrLabel43.StylePriority.UseFont = false;
			this.xrLabel43.StylePriority.UseForeColor = false;
			this.xrLabel43.StylePriority.UseTextAlignment = false;
			this.xrLabel43.Text = "xrLabel43";
			this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(40.64496F, 36.04167F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(141.8042F, 105.78F);
			this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
			// 
			// xrLabel7
			// 
			this.xrLabel7.BackColor = System.Drawing.Color.Empty;
			this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Series]")});
			this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(582.625F, 68.8867F);
			this.xrLabel7.Multiline = true;
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel7.StylePriority.UseBackColor = false;
			this.xrLabel7.StylePriority.UseFont = false;
			this.xrLabel7.StylePriority.UseForeColor = false;
			this.xrLabel7.StylePriority.UseTextAlignment = false;
			this.xrLabel7.Text = "p";
			this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel6
			// 
			this.xrLabel6.BackColor = System.Drawing.Color.Empty;
			this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[No]")});
			this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrLabel6.ForeColor = System.Drawing.Color.Red;
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(602.0896F, 91.88671F);
			this.xrLabel6.Multiline = true;
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel6.StylePriority.UseBackColor = false;
			this.xrLabel6.StylePriority.UseFont = false;
			this.xrLabel6.StylePriority.UseForeColor = false;
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "lbNo\r\n";
			this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel5
			// 
			this.xrLabel5.BackColor = System.Drawing.Color.Empty;
			this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Invoices].[ReleaseDate]")});
			this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(297.8333F, 82.50003F);
			this.xrLabel5.Multiline = true;
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(150F, 23F);
			this.xrLabel5.StylePriority.UseBackColor = false;
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.StylePriority.UseForeColor = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "xrLabel5";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrLabel5.TextFormatString = "{0:d}";
			// 
			// xrLabel4
			// 
			this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(515.0001F, 91.88671F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(53.12503F, 23F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.StylePriority.UseForeColor = false;
			this.xrLabel4.StylePriority.UseTextAlignment = false;
			this.xrLabel4.Text = "No:";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel3
			// 
			this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(515.0002F, 68.88671F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(67.62485F, 23F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.StylePriority.UseForeColor = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "Series:";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel2
			// 
			this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(515.0001F, 45.88671F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(67.62485F, 23F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.StylePriority.UseForeColor = false;
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "Pattern:";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(243.75F, 84.97505F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(54.08337F, 23F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseForeColor = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "Date:";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbName
			// 
			this.lbName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
			this.lbName.ForeColor = System.Drawing.Color.Maroon;
			this.lbName.LocationFloat = new DevExpress.Utils.PointFloat(248.3335F, 36.04167F);
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
			// xrTable1
			// 
			this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(2.083332F, 0F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(725.9166F, 25F);
			this.xrTable1.StylePriority.UseBorderDashStyle = false;
			this.xrTable1.StylePriority.UseBorders = false;
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 11.5D;
			// 
			// xrTableCell12
			// 
			this.xrTableCell12.Multiline = true;
			this.xrTableCell12.Name = "xrTableCell12";
			this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell12.StylePriority.UsePadding = false;
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.xrTableCell12.Summary = xrSummary1;
			this.xrTableCell12.Text = "xrTableCell12";
			this.xrTableCell12.Weight = 0.22731116008870009D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ItemName]")});
			this.xrTableCell1.Multiline = true;
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell1.Text = "xrTableCell1";
			this.xrTableCell1.Weight = 1.9837866467171024D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ItemPrice]")});
			this.xrTableCell2.Multiline = true;
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell2.Text = "xrTableCell2";
			this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrTableCell2.Weight = 0.54923424132586085D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitName]")});
			this.xrTableCell3.Multiline = true;
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell3.Text = "xrTableCell3";
			this.xrTableCell3.Weight = 0.41198792322620081D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
			this.xrTableCell4.Multiline = true;
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell4.Text = "xrTableCell4";
			this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrTableCell4.Weight = 0.48492770941242647D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalAmount]")});
			this.xrTableCell5.Multiline = true;
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell5.Text = "xrTableCell5";
			this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrTableCell5.Weight = 0.62184918744166762D;
			// 
			// ReportFooter
			// 
			this.ReportFooter.HeightF = 56.25F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// InvoiceReport
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupHeader2,
            this.ReportFooter});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.excelDataSource1});
			this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandBox1});
			this.DataMember = "Invoices";
			this.DataSource = this.sqlDataSource1;
			this.Margins = new System.Drawing.Printing.Margins(50, 46, 178, 50);
			this.PageHeight = 1169;
			this.PageWidth = 827;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Version = "18.1";
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
}
