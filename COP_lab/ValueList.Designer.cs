﻿namespace COP_lab
{
	partial class ValueList
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
			listBox = new ListBox();
			SuspendLayout();
			// 
			// listBox
			// 
			listBox.FormattingEnabled = true;
			listBox.ItemHeight = 15;
			listBox.Location = new Point(3, 3);
			listBox.Name = "listBox";
			listBox.Size = new Size(519, 139);
			listBox.TabIndex = 0;
			// 
			// ValueList
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(listBox);
			Name = "ValueList";
			Size = new Size(525, 150);
			ResumeLayout(false);
		}

		#endregion

		private ListBox listBox;
	}
}
