namespace Problem7_DigitFrequency
{
	partial class frm_7_DigitFrequency
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frm_7_DigitFrequency ) );
			panel2 = new Panel( );
			panel5 = new Panel( );
			label2 = new Label( );
			lblResult = new Label( );
			panel4 = new Panel( );
			txtDigitInput = new TextBox( );
			label1 = new Label( );
			txtNbrInput = new TextBox( );
			lblOfTxtBox = new Label( );
			panel3 = new Panel( );
			lblDescription = new Label( );
			btnReset = new Button( );
			btnCalFrequency = new Button( );
			panel1 = new Panel( );
			lblTitle = new Label( );
			panel2.SuspendLayout( );
			panel5.SuspendLayout( );
			panel4.SuspendLayout( );
			panel3.SuspendLayout( );
			panel1.SuspendLayout( );
			SuspendLayout( );
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb( 240, 240, 255 );
			panel2.Controls.Add( panel5 );
			panel2.Controls.Add( panel4 );
			panel2.Controls.Add( panel3 );
			panel2.Controls.Add( btnReset );
			panel2.Controls.Add( btnCalFrequency );
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point( 0, 86 );
			panel2.Name = "panel2";
			panel2.Size = new Size( 1741, 872 );
			panel2.TabIndex = 15;
			// 
			// panel5
			// 
			panel5.BackColor = Color.FromArgb( 224, 224, 255 );
			panel5.Controls.Add( label2 );
			panel5.Controls.Add( lblResult );
			panel5.Location = new Point( 983, 143 );
			panel5.Name = "panel5";
			panel5.Size = new Size( 695, 670 );
			panel5.TabIndex = 13;
			// 
			// label2
			// 
			label2.Font = new Font( "Showcard Gothic", 45F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label2.ForeColor = Color.Salmon;
			label2.Location = new Point( 139, 14 );
			label2.Name = "label2";
			label2.Size = new Size( 467, 202 );
			label2.TabIndex = 12;
			label2.Text = "Result:";
			// 
			// lblResult
			// 
			lblResult.Font = new Font( "Showcard Gothic", 30F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblResult.ForeColor = Color.OrangeRed;
			lblResult.Location = new Point( 128, 136 );
			lblResult.Name = "lblResult";
			lblResult.Size = new Size( 478, 513 );
			lblResult.TabIndex = 11;
			lblResult.Text = "???";
			lblResult.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb( 224, 224, 255 );
			panel4.Controls.Add( txtDigitInput );
			panel4.Controls.Add( label1 );
			panel4.Controls.Add( txtNbrInput );
			panel4.Controls.Add( lblOfTxtBox );
			panel4.Location = new Point( 106, 143 );
			panel4.Name = "panel4";
			panel4.Size = new Size( 757, 421 );
			panel4.TabIndex = 10;
			// 
			// txtDigitInput
			// 
			txtDigitInput.BackColor = Color.White;
			txtDigitInput.BorderStyle = BorderStyle.None;
			txtDigitInput.Font = new Font( "Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0 );
			txtDigitInput.Location = new Point( 32, 309 );
			txtDigitInput.Multiline = true;
			txtDigitInput.Name = "txtDigitInput";
			txtDigitInput.Size = new Size( 559, 86 );
			txtDigitInput.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb( 200, 200, 255 );
			label1.Font = new Font( "Segoe UI", 20F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label1.ForeColor = Color.FromArgb( 61, 61, 61 );
			label1.Location = new Point( 32, 222 );
			label1.Name = "label1";
			label1.Size = new Size( 694, 54 );
			label1.TabIndex = 1;
			label1.Text = "Enter a Digit to check its Frequency:";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtNbrInput
			// 
			txtNbrInput.BackColor = Color.White;
			txtNbrInput.BorderStyle = BorderStyle.None;
			txtNbrInput.Font = new Font( "Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0 );
			txtNbrInput.Location = new Point( 32, 102 );
			txtNbrInput.Multiline = true;
			txtNbrInput.Name = "txtNbrInput";
			txtNbrInput.Size = new Size( 559, 86 );
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
			panel3.Size = new Size( 1741, 113 );
			panel3.TabIndex = 6;
			// 
			// lblDescription
			// 
			lblDescription.Dock = DockStyle.Fill;
			lblDescription.Font = new Font( "Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			lblDescription.ForeColor = Color.FromArgb( 38, 36, 29 );
			lblDescription.Location = new Point( 0, 0 );
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size( 1741, 113 );
			lblDescription.TabIndex = 6;
			lblDescription.Text = resources.GetString( "lblDescription.Text" );
			lblDescription.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.FromArgb( 180, 100, 100 );
			btnReset.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnReset.ForeColor = Color.AliceBlue;
			btnReset.Location = new Point( 198, 749 );
			btnReset.Name = "btnReset";
			btnReset.Size = new Size( 530, 111 );
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
			btnCalFrequency.Location = new Point( 150, 605 );
			btnCalFrequency.Name = "btnCalFrequency";
			btnCalFrequency.Size = new Size( 632, 138 );
			btnCalFrequency.TabIndex = 3;
			btnCalFrequency.Text = "Calculate Frequency of a digit";
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
			panel1.Size = new Size( 1741, 86 );
			panel1.TabIndex = 14;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font( "Segoe UI", 36F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblTitle.ForeColor = Color.FromArgb( 53, 59, 72 );
			lblTitle.Location = new Point( 636, -10 );
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size( 572, 96 );
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Digit Frequency";
			// 
			// frm_7_DigitFrequency
			// 
			AutoScaleDimensions = new SizeF( 11F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 1741, 958 );
			Controls.Add( panel2 );
			Controls.Add( panel1 );
			Name = "frm_7_DigitFrequency";
			Text = "Form1";
			panel2.ResumeLayout( false );
			panel5.ResumeLayout( false );
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
		private Button btnCalFrequency;
		private Panel panel1;
		private Label lblTitle;
		private TextBox txtDigitInput;
		private Label label1;
		private Panel panel5;
	}
}
