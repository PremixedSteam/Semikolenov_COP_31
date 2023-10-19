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
            string path = @"C:\\Users\\georg\\Documents\\testtable.xlsx";
            string title = "title";
            var dataList = new List<Employee>
            {
                new Employee { Id = 1, Status = "Active", Name = "John", Surname = "Doe", Age = "30", Department = "IT", Position = "Manager" },
                new Employee { Id = 2, Status = "Active", Name = "Jane", Surname = "Smith", Age = "35", Department = "Design", Position = "Senior" },
            };
            var mergeInfo = new Dictionary<int, (string, int)>()
            {
                { 3, ("personal data", 3)},
                { 8, ("work", 2)},
            };

			var info = new ExcelTableInfo<Employee>(path, "Sample Document", dataList, mergeInfo);

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
    }
}
