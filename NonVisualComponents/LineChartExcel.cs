using OfficeOpenXml;
using System.ComponentModel;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Drawing.Chart;
using NonVisualComponents.objects;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace NonVisualComponents
{
	public partial class LineChartExcel : Component
	{
		public LineChartExcel()
		{
			InitializeComponent();
		}

		public LineChartExcel(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		public void GenerateChartExcel( ExcelChartInfo info)
		{
			if (string.IsNullOrEmpty(info.filePath))
			{
				throw new ArgumentException("File path is null or empty.");
			}
			if (string.IsNullOrEmpty(info.chartTitle))
			{
				throw new ArgumentException("Chart title is null or empty.");
			}
			if (string.IsNullOrEmpty(info.documentTitle))
			{
				throw new ArgumentException("Document title is null or empty.");
			}
			if (info.data == null || info.data.Count == 0)
			{
				throw new ArgumentException("Data is null or empty.");
			}

			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			using ExcelPackage excelPackage = new();

			ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
			worksheet.Cells["A1"].Value = info.documentTitle;

			int row = 2;
			int startCol = 1;
			int endCol = 1;

			foreach (var data in info.data)
			{
				worksheet.Cells[row, endCol].Value = data.Name;
				worksheet.Cells[row + 1, endCol].Value = data.Value;
				endCol++;
			}

			ExcelLineChart? lineChart = worksheet.Drawings.AddChart(info.chartTitle, eChartType.Line) as ExcelLineChart;
			lineChart.Title.Text = info.chartTitle;
			lineChart.Series.Add(ExcelCellBase.GetAddress(row + 1, startCol, row + 1, endCol - 1),
				ExcelCellBase.GetAddress(row, startCol, row, endCol - 1));
			lineChart.Legend.Position = (eLegendPosition)(int)info.enumAreaLegend;
			lineChart.DataLabel.ShowPercent = true;
			lineChart.SetPosition(1, 0, 0, 0);
			FileInfo fi = new(info.filePath);
			excelPackage.SaveAs(fi);
		}
	}
}
