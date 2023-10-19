using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP_lab
{
	public partial class ValueList : UserControl
	{
        private string layoutString;        
        private string startSymbol;
        private string endSymbol;
        public ValueList()
		{
			InitializeComponent();
		}

        //установка информации 
        public void SetLayoutInfo(string layout, string startS, string endS)
        {
            if (layout == null || startS == null || endS == null)
            {
                return;
            }
            layoutString = layout;
            startSymbol = startS;
            endSymbol = endS;
        }

        //получение и заполнение индекса выбранного элемента 
        public int SelectedIndex
        {
            get
            {
                if (listBox.SelectedIndex == -1)
                {
                    return -1;
                }
                return listBox.SelectedIndex;
            }
            set
            {
                if (listBox.SelectedItems.Count != 0)
                {
                    listBox.SelectedIndex = value;
                }
            }
        }
        //полученоие обьекта из строки
        public T GetObjectFromStr<T>() where T : class, new()
        {
            string selStr = "";
            if (listBox.SelectedIndex != -1)
            {
                selStr = listBox.SelectedItem.ToString()!;
            }
            T curObject = new T();
            foreach (var property in typeof(T).GetProperties())
            {
                if (!property.CanWrite)
                {
                    continue;
                }
                int borderOne = selStr.IndexOf(startSymbol);
                int borderTwo = selStr.IndexOf(endSymbol);
                if (borderOne == -1 || borderTwo == -1) break;
                string propertyValue = selStr.Substring(borderOne + 1, borderTwo - borderOne - 1);
                selStr = selStr.Substring(borderTwo + 1);
                property.SetValue(curObject, Convert.ChangeType(propertyValue, property.PropertyType));
            }
            return curObject;
        }
        //добавление обьекта
        public void AddInListBox<T>(T objects)
        {
            if (layoutString == null || startSymbol == null || endSymbol == null)
            {
                throw new Exception("заполните информацию о макетной строке");
            }
            if (!layoutString.Contains(startSymbol) || !layoutString.Contains(endSymbol))
            {
                throw new Exception("Макетная строка не содержит нужные элементы");
            }
            
            string str = layoutString;
            foreach (var prop in objects.GetType().GetProperties())
            {
                string str1 = $"{startSymbol}" + $"{prop.Name}" + $"{endSymbol}";
                str = str.Replace(str1, $"{startSymbol}" + prop.GetValue(objects).ToString() + $"{endSymbol}");
            }
            listBox.Items.Add(str);

        }
    }
}
