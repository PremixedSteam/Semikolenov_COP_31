namespace TestForms
{
    partial class NonVisualForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bigDataExcel1 = new NonVisualComponents.BigDataExcel(components);
            groupBox1 = new GroupBox();
            buttonBigDataSave = new Button();
            richTextBox = new RichTextBox();
            groupBox2 = new GroupBox();
            buttonSaveTable = new Button();
            groupBox3 = new GroupBox();
            buttonSaveChart = new Button();
            lineChartExcel1 = new NonVisualComponents.LineChartExcel(components);
            tableExcel1 = new NonVisualComponents.TableExcel(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonBigDataSave);
            groupBox1.Controls.Add(richTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Big Data Excel";
            // 
            // buttonBigDataSave
            // 
            buttonBigDataSave.Location = new Point(86, 397);
            buttonBigDataSave.Name = "buttonBigDataSave";
            buttonBigDataSave.Size = new Size(75, 23);
            buttonBigDataSave.TabIndex = 1;
            buttonBigDataSave.Text = "Save";
            buttonBigDataSave.UseVisualStyleBackColor = true;
            buttonBigDataSave.Click += buttonBigDataSave_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(6, 22);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(273, 369);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSaveTable);
            groupBox2.Location = new Point(328, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "TableExcel";
            // 
            // buttonSaveTable
            // 
            buttonSaveTable.Location = new Point(85, 210);
            buttonSaveTable.Name = "buttonSaveTable";
            buttonSaveTable.Size = new Size(75, 23);
            buttonSaveTable.TabIndex = 0;
            buttonSaveTable.Text = "button1";
            buttonSaveTable.UseVisualStyleBackColor = true;
            buttonSaveTable.Click += buttonSaveTable_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonSaveChart);
            groupBox3.Location = new Point(631, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(291, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // buttonSaveChart
            // 
            buttonSaveChart.Location = new Point(82, 210);
            buttonSaveChart.Name = "buttonSaveChart";
            buttonSaveChart.Size = new Size(75, 23);
            buttonSaveChart.TabIndex = 0;
            buttonSaveChart.Text = "button2";
            buttonSaveChart.UseVisualStyleBackColor = true;
            buttonSaveChart.Click += buttonSaveChart_Click;
            // 
            // NonVisualForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NonVisualForm";
            Text = "NonVisualForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NonVisualComponents.BigDataExcel bigDataExcel1;
        private GroupBox groupBox1;
        private Button buttonBigDataSave;
        private RichTextBox richTextBox;
        private GroupBox groupBox2;
        private Button buttonSaveTable;
        private GroupBox groupBox3;
        private Button buttonSaveChart;
        private NonVisualComponents.LineChartExcel lineChartExcel1;
        private NonVisualComponents.TableExcel tableExcel1;
    }
}