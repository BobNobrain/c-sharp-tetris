/*
 * Сделано в SharpDevelop.
 * Пользователь: user
 * Дата: 25.10.2013
 * Время: 2:22
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Форма ввода имени пользователя
	/// </summary>
	public partial class NewRecordDialog : Form
	{
		public string UserName {get; set;}
		public NewRecordDialog()
		{
			InitializeComponent();
			if(UserName!="")
				UNameTextBox.Text=UserName;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			UNameTextBox.Text=UNameTextBox.Text.Trim(' ');
			if(UNameTextBox.Text=="") return;
			UserName=UNameTextBox.Text;
			DialogResult=DialogResult.OK;
		}
	}
}
