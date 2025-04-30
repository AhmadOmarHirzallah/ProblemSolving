namespace Problem3_WinForms
{
	partial class Problem3Form
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
			panel4 = new Panel( );
			lblResult = new Label( );
			label2 = new Label( );
			panel3 = new Panel( );
			label4 = new Label( );
			btnCheckPerfectNumber = new Button( );
			txtNbrInput = new TextBox( );
			label3 = new Label( );
			panel1 = new Panel( );
			label1 = new Label( );
			panel2.SuspendLayout( );
			panel4.SuspendLayout( );
			panel3.SuspendLayout( );
			panel1.SuspendLayout( );
			SuspendLayout( );
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb( 130, 125, 165 );
			panel2.Controls.Add( panel4 );
			panel2.Controls.Add( panel3 );
			panel2.Controls.Add( btnCheckPerfectNumber );
			panel2.Controls.Add( txtNbrInput );
			panel2.Controls.Add( label3 );
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point( 0, 103 );
			panel2.Name = "panel2";
			panel2.Size = new Size( 1659, 795 );
			panel2.TabIndex = 3;
			// 
			// panel4
			// 
			panel4.Controls.Add( lblResult );
			panel4.Controls.Add( label2 );
			panel4.Location = new Point( 692, 301 );
			panel4.Name = "panel4";
			panel4.Size = new Size( 902, 456 );
			panel4.TabIndex = 7;
			// 
			// lblResult
			// 
			lblResult.Font = new Font( "Showcard Gothic", 30F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblResult.ForeColor = Color.Red;
			lblResult.Location = new Point( 430, 0 );
			lblResult.Name = "lblResult";
			lblResult.Size = new Size( 424, 442 );
			lblResult.TabIndex = 5;
			lblResult.Text = "???";
			lblResult.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Font = new Font( "Showcard Gothic", 40F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label2.ForeColor = Color.FromArgb( 38, 36, 29 );
			label2.Location = new Point( 45, 163 );
			label2.Name = "label2";
			label2.Size = new Size( 379, 107 );
			label2.TabIndex = 5;
			label2.Text = "Result:";
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb( 207, 202, 247 );
			panel3.Controls.Add( label4 );
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point( 0, 0 );
			panel3.Name = "panel3";
			panel3.Size = new Size( 1659, 113 );
			panel3.TabIndex = 6;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Fill;
			label4.Font = new Font( "Segoe UI", 18F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label4.ForeColor = Color.FromArgb( 38, 36, 29 );
			label4.Location = new Point( 0, 0 );
			label4.Name = "label4";
			label4.Size = new Size( 1659, 113 );
			label4.TabIndex = 6;
			label4.Text = " check whether a number entered is a Perfect Number. A Perfect Number is a number that is equal to the sum of its proper divisors, excluding the number itself.";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnCheckPerfectNumber
			// 
			btnCheckPerfectNumber.BackColor = Color.FromArgb( 75, 64, 154 );
			btnCheckPerfectNumber.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnCheckPerfectNumber.ForeColor = Color.AliceBlue;
			btnCheckPerfectNumber.Location = new Point( 90, 430 );
			btnCheckPerfectNumber.Name = "btnCheckPerfectNumber";
			btnCheckPerfectNumber.Size = new Size( 542, 158 );
			btnCheckPerfectNumber.TabIndex = 3;
			btnCheckPerfectNumber.Text = "Check if is Perfect Number";
			btnCheckPerfectNumber.UseVisualStyleBackColor = false;
			btnCheckPerfectNumber.Click +=  btnCheckPerfectNumber_Click ;
			// 
			// txtNbrInput
			// 
			txtNbrInput.BackColor = Color.FromArgb( 113, 96, 232 );
			txtNbrInput.BorderStyle = BorderStyle.None;
			txtNbrInput.Font = new Font( "Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 0 );
			txtNbrInput.Location = new Point( 971, 162 );
			txtNbrInput.Multiline = true;
			txtNbrInput.Name = "txtNbrInput";
			txtNbrInput.Size = new Size( 463, 99 );
			txtNbrInput.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb( 43, 41, 55 );
			label3.Font = new Font( "Segoe UI", 26F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label3.ForeColor = SystemColors.ActiveCaption;
			label3.Location = new Point( 90, 177 );
			label3.Name = "label3";
			label3.Size = new Size( 796, 70 );
			label3.TabIndex = 1;
			label3.Text = "Please enter a positive number:";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb( 113, 96, 232 );
			panel1.Controls.Add( label1 );
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Size = new Size( 1659, 103 );
			panel1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font( "Segoe UI", 36F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label1.Location = new Point( 369, 0 );
			label1.Name = "label1";
			label1.Size = new Size( 856, 96 );
			label1.TabIndex = 0;
			label1.Text = "Perfect Number Checker";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF( 10F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 1659, 896 );
			Controls.Add( panel2 );
			Controls.Add( panel1 );
			Name = "Form1";
			Text = "Form1";
			panel2.ResumeLayout( false );
			panel2.PerformLayout( );
			panel4.ResumeLayout( false );
			panel3.ResumeLayout( false );
			panel1.ResumeLayout( false );
			panel1.PerformLayout( );
			ResumeLayout( false );
		}

		#endregion

		private Panel panel2;
		private Panel panel3;
		private Label label2;
		private Button btnCheckPerfectNumber;
		private TextBox txtNbrInput;
		private Label label3;
		private Panel panel1;
		private Label label1;
		private Label label4;
		private Panel panel4;
		private Label lblResult;
	}
}
