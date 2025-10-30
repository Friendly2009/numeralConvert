namespace WindowsFormsApp1
{
	partial class Form1
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.result = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.input = new System.Windows.Forms.TextBox();
			this.ChooseLast = new System.Windows.Forms.ComboBox();
			this.ChooseFirst = new System.Windows.Forms.ComboBox();
			this.MainButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(264, 18);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 13);
			this.result.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(245, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "=";
			// 
			// input
			// 
			this.input.Location = new System.Drawing.Point(139, 15);
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(100, 20);
			this.input.TabIndex = 9;
			// 
			// ChooseLast
			// 
			this.ChooseLast.FormattingEnabled = true;
			this.ChooseLast.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10 ",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16 ",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
			this.ChooseLast.Location = new System.Drawing.Point(688, 18);
			this.ChooseLast.Name = "ChooseLast";
			this.ChooseLast.Size = new System.Drawing.Size(121, 21);
			this.ChooseLast.TabIndex = 8;
			// 
			// ChooseFirst
			// 
			this.ChooseFirst.FormattingEnabled = true;
			this.ChooseFirst.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10 ",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16 ",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
			this.ChooseFirst.Location = new System.Drawing.Point(12, 15);
			this.ChooseFirst.Name = "ChooseFirst";
			this.ChooseFirst.Size = new System.Drawing.Size(121, 21);
			this.ChooseFirst.TabIndex = 7;
			// 
			// MainButton
			// 
			this.MainButton.Location = new System.Drawing.Point(12, 122);
			this.MainButton.Name = "MainButton";
			this.MainButton.Size = new System.Drawing.Size(797, 30);
			this.MainButton.TabIndex = 6;
			this.MainButton.Text = "Посчитать";
			this.MainButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 170);
			this.Controls.Add(this.result);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.input);
			this.Controls.Add(this.ChooseLast);
			this.Controls.Add(this.ChooseFirst);
			this.Controls.Add(this.MainButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox input;
		private System.Windows.Forms.ComboBox ChooseLast;
		private System.Windows.Forms.ComboBox ChooseFirst;
		private System.Windows.Forms.Button MainButton;
	}
}

