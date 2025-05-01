namespace Problem8_NumberDigitsFreq_
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
			panel2 = new Panel( );
			panelDGV = new Panel( );
			dgvResults = new DataGridView( );
			panel4 = new Panel( );
			txtNbrInput = new TextBox( );
			lblOfTxtBox = new Label( );
			panel3 = new Panel( );
			lblDescription = new Label( );
			btnReset = new Button( );
			btnCalFrequency = new Button( );
			panel1 = new Panel( );
			lblTitle = new Label( );
			panel2.SuspendLayout( );
			panelDGV.SuspendLayout( );
			( (System.ComponentModel.ISupportInitialize)dgvResults ).BeginInit( );
			panel4.SuspendLayout( );
			panel3.SuspendLayout( );
			panel1.SuspendLayout( );
			SuspendLayout( );
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb( 240, 240, 255 );
			panel2.Controls.Add( panelDGV );
			panel2.Controls.Add( panel4 );
			panel2.Controls.Add( panel3 );
			panel2.Controls.Add( btnReset );
			panel2.Controls.Add( btnCalFrequency );
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point( 0, 86 );
			panel2.Name = "panel2";
			panel2.Size = new Size( 1748, 872 );
			panel2.TabIndex = 17;
			// 
			// panelDGV
			// 
			panelDGV.BackColor = Color.FromArgb( 224, 224, 255 );
			panelDGV.Controls.Add( dgvResults );
			panelDGV.Location = new Point( 811, 143 );
			panelDGV.Name = "panelDGV";
			panelDGV.Size = new Size( 890, 690 );
			panelDGV.TabIndex = 13;
			// 
			// dgvResults
			// 
			dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvResults.Dock = DockStyle.Fill;
			dgvResults.Location = new Point( 0, 0 );
			dgvResults.Name = "dgvResults";
			dgvResults.RowHeadersWidth = 62;
			dgvResults.Size = new Size( 890, 690 );
			dgvResults.TabIndex = 0;
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb( 224, 224, 255 );
			panel4.Controls.Add( txtNbrInput );
			panel4.Controls.Add( lblOfTxtBox );
			panel4.Location = new Point( 83, 143 );
			panel4.Name = "panel4";
			panel4.Size = new Size( 622, 278 );
			panel4.TabIndex = 10;
			// 
			// txtNbrInput
			// 
			txtNbrInput.BackColor = Color.White;
			txtNbrInput.BorderStyle = BorderStyle.None;
			txtNbrInput.Font = new Font( "Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0 );
			txtNbrInput.Location = new Point( 23, 113 );
			txtNbrInput.Multiline = true;
			txtNbrInput.Name = "txtNbrInput";
			txtNbrInput.Size = new Size( 552, 127 );
			txtNbrInput.TabIndex = 2;
			// 
			// lblOfTxtBox
			// 
			lblOfTxtBox.AutoSize = true;
			lblOfTxtBox.BackColor = Color.FromArgb( 200, 200, 255 );
			lblOfTxtBox.Font = new Font( "Segoe UI", 26F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblOfTxtBox.ForeColor = Color.FromArgb( 61, 61, 61 );
			lblOfTxtBox.Location = new Point( 32, 15 );
			lblOfTxtBox.Name = "lblOfTxtBox";
			lblOfTxtBox.Size = new Size( 429, 70 );
			lblOfTxtBox.TabIndex = 1;
			lblOfTxtBox.Text = "Enter a Number:";
			lblOfTxtBox.TextAlign = ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb( 207, 202, 247 );
			panel3.Controls.Add( lblDescription );
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point( 0, 0 );
			panel3.Name = "panel3";
			panel3.Size = new Size( 1748, 113 );
			panel3.TabIndex = 6;
			// 
			// lblDescription
			// 
			lblDescription.Dock = DockStyle.Fill;
			lblDescription.Font = new Font( "Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			lblDescription.ForeColor = Color.FromArgb( 38, 36, 29 );
			lblDescription.Location = new Point( 0, 0 );
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size( 1748, 113 );
			lblDescription.TabIndex = 6;
			lblDescription.Text = "The task requires reading two inputs:  1. A number (e.g., 1232322).    \r\n                                                                2. The program will dispaly each digit frequency";
			lblDescription.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.FromArgb( 180, 100, 100 );
			btnReset.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnReset.ForeColor = Color.AliceBlue;
			btnReset.Location = new Point( 83, 650 );
			btnReset.Name = "btnReset";
			btnReset.Size = new Size( 396, 111 );
			btnReset.TabIndex = 3;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click +=  btnReset_Click ;
			// 
			// btnCalFrequency
			// 
			btnCalFrequency.BackColor = Color.FromArgb( 100, 100, 255 );
			btnCalFrequency.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnCalFrequency.ForeColor = Color.AliceBlue;
			btnCalFrequency.Location = new Point( 83, 488 );
			btnCalFrequency.Name = "btnCalFrequency";
			btnCalFrequency.Size = new Size( 498, 138 );
			btnCalFrequency.TabIndex = 3;
			btnCalFrequency.Text = "Calculate Frequency of all digits";
			btnCalFrequency.UseVisualStyleBackColor = false;
			btnCalFrequency.Click +=  btnCalFrequency_Click ;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb( 113, 96, 232 );
			panel1.Controls.Add( lblTitle );
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Size = new Size( 1748, 86 );
			panel1.TabIndex = 16;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font( "Segoe UI", 36F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblTitle.ForeColor = Color.FromArgb( 53, 59, 72 );
			lblTitle.Location = new Point( 486, -14 );
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size( 749, 96 );
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Each Digit Frequency";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF( 11F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 1748, 952 );
			Controls.Add( panel2 );
			Controls.Add( panel1 );
			Name = "Form1";
			Text = "Form1";
			panel2.ResumeLayout( false );
			panelDGV.ResumeLayout( false );
			( (System.ComponentModel.ISupportInitialize)dgvResults ).EndInit( );
			panel4.ResumeLayout( false );
			panel4.PerformLayout( );
			panel3.ResumeLayout( false );
			panel1.ResumeLayout( false );
			panel1.PerformLayout( );
			ResumeLayout( false );
		}

		#endregion

		private Panel panel2;
		private Panel panelDGV;
		private Panel panel4;
		private TextBox txtNbrInput;
		private Label lblOfTxtBox;
		private Panel panel3;
		private Label lblDescription;
		private Button btnReset;
		private Button btnCalFrequency;
		private Panel panel1;
		private Label lblTitle;
		private DataGridView dgvResults;
	}
}
