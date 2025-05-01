using MathUtilsLib;

namespace Problem8_NumberDigitsFreq_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent( );
		}

		private bool inputHandler( out int enteredNumber )
		{
			string inputNumber = txtNbrInput.Text.Trim( );

			if (!int.TryParse( inputNumber, out enteredNumber ) || enteredNumber <= 0)
			{
				MessageBox.Show( "Please enter a valid positive number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				enteredNumber = 0;
				return false;
			}

			return true;
		}


		private void	setupDGV_Columns()
		{
			// Clear existing columns to reset the DataGridView (if necessary)
			dgvResults.Columns.Clear( );                

			dgvResults.Columns.Add( "Digit", "Digit" );  // Add "Digit" column

			dgvResults.Columns.Add( "Frequency", "Frequency" );         // Add "Frequency" column

			// Set AutoSizeMode for columns
			dgvResults.Columns["Digit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgvResults.Columns["Frequency"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			// Auto resize column widths to fit content
			dgvResults.AutoResizeColumns( DataGridViewAutoSizeColumnsMode.AllCells );

			dgvResults.RowTemplate.Height = 70; // Set custom height for rows
		}

		private void btnCalFrequency_Click( object sender, EventArgs e )
		{
			int enteredNumber;
			string timeLabel;
			if (inputHandler(out enteredNumber))
			{
				Dictionary<int, int> digitsFrequency = MathUtilsLib.Utils.countDigitsFrequency( enteredNumber );
				setupDGV_Columns( );
				dgvResults.Rows.Clear( );   // Clear previous results

				// Loop through all digits (0 to 9) to ensure every digit is checked and displayed
				for (int digit = 0; digit <= 9; digit++)
				{
					// Check if the digit is in the frequency dictionary, if not set its frequency to 0
					int frequency = digitsFrequency.ContainsKey( digit ) ? digitsFrequency[digit] : 0;

					timeLabel = ( frequency > 1 ) ? "Times" : "Time"; // Display "Times" for >1 frequency, else "Time"
					dgvResults.Rows.Add( digit, frequency + " " + timeLabel );
				}

				//  only exist and added elements to the dictionary are checked and displayed
				/*foreach (var entry in digitsFrequency)
				{
					timeLabel = ( entry.Value > 1 ) ? "Times" : "Time";
					dgvResults.Rows.Add( entry.Key, entry.Value + " " + timeLabel ); 
				}*/ 
			}
		}

		private void btnReset_Click( object sender, EventArgs e )
		{
			txtNbrInput.Clear( );
			dgvResults.Rows.Clear( ); 
		}
	}
}
