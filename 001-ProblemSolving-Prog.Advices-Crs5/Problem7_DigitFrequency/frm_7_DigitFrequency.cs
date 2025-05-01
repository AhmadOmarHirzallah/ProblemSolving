namespace Problem7_DigitFrequency
{
	public partial class frm_7_DigitFrequency : Form
	{
		public frm_7_DigitFrequency()
		{
			InitializeComponent( );
		}

		private bool inputsHandler( out int enteredNumber, out int enteredDigit )
		{
			string inputNumber = txtNbrInput.Text.Trim( );
			string inputDigit = txtDigitInput.Text.Trim( );

			if (!( int.TryParse( inputNumber, out enteredNumber ) ))
			{
				MessageBox.Show( "Please enter a valid positive number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				enteredNumber = 0;
				enteredDigit = 0;
				return ( false );
			}
			if (!( int.TryParse( inputDigit, out enteredDigit ) ))
			{
				MessageBox.Show( "Please enter a valid Single Digit (0-9).", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				enteredNumber = 0;
				enteredDigit = 0;
				return ( false );
			}
			return ( true );
		}

		private int countDigitFrequency( int number, int digit )
		{
			// New Better Way
			int frequencyCount = 0;
			int lastDigit = 0;

			while (number > 0)
			{
				lastDigit = number % 10;
				if (lastDigit == digit)
					frequencyCount++;
				number /= 10;
			}
			return ( frequencyCount );


			/* // Old Way
			int frequency = 0;
			string numberStr = number.ToString( );
			char digitChar = digit.ToString( )[0];

			foreach (char aDigit in numberStr)
			{
				if (aDigit == digitChar)
					frequency++;
			}
			return ( frequency );
			*/
		}

		private void btnCalFrequency_Click( object sender, EventArgs e )
		{
			int enteredNumber;
			int enteredDigit;
			int frequency;
			if (inputsHandler( out enteredNumber, out enteredDigit ))
			{
				frequency = countDigitFrequency( enteredNumber, enteredDigit );
				lblResult.Text = $"' Digit {enteredDigit} ' Frequency is: \" {frequency}" +
								( ( frequency > 1 ) ? " (Times)" : " (Time)" ) + " \"";
			}
		}

		private void btnReset_Click( object sender, EventArgs e )
		{
			txtNbrInput.Text = String.Empty;
			txtDigitInput.Clear( );
			lblResult.Text = String.Empty;
		}
	}
}
