/*
 * Сделано в SharpDevelop.
 * Пользователь: user
 * Дата: 31.10.2013
 * Время: 18:59
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Форма для отображения списка рекордов
	/// </summary>
	public partial class RecordsForm : Form
	{
		public RecordsForm(TetrisSave current)
		{
			
			InitializeComponent();
			
			for(int i=0; i<10; i++)
			{
				TetrisSave tmp=Saver.HighScores[i];
				bool eq=(tmp.UserName==current.UserName 
				         && tmp.GameDuration==current.GameDuration 
				         && tmp.Score==current.Score);
				
				ScoresListView.Items.Add(new TSLVItem(tmp, eq));
				
				tmp=Saver.HighTimes[i];
				eq=(tmp.UserName==current.UserName 
				         && tmp.GameDuration==current.GameDuration 
				         && tmp.Score==current.Score);
				
				TimesListView.Items.Add(new TSLVItem(tmp, eq));
			}
		}
		public RecordsForm(TetrisSave current, bool isHighTime): this(current)
		{
			if(isHighTime)
			{
				ListsTabControl.SelectedTab=TimesTabPage;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			DialogResult=DialogResult.OK;
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			DialogResult=DialogResult.Cancel;			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
	}
	
	public class TSLVItem : ListViewItem //Tetris save list view item
	{
		public TetrisSave Save {get; private set;}
		
		public TSLVItem(TetrisSave sv, bool hilight):base()
		{
			Save=sv;
			Text=sv.UserName;
			SubItems.Add(sv.Score.ToString());
			SubItems.Add(TimeSpanToStr(sv.GameDuration));
			SubItems.Add(sv.GameEnded.ToShortDateString());
			
			if(hilight)
			{
				this.UseItemStyleForSubItems=true;
				this.BackColor=Color.FromArgb(255, 242, 242);
				this.ForeColor=Color.FromArgb(160, 0, 0);
				Font=new Font(this.Font, FontStyle.Bold);
			}
		}
		
		private static string TimeSpanToStr(TimeSpan t)
		{
			string r=((int)(t.TotalMinutes)).ToString();
			r+=":"+(t.Seconds<10? "0":"") + t.Seconds.ToString();
			return r;
		}
	}
}
