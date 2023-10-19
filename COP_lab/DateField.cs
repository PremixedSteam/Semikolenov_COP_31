using System.Text.RegularExpressions;
using ToolTip = System.Windows.Forms.ToolTip;

namespace COP_lab
{
    public partial class DateField : UserControl
    {
        private string? pattern;
        private string example = "16.09.2002";
        private string? Error;
        public DateField()
        {
            InitializeComponent();
        }
        public string? Pattern
        {
            get { return pattern; }
            set { pattern = value; }
        }
        public string? TextBoxValue
        {
            get
            {
                Regex regex = new Regex(Pattern);
                bool isValid = regex.IsMatch(DateTextBox.Text);
                if (isValid)
                {
                    return DateTextBox.Text;
                }
                else
                {
                    Error = "Не правильный ввод";
                    return null;
                }
            }
            set
            {
                Regex regex = new Regex(Pattern);
                bool isValid = regex.IsMatch(value);
                if (isValid)
                {
                    DateTextBox.Text = value;
                }
                else
                {
                    Error = "Не правильный ввод";
                }

            }
        }
        public void setExample(string str)
        {
            Regex regex = new Regex(Pattern);
            bool isValid = regex.IsMatch(str);
            if (isValid)
            {
                example = str;
            }

        }

        //ToolTip для вывода примера
        private void textBox_Enter(object sender, EventArgs e)
        {
            int VisibleTime = 3000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show(example, DateTextBox, 30, -20, VisibleTime);
        }

        private EventHandler _explicitEvent;
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

        //событие при смене значения
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            _explicitEvent?.Invoke(sender, e);
        }
    }
}
