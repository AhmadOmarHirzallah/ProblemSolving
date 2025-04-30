namespace Problem4_WinForms;

partial class frmProblem4
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		label3 = new Label( );
		panel2 = new Panel( );
		label5 = new Label( );
		dgPerfectNbrs = new DataGridView( );
		panel3 = new Panel( );
		label4 = new Label( );
		btnCheck = new Button( );
		txtNbrInput = new TextBox( );
		panel1 = new Panel( );
		lblTitle = new Label( );
		btnReset = new Button( );
		panel2.SuspendLayout( );
		( (System.ComponentModel.ISupportInitialize)dgPerfectNbrs ).BeginInit( );
		panel3.SuspendLayout( );
		panel1.SuspendLayout( );
		SuspendLayout( );
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.BackColor = Color.FromArgb( 43, 41, 55 );
		label3.Font = new Font( "Segoe UI", 26F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
		label3.ForeColor = SystemColors.ActiveCaption;
		label3.Location = new Point( 90, 179 );
		label3.Name = "label3";
		label3.Size = new Size( 796, 70 );
		label3.TabIndex = 1;
		label3.Text = "Please enter a positive number:";
		// 
		// panel2
		// 
		panel2.BackColor = Color.FromArgb( 130, 125, 165 );
		panel2.Controls.Add( label5 );
		panel2.Controls.Add( dgPerfectNbrs );
		panel2.Controls.Add( panel3 );
		panel2.Controls.Add( btnReset );
		panel2.Controls.Add( btnCheck );
		panel2.Controls.Add( txtNbrInput );
		panel2.Controls.Add( label3 );
		panel2.Dock = DockStyle.Top;
		panel2.Location = new Point( 0, 101 );
		panel2.Name = "panel2";
		panel2.Size = new Size( 1733, 829 );
		panel2.TabIndex = 9;
		// 
		// label5
		// 
		label5.Font = new Font( "Segoe UI", 20F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
		label5.ForeColor = Color.FromArgb( 38, 36, 29 );
		label5.Location = new Point( 1062, 329 );
		label5.Name = "label5";
		label5.Size = new Size( 466, 62 );
		label5.TabIndex = 9;
		label5.Text = "Found Perfect Numbers";
		// 
		// dgPerfectNbrs
		// 
		dgPerfectNbrs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgPerfectNbrs.Location = new Point( 1070, 391 );
		dgPerfectNbrs.Name = "dgPerfectNbrs";
		dgPerfectNbrs.RowHeadersWidth = 62;
		dgPerfectNbrs.Size = new Size( 452, 377 );
		dgPerfectNbrs.TabIndex = 8;
		// 
		// panel3
		// 
		panel3.BackColor = Color.FromArgb( 207, 202, 247 );
		panel3.Controls.Add( label4 );
		panel3.Dock = DockStyle.Top;
		panel3.Location = new Point( 0, 0 );
		panel3.Name = "panel3";
		panel3.Size = new Size( 1733, 113 );
		panel3.TabIndex = 6;
		// 
		// label4
		// 
		label4.Dock = DockStyle.Fill;
		label4.Font = new Font( "Segoe UI", 18F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
		label4.ForeColor = Color.FromArgb( 38, 36, 29 );
		label4.Location = new Point( 0, 0 );
		label4.Name = "label4";
		label4.Size = new Size( 1733, 113 );
		label4.TabIndex = 6;
		label4.Text = "find all the perfect numbers between 1 and N, where N is provided by the user.";
		label4.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// btnCheck
		// 
		btnCheck.BackColor = Color.FromArgb( 75, 64, 154 );
		btnCheck.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
		btnCheck.ForeColor = Color.AliceBlue;
		btnCheck.Location = new Point( 151, 357 );
		btnCheck.Name = "btnCheck";
		btnCheck.Size = new Size( 648, 197 );
		btnCheck.TabIndex = 3;
		btnCheck.Text = "Generate Perfect Numbers";
		btnCheck.UseVisualStyleBackColor = false;
		btnCheck.Click +=  btnCheck_Click ;
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
		// panel1
		// 
		panel1.BackColor = Color.FromArgb( 113, 96, 232 );
		panel1.Controls.Add( lblTitle );
		panel1.Dock = DockStyle.Top;
		panel1.Location = new Point( 0, 0 );
		panel1.Name = "panel1";
		panel1.Size = new Size( 1733, 101 );
		panel1.TabIndex = 8;
		// 
		// lblTitle
		// 
		lblTitle.AutoSize = true;
		lblTitle.Font = new Font( "Segoe UI", 36F,  FontStyle.Bold  |  FontStyle.Italic , GraphicsUnit.Point, 0 );
		lblTitle.Location = new Point( 185, 0 );
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new Size( 1297, 96 );
		lblTitle.TabIndex = 0;
		lblTitle.Text = "Find All Perfect Numbers from 1 to N";
		// 
		// btnReset
		// 
		btnReset.BackColor = Color.FromArgb( 121, 74, 73 );
		btnReset.Font = new Font( "Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0 );
		btnReset.ForeColor = Color.AliceBlue;
		btnReset.Location = new Point( 200, 585 );
		btnReset.Name = "btnReset";
		btnReset.Size = new Size( 542, 158 );
		btnReset.TabIndex = 3;
		btnReset.Text = "Reset";
		btnReset.UseVisualStyleBackColor = false;
		btnReset.Click +=  btnReset_Click ;
		// 
		// frmProblem4
		// 
		AutoScaleDimensions = new SizeF( 10F, 25F );
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size( 1733, 924 );
		Controls.Add( panel2 );
		Controls.Add( panel1 );
		Name = "frmProblem4";
		Text = "Form1";
		panel2.ResumeLayout( false );
		panel2.PerformLayout( );
		( (System.ComponentModel.ISupportInitialize)dgPerfectNbrs ).EndInit( );
		panel3.ResumeLayout( false );
		panel1.ResumeLayout( false );
		panel1.PerformLayout( );
		ResumeLayout( false );
	}

	#endregion

	private Label label3;
	private Panel panel2;
	private Panel panel3;
	private Label label4;
	private Button btnCheck;
	private TextBox txtNbrInput;
	private Panel panel1;
	private Label lblTitle;
	private Label label5;
	private DataGridView dgPerfectNbrs;
	private Button btnReset;
}
