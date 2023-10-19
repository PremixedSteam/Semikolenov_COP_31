namespace COP_lab
{
	partial class DropDownList
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
			comboBox = new ComboBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// comboBox
			// 
			comboBox.FormattingEnabled = true;
			comboBox.Location = new Point(3, 28);
			comboBox.Name = "comboBox";
			comboBox.Size = new Size(184, 23);
			comboBox.TabIndex = 0;
			comboBox.SelectedValueChanged += comboBox_SelectedValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(39, 10);
			label1.Name = "label1";
			label1.Size = new Size(110, 15);
			label1.TabIndex = 1;
			label1.Text = "custom ComboBox";
			// 
			// DropDownList
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label1);
			Controls.Add(comboBox);
			Name = "DropDownList";
			Size = new Size(190, 72);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox comboBox;
		private Label label1;
	}
}
