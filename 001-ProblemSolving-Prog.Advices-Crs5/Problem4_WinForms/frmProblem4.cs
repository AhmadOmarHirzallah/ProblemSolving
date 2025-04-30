namespace Problem4_WinForms;
using MathUtilsLib;

public partial class frmProblem4 : Form
{
	public frmProblem4()
	{
		InitializeComponent( );
	}

	private void dsplyPrfctNbrsInDtaGrdView( List<long> perfectNbrsList )
	{
		dgPerfectNbrs.Rows.Clear( );

		if (dgPerfectNbrs.Columns.Count == 0)
			dgPerfectNbrs.Columns.Add( "PerfectNumbersColumn", "Perfect Numbers" );

		foreach (long perfectNumber in perfectNbrsList)
			dgPerfectNbrs.Rows.Add( perfectNumber.ToString( ) );
	}

	private void btnCheck_Click( object sender, EventArgs e )
	{
		long enteredNbr;

		if (long.TryParse( txtNbrInput.Text, out enteredNbr ) && enteredNbr > 0)
		{
			var perfectNumbersLst = MathUtilsLib.SequenceGenerators.GetPerfectNumbersUpTo( enteredNbr );
			dsplyPrfctNbrsInDtaGrdView( perfectNumbersLst );
		}
		else
			// Display an error message if the input is invalid
			MessageBox.Show( "Please enter a valid positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
	}

	private void btnReset_Click( object sender, EventArgs e )
	{
		txtNbrInput.Clear( );

		// Clear the DataGridView
		dgPerfectNbrs.Rows.Clear( );
	}
}
