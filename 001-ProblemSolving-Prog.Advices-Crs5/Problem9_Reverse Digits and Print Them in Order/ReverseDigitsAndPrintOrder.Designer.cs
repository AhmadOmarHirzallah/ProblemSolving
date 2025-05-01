namespace Problem9_Reverse_Digits_and_Print_Them_in_Order
{
	partial class ReverseDigitsAndPrintOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ReverseDigitsAndPrintOrder ) );
			panel2 = new Panel( );
			panelDGV = new Panel( );
			lstResult = new ListBox( );
			label1 = new Label( );
			panel4 = new Panel( );
			txtNumberInput = new TextBox( );
			lblOfTxtBox = new Label( );
			panel3 = new Panel( );
			lblDescription = new Label( );
			btnReset = new Button( );
			btnReverseAndDisplay = new Button( );
			panel1 = new Panel( );
			lblTitle = new Label( );
			panel2.SuspendLayout( );
			panelDGV.SuspendLayout( );
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
			panel2.Controls.Add( btnReverseAndDisplay );
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point( 0, 86 );
			panel2.Name = "panel2";
			panel2.Size = new Size( 1773, 872 );
			panel2.TabIndex = 19;
			// 
			// panelDGV
			// 
			panelDGV.BackColor = Color.FromArgb( 224, 224, 255 );
			panelDGV.Controls.Add( lstResult );
			panelDGV.Controls.Add( label1 );
			panelDGV.Location = new Point( 808, 220 );
			panelDGV.Name = "panelDGV";
			panelDGV.Size = new Size( 853, 586 );
			panelDGV.TabIndex = 13;
			// 
			// lstResult
			// 
			lstResult.Dock = DockStyle.Bottom;
			lstResult.FormattingEnabled = true;
			lstResult.ItemHeight = 25;
			lstResult.Location = new Point( 0, 232 );
			lstResult.Name = "lstResult";
			lstResult.Size = new Size( 853, 354 );
			lstResult.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb( 200, 200, 255 );
			label1.Font = new Font( "Segoe UI", 50F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			label1.ForeColor = Color.FromArgb( 61, 61, 61 );
			label1.Location = new Point( 229, 44 );
			label1.Name = "label1";
			label1.Size = new Size( 374, 133 );
			label1.TabIndex = 1;
			label1.Text = "Result:";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb( 224, 224, 255 );
			panel4.Controls.Add( txtNumberInput );
			panel4.Controls.Add( lblOfTxtBox );
			panel4.Location = new Point( 60, 220 );
			panel4.Name = "panel4";
			panel4.Size = new Size( 622, 278 );
			panel4.TabIndex = 10;
			// 
			// txtNumberInput
			// 
			txtNumberInput.BackColor = Color.White;
			txtNumberInput.BorderStyle = BorderStyle.None;
			txtNumberInput.Font = new Font( "Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0 );
			txtNumberInput.Location = new Point( 23, 113 );
			txtNumberInput.Multiline = true;
			txtNumberInput.Name = "txtNumberInput";
			txtNumberInput.Size = new Size( 552, 127 );
			txtNumberInput.TabIndex = 2;
			// 
			// lblOfTxtBox
			// 
			lblOfTxtBox.AutoSize = true;
			lblOfTxtBox.BackColor = Color.FromArgb( 200, 200, 255 );
			lblOfTxtBox.Font = new Font( "Segoe UI", 22F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblOfTxtBox.ForeColor = Color.FromArgb( 61, 61, 61 );
			lblOfTxtBox.Location = new Point( 32, 15 );
			lblOfTxtBox.Name = "lblOfTxtBox";
			lblOfTxtBox.Size = new Size( 569, 60 );
			lblOfTxtBox.TabIndex = 1;
			lblOfTxtBox.Text = "Enter a Number (Positive):";
			lblOfTxtBox.TextAlign = ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb( 207, 202, 247 );
			panel3.Controls.Add( lblDescription );
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point( 0, 0 );
			panel3.Name = "panel3";
			panel3.Size = new Size( 1773, 200 );
			panel3.TabIndex = 6;
			// 
			// lblDescription
			// 
			lblDescription.Dock = DockStyle.Fill;
			lblDescription.Font = new Font( "Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			lblDescription.ForeColor = Color.FromArgb( 38, 36, 29 );
			lblDescription.Location = new Point( 0, 0 );
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size( 1773, 200 );
			lblDescription.TabIndex = 6;
			lblDescription.Text = resources.GetString( "lblDescription.Text" );
			lblDescription.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.FromArgb( 180, 100, 100 );
			btnReset.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnReset.ForeColor = Color.AliceBlue;
			btnReset.Location = new Point( 60, 727 );
			btnReset.Name = "btnReset";
			btnReset.Size = new Size( 396, 111 );
			btnReset.TabIndex = 3;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click +=  btnReset_Click ;
			// 
			// btnReverseAndDisplay
			// 
			btnReverseAndDisplay.BackColor = Color.FromArgb( 100, 100, 255 );
			btnReverseAndDisplay.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
			btnReverseAndDisplay.ForeColor = Color.AliceBlue;
			btnReverseAndDisplay.Location = new Point( 60, 565 );
			btnReverseAndDisplay.Name = "btnReverseAndDisplay";
			btnReverseAndDisplay.Size = new Size( 498, 138 );
			btnReverseAndDisplay.TabIndex = 3;
			btnReverseAndDisplay.Text = "Reverse Digits and Display Them";
			btnReverseAndDisplay.UseVisualStyleBackColor = false;
			btnReverseAndDisplay.Click +=  btnReverseAndDisplay_Click ;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb( 113, 96, 232 );
			panel1.Controls.Add( lblTitle );
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point( 0, 0 );
			panel1.Name = "panel1";
			panel1.Size = new Size( 1773, 86 );
			panel1.TabIndex = 18;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font( "Segoe UI", 36F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
			lblTitle.ForeColor = Color.FromArgb( 53, 59, 72 );
			lblTitle.Location = new Point( 202, -10 );
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size( 1361, 96 );
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Reverse Digits and Print Them in Order";
			// 
			// ReverseDigitsAndPrintOrder
			// 
			AutoScaleDimensions = new SizeF( 11F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 1773, 941 );
			Controls.Add( panel2 );
			Controls.Add( panel1 );
			Name = "ReverseDigitsAndPrintOrder";
			Text = "Form1";
			panel2.ResumeLayout( false );
			panelDGV.ResumeLayout( false );
			panelDGV.PerformLayout( );
			panel4.ResumeLayout( false );
			panel4.PerformLayout( );
			panel3.ResumeLayout( false );
			panel1.ResumeLayout( false );
			panel1.PerformLayout( );
			ResumeLayout( false );
		}

		#endregion

		private Panel panel2;
		private Panel panel4;
		private TextBox txtNumberInput;
		private Label lblOfTxtBox;
		private Panel panel3;
		private Label lblDescription;
		private Button btnReset;
		private Button btnReverseAndDisplay;
		private Panel panel1;
		private Label lblTitle;
		private Panel panelDGV;
		private ListBox lstResult;
		private Label label1;
	}
}
