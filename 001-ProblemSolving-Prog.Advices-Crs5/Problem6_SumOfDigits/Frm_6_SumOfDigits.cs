using System.Security.AccessControl;

namespace Problem6_SumOfDigits
{
	public partial class Frm_6_SumOfDigits : Form
	{
		public Frm_6_SumOfDigits()
		{
			InitializeComponent( );
		}

		// Design Effects
		private void btnSumDigits_MouseHover( object sender, EventArgs e )
		{
			btnSumDigits.BackColor = System.Drawing.Color.FromArgb( 80, 80, 230 ); // Darker blue when hovered
		}

		private void btnSumDigits_MouseLeave( object sender, EventArgs e )
		{
			btnSumDigits.BackColor = System.Drawing.Color.FromArgb( 100, 100, 255 ); // Original blue when mouse leaves
		}

		private void btnReset_MouseHover( object sender, EventArgs e )
		{
			btnReset.BackColor = System.Drawing.Color.FromArgb( 160, 80, 80 ); // Darker red when hovered

		}

		private void btnReset_MouseLeave( object sender, EventArgs e )
		{
			btnReset.BackColor = System.Drawing.Color.FromArgb( 180, 100, 100 ); // Original red when mouse leaves
		}

		int calcSumOfDigits( int number )
		{
			int sum = 0;

			while (number > 0)
			{
				sum += number % 10;
				number /= 10;
			}
			return ( sum );
		}

		private bool inputHandler( out int enteredNbr )
		{
			string input = txtNbrInput.Text.Trim( );

			if (int.TryParse( input, out enteredNbr ) && enteredNbr > 0)
				return ( true );
			else
			{
				MessageBox.Show( "Please enter a valid positive integer.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error );
				enteredNbr = 0;
				return ( false );
			}
		}

		private void btnSumDigits_Click( object sender, EventArgs e )
		{
			int enteredNbr;
			if (inputHandler( out enteredNbr ))
				lblResult.Text = $"Sum of the Digits: {calcSumOfDigits( number: enteredNbr ).ToString()}";

		}

		private void btnReset_Click( object sender, EventArgs e )
		{
			txtNbrInput.Clear( );
			lblResult.Text = String.Empty;
		}
	}
}
