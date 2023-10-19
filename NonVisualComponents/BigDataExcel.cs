using System.ComponentModel;
using NPOI.XSSF.UserModel;
using NonVisualComponents.objects;

namespace NonVisualComponents
{
    public partial class BigDataExcel : Component
    {        
        public BigDataExcel()
        {
            InitializeComponent();
        }

        public BigDataExcel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
       
        public void GenerateBigDataExcel(TextObject info)
        {
			if (string.IsNullOrEmpty(info.FilePath))
			{
				throw new ArgumentNullException(nameof(info.FilePath), "File path cannot be null or empty.");
			}
			if (info.TextData == null || info.TextData.Length == 0)
			{
				throw new ArgumentException("At least one string must be provided.", nameof(info.TextData));
			}

			if (string.IsNullOrEmpty(info.DocumentTitle))
			{
				throw new ArgumentNullException(nameof(info.DocumentTitle), "Document title cannot be null or empty.");
			}

			var workbook = new XSSFWorkbook();
			var sheet = workbook.CreateSheet("Sheet1");
			sheet.CreateRow(0).CreateCell(0).SetCellValue(info.DocumentTitle);

			int startRowIndex = 2;

			for (int i = 0; i < info.TextData.Length;  i++)
			{
				sheet.CreateRow(startRowIndex + i).CreateCell(0).SetCellValue(info.TextData[i]);
			}
			using (var fs = new FileStream(info.FilePath, FileMode.Create, FileAccess.Write))
			{
				workbook.Write(fs);
			}
		}

		
	}
}
