/*
 * Сделано в SharpDevelop.
 * Пользователь: user
 * Дата: 25.10.2013
 * Время: 2:22
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Tetris
{
	partial class NewRecordDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.UNameTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Поздравляем, вы попали в таблицу рекордов! Введите ваше имя:";
			// 
			// UNameTextBox
			// 
			this.UNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.UNameTextBox.Location = new System.Drawing.Point(12, 47);
			this.UNameTextBox.Name = "UNameTextBox";
			this.UNameTextBox.Size = new System.Drawing.Size(168, 20);
			this.UNameTextBox.TabIndex = 1;
			this.UNameTextBox.Text = "User";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(186, 45);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Готово!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// NewRecordDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 77);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.UNameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewRecordDialog";
			this.ShowIcon = false;
			this.Text = "Новый рекорд!";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox UNameTextBox;
		private System.Windows.Forms.Label label1;
	}
}
