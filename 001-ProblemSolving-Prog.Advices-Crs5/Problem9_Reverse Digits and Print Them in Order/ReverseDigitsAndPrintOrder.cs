using MathUtilsLib;

namespace Problem9_Reverse_Digits_and_Print_Them_in_Order
{
	public partial class ReverseDigitsAndPrintOrder : Form
	{
		public ReverseDigitsAndPrintOrder()
		{
			InitializeComponent( );
		}

		// Function: Validate and Read Input
		private bool validateAndReadInput( out int enteredNumber )
		{
			string input = txtNumberInput.Text.Trim( );

			if (!int.TryParse( input, out enteredNumber ) || enteredNumber <= 0)
			{
				MessageBox.Show( "Please enter a valid positive number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				enteredNumber = 0;
				return false;
			}
			return true;
		}


		private void displayDigitsResult(int number)
		{
			int digit;
			
			while(number > 0)
			{
				digit = number % 10;
				number /= 10;
				lstResult.Items.Add( digit );
			}
		}
		
		private void btnReverseAndDisplay_Click( object sender, EventArgs e )
		{
			int enteredNumber;
			int reversedNumber;

			if (validateAndReadInput(out enteredNumber))
			{
				reversedNumber = MathUtilsLib.Utils.reverseNumber( enteredNumber );
				lstResult.Items.Clear( );   // Clear the previous results
				displayDigitsResult( reversedNumber );
			}
		}

		private void btnReset_Click( object sender, EventArgs e )
		{
			txtNumberInput.Clear( );
			lstResult.Items.Clear( ); 
		}
	}
}
