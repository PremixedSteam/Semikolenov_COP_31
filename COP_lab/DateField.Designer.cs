namespace COP_lab
{
    partial class DateField
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DateTextBox = new TextBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(16, 27);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(192, 23);
            DateTextBox.TabIndex = 0;
            DateTextBox.TextChanged += textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Date textBox";
            // 
            // DateField
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(DateTextBox);
            Name = "DateField";
            Size = new Size(223, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DateTextBox;
        private ToolTip toolTip1;
        private Label label1;
    }
}
