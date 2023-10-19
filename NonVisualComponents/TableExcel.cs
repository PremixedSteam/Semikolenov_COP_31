using System.ComponentModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;
using NonVisualComponents.objects;

namespace NonVisualComponents
{
	public partial class TableExcel : Component
	{
		public TableExcel()
		{
			InitializeComponent();
		}

		public TableExcel(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
		public void GenerateTableExcel(ExcelTableInfo<object> info)
		{
			if (string.IsNullOrEmpty(info.FilePath))
			{
				throw new ArgumentException("File path is null or empty.");
			}
			if (string.IsNullOrEmpty(info.DocumentTitle))
			{
				throw new ArgumentException("Document title is null or empty.");
			}
			if (info.Data == null || info.Data.Count == 0)
			{
				throw new ArgumentException("Data is null or empty.");
			}

			// Создание документа и листа
			var workbook = new XSSFWorkbook();
			var sheet = workbook.CreateSheet("Sheet1");

			// Установка заголовка документа в первой строке листа
			sheet.CreateRow(0).CreateCell(0).SetCellValue(info.DocumentTitle);

			int posString = 2;
			int posColumn = 1;
			int count = 0;
			int localCount = 0;
			
			foreach(var item in info.Properties)
			{
				sheet.CreateRow(posString).CreateCell(posColumn).SetCellValue(item);
			}
		}

	}
}

