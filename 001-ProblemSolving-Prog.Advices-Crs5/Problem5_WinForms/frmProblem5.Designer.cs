namespace Problem5_WinForms
{
	partial class frmProblem5
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
			lblResult = new Label( );
			label2 = new Label( );
			panel4 = new Panel( );
			txtNbrInput = new TextBox( );
			lblOfTxtBox = new Label( );
			panel3 = new Panel( );
			lblDescription = new Label( );
			btnReset = new Button( );
			btnReverseDisplay = new Button( );
			panel1 = new Panel( );
			lblTitle = new Label( );
			panel2.SuspendLayout( );
			panel4.SuspendLayout( );
			panel3.SuspendLayout( );
			panel1.SuspendLayout( );
			SuspendLayout( );
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb( 130, 125, 165 );
			panel2.Controls.Add( lblResult );
			panel2.Controls.Add( label2 );
			panel2.Controls.Add( panel4 );
			panel2.Controls.Add( panel3 );
			panel2.Controls.Add( btnReset );
			panel2.Controls.Add( btnReverseDisplay );
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point( 0, 101 );
			panel2.Name = "panel2";
			panel2.Size = new Size( 1664, 829 );
			panel2.TabIndex = 11;
			// 
			// lblResult
			// 
			lblResult.Font = new Font( "Showcard Gothic", 30F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblResult.ForeColor = Color.Red;
			lblResult.Location = new Point( 1239, 312 );
			lblResult.Name = "lblResult";
			lblResult.Size = new Size( 390, 433 );
			lblResult.TabIndex = 11;
			lblResult.Text = "???";
			lblResult.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Font = new Font( "Showcard Gothic", 40F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label2.ForeColor = Color.FromArgb( 38, 36, 29 );
			label2.Location = new Point( 854, 475 );
			label2.Name = "label2";
			label2.Size = new Size( 363, 98 );
			label2.TabIndex = 12;
			label2.Text = "Result:";
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb( 152, 124, 157 );
			panel4.Controls.Add( txtNbrInput );
			panel4.Controls.Add( lblOfTxtBox );
			panel4.Location = new Point( 104, 145 );
			panel4.Name = "panel4";
			panel4.Size = new Size( 1477, 148 );
			panel4.TabIndex = 10;
			// 
			// txtNbrInput
			// 
			txtNbrInput.BackColor = Color.FromArgb( 113, 96, 232 );
			txtNbrInput.BorderStyle = BorderStyle.None;
			txtNbrInput.Font = new Font( "Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0 );
			txtNbrInput.Location = new Point( 927, 19 );
			txtNbrInput.Multiline = true;
			txtNbrInput.Name = "txtNbrInput";
			txtNbrInput.Size = new Size( 501, 100 );
			txtNbrInput.TabIndex = 2;
			// 
			// lblOfTxtBox
			// 
			lblOfTxtBox.AutoSize = true;
			lblOfTxtBox.BackColor = Color.FromArgb( 86, 83, 110 );
			lblOfTxtBox.Font = new Font( "Segoe UI", 26F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblOfTxtBox.ForeColor = Color.FromArgb( 190, 113, 23 );
			lblOfTxtBox.Location = new Point( 47, 39 );
			lblOfTxtBox.Name = "lblOfTxtBox";
			lblOfTxtBox.Size = new Size( 648, 70 );
			lblOfTxtBox.TabIndex = 1;
			lblOfTxtBox.Text = "Please enter any number:";
			lblOfTxtBox.TextAlign = ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb( 207, 202, 247 );
			panel3.Controls.Add( lblDescription );
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point( 0, 0 );
			panel3.Name = "panel3";
			panel3.Size = new Size( 1664, 113 );
			panel3.TabIndex = 6;
			// 
			// lblDescription
			// 
			lblDescription.Dock = DockStyle.Fill;
			lblDescription.Font = new Font( "Segoe UI", 18F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblDescription.ForeColor = Color.FromArgb( 38, 36, 29 );
			lblDescription.Location = new Point( 0, 0 );
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size( 1664, 113 );
			lblDescription.TabIndex = 6;
			lblDescription.Text = "Write a program that will read a number from the user (check if it is a valid number first) and print it in reversed order.";
			lblDescription.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.FromArgb( 121, 74, 73 );
			btnReset.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnReset.ForeColor = Color.AliceBlue;
			btnReset.Location = new Point( 160, 596 );
			btnReset.Name = "btnReset";
			btnReset.Size = new Size( 542, 158 );
			btnReset.TabIndex = 3;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click +=  btnReset_Click ;
			// 
			// btnReverseDisplay
			// 
			btnReverseDisplay.BackColor = Color.FromArgb( 75, 64, 154 );
			btnReverseDisplay.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnReverseDisplay.ForeColor = Color.AliceBlue;
			btnReverseDisplay.Location = new Point( 111, 368 );
			btnReverseDisplay.Name = "btnReverseDisplay";
			btnReverseDisplay.Size = new Size( 648, 197 );
			btnReverseDisplay.TabIndex = 3;
			btnReverseDisplay.Text = "Reverse Number";
			btnReverseDisplay.UseVisualStyleBackColor = false;
			btnReverseDisplay.Click +=  btnReverseDisplay_Click ;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb( 113, 96, 232 );
			panel1.Controls.Add( lblTitle );
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Size = new Size( 1664, 101 );
			panel1.TabIndex = 10;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font( "Segoe UI", 36F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblTitle.Location = new Point( 418, 2 );
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size( 877, 96 );
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Reverse Number Checker";
			// 
			// frmProblem5
			// 
			AutoScaleDimensions = new SizeF( 10F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 1664, 917 );
			Controls.Add( panel2 );
			Controls.Add( panel1 );
			Name = "frmProblem5";
			Text = "Form1";
			panel2.ResumeLayout( false );
			panel4.ResumeLayout( false );
			panel4.PerformLayout( );
			panel3.ResumeLayout( false );
			panel1.ResumeLayout( false );
			panel1.PerformLayout( );
			ResumeLayout( false );
		}

		#endregion

		private Panel panel2;
		private Panel panel3;
		private Label lblDescription;
		private Button btnReset;
		private Button btnReverseDisplay;
		private TextBox txtNbrInput;
		private Label lblOfTxtBox;
		private Panel panel1;
		private Label lblTitle;
		private Panel panel4;
		private Label lblResult;
		private Label label2;
	}
}
