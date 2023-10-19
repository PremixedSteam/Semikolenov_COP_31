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
		public Dictionary<string, (int StartIndex, int count)>? MergeInfo = new();

		public ExcelTableInfo(string filePath, string documentTitle, List<T> data, Dictionary<string, (int, int)>? mergeInfo)
		{
			FilePath = filePath;
			DocumentTitle = documentTitle;
			Data = data;
			foreach(var property in typeof(T).GetProperties())
			{
				Properties.Add(property.Name);
            }
			MergeInfo = mergeInfo;
		}
		
	}
}
