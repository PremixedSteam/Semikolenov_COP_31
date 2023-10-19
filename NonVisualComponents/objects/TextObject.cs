using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonVisualComponents.objects
{
	public class TextObject
	{
		public string FilePath = string.Empty;
		public string DocumentTitle = string.Empty;
		public string[] TextData;
		public TextObject(string filePath, string documentTitle, string[] textData) 
		{
			FilePath = filePath;
			DocumentTitle = documentTitle;
			TextData = textData;
		}
	}
}
