/*
 * Сделано в SharpDevelop.
 * Пользователь: user
 * Дата: 08.11.2013
 * Время: 18:18
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Tetris
{
	partial class AboutDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(241, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ещё один тетрис";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(401, 102);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(17, 30);
			this.linkLabel1.Location = new System.Drawing.Point(12, 113);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(182, 23);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Контакты автора: Иванов Никита";
			this.linkLabel1.UseCompatibleTextRendering = true;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(313, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Закрыть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Сделано в МИФИ";
			// 
			// linkLabel2
			// 
			this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(21, 30);
			this.linkLabel2.Location = new System.Drawing.Point(12, 136);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(209, 23);
			this.linkLabel2.TabIndex = 6;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Иконка приложения -  Everaldo Coelho ";
			this.linkLabel2.UseCompatibleTextRendering = true;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
			// 
			// AboutDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 185);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.Text = "О программе";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
