namespace Problem1_WinForms
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
			label2 = new Label( );
			label1 = new Label( );
			panel2 = new Panel( );
			btnReset = new Button( );
			btnGenrateTable = new Button( );
			panel3 = new Panel( );
			dgMultTableData = new DataGridView( );
			panel1.SuspendLayout( );
			panel2.SuspendLayout( );
			panel3.SuspendLayout( );
			( (System.ComponentModel.ISupportInitialize)dgMultTableData ).BeginInit( );
			SuspendLayout( );
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb( 111, 101, 79 );
			panel1.Controls.Add( label2 );
			panel1.Controls.Add( label1 );
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Size = new Size( 1921, 100 );
			panel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.FromArgb( 189, 195, 164 );
			label2.Dock = DockStyle.Bottom;
			label2.Font = new Font( "Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			label2.ForeColor = Color.FromArgb( 74, 67, 52 );
			label2.Location = new Point( 0, 71 );
			label2.Name = "label2";
			label2.Size = new Size( 635, 29 );
			label2.TabIndex = 1;
			label2.Text = "Generate a multiplication table from 1 to 10";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb( 74, 67, 52 );
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font( "Segoe UI", 16F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label1.ForeColor = Color.White;
			label1.Location = new Point( 0, 0 );
			label1.Name = "label1";
			label1.Size = new Size( 484, 45 );
			label1.TabIndex = 0;
			label1.Text = "Multiplication Table Generator";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb( 111, 101, 79 );
			panel2.Controls.Add( btnReset );
			panel2.Controls.Add( btnGenrateTable );
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point( 0, 100 );
			panel2.Name = "panel2";
			panel2.Size = new Size( 198, 589 );
			panel2.TabIndex = 1;
			// 
			// btnReset
			// 
			btnReset.AutoSize = true;
			btnReset.BackColor = Color.FromArgb( 74, 67, 52 );
			btnReset.Dock = DockStyle.Top;
			btnReset.FlatStyle = FlatStyle.Flat;
			btnReset.Font = new Font( "Segoe UI Semibold", 12F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			btnReset.ForeColor = Color.FromArgb( 245, 246, 244 );
			btnReset.Location = new Point( 0, 293 );
			btnReset.Margin = new Padding( 3, 3, 3, 15 );
			btnReset.Name = "btnReset";
			btnReset.Size = new Size( 198, 293 );
			btnReset.TabIndex = 1;
			btnReset.Text = "Rest";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click +=  btnReset_Click ;
			// 
			// btnGenrateTable
			// 
			btnGenrateTable.AutoSize = true;
			btnGenrateTable.BackColor = Color.FromArgb( 74, 67, 52 );
			btnGenrateTable.Dock = DockStyle.Top;
			btnGenrateTable.FlatAppearance.BorderSize = 0;
			btnGenrateTable.FlatStyle = FlatStyle.Flat;
			btnGenrateTable.Font = new Font( "Segoe UI Semibold", 12F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			btnGenrateTable.ForeColor = Color.FromArgb( 245, 246, 244 );
			btnGenrateTable.Location = new Point( 0, 0 );
			btnGenrateTable.Margin = new Padding( 3, 3, 3, 15 );
			btnGenrateTable.Name = "btnGenrateTable";
			btnGenrateTable.Size = new Size( 198, 293 );
			btnGenrateTable.TabIndex = 0;
			btnGenrateTable.Text = "Generate Multiplication Table";
			btnGenrateTable.UseVisualStyleBackColor = false;
			btnGenrateTable.Click +=  btnGenrateTable_Click ;
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb( 207, 203, 196 );
			panel3.Controls.Add( dgMultTableData );
			panel3.Location = new Point( 198, 100 );
			panel3.Name = "panel3";
			panel3.Size = new Size( 1766, 586 );
			panel3.TabIndex = 2;
			// 
			// dgMultTableData
			// 
			dgMultTableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgMultTableData.Dock = DockStyle.Fill;
			dgMultTableData.Location = new Point( 0, 0 );
			dgMultTableData.Name = "dgMultTableData";
			dgMultTableData.RowHeadersWidth = 62;
			dgMultTableData.Size = new Size( 1766, 586 );
			dgMultTableData.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF( 11F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 1921, 689 );
			Controls.Add( panel3 );
			Controls.Add( panel2 );
			Controls.Add( panel1 );
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			panel1.ResumeLayout( false );
			panel1.PerformLayout( );
			panel2.ResumeLayout( false );
			panel2.PerformLayout( );
			panel3.ResumeLayout( false );
			( (System.ComponentModel.ISupportInitialize)dgMultTableData ).EndInit( );
			ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private Panel panel2;
		private Button btnGenrateTable;
		private Button btnReset;
		private Panel panel3;
		private DataGridView dgMultTableData;
	}
}
