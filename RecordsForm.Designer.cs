/*
 * Сделано в SharpDevelop.
 * Пользователь: user
 * Дата: 31.10.2013
 * Время: 18:59
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Tetris
{
	partial class RecordsForm
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
			this.ListsTabControl = new System.Windows.Forms.TabControl();
			this.ScoresTabPage = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.ScoresListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.TimesTabPage = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.TimesListView = new System.Windows.Forms.ListView();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.button1 = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.ListsTabControl.SuspendLayout();
			this.ScoresTabPage.SuspendLayout();
			this.TimesTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// ListsTabControl
			// 
			this.ListsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.ListsTabControl.Controls.Add(this.ScoresTabPage);
			this.ListsTabControl.Controls.Add(this.TimesTabPage);
			this.ListsTabControl.Location = new System.Drawing.Point(12, 12);
			this.ListsTabControl.Name = "ListsTabControl";
			this.ListsTabControl.SelectedIndex = 0;
			this.ListsTabControl.Size = new System.Drawing.Size(403, 270);
			this.ListsTabControl.TabIndex = 0;
			// 
			// ScoresTabPage
			// 
			this.ScoresTabPage.Controls.Add(this.label1);
			this.ScoresTabPage.Controls.Add(this.ScoresListView);
			this.ScoresTabPage.Location = new System.Drawing.Point(4, 22);
			this.ScoresTabPage.Name = "ScoresTabPage";
			this.ScoresTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ScoresTabPage.Size = new System.Drawing.Size(395, 244);
			this.ScoresTabPage.TabIndex = 0;
			this.ScoresTabPage.Text = "По очкам";
			this.ScoresTabPage.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(6, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(383, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Игроки, набравшие наибольшее количество очков:";
			// 
			// ScoresListView
			// 
			this.ScoresListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.ScoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.ScoresListView.FullRowSelect = true;
			this.ScoresListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ScoresListView.Location = new System.Drawing.Point(6, 29);
			this.ScoresListView.Name = "ScoresListView";
			this.ScoresListView.Size = new System.Drawing.Size(383, 209);
			this.ScoresListView.TabIndex = 0;
			this.ScoresListView.UseCompatibleStateImageBehavior = false;
			this.ScoresListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Игрок";
			this.columnHeader1.Width = 84;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Очки";
			this.columnHeader2.Width = 72;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Время игры";
			this.columnHeader3.Width = 99;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Дата";
			this.columnHeader4.Width = 107;
			// 
			// TimesTabPage
			// 
			this.TimesTabPage.Controls.Add(this.label2);
			this.TimesTabPage.Controls.Add(this.TimesListView);
			this.TimesTabPage.Location = new System.Drawing.Point(4, 22);
			this.TimesTabPage.Name = "TimesTabPage";
			this.TimesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.TimesTabPage.Size = new System.Drawing.Size(395, 244);
			this.TimesTabPage.TabIndex = 1;
			this.TimesTabPage.Text = "По времени";
			this.TimesTabPage.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(6, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(383, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Игроки, продержавшиеся наибольшее количество времени:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// TimesListView
			// 
			this.TimesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.TimesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7,
									this.columnHeader8});
			this.TimesListView.FullRowSelect = true;
			this.TimesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.TimesListView.Location = new System.Drawing.Point(6, 29);
			this.TimesListView.Name = "TimesListView";
			this.TimesListView.Size = new System.Drawing.Size(383, 211);
			this.TimesListView.TabIndex = 2;
			this.TimesListView.UseCompatibleStateImageBehavior = false;
			this.TimesListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Игрок";
			this.columnHeader5.Width = 84;
			// 
			// columnHeader6
			// 
			this.columnHeader6.DisplayIndex = 2;
			this.columnHeader6.Text = "Очки";
			this.columnHeader6.Width = 72;
			// 
			// columnHeader7
			// 
			this.columnHeader7.DisplayIndex = 1;
			this.columnHeader7.Text = "Время игры";
			this.columnHeader7.Width = 99;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Дата";
			this.columnHeader8.Width = 107;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(335, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Играть ещё!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
			this.linkLabel1.Location = new System.Drawing.Point(12, 293);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(55, 23);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Закрыть";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// RecordsForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.linkLabel1;
			this.ClientSize = new System.Drawing.Size(427, 323);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ListsTabControl);
			this.MaximizeBox = false;
			this.Name = "RecordsForm";
			this.ShowIcon = false;
			this.Text = "Таблица рекордов";
			this.ListsTabControl.ResumeLayout(false);
			this.ScoresTabPage.ResumeLayout(false);
			this.TimesTabPage.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ListView TimesListView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView ScoresListView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage TimesTabPage;
		private System.Windows.Forms.TabPage ScoresTabPage;
		private System.Windows.Forms.TabControl ListsTabControl;
	}
}
