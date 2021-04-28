namespace Cypher_Project
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.betterCipher_checkBox = new System.Windows.Forms.CheckBox();
			this.Decipher_button = new System.Windows.Forms.Button();
			this.cypher_button = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.help_button = new System.Windows.Forms.Button();
			this.Path_textBox_c = new System.Windows.Forms.TextBox();
			this.Path_textBox_dec = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Dicipher_openFile_button = new System.Windows.Forms.Button();
			this.Key_textBox_dec = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Key_textBox_c = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// betterCipher_checkBox
			// 
			this.betterCipher_checkBox.AutoSize = true;
			this.betterCipher_checkBox.Location = new System.Drawing.Point(6, 69);
			this.betterCipher_checkBox.Name = "betterCipher_checkBox";
			this.betterCipher_checkBox.Size = new System.Drawing.Size(143, 17);
			this.betterCipher_checkBox.TabIndex = 0;
			this.betterCipher_checkBox.Text = "Улучшенная шифровка";
			this.betterCipher_checkBox.UseVisualStyleBackColor = true;
			// 
			// Decipher_button
			// 
			this.Decipher_button.Location = new System.Drawing.Point(235, 95);
			this.Decipher_button.Name = "Decipher_button";
			this.Decipher_button.Size = new System.Drawing.Size(100, 23);
			this.Decipher_button.TabIndex = 1;
			this.Decipher_button.Text = "Дешифровать";
			this.Decipher_button.UseVisualStyleBackColor = true;
			// 
			// cypher_button
			// 
			this.cypher_button.Location = new System.Drawing.Point(6, 106);
			this.cypher_button.Name = "cypher_button";
			this.cypher_button.Size = new System.Drawing.Size(100, 23);
			this.cypher_button.TabIndex = 2;
			this.cypher_button.Text = "Зашифровать";
			this.cypher_button.UseVisualStyleBackColor = true;
			this.cypher_button.Click += new System.EventHandler(this.cypher_button_Click);
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.FlatAppearance.BorderSize = 2;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.button3.Location = new System.Drawing.Point(235, 41);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 22);
			this.button3.TabIndex = 4;
			this.button3.Text = "Обзор";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// help_button
			// 
			this.help_button.Location = new System.Drawing.Point(2, 2);
			this.help_button.Name = "help_button";
			this.help_button.Size = new System.Drawing.Size(75, 23);
			this.help_button.TabIndex = 6;
			this.help_button.Text = "Помощь";
			this.help_button.UseVisualStyleBackColor = true;
			this.help_button.Click += new System.EventHandler(this.help_button_Click);
			// 
			// Path_textBox_c
			// 
			this.Path_textBox_c.Location = new System.Drawing.Point(6, 43);
			this.Path_textBox_c.Name = "Path_textBox_c";
			this.Path_textBox_c.Size = new System.Drawing.Size(220, 20);
			this.Path_textBox_c.TabIndex = 7;
			// 
			// Path_textBox_dec
			// 
			this.Path_textBox_dec.Location = new System.Drawing.Point(6, 47);
			this.Path_textBox_dec.Name = "Path_textBox_dec";
			this.Path_textBox_dec.Size = new System.Drawing.Size(220, 20);
			this.Path_textBox_dec.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Dicipher_openFile_button);
			this.groupBox1.Controls.Add(this.Key_textBox_dec);
			this.groupBox1.Controls.Add(this.Path_textBox_dec);
			this.groupBox1.Controls.Add(this.Decipher_button);
			this.groupBox1.Location = new System.Drawing.Point(12, 182);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(341, 154);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Дешифровка";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Криптоключ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Путь до зашифрованного файла";
			// 
			// Dicipher_openFile_button
			// 
			this.Dicipher_openFile_button.Location = new System.Drawing.Point(235, 45);
			this.Dicipher_openFile_button.Name = "Dicipher_openFile_button";
			this.Dicipher_openFile_button.Size = new System.Drawing.Size(75, 23);
			this.Dicipher_openFile_button.TabIndex = 10;
			this.Dicipher_openFile_button.Text = "Обзор";
			this.Dicipher_openFile_button.UseVisualStyleBackColor = true;
			// 
			// Key_textBox_dec
			// 
			this.Key_textBox_dec.Location = new System.Drawing.Point(6, 97);
			this.Key_textBox_dec.Name = "Key_textBox_dec";
			this.Key_textBox_dec.Size = new System.Drawing.Size(220, 20);
			this.Key_textBox_dec.TabIndex = 9;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.Key_textBox_c);
			this.groupBox2.Controls.Add(this.Path_textBox_c);
			this.groupBox2.Controls.Add(this.cypher_button);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.betterCipher_checkBox);
			this.groupBox2.Location = new System.Drawing.Point(12, 31);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(319, 145);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Шифровка";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(112, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Криптоключ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(223, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Путь до файла для шифровки(*.txt, *.doc(x))";
			// 
			// Key_textBox_c
			// 
			this.Key_textBox_c.Location = new System.Drawing.Point(112, 108);
			this.Key_textBox_c.Name = "Key_textBox_c";
			this.Key_textBox_c.ReadOnly = true;
			this.Key_textBox_c.Size = new System.Drawing.Size(198, 20);
			this.Key_textBox_c.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 343);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.help_button);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Cypher";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.CheckBox betterCipher_checkBox;
		private System.Windows.Forms.Button Decipher_button;
		private System.Windows.Forms.Button cypher_button;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button help_button;
		private System.Windows.Forms.TextBox Path_textBox_c;
		private System.Windows.Forms.TextBox Path_textBox_dec;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox Key_textBox_dec;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox Key_textBox_c;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Dicipher_openFile_button;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

