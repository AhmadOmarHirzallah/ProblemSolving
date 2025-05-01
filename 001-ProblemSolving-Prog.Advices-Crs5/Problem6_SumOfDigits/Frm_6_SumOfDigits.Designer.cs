namespace Problem6_SumOfDigits
{
	partial class Frm_6_SumOfDigits
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
			btnSumDigits = new Button( );
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
			panel2.BackColor = Color.FromArgb( 240, 240, 255 );
			panel2.Controls.Add( lblResult );
			panel2.Controls.Add( label2 );
			panel2.Controls.Add( panel4 );
			panel2.Controls.Add( panel3 );
			panel2.Controls.Add( btnReset );
			panel2.Controls.Add( btnSumDigits );
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point( 0, 86 );
			panel2.Name = "panel2";
			panel2.Size = new Size( 1857, 814 );
			panel2.TabIndex = 13;
			// 
			// lblResult
			// 
			lblResult.Font = new Font( "Showcard Gothic", 30F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblResult.ForeColor = Color.Red;
			lblResult.Location = new Point( 1363, 312 );
			lblResult.Name = "lblResult";
			lblResult.Size = new Size( 429, 433 );
			lblResult.TabIndex = 11;
			lblResult.Text = "???";
			lblResult.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Font = new Font( "Showcard Gothic", 45F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label2.ForeColor = Color.Salmon;
			label2.Location = new Point( 939, 475 );
			label2.Name = "label2";
			label2.Size = new Size( 418, 122 );
			label2.TabIndex = 12;
			label2.Text = "Result:";
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb( 224, 224, 255 );
			panel4.Controls.Add( txtNbrInput );
			panel4.Controls.Add( lblOfTxtBox );
			panel4.Location = new Point( 114, 145 );
			panel4.Name = "panel4";
			panel4.Size = new Size( 1625, 148 );
			panel4.TabIndex = 10;
			// 
			// txtNbrInput
			// 
			txtNbrInput.BackColor = Color.White;
			txtNbrInput.BorderStyle = BorderStyle.None;
			txtNbrInput.Font = new Font( "Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0 );
			txtNbrInput.Location = new Point( 792, 20 );
			txtNbrInput.Multiline = true;
			txtNbrInput.Name = "txtNbrInput";
			txtNbrInput.Size = new Size( 670, 100 );
			txtNbrInput.TabIndex = 2;
			// 
			// lblOfTxtBox
			// 
			lblOfTxtBox.AutoSize = true;
			lblOfTxtBox.BackColor = Color.FromArgb( 200, 200, 255 );
			lblOfTxtBox.Font = new Font( "Segoe UI", 26F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblOfTxtBox.ForeColor = Color.FromArgb( 61, 61, 61 );
			lblOfTxtBox.Location = new Point( 148, 50 );
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
			panel3.Size = new Size( 1857, 113 );
			panel3.TabIndex = 6;
			// 
			// lblDescription
			// 
			lblDescription.Dock = DockStyle.Fill;
			lblDescription.Font = new Font( "Segoe UI", 18F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblDescription.ForeColor = Color.FromArgb( 38, 36, 29 );
			lblDescription.Location = new Point( 0, 0 );
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size( 1857, 113 );
			lblDescription.TabIndex = 6;
			lblDescription.Text = "Write a program that will read a number from the user (check if it is a valid number first) and print it in reversed order.";
			lblDescription.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.FromArgb( 180, 100, 100 );
			btnReset.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnReset.ForeColor = Color.AliceBlue;
			btnReset.Location = new Point( 176, 596 );
			btnReset.Name = "btnReset";
			btnReset.Size = new Size( 596, 158 );
			btnReset.TabIndex = 3;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click +=  btnReset_Click ;
			btnReset.MouseLeave +=  btnReset_MouseLeave ;
			btnReset.MouseHover +=  btnReset_MouseHover ;
			// 
			// btnSumDigits
			// 
			btnSumDigits.BackColor = Color.FromArgb( 100, 100, 255 );
			btnSumDigits.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnSumDigits.ForeColor = Color.AliceBlue;
			btnSumDigits.Location = new Point( 122, 368 );
			btnSumDigits.Name = "btnSumDigits";
			btnSumDigits.Size = new Size( 713, 197 );
			btnSumDigits.TabIndex = 3;
			btnSumDigits.Text = "Sum Digits of the Number";
			btnSumDigits.UseVisualStyleBackColor = false;
			btnSumDigits.Click +=  btnSumDigits_Click ;
			btnSumDigits.MouseLeave +=  btnSumDigits_MouseLeave ;
			btnSumDigits.MouseHover +=  btnSumDigits_MouseHover ;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb( 113, 96, 232 );
			panel1.Controls.Add( lblTitle );
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Size = new Size( 1857, 86 );
			panel1.TabIndex = 12;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font( "Segoe UI", 36F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblTitle.ForeColor = Color.FromArgb( 53, 59, 72 );
			lblTitle.Location = new Point( 704, -10 );
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size( 410, 96 );
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Digits Sum";
			// 
			// Frm_6_SumOfDigits
			// 
			AutoScaleDimensions = new SizeF( 11F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 1857, 902 );
			Controls.Add( panel2 );
			Controls.Add( panel1 );
			Name = "Frm_6_SumOfDigits";
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
		private Label lblResult;
		private Label label2;
		private Panel panel4;
		private TextBox txtNbrInput;
		private Label lblOfTxtBox;
		private Panel panel3;
		private Label lblDescription;
		private Button btnReset;
		private Button btnSumDigits;
		private Panel panel1;
		private Label lblTitle;
	}
}
