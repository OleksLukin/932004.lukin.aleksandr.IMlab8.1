namespace lab81
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
			this.b_yesno = new System.Windows.Forms.Button();
			this.l_ans = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// b_yesno
			// 
			this.b_yesno.BackColor = System.Drawing.SystemColors.HotTrack;
			this.b_yesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.b_yesno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.b_yesno.Location = new System.Drawing.Point(186, 232);
			this.b_yesno.Margin = new System.Windows.Forms.Padding(2);
			this.b_yesno.Name = "b_yesno";
			this.b_yesno.Size = new System.Drawing.Size(201, 41);
			this.b_yesno.TabIndex = 0;
			this.b_yesno.Text = "Узнать ответ";
			this.b_yesno.UseVisualStyleBackColor = false;
			this.b_yesno.Click += new System.EventHandler(this.b_yesno_Click);
			// 
			// l_ans
			// 
			this.l_ans.AutoSize = true;
			this.l_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.l_ans.Location = new System.Drawing.Point(203, 305);
			this.l_ans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.l_ans.Name = "l_ans";
			this.l_ans.Size = new System.Drawing.Size(0, 25);
			this.l_ans.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBox1.Location = new System.Drawing.Point(80, 167);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(429, 20);
			this.textBox1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.Location = new System.Drawing.Point(203, 105);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Введите вопрос:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 425);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.l_ans);
			this.Controls.Add(this.b_yesno);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button b_yesno;
		private System.Windows.Forms.Label l_ans;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}

