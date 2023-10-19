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

			int posString = 2;
			int posColumn = 1;
			int count = 1;
			int localCount = 0;
			
			foreach(var item in info.Properties)
			{
				if (info.MergeInfo.ContainsKey(count))
				{
					localCount = info.MergeInfo[count].Item2;
					var mergeStartCelRef = CellReference.ConvertNumToColString(posColumn) + (posString + 1);
					var mergeEndCelRef = CellReference.ConvertNumToColString(posColumn + localCount) + (posString + 1);

					sheet.AddMergedRegion(new CellRangeAddress(posString, posString, posColumn, posColumn + localCount));
					var mergeCell = sheet.GetRow(posString).CreateCell(posColumn);
					mergeCell.SetCellValue(info.MergeInfo[count].Item2);
				}
				if (localCount > 0)
				{
					sheet.CreateRow(posString + 1).CreateCell(posColumn).SetCellValue(item);
					localCount--;
				}
				else
				{
					sheet.AddMergedRegion(new CellRangeAddress(posString, posString+1, posColumn, posColumn));
					var mergeCell = sheet.GetRow(posString).CreateCell(posColumn);
					mergeCell.SetCellValue(item);
				}
				posColumn++;
				count++;
			}
		}

	}
}

