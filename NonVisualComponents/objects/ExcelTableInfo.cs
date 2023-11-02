using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonVisualComponents.objects
{
	public class ExcelTableInfo<T>
	{
		public string? FilePath { get; set; } = string.Empty;
		public string? DocumentTitle { get; set; } = string.Empty;
		public List<T>? Data { get; set; } = new();
		public List<string>? Properties = new();
		public Dictionary<int, (string Value, int count)>? MergeInfo = new();
		public int[] Widths; 

		public ExcelTableInfo(string filePath, string documentTitle, List<T> data, List<string> properties, Dictionary<int, (string, int)>? mergeInfo, int[] widths)
		{
			FilePath = filePath;
			DocumentTitle = documentTitle;
			Data = data;
			Properties = properties;
			MergeInfo = mergeInfo;
			Widths = widths;
		}
		
	}
}
