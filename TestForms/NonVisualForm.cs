using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonVisualComponents;
using NonVisualComponents.Enums;
using NonVisualComponents.objects;
using OfficeOpenXml.Table;

namespace TestForms
{
    public partial class NonVisualForm : Form
    {
        TextObject info;
        public NonVisualForm()
        {
            InitializeComponent();
        }

        private void buttonBigDataSave_Click(object sender, EventArgs e)
        {
            info = new TextObject("C:\\Users\\user\\Documents\\testchart.xlsx", "My Document", richTextBox.Lines);
            try
            {
                bigDataExcel1.GenerateBigDataExcel(info);
                MessageBox.Show("Сохарнено успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveChart_Click(object sender, EventArgs e)
        {
            LineChartExcel chart = new();

            EnumAreaLegend legend = new();
            var data = new List<DataItem>()
            {
                new DataItem() { Name = "Data 1", Value = 10 },
                new DataItem() { Name = "Data 2", Value = 20 },
                new DataItem() { Name = "Data 3", Value = 30 },
                new DataItem() { Name = "Data 4", Value = 40 }
            };
            ExcelChartInfo info = new("C:\\Users\\user\\Documents\\testchart.xlsx", "My Document", "My Chart", EnumAreaLegend.Left, data);
            try
            {
                chart.GenerateChartExcel(info);
                MessageBox.Show("Сохарнено успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveTable_Click(object sender, EventArgs e)
        {
            TableExcel table = new();
            string path = @"C:\\Users\\User\\Documents\\testtable.xlsx";
            string title = "title";
            var dataList = new List<object>
            {
                new Employee { Id = 1, Status = "Active", Name = "John", Surname = "Doe", Age = "30", Department = "IT", Position = "Manager" },
                new Employee { Id = 2, Status = "Active", Name = "Jane", Surname = "Smith", Age = "35", Department = "Design", Position = "Senior" },
            };

            var info = new ExcelTableInfo(path, "Sample Document", new List<object>(), new Dictionary<string, (List<string>, List<int>)>());

            info.addDictionary("Table1", "Field1", 20);
            info.addDictionary("Table1", "Field2", 15);
            info.addDictionary("Table2", "Field1", 25);
            info.addDictionary("Table2", "Field2", 18);
            info.addDictionary("Table2", "Field3", 22);

            info.addDictionaryAlone("Table3", 30);

            info.Data.Add(new Employee1 { Department = "Dept1", Position = "Position1", Name = "Employee1" });
            info.Data.Add(new Employee1 { Department = "Dept2", Position = "Position2", Name = "Employee2" });
            info.Data.Add(new Employee1 { Department = "Dept1", Position = "Position1", Name = "Employee3" });

            dataList.Clear();
            try
            {
                table.GenerateTableExcel(info);
                MessageBox.Show("Сохарнено успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*ExcelTable table = new();

            var mergeInfo = new List<MergeInfo>
            {
                new MergeInfo { Value = "", StartRow = 0, EndRow = 0, StartCol = 0, EndCol = 1 },
                new MergeInfo { Value = "", StartRow = 1, EndRow = 1, StartCol = 0, EndCol = 1 },
                new MergeInfo { Value = "Личные данные", StartRow = 2, EndRow = 4, StartCol = 0, EndCol = 0 },
                new MergeInfo { Value = "Работа", StartRow = 5, EndRow = 6, StartCol = 0, EndCol = 0 }
            };
            var headerTitles = new List<string> { "ID", "Status", "Name", "Surname", "Age", "Department", "Position" };
            var data = new List<object>
            {
                new Employees { Id = 1, Status = "Active", Name = "John", Surname = "Doe", Age = "30", Department = "IT", Position = "Manager" },
                new Employees { Id = 2, Status = "Active", Name = "Jane", Surname = "Smith", Age = "35", Department = "Design", Position = "Senior" },
            };
            ExcelTableInfo info = new("C:\\Users\\User\\Documents\\testtable.xlsx", "My Document", mergeInfo, headerTitles, data);
            try
            {
                table.GenerateDocument(info);
                MessageBox.Show("Сохарнено успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        public class Employee
        {
            public int? Id { get; set; }
            public string? Status { get; set; } = string.Empty;
            public string? Name { get; set; } = string.Empty;
            public string? Surname { get; set; } = string.Empty;
            public string? Age { get; set; } = string.Empty;
            public string? Department { get; set; } = string.Empty;
            public string? Position { get; set; } = string.Empty;
        }
        public class Employee1
        {
            public string? Department { get; set; }
            public string? Position { get; set; }
            public string? Name { get; set; }
        }
    }
}
