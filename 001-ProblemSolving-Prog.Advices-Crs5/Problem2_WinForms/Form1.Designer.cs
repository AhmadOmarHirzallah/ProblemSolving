namespace Problem2_WinForms
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && ( components != null ))
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel( );
			label1 = new Label( );
			panel2 = new Panel( );
			label2 = new Label( );
			dgPrimeNbrs = new DataGridView( );
			btnGenerateNbrs = new Button( );
			txtEnteredNbr = new TextBox( );
			label3 = new Label( );
			panel1.SuspendLayout( );
			panel2.SuspendLayout( );
			( (System.ComponentModel.ISupportInitialize)dgPrimeNbrs ).BeginInit( );
			SuspendLayout( );
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb( 113, 96, 232 );
			panel1.Controls.Add( label1 );
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Size = new Size( 1520, 103 );
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font( "Segoe UI", 36F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label1.Location = new Point( 369, 0 );
			label1.Name = "label1";
			label1.Size = new Size( 801, 96 );
			label1.TabIndex = 0;
			label1.Text = "Prime Numbers Finder";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb( 130, 125, 165 );
			panel2.Controls.Add( label2 );
			panel2.Controls.Add( dgPrimeNbrs );
			panel2.Controls.Add( btnGenerateNbrs );
			panel2.Controls.Add( txtEnteredNbr );
			panel2.Controls.Add( label3 );
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point( 0, 103 );
			panel2.Name = "panel2";
			panel2.Size = new Size( 1520, 666 );
			panel2.TabIndex = 1;
			// 
			// label2
			// 
			label2.Font = new Font( "Segoe UI", 20F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label2.ForeColor = Color.FromArgb( 38, 36, 29 );
			label2.Location = new Point( 904, 203 );
			label2.Name = "label2";
			label2.Size = new Size( 452, 62 );
			label2.TabIndex = 5;
			label2.Text = "Found Prime Numbers";
			// 
			// dgPrimeNbrs
			// 
			dgPrimeNbrs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgPrimeNbrs.Location = new Point( 904, 265 );
			dgPrimeNbrs.Name = "dgPrimeNbrs";
			dgPrimeNbrs.RowHeadersWidth = 62;
			dgPrimeNbrs.Size = new Size( 452, 377 );
			dgPrimeNbrs.TabIndex = 4;
			// 
			// btnGenerateNbrs
			// 
			btnGenerateNbrs.BackColor = Color.FromArgb( 75, 64, 154 );
			btnGenerateNbrs.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnGenerateNbrs.ForeColor = Color.AliceBlue;
			btnGenerateNbrs.Location = new Point( 58, 309 );
			btnGenerateNbrs.Name = "btnGenerateNbrs";
			btnGenerateNbrs.Size = new Size( 542, 158 );
			btnGenerateNbrs.TabIndex = 3;
			btnGenerateNbrs.Text = "Generate Prime Numbers";
			btnGenerateNbrs.UseVisualStyleBackColor = false;
			btnGenerateNbrs.Click +=  btnGenerateNbrs_Click ;
			// 
			// txtEnteredNbr
			// 
			txtEnteredNbr.BackColor = Color.FromArgb( 113, 96, 232 );
			txtEnteredNbr.BorderStyle = BorderStyle.None;
			txtEnteredNbr.Font = new Font( "Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0 );
			txtEnteredNbr.Location = new Point( 893, 24 );
			txtEnteredNbr.Multiline = true;
			txtEnteredNbr.Name = "txtEnteredNbr";
			txtEnteredNbr.Size = new Size( 463, 99 );
			txtEnteredNbr.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb( 43, 41, 55 );
			label3.Font = new Font( "Segoe UI", 26F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label3.ForeColor = SystemColors.ActiveCaption;
			label3.Location = new Point( 12, 39 );
			label3.Name = "label3";
			label3.Size = new Size( 796, 70 );
			label3.TabIndex = 1;
			label3.Text = "Please enter a positive number:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF( 10F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 1520, 781 );
			Controls.Add( panel2 );
			Controls.Add( panel1 );
			Name = "Form1";
			Text = "Form1";
			panel1.ResumeLayout( false );
			panel1.PerformLayout( );
			panel2.ResumeLayout( false );
			panel2.PerformLayout( );
			( (System.ComponentModel.ISupportInitialize)dgPrimeNbrs ).EndInit( );
			ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private TextBox txtEnteredNbr;
		private Label label3;
		private Button btnGenerateNbrs;
		private DataGridView dgPrimeNbrs;
		private Label label2;
	}
}
