namespace Problem5_WinForms
{
	public partial class frmProblem5 : Form
	{
		public frmProblem5()
		{
			InitializeComponent( );
		}

		private int readValidNbr()
		{
			int nbr;

			while (true)
				if (int.TryParse( txtNbrInput.Text, out nbr ))
					return ( nbr );
		}

		private string reverseNbr( int nbr )
		{
			string clearedNumber = Math.Abs( nbr ).ToString( );
			string reversedNumber = new string( clearedNumber.Reverse( ).ToArray( ) );
			if (nbr < 0)
				return ( $"-{reversedNumber}" );
			return ( $"{reversedNumber}" );
		}

		private void btnReverseDisplay_Click( object sender, EventArgs e )
		{
			int number = readValidNbr( );
			string reversedNumber = reverseNbr( number );
			lblResult.Text = reversedNumber;
		}

		private void btnReset_Click( object sender, EventArgs e )
		{
			txtNbrInput.Clear( );
			lblResult.Text = String.Empty;
		}
	}
}
