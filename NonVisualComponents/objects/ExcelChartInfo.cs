using NonVisualComponents.Enums;

namespace NonVisualComponents.objects
{
	public class ExcelChartInfo
	{
		public string? filePath { get; set; } = string.Empty;
		public string? documentTitle { get; set; } = string.Empty;
		public string? chartTitle { get; set; } = string.Empty;
		public EnumAreaLegend enumAreaLegend { get; set; }
		public List<DataItem>? data { get; set; }

		public ExcelChartInfo(string? filePath, string? documentTitle, string? chartTitle, EnumAreaLegend enumAreaLegend, List<DataItem>? data)
		{
			this.filePath = filePath;
			this.documentTitle = documentTitle;
			this.chartTitle = chartTitle;
			this.enumAreaLegend = enumAreaLegend;
			this.data = data;
		}
	}
}
