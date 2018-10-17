using DevExpress.Web.Mvc;
using EInvoice.Data.Services;
using EInvoice.Service;
using EInvoice.Web.Models;

namespace EInvoice.Web.Code.Helpers
{
	public class CategoryViewHelper
	{
		static IUnitService _unitService;
		public CategoryViewHelper(IUnitService unitService)
		{
			_unitService = unitService;
		}
		public const string KeyFieldName = "ProductID";

		static MVCxGridViewColumnCollection exportedColumns;
		public static MVCxGridViewColumnCollection ExportedColumns
		{
			get
			{
				if (exportedColumns == null)
					exportedColumns = CreateExportedColumns();
				return exportedColumns;
			}
		}

		static GridViewSettings exportGridSettings;
		public static GridViewSettings ExportGridSettings
		{
			get
			{
				if (exportGridSettings == null)
					exportGridSettings = CreateExportGridSettings();
				return exportGridSettings;
			}
		}

		static MVCxGridViewColumnCollection CreateExportedColumns()
		{
			var columns = new MVCxGridViewColumnCollection();
			columns.Add("ProductCode");
			columns.Add("Name");
			columns.Add(
				c=>
				{
					c.FieldName= "Price";
					c.EditorProperties().SpinEdit(p => {
						p.DisplayFormatString = "c";
						p.DisplayFormatInEditMode = true;
					});
				});
			columns.Add(c => {
				c.FieldName = "UnitID";
				c.Caption = "Unit";
				c.EditorProperties().ComboBox(p => {
					p.TextField = "Name";
					p.ValueField = "UnitID";
					p.ValueType = typeof(int);
					p.BindList(_unitService.GetAll());
				});
				
			});
			columns.Add("Tax");
			columns.Add("Description");
			return columns;
		}

		static GridViewSettings CreateExportGridSettings()
		{
			var settings = new GridViewSettings();
			settings.Name = "grid";
			settings.KeyFieldName = KeyFieldName;
			settings.Columns.Assign(ExportedColumns);
			return settings;
		}
	}
}