using System.ComponentModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;
using NonVisualComponents.objects;
using NPOI.SS.Util;

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
		public void GenerateTableExcel <T>(ExcelTableInfo<T> info)
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

			int posString = 1;
			int posColumn = 0;
			int count = 1;
			int localCount = 0;
			IRow upper = sheet.CreateRow(posString);
			IRow lower = sheet.CreateRow(posString+1);
			ICellStyle cellStyle = workbook.CreateCellStyle();
			//cellStyle.BorderLeft = BorderStyle.Thin;
			//cellStyle.BorderRight = BorderStyle.Thin;
			//cellStyle.BorderTop = BorderStyle.Thin;
			//cellStyle.BorderBottom = BorderStyle.Thin;
			

			foreach (var item in info.Properties)
			{
				if (info.MergeInfo.ContainsKey(count))
				{
					localCount = info.MergeInfo[count].Item2;
					
					sheet.AddMergedRegion(new CellRangeAddress(posString, posString, posColumn, posColumn + localCount - 1));
					var mergeCell = upper.CreateCell(posColumn);
					mergeCell.SetCellValue(info.MergeInfo[count].Item1);
				}
				if (localCount > 0)
				{
					lower.CreateCell(posColumn).SetCellValue(item);
					localCount--;
				}
				else
				{
					sheet.AddMergedRegion(new CellRangeAddress(posString, posString+1, posColumn, posColumn));
					var mergeCell = upper.CreateCell(posColumn);
					mergeCell.SetCellValue(item);
				}
				posColumn++;
				count++;
			}
			posString = 3;
			T data;
			Type type = typeof(T);
			for (int i = 0; i < info.Data.Count; i++)
			{

				posColumn = 0;
				IRow row = sheet.CreateRow(posString + i);
				data = info.Data[i];
				
				foreach (var item in info.Properties)
				{
					var property = type.GetProperty(item);
					var value = property?.GetValue(data);
					row.CreateCell(posColumn).SetCellValue(Convert.ToString(value));
					posColumn++;
				}
			}
			using var fs = new FileStream(info.FilePath, FileMode.Create, FileAccess.Write);
			workbook.Write(fs);
		}

	}
}

