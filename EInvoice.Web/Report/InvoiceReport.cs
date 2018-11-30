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
	private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
	private BackgroundWorker backgroundWorker1;
	private XRTable tbItemDetail;
	private XRTableRow xrTableRow1;
	private XRTableCell xrTableCell12;
	private XRTableCell xrTableCell1;
	private XRTableCell xrTableCell2;
	private XRTableCell xrTableCell3;
	private XRTableCell xrTableCell4;
	private XRTableCell xrTableCell5;
	private GroupHeaderBand groupHeaderBand1;
	private XRPictureBox xrPictureBox1;
	private XRLabel lbName;
	private XRLabel lbDay;
	private XRLabel lbPattern;
	private XRLabel lbSeries;
	private XRLabel lbNo;
	private XRLabel lbdDay;
	private XRLabel lbdNo;
	private XRLabel lbdPattern;
	private XRTable tbItemHeader;
	private XRTableRow xrTableRow2;
	private XRTableCell xrTableCell11;
	private XRTableCell xrTableCell6;
	private XRTableCell xrTableCell7;
	private XRTableCell xrTableCell8;
	private XRTableCell xrTableCell9;
	private XRTableCell xrTableCell10;
	private XRLabel lbCusName;
	private XRLabel lbCusAddress;
	private XRLabel lbCusEmail;
	private XRLabel lbCusPhone;
	private XRLabel lbCusFax;
	private XRLabel lbdCusName;
	private XRLabel lbdCusEmail;
	private XRLabel lbdCusAddress;
	private XRLabel lbdCusPhone;
	private XRLabel lbdCusFax;
	private XRLabel lbCusTaxCode;
	private XRLabel lbdCusCompany;
	private XRLabel lbCusCompany;
	private XRLabel lbdPaymentType;
	private XRLabel lbPaymentType;
	private XRLabel lbdCompanyFax;
	private XRLabel lbCompanyTaxCode;
	private XRLabel lbCompanyAddress;
	private XRLabel lbCompanyPhone;
	private XRLabel lbCompanyFax;
	private XRLabel lbdCompanyName;
	private XRLabel lbdCompanyEmail;
	private XRLabel lbdCompanyTaxCode;
	private XRLabel xrLabel19;
	private XRLabel lbdCompanyPhone;
	private XRLabel lbCompany;
	private XRCrossBandBox xrCrossBandBox1;
	private DevExpress.XtraReports.Parameters.Parameter IDParameter;
	private XRPageInfo xrPageInfo;
	private GroupFooterBand groupFooterBand1;
	private XRLabel lbdYear;
	private XRLabel lbYear;
	private XRLabel lbMonth;
	private XRCrossBandLine xrCrossBandLine1;
	private XRCrossBandLine xrCrossBandLine2;
	private XRTable tbSymbol;
	private XRTableRow xrTableRow3;
	private XRTableCell xrTableCell13;
	private XRTableCell xrTableCell14;
	private XRTableCell xrTableCell15;
	private XRTableCell xrTableCell16;
	private XRTableCell xrTableCell17;
	private XRTableCell xrTableCell18;
	private XRTable xrTable7;
	private XRTableRow tbGrandTotal;
	private XRTableCell xrTableCell25;
	private XRTableCell xrTableCell26;
	private XRTable xrTable6;
	private XRTableRow tbVATAmount;
	private XRTableCell xrTableCell23;
	private XRTableCell xrTableCell24;
	private XRTable tbVAT;
	private XRTableRow xrTableRow5;
	private XRTableCell xrTableCell20;
	private XRTableCell xrTableCell22;
	private XRTable tbSubTotal;
	private XRTableRow xrTableRow4;
	private XRTableCell xrTableCell19;
	private XRTableCell xrTableCell21;
	private XRLabel lbCSignature;
	private XRLabel lbPSignature;
	private XRLabel lbInWord;
	private XRRichText rtCopytight;
	private ReportFooterBand ReportFooter;
	private XRCrossBandLine xrCrossBandLine4;
	private XRCrossBandLine xrCrossBandLine3;
	private XRLabel lbCompanyEmail;
	private XRLabel lbdCusTaxCode;
	private XRLabel lbdMonth;
	private XRRichText xrRichText1;
	private XRLabel lbdSeries;
	private XRBarCode xrBarCode1;
	private XRLabel xrLabel1;

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
			DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
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
			DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
			DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
			DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
			DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
			DevExpress.DataAccess.Sql.Column column44 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression44 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
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
			DevExpress.DataAccess.Sql.Join join6 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo6 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			DevExpress.DataAccess.Sql.Join join7 = new DevExpress.DataAccess.Sql.Join();
			DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo7 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReport));
			DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.tbItemDetail = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
			this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
			this.tbSymbol = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
			this.lbdYear = new DevExpress.XtraReports.UI.XRLabel();
			this.lbYear = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdMonth = new DevExpress.XtraReports.UI.XRLabel();
			this.lbMonth = new DevExpress.XtraReports.UI.XRLabel();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			this.lbName = new DevExpress.XtraReports.UI.XRLabel();
			this.lbDay = new DevExpress.XtraReports.UI.XRLabel();
			this.lbPattern = new DevExpress.XtraReports.UI.XRLabel();
			this.lbSeries = new DevExpress.XtraReports.UI.XRLabel();
			this.lbNo = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdDay = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdNo = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdSeries = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdPattern = new DevExpress.XtraReports.UI.XRLabel();
			this.tbItemHeader = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.lbCusName = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCusAddress = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCusEmail = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCusPhone = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCusFax = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCusName = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCusEmail = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCusAddress = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCusPhone = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCusFax = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCusTaxCode = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCusTaxCode = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCusCompany = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCusCompany = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdPaymentType = new DevExpress.XtraReports.UI.XRLabel();
			this.lbPaymentType = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCompanyFax = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCompanyTaxCode = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCompanyAddress = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCompanyEmail = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCompanyPhone = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCompanyFax = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCompanyName = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCompanyEmail = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCompanyTaxCode = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.lbdCompanyPhone = new DevExpress.XtraReports.UI.XRLabel();
			this.lbCompany = new DevExpress.XtraReports.UI.XRLabel();
			this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
			this.IDParameter = new DevExpress.XtraReports.Parameters.Parameter();
			this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.lbCSignature = new DevExpress.XtraReports.UI.XRLabel();
			this.lbPSignature = new DevExpress.XtraReports.UI.XRLabel();
			this.lbInWord = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
			this.tbGrandTotal = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
			this.tbVATAmount = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tbVAT = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
			this.tbSubTotal = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrCrossBandLine1 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.xrCrossBandLine2 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.rtCopytight = new DevExpress.XtraReports.UI.XRRichText();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.xrCrossBandLine4 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.xrCrossBandLine3 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.tbItemDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSymbol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbItemHeader)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbVAT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSubTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rtCopytight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbItemDetail});
			this.Detail.HeightF = 25F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// tbItemDetail
			// 
			this.tbItemDetail.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.tbItemDetail.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.tbItemDetail.LocationFloat = new DevExpress.Utils.PointFloat(2.083332F, 0F);
			this.tbItemDetail.Name = "tbItemDetail";
			this.tbItemDetail.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.tbItemDetail.SizeF = new System.Drawing.SizeF(786.8331F, 25F);
			this.tbItemDetail.StylePriority.UseBorderDashStyle = false;
			this.tbItemDetail.StylePriority.UseBorders = false;
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.StylePriority.UseBorders = false;
			this.xrTableRow1.Weight = 11.5D;
			// 
			// xrTableCell12
			// 
			this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")});
			this.xrTableCell12.Multiline = true;
			this.xrTableCell12.Name = "xrTableCell12";
			this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell12.StylePriority.UseBorders = false;
			this.xrTableCell12.StylePriority.UsePadding = false;
			this.xrTableCell12.StylePriority.UseTextAlignment = false;
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.xrTableCell12.Summary = xrSummary1;
			this.xrTableCell12.Text = "xrTableCell12";
			this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell12.Weight = 0.22731116008870009D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ItemName]")});
			this.xrTableCell1.Multiline = true;
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell1.StylePriority.UseBorders = false;
			this.xrTableCell1.StylePriority.UseTextAlignment = false;
			this.xrTableCell1.Text = "xrTableCell1";
			this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell1.Weight = 1.92483968863974D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ItemPrice]")});
			this.xrTableCell2.Multiline = true;
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell2.StylePriority.UseBorders = false;
			this.xrTableCell2.StylePriority.UseTextAlignment = false;
			this.xrTableCell2.Text = "xrTableCell2";
			this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell2.TextFormatString = "{0:n}";
			this.xrTableCell2.Weight = 0.608181199403223D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitName]")});
			this.xrTableCell3.Multiline = true;
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell3.StylePriority.UseBorders = false;
			this.xrTableCell3.StylePriority.UseTextAlignment = false;
			this.xrTableCell3.Text = "xrTableCell3";
			this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell3.Weight = 0.35304024557489139D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
			this.xrTableCell4.Multiline = true;
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell4.StylePriority.UseBorders = false;
			this.xrTableCell4.StylePriority.UseTextAlignment = false;
			this.xrTableCell4.Text = "xrTableCell4";
			this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell4.TextFormatString = "{0:#.0}";
			this.xrTableCell4.Weight = 0.4849282490928869D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalAmount]")});
			this.xrTableCell5.Multiline = true;
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell5.StylePriority.UseTextAlignment = false;
			this.xrTableCell5.Text = "xrTableCell5";
			this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell5.TextFormatString = "{0:n}";
			this.xrTableCell5.Weight = 1.0398835133683495D;
			// 
			// TopMargin
			// 
			this.TopMargin.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.TopMargin.ForeColor = System.Drawing.Color.Empty;
			this.TopMargin.HeightF = 50F;
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
			columnExpression1.ColumnName = "No";
			table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"476\" />";
			table2.Name = "Invoices";
			columnExpression1.Table = table2;
			column1.Expression = columnExpression1;
			columnExpression2.ColumnName = "PurchaserCustomerID";
			columnExpression2.Table = table2;
			column2.Expression = columnExpression2;
			columnExpression3.ColumnName = "Tax";
			columnExpression3.Table = table2;
			column3.Expression = columnExpression3;
			columnExpression4.ColumnName = "TaxAmount";
			columnExpression4.Table = table2;
			column4.Expression = columnExpression4;
			columnExpression5.ColumnName = "SubTotalAmount";
			columnExpression5.Table = table2;
			column5.Expression = columnExpression5;
			columnExpression6.ColumnName = "GrandTotalAmount";
			columnExpression6.Table = table2;
			column6.Expression = columnExpression6;
			columnExpression7.ColumnName = "CreatedDate";
			columnExpression7.Table = table2;
			column7.Expression = columnExpression7;
			columnExpression8.ColumnName = "ReleaseDate";
			columnExpression8.Table = table2;
			column8.Expression = columnExpression8;
			columnExpression9.ColumnName = "Status";
			columnExpression9.Table = table2;
			column9.Expression = columnExpression9;
			columnExpression10.ColumnName = "Quantity";
			table3.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"248\" />";
			table3.Name = "Items";
			columnExpression10.Table = table3;
			column10.Expression = columnExpression10;
			columnExpression11.ColumnName = "Discount";
			columnExpression11.Table = table3;
			column11.Expression = columnExpression11;
			columnExpression12.ColumnName = "DiscountAmount";
			columnExpression12.Table = table3;
			column12.Expression = columnExpression12;
			columnExpression13.ColumnName = "TotalAmount";
			columnExpression13.Table = table3;
			column13.Expression = columnExpression13;
			columnExpression14.ColumnName = "ItemName";
			columnExpression14.Table = table3;
			column14.Expression = columnExpression14;
			columnExpression15.ColumnName = "ItemPrice";
			columnExpression15.Table = table3;
			column15.Expression = columnExpression15;
			columnExpression16.ColumnName = "UnitName";
			columnExpression16.Table = table3;
			column16.Expression = columnExpression16;
			column17.Alias = "Patterns_Name";
			columnExpression17.ColumnName = "Name";
			table4.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"115\" />";
			table4.Name = "Patterns";
			columnExpression17.Table = table4;
			column17.Expression = columnExpression17;
			column18.Alias = "PaymentMethods_Name";
			columnExpression18.ColumnName = "Name";
			table5.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"96\" />";
			table5.Name = "PaymentMethods";
			columnExpression18.Table = table5;
			column18.Expression = columnExpression18;
			columnExpression19.ColumnName = "Code";
			columnExpression19.Table = table1;
			column19.Expression = columnExpression19;
			columnExpression20.ColumnName = "TaxCode";
			columnExpression20.Table = table1;
			column20.Expression = columnExpression20;
			columnExpression21.ColumnName = "EnterpriseName";
			columnExpression21.Table = table1;
			column21.Expression = columnExpression21;
			columnExpression22.ColumnName = "Email";
			columnExpression22.Table = table1;
			column22.Expression = columnExpression22;
			columnExpression23.ColumnName = "Address";
			columnExpression23.Table = table1;
			column23.Expression = columnExpression23;
			columnExpression24.ColumnName = "Phone";
			columnExpression24.Table = table1;
			column24.Expression = columnExpression24;
			columnExpression25.ColumnName = "Fax";
			columnExpression25.Table = table1;
			column25.Expression = columnExpression25;
			columnExpression26.ColumnName = "LegalPresenter";
			columnExpression26.Table = table1;
			column26.Expression = columnExpression26;
			column27.Alias = "Companies_TaxCode";
			columnExpression27.ColumnName = "TaxCode";
			table6.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"362\" />";
			table6.Name = "Companies";
			columnExpression27.Table = table6;
			column27.Expression = columnExpression27;
			column28.Alias = "Companies_Name";
			columnExpression28.ColumnName = "Name";
			columnExpression28.Table = table6;
			column28.Expression = columnExpression28;
			column29.Alias = "Companies_Address";
			columnExpression29.ColumnName = "Address";
			columnExpression29.Table = table6;
			column29.Expression = columnExpression29;
			column30.Alias = "Companies_Phone";
			columnExpression30.ColumnName = "Phone";
			columnExpression30.Table = table6;
			column30.Expression = columnExpression30;
			column31.Alias = "Companies_Fax";
			columnExpression31.ColumnName = "Fax";
			columnExpression31.Table = table6;
			column31.Expression = columnExpression31;
			columnExpression32.ColumnName = "Website";
			columnExpression32.Table = table6;
			column32.Expression = columnExpression32;
			column33.Alias = "Companies_LegalPresenter";
			columnExpression33.ColumnName = "LegalPresenter";
			columnExpression33.Table = table6;
			column33.Expression = columnExpression33;
			column34.Alias = "Companies_Email";
			columnExpression34.ColumnName = "Email";
			columnExpression34.Table = table6;
			column34.Expression = columnExpression34;
			column35.Alias = "Companies_BankAccountId";
			columnExpression35.ColumnName = "BankAccountID";
			columnExpression35.Table = table6;
			column35.Expression = columnExpression35;
			column36.Alias = "Companies_AccountHolder";
			columnExpression36.ColumnName = "AccountHolder";
			columnExpression36.Table = table6;
			column36.Expression = columnExpression36;
			column37.Alias = "Companies_BankName";
			columnExpression37.ColumnName = "BankName";
			columnExpression37.Table = table6;
			column37.Expression = columnExpression37;
			columnExpression38.ColumnName = "Agency";
			columnExpression38.Table = table6;
			column38.Expression = columnExpression38;
			columnExpression39.ColumnName = "AccountID";
			columnExpression39.Table = table6;
			column39.Expression = columnExpression39;
			columnExpression40.ColumnName = "Note";
			columnExpression40.Table = table6;
			column40.Expression = columnExpression40;
			column41.Alias = "PurchaserCustomers_Purchaser";
			columnExpression41.ColumnName = "Purchaser";
			columnExpression41.Table = table1;
			column41.Expression = columnExpression41;
			columnExpression42.ColumnName = "ID";
			columnExpression42.Table = table2;
			column42.Expression = columnExpression42;
			column43.Alias = "Serial_Name";
			columnExpression43.ColumnName = "Name";
			table7.MetaSerializable = "<Meta X=\"960\" Y=\"30\" Width=\"125\" Height=\"115\" />";
			table7.Name = "Serial";
			columnExpression43.Table = table7;
			column43.Expression = columnExpression43;
			columnExpression44.ColumnName = "InWord";
			columnExpression44.Table = table2;
			column44.Expression = columnExpression44;
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
			selectQuery1.Columns.Add(column44);
			selectQuery1.FilterString = "[Invoices.ID] = ?pInvoiceID";
			selectQuery1.GroupFilterString = "";
			selectQuery1.Name = "Invoices";
			queryParameter1.Name = "pInvoiceID";
			queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.IDParameter]", typeof(long));
			selectQuery1.Parameters.Add(queryParameter1);
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
			relationColumnInfo6.NestedKeyColumn = "PatternId";
			relationColumnInfo6.ParentKeyColumn = "ID";
			join6.KeyColumns.Add(relationColumnInfo6);
			join6.Nested = table7;
			join6.Parent = table4;
			relationColumnInfo7.NestedKeyColumn = "ID";
			relationColumnInfo7.ParentKeyColumn = "SeriesId";
			join7.KeyColumns.Add(relationColumnInfo7);
			join7.Nested = table7;
			join7.Parent = table2;
			selectQuery1.Relations.Add(join1);
			selectQuery1.Relations.Add(join2);
			selectQuery1.Relations.Add(join3);
			selectQuery1.Relations.Add(join4);
			selectQuery1.Relations.Add(join5);
			selectQuery1.Relations.Add(join6);
			selectQuery1.Relations.Add(join7);
			selectQuery1.Tables.Add(table2);
			selectQuery1.Tables.Add(table3);
			selectQuery1.Tables.Add(table4);
			selectQuery1.Tables.Add(table5);
			selectQuery1.Tables.Add(table1);
			selectQuery1.Tables.Add(table6);
			selectQuery1.Tables.Add(table7);
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
			this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
			// 
			// excelDataSource1
			// 
			this.excelDataSource1.Name = "excelDataSource1";
			// 
			// groupHeaderBand1
			// 
			this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.xrRichText1,
            this.tbSymbol,
            this.lbdYear,
            this.lbYear,
            this.lbdMonth,
            this.lbMonth,
            this.xrPictureBox1,
            this.lbName,
            this.lbDay,
            this.lbPattern,
            this.lbSeries,
            this.lbNo,
            this.lbdDay,
            this.lbdNo,
            this.lbdSeries,
            this.lbdPattern,
            this.tbItemHeader,
            this.lbCusName,
            this.lbCusAddress,
            this.lbCusEmail,
            this.lbCusPhone,
            this.lbCusFax,
            this.lbdCusName,
            this.lbdCusEmail,
            this.lbdCusAddress,
            this.lbdCusPhone,
            this.lbdCusFax,
            this.lbdCusTaxCode,
            this.lbCusTaxCode,
            this.lbdCusCompany,
            this.lbCusCompany,
            this.lbdPaymentType,
            this.lbPaymentType,
            this.lbdCompanyFax,
            this.lbCompanyTaxCode,
            this.lbCompanyAddress,
            this.lbCompanyEmail,
            this.lbCompanyPhone,
            this.lbCompanyFax,
            this.lbdCompanyName,
            this.lbdCompanyEmail,
            this.lbdCompanyTaxCode,
            this.xrLabel19,
            this.lbdCompanyPhone,
            this.lbCompany});
			this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.groupHeaderBand1.HeightF = 493.1786F;
			this.groupHeaderBand1.Name = "groupHeaderBand1";
			this.groupHeaderBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
			// 
			// xrBarCode1
			// 
			this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(642.9365F, 82.78001F);
			this.xrBarCode1.Name = "xrBarCode1";
			this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
			this.xrBarCode1.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrBarCode1.Symbology = code128Generator1;
			// 
			// xrRichText1
			// 
			this.xrRichText1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(281.4307F, 92.77998F);
			this.xrRichText1.Name = "xrRichText1";
			this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
			this.xrRichText1.SizeF = new System.Drawing.SizeF(248.8128F, 23.00002F);
			// 
			// tbSymbol
			// 
			this.tbSymbol.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.tbSymbol.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.tbSymbol.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 468.1786F);
			this.tbSymbol.Name = "tbSymbol";
			this.tbSymbol.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
			this.tbSymbol.SizeF = new System.Drawing.SizeF(786.8331F, 25F);
			this.tbSymbol.StylePriority.UseBorders = false;
			this.tbSymbol.StylePriority.UseFont = false;
			this.tbSymbol.StylePriority.UseTextAlignment = false;
			this.tbSymbol.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrTableRow3
			// 
			this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18});
			this.xrTableRow3.Name = "xrTableRow3";
			this.xrTableRow3.Weight = 1D;
			// 
			// xrTableCell13
			// 
			this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell13.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell13.Multiline = true;
			this.xrTableCell13.Name = "xrTableCell13";
			this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell13.StylePriority.UseBorders = false;
			this.xrTableCell13.StylePriority.UseFont = false;
			this.xrTableCell13.StylePriority.UsePadding = false;
			this.xrTableCell13.Text = "1";
			this.xrTableCell13.Weight = 0.533232500334059D;
			// 
			// xrTableCell14
			// 
			this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell14.BorderWidth = 1F;
			this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell14.Multiline = true;
			this.xrTableCell14.Name = "xrTableCell14";
			this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell14.StylePriority.UseBorders = false;
			this.xrTableCell14.StylePriority.UseBorderWidth = false;
			this.xrTableCell14.StylePriority.UseFont = false;
			this.xrTableCell14.Text = "2";
			this.xrTableCell14.Weight = 4.5153390521320835D;
			// 
			// xrTableCell15
			// 
			this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell15.Multiline = true;
			this.xrTableCell15.Name = "xrTableCell15";
			this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell15.StylePriority.UseBorders = false;
			this.xrTableCell15.StylePriority.UseFont = false;
			this.xrTableCell15.Text = "3";
			this.xrTableCell15.Weight = 1.4266883918803923D;
			// 
			// xrTableCell16
			// 
			this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell16.Multiline = true;
			this.xrTableCell16.Name = "xrTableCell16";
			this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell16.StylePriority.UseBorders = false;
			this.xrTableCell16.StylePriority.UseFont = false;
			this.xrTableCell16.StylePriority.UseTextAlignment = false;
			this.xrTableCell16.Text = "4";
			this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell16.Weight = 0.82817115140576547D;
			// 
			// xrTableCell17
			// 
			this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell17.Multiline = true;
			this.xrTableCell17.Name = "xrTableCell17";
			this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell17.StylePriority.UseBorders = false;
			this.xrTableCell17.StylePriority.UseFont = false;
			this.xrTableCell17.StylePriority.UsePadding = false;
			this.xrTableCell17.Text = "5";
			this.xrTableCell17.Weight = 1.1375562548753271D;
			// 
			// xrTableCell18
			// 
			this.xrTableCell18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell18.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrTableCell18.Multiline = true;
			this.xrTableCell18.Name = "xrTableCell18";
			this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell18.StylePriority.UseBorderDashStyle = false;
			this.xrTableCell18.StylePriority.UseBorders = false;
			this.xrTableCell18.StylePriority.UseFont = false;
			this.xrTableCell18.StylePriority.UsePadding = false;
			this.xrTableCell18.Text = "6 = 3x5";
			this.xrTableCell18.Weight = 2.4393874353019904D;
			// 
			// lbdYear
			// 
			this.lbdYear.BackColor = System.Drawing.Color.Empty;
			this.lbdYear.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReleaseDate]")});
			this.lbdYear.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
			this.lbdYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdYear.LocationFloat = new DevExpress.Utils.PointFloat(502.2974F, 54.30339F);
			this.lbdYear.Multiline = true;
			this.lbdYear.Name = "lbdYear";
			this.lbdYear.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdYear.SizeF = new System.Drawing.SizeF(39.84738F, 22.99999F);
			this.lbdYear.StylePriority.UseBackColor = false;
			this.lbdYear.StylePriority.UseFont = false;
			this.lbdYear.StylePriority.UseForeColor = false;
			this.lbdYear.StylePriority.UseTextAlignment = false;
			this.lbdYear.Text = "xrLabel5";
			this.lbdYear.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.lbdYear.TextFormatString = "{0:yyyy}";
			// 
			// lbYear
			// 
			this.lbYear.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbYear.LocationFloat = new DevExpress.Utils.PointFloat(456.8112F, 54.30339F);
			this.lbYear.Multiline = true;
			this.lbYear.Name = "lbYear";
			this.lbYear.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbYear.SizeF = new System.Drawing.SizeF(39.50003F, 23F);
			this.lbYear.StylePriority.UseFont = false;
			this.lbYear.StylePriority.UseForeColor = false;
			this.lbYear.StylePriority.UseTextAlignment = false;
			this.lbYear.Text = "Year:";
			this.lbYear.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// lbdMonth
			// 
			this.lbdMonth.BackColor = System.Drawing.Color.Empty;
			this.lbdMonth.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReleaseDate]")});
			this.lbdMonth.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
			this.lbdMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdMonth.LocationFloat = new DevExpress.Utils.PointFloat(410.0132F, 54.30342F);
			this.lbdMonth.Multiline = true;
			this.lbdMonth.Name = "lbdMonth";
			this.lbdMonth.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdMonth.SizeF = new System.Drawing.SizeF(28.95801F, 23F);
			this.lbdMonth.StylePriority.UseBackColor = false;
			this.lbdMonth.StylePriority.UseFont = false;
			this.lbdMonth.StylePriority.UseForeColor = false;
			this.lbdMonth.StylePriority.UseTextAlignment = false;
			this.lbdMonth.Text = "i";
			this.lbdMonth.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.lbdMonth.TextFormatString = "{0:MM}";
			// 
			// lbMonth
			// 
			this.lbMonth.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbMonth.LocationFloat = new DevExpress.Utils.PointFloat(355.9298F, 54.30339F);
			this.lbMonth.Multiline = true;
			this.lbMonth.Name = "lbMonth";
			this.lbMonth.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbMonth.SizeF = new System.Drawing.SizeF(53.04172F, 23F);
			this.lbMonth.StylePriority.UseFont = false;
			this.lbMonth.StylePriority.UseForeColor = false;
			this.lbMonth.StylePriority.UseTextAlignment = false;
			this.lbMonth.Text = "Month:";
			this.lbMonth.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(13.62445F, 0F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(141.8042F, 105.78F);
			this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
			// 
			// lbName
			// 
			this.lbName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
			this.lbName.ForeColor = System.Drawing.Color.Maroon;
			this.lbName.LocationFloat = new DevExpress.Utils.PointFloat(281.4307F, 0F);
			this.lbName.Multiline = true;
			this.lbName.Name = "lbName";
			this.lbName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbName.SizeF = new System.Drawing.SizeF(248.8129F, 32.84505F);
			this.lbName.StylePriority.UseFont = false;
			this.lbName.StylePriority.UseForeColor = false;
			this.lbName.StylePriority.UseTextAlignment = false;
			this.lbName.Text = "VAT INVOICE";
			this.lbName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// lbDay
			// 
			this.lbDay.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbDay.LocationFloat = new DevExpress.Utils.PointFloat(281.4307F, 54.30339F);
			this.lbDay.Multiline = true;
			this.lbDay.Name = "lbDay";
			this.lbDay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbDay.SizeF = new System.Drawing.SizeF(37.41672F, 23F);
			this.lbDay.StylePriority.UseFont = false;
			this.lbDay.StylePriority.UseForeColor = false;
			this.lbDay.StylePriority.UseTextAlignment = false;
			this.lbDay.Text = "Day:\r\n";
			this.lbDay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// lbPattern
			// 
			this.lbPattern.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbPattern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbPattern.LocationFloat = new DevExpress.Utils.PointFloat(594.258F, 8.303388F);
			this.lbPattern.Multiline = true;
			this.lbPattern.Name = "lbPattern";
			this.lbPattern.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbPattern.SizeF = new System.Drawing.SizeF(67.62485F, 23F);
			this.lbPattern.StylePriority.UseFont = false;
			this.lbPattern.StylePriority.UseForeColor = false;
			this.lbPattern.StylePriority.UseTextAlignment = false;
			this.lbPattern.Text = "Pattern:";
			this.lbPattern.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbSeries
			// 
			this.lbSeries.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbSeries.LocationFloat = new DevExpress.Utils.PointFloat(594.258F, 31.30337F);
			this.lbSeries.Multiline = true;
			this.lbSeries.Name = "lbSeries";
			this.lbSeries.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbSeries.SizeF = new System.Drawing.SizeF(67.62485F, 23F);
			this.lbSeries.StylePriority.UseFont = false;
			this.lbSeries.StylePriority.UseForeColor = false;
			this.lbSeries.StylePriority.UseTextAlignment = false;
			this.lbSeries.Text = "Series:";
			this.lbSeries.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbNo
			// 
			this.lbNo.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbNo.LocationFloat = new DevExpress.Utils.PointFloat(594.258F, 54.30339F);
			this.lbNo.Multiline = true;
			this.lbNo.Name = "lbNo";
			this.lbNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbNo.SizeF = new System.Drawing.SizeF(67.62488F, 23F);
			this.lbNo.StylePriority.UseFont = false;
			this.lbNo.StylePriority.UseForeColor = false;
			this.lbNo.StylePriority.UseTextAlignment = false;
			this.lbNo.Text = "No:";
			this.lbNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdDay
			// 
			this.lbdDay.BackColor = System.Drawing.Color.Empty;
			this.lbdDay.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReleaseDate]")});
			this.lbdDay.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
			this.lbdDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdDay.LocationFloat = new DevExpress.Utils.PointFloat(319.889F, 54.30342F);
			this.lbdDay.Multiline = true;
			this.lbdDay.Name = "lbdDay";
			this.lbdDay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdDay.SizeF = new System.Drawing.SizeF(28.95801F, 23F);
			this.lbdDay.StylePriority.UseBackColor = false;
			this.lbdDay.StylePriority.UseFont = false;
			this.lbdDay.StylePriority.UseForeColor = false;
			this.lbdDay.StylePriority.UseTextAlignment = false;
			this.lbdDay.Text = "lbdDay";
			this.lbdDay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.lbdDay.TextFormatString = "{0:dd}";
			// 
			// lbdNo
			// 
			this.lbdNo.BackColor = System.Drawing.Color.Empty;
			this.lbdNo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[No]")});
			this.lbdNo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.lbdNo.ForeColor = System.Drawing.Color.Red;
			this.lbdNo.LocationFloat = new DevExpress.Utils.PointFloat(661.8828F, 54.30339F);
			this.lbdNo.Multiline = true;
			this.lbdNo.Name = "lbdNo";
			this.lbdNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdNo.SizeF = new System.Drawing.SizeF(119.1171F, 23F);
			this.lbdNo.StylePriority.UseBackColor = false;
			this.lbdNo.StylePriority.UseFont = false;
			this.lbdNo.StylePriority.UseForeColor = false;
			this.lbdNo.StylePriority.UseTextAlignment = false;
			this.lbdNo.Text = "lbNo\r\n";
			this.lbdNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.lbdNo.TextFormatString = "{0:0000000}";
			// 
			// lbdSeries
			// 
			this.lbdSeries.BackColor = System.Drawing.Color.Empty;
			this.lbdSeries.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Serial_Name]")});
			this.lbdSeries.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdSeries.LocationFloat = new DevExpress.Utils.PointFloat(661.8828F, 31.30337F);
			this.lbdSeries.Multiline = true;
			this.lbdSeries.Name = "lbdSeries";
			this.lbdSeries.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdSeries.SizeF = new System.Drawing.SizeF(119.1171F, 23F);
			this.lbdSeries.StylePriority.UseBackColor = false;
			this.lbdSeries.StylePriority.UseFont = false;
			this.lbdSeries.StylePriority.UseForeColor = false;
			this.lbdSeries.StylePriority.UseTextAlignment = false;
			this.lbdSeries.Text = "lbdSeries";
			this.lbdSeries.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdPattern
			// 
			this.lbdPattern.BackColor = System.Drawing.Color.Empty;
			this.lbdPattern.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Patterns_Name]")});
			this.lbdPattern.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdPattern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdPattern.LocationFloat = new DevExpress.Utils.PointFloat(661.8828F, 8.303388F);
			this.lbdPattern.Multiline = true;
			this.lbdPattern.Name = "lbdPattern";
			this.lbdPattern.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdPattern.SizeF = new System.Drawing.SizeF(119.1171F, 23F);
			this.lbdPattern.StylePriority.UseBackColor = false;
			this.lbdPattern.StylePriority.UseFont = false;
			this.lbdPattern.StylePriority.UseForeColor = false;
			this.lbdPattern.StylePriority.UseTextAlignment = false;
			this.lbdPattern.Text = "lbdPattern";
			this.lbdPattern.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// tbItemHeader
			// 
			this.tbItemHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.tbItemHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.tbItemHeader.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 443.1786F);
			this.tbItemHeader.Name = "tbItemHeader";
			this.tbItemHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.tbItemHeader.SizeF = new System.Drawing.SizeF(786.8332F, 25F);
			this.tbItemHeader.StylePriority.UseBorders = false;
			this.tbItemHeader.StylePriority.UseFont = false;
			this.tbItemHeader.StylePriority.UseTextAlignment = false;
			this.tbItemHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.tbItemHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTable2_BeforePrint);
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
			// xrTableCell11
			// 
			this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell11.Multiline = true;
			this.xrTableCell11.Name = "xrTableCell11";
			this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell11.StylePriority.UseBorders = false;
			this.xrTableCell11.StylePriority.UseFont = false;
			this.xrTableCell11.StylePriority.UsePadding = false;
			this.xrTableCell11.Text = "Pos.";
			this.xrTableCell11.Weight = 0.533232500334059D;
			this.xrTableCell11.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell11_BeforePrint);
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell6.BorderWidth = 1F;
			this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell6.Multiline = true;
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell6.StylePriority.UseBorders = false;
			this.xrTableCell6.StylePriority.UseBorderWidth = false;
			this.xrTableCell6.StylePriority.UseFont = false;
			this.xrTableCell6.Text = "Product Name";
			this.xrTableCell6.Weight = 4.51533873563291D;
			// 
			// xrTableCell7
			// 
			this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell7.Multiline = true;
			this.xrTableCell7.Name = "xrTableCell7";
			this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell7.StylePriority.UseFont = false;
			this.xrTableCell7.Text = "Price";
			this.xrTableCell7.Weight = 1.4266887083795654D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell8.Multiline = true;
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell8.StylePriority.UseFont = false;
			this.xrTableCell8.StylePriority.UseTextAlignment = false;
			this.xrTableCell8.Text = "Unit";
			this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.xrTableCell8.Weight = 0.82817115140576547D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell9.Multiline = true;
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell9.StylePriority.UseFont = false;
			this.xrTableCell9.StylePriority.UsePadding = false;
			this.xrTableCell9.Text = "Quantity";
			this.xrTableCell9.Weight = 1.1375562548753271D;
			// 
			// xrTableCell10
			// 
			this.xrTableCell10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.xrTableCell10.Multiline = true;
			this.xrTableCell10.Name = "xrTableCell10";
			this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell10.StylePriority.UseBorderDashStyle = false;
			this.xrTableCell10.StylePriority.UseBorders = false;
			this.xrTableCell10.StylePriority.UseFont = false;
			this.xrTableCell10.StylePriority.UsePadding = false;
			this.xrTableCell10.Text = "Total";
			this.xrTableCell10.Weight = 2.4393891232975804D;
			// 
			// lbCusName
			// 
			this.lbCusName.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCusName.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 276.9702F);
			this.lbCusName.Multiline = true;
			this.lbCusName.Name = "lbCusName";
			this.lbCusName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbCusName.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCusName.StylePriority.UseFont = false;
			this.lbCusName.StylePriority.UseForeColor = false;
			this.lbCusName.StylePriority.UseTextAlignment = false;
			this.lbCusName.Text = "Purchaser:";
			this.lbCusName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCusAddress
			// 
			this.lbCusAddress.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCusAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCusAddress.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 345.9702F);
			this.lbCusAddress.Multiline = true;
			this.lbCusAddress.Name = "lbCusAddress";
			this.lbCusAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbCusAddress.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCusAddress.StylePriority.UseFont = false;
			this.lbCusAddress.StylePriority.UseForeColor = false;
			this.lbCusAddress.StylePriority.UseTextAlignment = false;
			this.lbCusAddress.Text = "Address:";
			this.lbCusAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCusEmail
			// 
			this.lbCusEmail.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCusEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCusEmail.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 368.9702F);
			this.lbCusEmail.Multiline = true;
			this.lbCusEmail.Name = "lbCusEmail";
			this.lbCusEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbCusEmail.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCusEmail.StylePriority.UseFont = false;
			this.lbCusEmail.StylePriority.UseForeColor = false;
			this.lbCusEmail.StylePriority.UseTextAlignment = false;
			this.lbCusEmail.Text = "Email:";
			this.lbCusEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCusPhone
			// 
			this.lbCusPhone.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCusPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCusPhone.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 391.9702F);
			this.lbCusPhone.Multiline = true;
			this.lbCusPhone.Name = "lbCusPhone";
			this.lbCusPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbCusPhone.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCusPhone.StylePriority.UseFont = false;
			this.lbCusPhone.StylePriority.UseForeColor = false;
			this.lbCusPhone.StylePriority.UseTextAlignment = false;
			this.lbCusPhone.Text = "Phone:";
			this.lbCusPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCusFax
			// 
			this.lbCusFax.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCusFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCusFax.LocationFloat = new DevExpress.Utils.PointFloat(364.1309F, 391.9702F);
			this.lbCusFax.Multiline = true;
			this.lbCusFax.Name = "lbCusFax";
			this.lbCusFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbCusFax.SizeF = new System.Drawing.SizeF(40.70294F, 23F);
			this.lbCusFax.StylePriority.UseFont = false;
			this.lbCusFax.StylePriority.UseForeColor = false;
			this.lbCusFax.StylePriority.UseTextAlignment = false;
			this.lbCusFax.Text = "Fax:";
			this.lbCusFax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCusName
			// 
			this.lbdCusName.BackColor = System.Drawing.Color.Empty;
			this.lbdCusName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Purchaser]")});
			this.lbdCusName.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCusName.LocationFloat = new DevExpress.Utils.PointFloat(119.7898F, 276.9701F);
			this.lbdCusName.Multiline = true;
			this.lbdCusName.Name = "lbdCusName";
			this.lbdCusName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdCusName.SizeF = new System.Drawing.SizeF(669.1255F, 23F);
			this.lbdCusName.StylePriority.UseBackColor = false;
			this.lbdCusName.StylePriority.UseFont = false;
			this.lbdCusName.StylePriority.UseForeColor = false;
			this.lbdCusName.StylePriority.UseTextAlignment = false;
			this.lbdCusName.Text = "lbdCusName";
			this.lbdCusName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCusEmail
			// 
			this.lbdCusEmail.BackColor = System.Drawing.Color.Empty;
			this.lbdCusEmail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Email]")});
			this.lbdCusEmail.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCusEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCusEmail.LocationFloat = new DevExpress.Utils.PointFloat(119.7903F, 368.9702F);
			this.lbdCusEmail.Multiline = true;
			this.lbdCusEmail.Name = "lbdCusEmail";
			this.lbdCusEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdCusEmail.SizeF = new System.Drawing.SizeF(669.1257F, 23F);
			this.lbdCusEmail.StylePriority.UseBackColor = false;
			this.lbdCusEmail.StylePriority.UseFont = false;
			this.lbdCusEmail.StylePriority.UseForeColor = false;
			this.lbdCusEmail.StylePriority.UseTextAlignment = false;
			this.lbdCusEmail.Text = "lbdCusEmail";
			this.lbdCusEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCusAddress
			// 
			this.lbdCusAddress.BackColor = System.Drawing.Color.Empty;
			this.lbdCusAddress.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Address]")});
			this.lbdCusAddress.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCusAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCusAddress.LocationFloat = new DevExpress.Utils.PointFloat(119.7893F, 345.9701F);
			this.lbdCusAddress.Multiline = true;
			this.lbdCusAddress.Name = "lbdCusAddress";
			this.lbdCusAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdCusAddress.SizeF = new System.Drawing.SizeF(669.1258F, 23F);
			this.lbdCusAddress.StylePriority.UseBackColor = false;
			this.lbdCusAddress.StylePriority.UseFont = false;
			this.lbdCusAddress.StylePriority.UseForeColor = false;
			this.lbdCusAddress.StylePriority.UseTextAlignment = false;
			this.lbdCusAddress.Text = "lbdCusAddress";
			this.lbdCusAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCusPhone
			// 
			this.lbdCusPhone.BackColor = System.Drawing.Color.Empty;
			this.lbdCusPhone.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Phone]")});
			this.lbdCusPhone.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCusPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCusPhone.LocationFloat = new DevExpress.Utils.PointFloat(119.7895F, 391.9701F);
			this.lbdCusPhone.Multiline = true;
			this.lbdCusPhone.Name = "lbdCusPhone";
			this.lbdCusPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdCusPhone.SizeF = new System.Drawing.SizeF(229.0575F, 23F);
			this.lbdCusPhone.StylePriority.UseBackColor = false;
			this.lbdCusPhone.StylePriority.UseFont = false;
			this.lbdCusPhone.StylePriority.UseForeColor = false;
			this.lbdCusPhone.StylePriority.UseTextAlignment = false;
			this.lbdCusPhone.Text = "lbCusPhone";
			this.lbdCusPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCusFax
			// 
			this.lbdCusFax.BackColor = System.Drawing.Color.Empty;
			this.lbdCusFax.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_Fax]")});
			this.lbdCusFax.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCusFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCusFax.LocationFloat = new DevExpress.Utils.PointFloat(417.2141F, 391.9702F);
			this.lbdCusFax.Multiline = true;
			this.lbdCusFax.Name = "lbdCusFax";
			this.lbdCusFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdCusFax.SizeF = new System.Drawing.SizeF(371.7007F, 23F);
			this.lbdCusFax.StylePriority.UseBackColor = false;
			this.lbdCusFax.StylePriority.UseFont = false;
			this.lbdCusFax.StylePriority.UseForeColor = false;
			this.lbdCusFax.StylePriority.UseTextAlignment = false;
			this.lbdCusFax.Text = "lbdCusFax";
			this.lbdCusFax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCusTaxCode
			// 
			this.lbdCusTaxCode.BackColor = System.Drawing.Color.Empty;
			this.lbdCusTaxCode.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_TaxCode]")});
			this.lbdCusTaxCode.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCusTaxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCusTaxCode.LocationFloat = new DevExpress.Utils.PointFloat(119.7893F, 322.9701F);
			this.lbdCusTaxCode.Multiline = true;
			this.lbdCusTaxCode.Name = "lbdCusTaxCode";
			this.lbdCusTaxCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdCusTaxCode.SizeF = new System.Drawing.SizeF(669.1257F, 23F);
			this.lbdCusTaxCode.StylePriority.UseBackColor = false;
			this.lbdCusTaxCode.StylePriority.UseFont = false;
			this.lbdCusTaxCode.StylePriority.UseForeColor = false;
			this.lbdCusTaxCode.StylePriority.UseTextAlignment = false;
			this.lbdCusTaxCode.Text = "lbdCusTaxCode";
			this.lbdCusTaxCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCusTaxCode
			// 
			this.lbCusTaxCode.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCusTaxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCusTaxCode.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 322.9702F);
			this.lbCusTaxCode.Multiline = true;
			this.lbCusTaxCode.Name = "lbCusTaxCode";
			this.lbCusTaxCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbCusTaxCode.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCusTaxCode.StylePriority.UseFont = false;
			this.lbCusTaxCode.StylePriority.UseForeColor = false;
			this.lbCusTaxCode.StylePriority.UseTextAlignment = false;
			this.lbCusTaxCode.Text = "Tax code:";
			this.lbCusTaxCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCusCompany
			// 
			this.lbdCusCompany.BackColor = System.Drawing.Color.Empty;
			this.lbdCusCompany.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCustomers_EnterpriseName]")});
			this.lbdCusCompany.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCusCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCusCompany.LocationFloat = new DevExpress.Utils.PointFloat(119.7893F, 299.9701F);
			this.lbdCusCompany.Multiline = true;
			this.lbdCusCompany.Name = "lbdCusCompany";
			this.lbdCusCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdCusCompany.SizeF = new System.Drawing.SizeF(669.1257F, 23F);
			this.lbdCusCompany.StylePriority.UseBackColor = false;
			this.lbdCusCompany.StylePriority.UseFont = false;
			this.lbdCusCompany.StylePriority.UseForeColor = false;
			this.lbdCusCompany.StylePriority.UseTextAlignment = false;
			this.lbdCusCompany.Text = "lbdCusCompany";
			this.lbdCusCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCusCompany
			// 
			this.lbCusCompany.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCusCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCusCompany.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 299.9701F);
			this.lbCusCompany.Multiline = true;
			this.lbCusCompany.Name = "lbCusCompany";
			this.lbCusCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbCusCompany.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCusCompany.StylePriority.UseFont = false;
			this.lbCusCompany.StylePriority.UseForeColor = false;
			this.lbCusCompany.StylePriority.UseTextAlignment = false;
			this.lbCusCompany.Text = "Enterprise:";
			this.lbCusCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdPaymentType
			// 
			this.lbdPaymentType.BackColor = System.Drawing.Color.Empty;
			this.lbdPaymentType.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentMethods_Name]")});
			this.lbdPaymentType.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdPaymentType.LocationFloat = new DevExpress.Utils.PointFloat(119.7898F, 414.9702F);
			this.lbdPaymentType.Multiline = true;
			this.lbdPaymentType.Name = "lbdPaymentType";
			this.lbdPaymentType.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbdPaymentType.SizeF = new System.Drawing.SizeF(229.0575F, 23F);
			this.lbdPaymentType.StylePriority.UseBackColor = false;
			this.lbdPaymentType.StylePriority.UseFont = false;
			this.lbdPaymentType.StylePriority.UseForeColor = false;
			this.lbdPaymentType.StylePriority.UseTextAlignment = false;
			this.lbdPaymentType.Text = "lbdPaymentType";
			this.lbdPaymentType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbPaymentType
			// 
			this.lbPaymentType.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbPaymentType.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 414.9703F);
			this.lbPaymentType.Multiline = true;
			this.lbPaymentType.Name = "lbPaymentType";
			this.lbPaymentType.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbPaymentType.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbPaymentType.StylePriority.UseFont = false;
			this.lbPaymentType.StylePriority.UseForeColor = false;
			this.lbPaymentType.StylePriority.UseTextAlignment = false;
			this.lbPaymentType.Text = "Payment Type:";
			this.lbPaymentType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCompanyFax
			// 
			this.lbdCompanyFax.BackColor = System.Drawing.Color.Empty;
			this.lbdCompanyFax.CanGrow = false;
			this.lbdCompanyFax.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Fax]")});
			this.lbdCompanyFax.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCompanyFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCompanyFax.LocationFloat = new DevExpress.Utils.PointFloat(417.2142F, 223.47F);
			this.lbdCompanyFax.Multiline = true;
			this.lbdCompanyFax.Name = "lbdCompanyFax";
			this.lbdCompanyFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbdCompanyFax.SizeF = new System.Drawing.SizeF(371.7018F, 23F);
			this.lbdCompanyFax.StylePriority.UseBackColor = false;
			this.lbdCompanyFax.StylePriority.UseFont = false;
			this.lbdCompanyFax.StylePriority.UseForeColor = false;
			this.lbdCompanyFax.StylePriority.UsePadding = false;
			this.lbdCompanyFax.StylePriority.UseTextAlignment = false;
			this.lbdCompanyFax.Text = "lbdCompanyFax";
			this.lbdCompanyFax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCompanyTaxCode
			// 
			this.lbCompanyTaxCode.CanGrow = false;
			this.lbCompanyTaxCode.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCompanyTaxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCompanyTaxCode.LocationFloat = new DevExpress.Utils.PointFloat(13.62445F, 154.4701F);
			this.lbCompanyTaxCode.Multiline = true;
			this.lbCompanyTaxCode.Name = "lbCompanyTaxCode";
			this.lbCompanyTaxCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbCompanyTaxCode.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCompanyTaxCode.StylePriority.UseFont = false;
			this.lbCompanyTaxCode.StylePriority.UseForeColor = false;
			this.lbCompanyTaxCode.StylePriority.UsePadding = false;
			this.lbCompanyTaxCode.StylePriority.UseTextAlignment = false;
			this.lbCompanyTaxCode.Text = "Tax code:";
			this.lbCompanyTaxCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCompanyAddress
			// 
			this.lbCompanyAddress.CanGrow = false;
			this.lbCompanyAddress.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCompanyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCompanyAddress.LocationFloat = new DevExpress.Utils.PointFloat(13.62445F, 177.47F);
			this.lbCompanyAddress.Multiline = true;
			this.lbCompanyAddress.Name = "lbCompanyAddress";
			this.lbCompanyAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbCompanyAddress.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCompanyAddress.StylePriority.UseFont = false;
			this.lbCompanyAddress.StylePriority.UseForeColor = false;
			this.lbCompanyAddress.StylePriority.UsePadding = false;
			this.lbCompanyAddress.StylePriority.UseTextAlignment = false;
			this.lbCompanyAddress.Text = "Address:";
			this.lbCompanyAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCompanyEmail
			// 
			this.lbCompanyEmail.CanGrow = false;
			this.lbCompanyEmail.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCompanyEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCompanyEmail.LocationFloat = new DevExpress.Utils.PointFloat(13.62445F, 200.4701F);
			this.lbCompanyEmail.Multiline = true;
			this.lbCompanyEmail.Name = "lbCompanyEmail";
			this.lbCompanyEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbCompanyEmail.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCompanyEmail.StylePriority.UseFont = false;
			this.lbCompanyEmail.StylePriority.UseForeColor = false;
			this.lbCompanyEmail.StylePriority.UsePadding = false;
			this.lbCompanyEmail.StylePriority.UseTextAlignment = false;
			this.lbCompanyEmail.Text = "Email:";
			this.lbCompanyEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCompanyPhone
			// 
			this.lbCompanyPhone.CanGrow = false;
			this.lbCompanyPhone.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCompanyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCompanyPhone.LocationFloat = new DevExpress.Utils.PointFloat(13.62445F, 223.47F);
			this.lbCompanyPhone.Multiline = true;
			this.lbCompanyPhone.Name = "lbCompanyPhone";
			this.lbCompanyPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbCompanyPhone.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCompanyPhone.StylePriority.UseFont = false;
			this.lbCompanyPhone.StylePriority.UseForeColor = false;
			this.lbCompanyPhone.StylePriority.UsePadding = false;
			this.lbCompanyPhone.StylePriority.UseTextAlignment = false;
			this.lbCompanyPhone.Text = "Phone:";
			this.lbCompanyPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCompanyFax
			// 
			this.lbCompanyFax.CanGrow = false;
			this.lbCompanyFax.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCompanyFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCompanyFax.LocationFloat = new DevExpress.Utils.PointFloat(364.1308F, 227.4677F);
			this.lbCompanyFax.Multiline = true;
			this.lbCompanyFax.Name = "lbCompanyFax";
			this.lbCompanyFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbCompanyFax.SizeF = new System.Drawing.SizeF(27.16132F, 19.00228F);
			this.lbCompanyFax.StylePriority.UseFont = false;
			this.lbCompanyFax.StylePriority.UseForeColor = false;
			this.lbCompanyFax.StylePriority.UsePadding = false;
			this.lbCompanyFax.StylePriority.UseTextAlignment = false;
			this.lbCompanyFax.Text = "Fax:";
			this.lbCompanyFax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCompanyName
			// 
			this.lbdCompanyName.BackColor = System.Drawing.Color.Empty;
			this.lbdCompanyName.CanGrow = false;
			this.lbdCompanyName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Name]")});
			this.lbdCompanyName.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(119.7907F, 131.4701F);
			this.lbdCompanyName.Multiline = true;
			this.lbdCompanyName.Name = "lbdCompanyName";
			this.lbdCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbdCompanyName.SizeF = new System.Drawing.SizeF(669.1255F, 23F);
			this.lbdCompanyName.StylePriority.UseBackColor = false;
			this.lbdCompanyName.StylePriority.UseFont = false;
			this.lbdCompanyName.StylePriority.UseForeColor = false;
			this.lbdCompanyName.StylePriority.UsePadding = false;
			this.lbdCompanyName.StylePriority.UseTextAlignment = false;
			this.lbdCompanyName.Text = "lbdCompanyName";
			this.lbdCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCompanyEmail
			// 
			this.lbdCompanyEmail.BackColor = System.Drawing.Color.Empty;
			this.lbdCompanyEmail.CanGrow = false;
			this.lbdCompanyEmail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Email]")});
			this.lbdCompanyEmail.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCompanyEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCompanyEmail.LocationFloat = new DevExpress.Utils.PointFloat(119.7904F, 200.4701F);
			this.lbdCompanyEmail.Multiline = true;
			this.lbdCompanyEmail.Name = "lbdCompanyEmail";
			this.lbdCompanyEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbdCompanyEmail.SizeF = new System.Drawing.SizeF(669.1257F, 22.99998F);
			this.lbdCompanyEmail.StylePriority.UseBackColor = false;
			this.lbdCompanyEmail.StylePriority.UseFont = false;
			this.lbdCompanyEmail.StylePriority.UseForeColor = false;
			this.lbdCompanyEmail.StylePriority.UsePadding = false;
			this.lbdCompanyEmail.StylePriority.UseTextAlignment = false;
			this.lbdCompanyEmail.Text = "lbdCompanyEmail";
			this.lbdCompanyEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCompanyTaxCode
			// 
			this.lbdCompanyTaxCode.BackColor = System.Drawing.Color.Empty;
			this.lbdCompanyTaxCode.CanGrow = false;
			this.lbdCompanyTaxCode.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_TaxCode]")});
			this.lbdCompanyTaxCode.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCompanyTaxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCompanyTaxCode.LocationFloat = new DevExpress.Utils.PointFloat(119.7913F, 154.4701F);
			this.lbdCompanyTaxCode.Multiline = true;
			this.lbdCompanyTaxCode.Name = "lbdCompanyTaxCode";
			this.lbdCompanyTaxCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbdCompanyTaxCode.SizeF = new System.Drawing.SizeF(669.1237F, 23F);
			this.lbdCompanyTaxCode.StylePriority.UseBackColor = false;
			this.lbdCompanyTaxCode.StylePriority.UseFont = false;
			this.lbdCompanyTaxCode.StylePriority.UseForeColor = false;
			this.lbdCompanyTaxCode.StylePriority.UsePadding = false;
			this.lbdCompanyTaxCode.StylePriority.UseTextAlignment = false;
			this.lbdCompanyTaxCode.Text = "s";
			this.lbdCompanyTaxCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel19
			// 
			this.xrLabel19.BackColor = System.Drawing.Color.Empty;
			this.xrLabel19.CanGrow = false;
			this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Address]")});
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.xrLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(119.7904F, 177.47F);
			this.xrLabel19.Multiline = true;
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(669.1257F, 23.00002F);
			this.xrLabel19.StylePriority.UseBackColor = false;
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.StylePriority.UseForeColor = false;
			this.xrLabel19.StylePriority.UsePadding = false;
			this.xrLabel19.StylePriority.UseTextAlignment = false;
			this.xrLabel19.Text = "lbdCompanyAddress";
			this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbdCompanyPhone
			// 
			this.lbdCompanyPhone.BackColor = System.Drawing.Color.Empty;
			this.lbdCompanyPhone.CanGrow = false;
			this.lbdCompanyPhone.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Companies_Phone]")});
			this.lbdCompanyPhone.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbdCompanyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.lbdCompanyPhone.LocationFloat = new DevExpress.Utils.PointFloat(119.7913F, 223.47F);
			this.lbdCompanyPhone.Multiline = true;
			this.lbdCompanyPhone.Name = "lbdCompanyPhone";
			this.lbdCompanyPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbdCompanyPhone.SizeF = new System.Drawing.SizeF(244.3395F, 23F);
			this.lbdCompanyPhone.StylePriority.UseBackColor = false;
			this.lbdCompanyPhone.StylePriority.UseFont = false;
			this.lbdCompanyPhone.StylePriority.UseForeColor = false;
			this.lbdCompanyPhone.StylePriority.UsePadding = false;
			this.lbdCompanyPhone.StylePriority.UseTextAlignment = false;
			this.lbdCompanyPhone.Text = "lbdCompanyPhone";
			this.lbdCompanyPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// lbCompany
			// 
			this.lbCompany.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.lbCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
			this.lbCompany.LocationFloat = new DevExpress.Utils.PointFloat(13.62445F, 131.4701F);
			this.lbCompany.Multiline = true;
			this.lbCompany.Name = "lbCompany";
			this.lbCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.lbCompany.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCompany.StylePriority.UseFont = false;
			this.lbCompany.StylePriority.UseForeColor = false;
			this.lbCompany.StylePriority.UsePadding = false;
			this.lbCompany.StylePriority.UseTextAlignment = false;
			this.lbCompany.Text = "Company:";
			this.lbCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrCrossBandBox1
			// 
			this.xrCrossBandBox1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
			this.xrCrossBandBox1.EndBand = this.BottomMargin;
			this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(0F, 11.83685F);
			this.xrCrossBandBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 30.20833F);
			this.xrCrossBandBox1.Name = "xrCrossBandBox1";
			this.xrCrossBandBox1.StartBand = this.TopMargin;
			this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(0F, 30.20833F);
			this.xrCrossBandBox1.WidthF = 791F;
			// 
			// IDParameter
			// 
			this.IDParameter.Description = "Parameter1";
			this.IDParameter.Name = "IDParameter";
			this.IDParameter.Type = typeof(int);
			this.IDParameter.ValueInfo = "3";
			// 
			// groupFooterBand1
			// 
			this.groupFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.lbCSignature,
            this.lbPSignature,
            this.lbInWord,
            this.xrTable7,
            this.xrTable6,
            this.tbVAT,
            this.tbSubTotal});
			this.groupFooterBand1.HeightF = 236.9583F;
			this.groupFooterBand1.Name = "groupFooterBand1";
			// 
			// lbCSignature
			// 
			this.lbCSignature.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.lbCSignature.LocationFloat = new DevExpress.Utils.PointFloat(655.4365F, 181.25F);
			this.lbCSignature.Multiline = true;
			this.lbCSignature.Name = "lbCSignature";
			this.lbCSignature.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbCSignature.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbCSignature.StylePriority.UseFont = false;
			this.lbCSignature.StylePriority.UseTextAlignment = false;
			this.lbCSignature.Text = "Seller";
			this.lbCSignature.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// lbPSignature
			// 
			this.lbPSignature.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.lbPSignature.LocationFloat = new DevExpress.Utils.PointFloat(36.06164F, 181.25F);
			this.lbPSignature.Multiline = true;
			this.lbPSignature.Name = "lbPSignature";
			this.lbPSignature.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbPSignature.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbPSignature.StylePriority.UseFont = false;
			this.lbPSignature.StylePriority.UseTextAlignment = false;
			this.lbPSignature.Text = "Purchaser";
			this.lbPSignature.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			// 
			// lbInWord
			// 
			this.lbInWord.BackColor = System.Drawing.Color.Empty;
			this.lbInWord.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.lbInWord.LocationFloat = new DevExpress.Utils.PointFloat(36.06164F, 133.6715F);
			this.lbInWord.Multiline = true;
			this.lbInWord.Name = "lbInWord";
			this.lbInWord.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lbInWord.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.lbInWord.StylePriority.UseBackColor = false;
			this.lbInWord.StylePriority.UseFont = false;
			this.lbInWord.StylePriority.UseTextAlignment = false;
			this.lbInWord.Text = "In word:";
			this.lbInWord.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrTable7
			// 
			this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(470.3528F, 51.04167F);
			this.xrTable7.Name = "xrTable7";
			this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tbGrandTotal});
			this.xrTable7.SizeF = new System.Drawing.SizeF(318.5634F, 25F);
			// 
			// tbGrandTotal
			// 
			this.tbGrandTotal.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell26});
			this.tbGrandTotal.Name = "tbGrandTotal";
			this.tbGrandTotal.Weight = 1D;
			// 
			// xrTableCell25
			// 
			this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell25.Multiline = true;
			this.xrTableCell25.Name = "xrTableCell25";
			this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell25.StylePriority.UseFont = false;
			this.xrTableCell25.StylePriority.UseTextAlignment = false;
			this.xrTableCell25.Text = "Grand Total:";
			this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell25.Weight = 0.58083227408864424D;
			// 
			// xrTableCell26
			// 
			this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GrandTotalAmount]")});
			this.xrTableCell26.Multiline = true;
			this.xrTableCell26.Name = "xrTableCell26";
			this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell26.StylePriority.UseBorders = false;
			this.xrTableCell26.StylePriority.UseTextAlignment = false;
			this.xrTableCell26.Text = "xrTableCell21";
			this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell26.TextFormatString = "{0:n}";
			this.xrTableCell26.Weight = 0.73041352038342444D;
			// 
			// xrTable6
			// 
			this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(470.3529F, 26.04167F);
			this.xrTable6.Name = "xrTable6";
			this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tbVATAmount});
			this.xrTable6.SizeF = new System.Drawing.SizeF(318.5632F, 25F);
			// 
			// tbVATAmount
			// 
			this.tbVATAmount.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell23,
            this.xrTableCell24});
			this.tbVATAmount.Name = "tbVATAmount";
			this.tbVATAmount.Weight = 1D;
			// 
			// xrTableCell23
			// 
			this.xrTableCell23.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell23.Multiline = true;
			this.xrTableCell23.Name = "xrTableCell23";
			this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell23.StylePriority.UseFont = false;
			this.xrTableCell23.StylePriority.UseTextAlignment = false;
			this.xrTableCell23.Text = "VAT Amount:";
			this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell23.Weight = 0.58083202262806122D;
			// 
			// xrTableCell24
			// 
			this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TaxAmount]")});
			this.xrTableCell24.Multiline = true;
			this.xrTableCell24.Name = "xrTableCell24";
			this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell24.StylePriority.UseBorders = false;
			this.xrTableCell24.StylePriority.UseTextAlignment = false;
			this.xrTableCell24.Text = "xrTableCell21";
			this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell24.TextFormatString = "{0:n}";
			this.xrTableCell24.Weight = 0.73041326908742787D;
			// 
			// tbVAT
			// 
			this.tbVAT.LocationFloat = new DevExpress.Utils.PointFloat(51.80426F, 26.04167F);
			this.tbVAT.Name = "tbVAT";
			this.tbVAT.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
			this.tbVAT.SizeF = new System.Drawing.SizeF(126.0616F, 25F);
			// 
			// xrTableRow5
			// 
			this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20,
            this.xrTableCell22});
			this.xrTableRow5.Name = "xrTableRow5";
			this.xrTableRow5.Weight = 1D;
			// 
			// xrTableCell20
			// 
			this.xrTableCell20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell20.Multiline = true;
			this.xrTableCell20.Name = "xrTableCell20";
			this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell20.StylePriority.UseFont = false;
			this.xrTableCell20.StylePriority.UseTextAlignment = false;
			this.xrTableCell20.Text = "VAT:";
			this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell20.Weight = 0.2249591398881885D;
			// 
			// xrTableCell22
			// 
			this.xrTableCell22.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tax]")});
			this.xrTableCell22.Multiline = true;
			this.xrTableCell22.Name = "xrTableCell22";
			this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell22.StylePriority.UseBorders = false;
			this.xrTableCell22.StylePriority.UseTextAlignment = false;
			this.xrTableCell22.Text = "xrTableCell21";
			this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell22.TextFormatString = "{0}%";
			this.xrTableCell22.Weight = 0.29392594248587595D;
			// 
			// tbSubTotal
			// 
			this.tbSubTotal.LocationFloat = new DevExpress.Utils.PointFloat(470.3529F, 0F);
			this.tbSubTotal.Name = "tbSubTotal";
			this.tbSubTotal.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
			this.tbSubTotal.SizeF = new System.Drawing.SizeF(318.5635F, 25F);
			// 
			// xrTableRow4
			// 
			this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell21});
			this.xrTableRow4.Name = "xrTableRow4";
			this.xrTableRow4.Weight = 1D;
			// 
			// xrTableCell19
			// 
			this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.xrTableCell19.Multiline = true;
			this.xrTableCell19.Name = "xrTableCell19";
			this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell19.StylePriority.UseFont = false;
			this.xrTableCell19.StylePriority.UseTextAlignment = false;
			this.xrTableCell19.Text = "Total:";
			this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell19.Weight = 0.58083217513518726D;
			// 
			// xrTableCell21
			// 
			this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
			this.xrTableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubTotalAmount]")});
			this.xrTableCell21.Multiline = true;
			this.xrTableCell21.Name = "xrTableCell21";
			this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrTableCell21.StylePriority.UseBorders = false;
			this.xrTableCell21.StylePriority.UseTextAlignment = false;
			this.xrTableCell21.Text = "xrTableCell21";
			this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell21.TextFormatString = "{0:n}";
			this.xrTableCell21.Weight = 0.73041392113506887D;
			// 
			// xrPageInfo
			// 
			this.xrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(682.5078F, 89.49998F);
			this.xrPageInfo.Name = "xrPageInfo";
			this.xrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo.SizeF = new System.Drawing.SizeF(98.49207F, 23F);
			this.xrPageInfo.TextFormatString = "Page {0}/{1}";
			// 
			// xrCrossBandLine1
			// 
			this.xrCrossBandLine1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
			this.xrCrossBandLine1.EndBand = this.groupHeaderBand1;
			this.xrCrossBandLine1.EndPointFloat = new DevExpress.Utils.PointFloat(2.083238F, 125.5534F);
			this.xrCrossBandLine1.LocationFloat = new DevExpress.Utils.PointFloat(2.083238F, 123.4701F);
			this.xrCrossBandLine1.Name = "xrCrossBandLine1";
			this.xrCrossBandLine1.StartBand = this.groupHeaderBand1;
			this.xrCrossBandLine1.StartPointFloat = new DevExpress.Utils.PointFloat(2.083238F, 123.4701F);
			this.xrCrossBandLine1.WidthF = 786.8334F;
			// 
			// xrCrossBandLine2
			// 
			this.xrCrossBandLine2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
			this.xrCrossBandLine2.EndBand = this.groupHeaderBand1;
			this.xrCrossBandLine2.EndPointFloat = new DevExpress.Utils.PointFloat(2.083238F, 260.5717F);
			this.xrCrossBandLine2.LocationFloat = new DevExpress.Utils.PointFloat(2.083238F, 258.4883F);
			this.xrCrossBandLine2.Name = "xrCrossBandLine2";
			this.xrCrossBandLine2.StartBand = this.groupHeaderBand1;
			this.xrCrossBandLine2.StartPointFloat = new DevExpress.Utils.PointFloat(2.083238F, 258.4883F);
			this.xrCrossBandLine2.WidthF = 786.8333F;
			// 
			// rtCopytight
			// 
			this.rtCopytight.Font = new System.Drawing.Font("Times New Roman", 9.75F);
			this.rtCopytight.LocationFloat = new DevExpress.Utils.PointFloat(119.7914F, 89.49998F);
			this.rtCopytight.Name = "rtCopytight";
			this.rtCopytight.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.rtCopytight.SerializableRtfString = resources.GetString("rtCopytight.SerializableRtfString");
			this.rtCopytight.SizeF = new System.Drawing.SizeF(550.0065F, 23.00002F);
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo,
            this.rtCopytight});
			this.ReportFooter.HeightF = 112.5F;
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.PrintAtBottom = true;
			// 
			// xrCrossBandLine4
			// 
			this.xrCrossBandLine4.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
			this.xrCrossBandLine4.EndBand = this.groupFooterBand1;
			this.xrCrossBandLine4.EndPointFloat = new DevExpress.Utils.PointFloat(2.083365F, 158.7549F);
			this.xrCrossBandLine4.LocationFloat = new DevExpress.Utils.PointFloat(2.083365F, 156.6715F);
			this.xrCrossBandLine4.Name = "xrCrossBandLine4";
			this.xrCrossBandLine4.StartBand = this.groupFooterBand1;
			this.xrCrossBandLine4.StartPointFloat = new DevExpress.Utils.PointFloat(2.083365F, 156.6715F);
			this.xrCrossBandLine4.WidthF = 786.8329F;
			// 
			// xrCrossBandLine3
			// 
			this.xrCrossBandLine3.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
			this.xrCrossBandLine3.EndBand = this.groupFooterBand1;
			this.xrCrossBandLine3.EndPointFloat = new DevExpress.Utils.PointFloat(2.083365F, 125.6715F);
			this.xrCrossBandLine3.LocationFloat = new DevExpress.Utils.PointFloat(2.083365F, 123.5882F);
			this.xrCrossBandLine3.Name = "xrCrossBandLine3";
			this.xrCrossBandLine3.StartBand = this.groupFooterBand1;
			this.xrCrossBandLine3.StartPointFloat = new DevExpress.Utils.PointFloat(2.083365F, 123.5882F);
			this.xrCrossBandLine3.WidthF = 786.8329F;
			// 
			// xrLabel1
			// 
			this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InWord]")});
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(148.958F, 127.7549F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(632.0419F, 28.91661F);
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "xrLabel1";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// InvoiceReport
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.groupHeaderBand1,
            this.groupFooterBand1,
            this.ReportFooter});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.excelDataSource1});
			this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandLine4,
            this.xrCrossBandLine3,
            this.xrCrossBandLine2,
            this.xrCrossBandLine1,
            this.xrCrossBandBox1});
			this.DataMember = "Invoices";
			this.DataSource = this.sqlDataSource1;
			this.Margins = new System.Drawing.Printing.Margins(18, 18, 50, 50);
			this.PageHeight = 1169;
			this.PageWidth = 827;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IDParameter});
			this.Version = "18.1";
			((System.ComponentModel.ISupportInitialize)(this.tbItemDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSymbol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbItemHeader)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbVAT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSubTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rtCopytight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

	private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
	{

	}

	private void xrTableCell11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
	{

	}
}
