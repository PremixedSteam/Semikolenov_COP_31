namespace TestForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dropDownList1 = new COP_lab.DropDownList();
            dateField1 = new COP_lab.DateField();
            valueList1 = new COP_lab.ValueList();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonAdd = new Button();
            buttonClear = new Button();
            labelShow = new Label();
            buttonShow = new Button();
            buttonShowTB = new Button();
            buttonSetExample = new Button();
            buttonAddObject = new Button();
            buttonShowInput = new Button();
            labelShowTB = new Label();
            labelExample = new Label();
            labelShowInput = new Label();
            textBoxExample = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dropDownList1
            // 
            dropDownList1.Location = new Point(6, 22);
            dropDownList1.Name = "dropDownList1";
            dropDownList1.Selected = "";
            dropDownList1.Size = new Size(190, 94);
            dropDownList1.TabIndex = 0;
            // 
            // dateField1
            // 
            dateField1.Location = new Point(6, 22);
            dateField1.Name = "dateField1";
            dateField1.Pattern = null;
            dateField1.Size = new Size(223, 65);
            dateField1.TabIndex = 1;
            // 
            // valueList1
            // 
            valueList1.Location = new Point(10, 22);
            valueList1.Name = "valueList1";
            valueList1.SelectedIndex = -1;
            valueList1.Size = new Size(350, 150);
            valueList1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonShow);
            groupBox1.Controls.Add(labelShow);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(dropDownList1);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 309);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Первый компонент";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxExample);
            groupBox2.Controls.Add(labelExample);
            groupBox2.Controls.Add(labelShowTB);
            groupBox2.Controls.Add(buttonSetExample);
            groupBox2.Controls.Add(buttonShowTB);
            groupBox2.Controls.Add(dateField1);
            groupBox2.Location = new Point(268, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(232, 309);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Второй компонент";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelShowInput);
            groupBox3.Controls.Add(buttonShowInput);
            groupBox3.Controls.Add(buttonAddObject);
            groupBox3.Controls.Add(valueList1);
            groupBox3.Location = new Point(528, 25);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(387, 309);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Третий компонент";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(10, 90);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(186, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(10, 122);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(186, 23);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelShow
            // 
            labelShow.AutoSize = true;
            labelShow.Location = new Point(10, 175);
            labelShow.Name = "labelShow";
            labelShow.Size = new Size(54, 15);
            labelShow.TabIndex = 3;
            labelShow.Text = "Элемент";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(10, 216);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(75, 23);
            buttonShow.TabIndex = 4;
            buttonShow.Text = "Проверить";
            buttonShow.UseVisualStyleBackColor = true;
            // 
            // buttonShowTB
            // 
            buttonShowTB.Location = new Point(24, 140);
            buttonShowTB.Name = "buttonShowTB";
            buttonShowTB.Size = new Size(75, 23);
            buttonShowTB.TabIndex = 2;
            buttonShowTB.Text = "Проверка";
            buttonShowTB.UseVisualStyleBackColor = true;
            // 
            // buttonSetExample
            // 
            buttonSetExample.Location = new Point(24, 251);
            buttonSetExample.Name = "buttonSetExample";
            buttonSetExample.Size = new Size(160, 23);
            buttonSetExample.TabIndex = 3;
            buttonSetExample.Text = "Поменять";
            buttonSetExample.UseVisualStyleBackColor = true;
            // 
            // buttonAddObject
            // 
            buttonAddObject.Location = new Point(114, 184);
            buttonAddObject.Name = "buttonAddObject";
            buttonAddObject.Size = new Size(198, 23);
            buttonAddObject.TabIndex = 3;
            buttonAddObject.Text = "Добавить";
            buttonAddObject.UseVisualStyleBackColor = true;
            // 
            // buttonShowInput
            // 
            buttonShowInput.Location = new Point(114, 269);
            buttonShowInput.Name = "buttonShowInput";
            buttonShowInput.Size = new Size(198, 23);
            buttonShowInput.TabIndex = 4;
            buttonShowInput.Text = "Получить";
            buttonShowInput.UseVisualStyleBackColor = true;
            // 
            // labelShowTB
            // 
            labelShowTB.AutoSize = true;
            labelShowTB.Location = new Point(27, 112);
            labelShowTB.Name = "labelShowTB";
            labelShowTB.Size = new Size(61, 15);
            labelShowTB.TabIndex = 4;
            labelShowTB.Text = "Проверка";
            // 
            // labelExample
            // 
            labelExample.AutoSize = true;
            labelExample.Location = new Point(24, 204);
            labelExample.Name = "labelExample";
            labelExample.Size = new Size(52, 15);
            labelExample.TabIndex = 5;
            labelExample.Text = "Пример";
            // 
            // labelShowInput
            // 
            labelShowInput.AutoSize = true;
            labelShowInput.Location = new Point(114, 240);
            labelShowInput.Name = "labelShowInput";
            labelShowInput.Size = new Size(42, 15);
            labelShowInput.TabIndex = 5;
            labelShowInput.Text = "Вывод";
            // 
            // textBoxExample
            // 
            textBoxExample.Location = new Point(24, 222);
            textBoxExample.Name = "textBoxExample";
            textBoxExample.Size = new Size(160, 23);
            textBoxExample.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 346);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private COP_lab.DropDownList dropDownList1;
        private COP_lab.DateField dateField1;
        private COP_lab.ValueList valueList1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonShow;
        private Label labelShow;
        private Button buttonClear;
        private Button buttonAdd;
        private TextBox textBoxExample;
        private Label labelExample;
        private Label labelShowTB;
        private Button buttonSetExample;
        private Button buttonShowTB;
        private Label labelShowInput;
        private Button buttonShowInput;
        private Button buttonAddObject;
    }
}