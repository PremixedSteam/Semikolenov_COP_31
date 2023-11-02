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
			cellStyle.BorderLeft = BorderStyle.Thin;
			cellStyle.BorderRight = BorderStyle.Thin;
			cellStyle.BorderTop = BorderStyle.Thin;
			cellStyle.BorderBottom = BorderStyle.Thin;
			IFont font = workbook.CreateFont();
			font.FontName = "Times New Roman";
			font.FontHeightInPoints = 15;
			cellStyle.SetFont(font);
			
			

			foreach (var property in typeof(T).GetProperties())
			{
				if (!info.Properties.ContainsKey(property.Name))
				{
					throw new ArgumentException($"property {1} is not in dictionary", property.Name);
				}
				if (info.MergeInfo.ContainsKey(count))
				{
					localCount = info.MergeInfo[count].Item2;
					CellRangeAddress MergedRegion = new CellRangeAddress(posString, posString, posColumn, posColumn + localCount - 1);
                    for (int currentCell = MergedRegion.FirstColumn; currentCell <= MergedRegion.LastColumn; currentCell++)
                    {
						upper.CreateCell(currentCell);
                        upper.Cells[currentCell].CellStyle = cellStyle;
                    }
                    sheet.AddMergedRegion(MergedRegion);
					var mergeCell = upper.Cells[posColumn];
					mergeCell.SetCellValue(info.MergeInfo[count].Item1);					
				}
				if (localCount > 0)
				{
					lower.CreateCell(posColumn).SetCellValue(info.Properties[property.Name]);
					lower.GetCell(posColumn).CellStyle = cellStyle;
					localCount--;
				}
				else
				{
					CellRangeAddress MergedRegion = new CellRangeAddress(posString, posString + 1, posColumn, posColumn);                    
                    sheet.AddMergedRegion(MergedRegion);
					var mergeCell = upper.CreateCell(posColumn);
					mergeCell.SetCellValue(info.Properties[property.Name]);
					upper.GetCell(posColumn).CellStyle = cellStyle;

				}
				if (posColumn< info.Widths.Length)
				{
					//sheet.SetColumnWidth(posColumn, info.Widths[posColumn]);
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
					var property = type.GetProperty(item.Key);
					var value = property?.GetValue(data);
					row.CreateCell(posColumn).SetCellValue(Convert.ToString(value));
					row.GetCell(posColumn).CellStyle= cellStyle;
					posColumn++;
				}
			}
			using var fs = new FileStream(info.FilePath, FileMode.Create, FileAccess.Write);
			workbook.Write(fs);
		}

	}
}

