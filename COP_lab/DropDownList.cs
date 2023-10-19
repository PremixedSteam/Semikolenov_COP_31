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
	public partial class DropDownList : UserControl
	{
		public DropDownList()
		{
			InitializeComponent();
		}
		public void AddingToList(string Value)
		{
			if (Value.Length == 0)
			{
				return;
			}
			comboBox.Items.Add(Value);
		}
		public void Clear()
		{
			comboBox.Items.Clear();
		}
		public string Selected
		{
			get
			{
				if (comboBox.Items.Count == 0)
				{
					return "";
				}
				if (comboBox.SelectedItem == null)
				{
					return "";
				}
				return comboBox.SelectedItem.ToString()!;
			}
			set
			{
				if (comboBox.Items.Contains(value))
				{
					comboBox.SelectedItem = value;
				}

			}
		}
		private EventHandler? _explicitEvent;
		public event EventHandler ExplicitEvent
		{
			add
			{
				_explicitEvent += value;
			}
			remove
			{
				_explicitEvent -= value;
			}
		}
		//событие, вызываемое при смене значения в ComboBox.
		private void comboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			_explicitEvent?.Invoke(sender, e);
		}
	}
}
