using System.Diagnostics;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Problem2_WinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent( );
			initializeDataGridView( );
		}


		private void initializeDataGridView()
		{
			dgPrimeNbrs.Columns.Clear( ); // Clear any previous columns (if any)
			dgPrimeNbrs.Columns.Add( "PrimeNbrsClmn", "Prime Numbers" );
			dgPrimeNbrs.ColumnHeadersDefaultCellStyle.Font = new Font( "Segoe UI", 14, FontStyle.Bold );
			dgPrimeNbrs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			// Set the height of the column header row
			dgPrimeNbrs.Columns[0].Width = 400; // Set the width of the first column header
			dgPrimeNbrs.DefaultCellStyle.Font = new Font( "Segoe UI", 14 );
			dgPrimeNbrs.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			foreach (DataGridViewColumn column in dgPrimeNbrs.Columns)
			{
				column.Width = 400; // Increase column width for all columns
			}
		}

		private List<int> generatePrimeNbrs(int max)
		{
			var primes = new List<int>() ;

			for (int num = 2; num <= max; num++)
				if (isPrime( num ))		primes.Add( num );

			return ( primes );
		}

		private static bool isPrime(int num)
		{
			if (num < 2) return ( false );
			for (int i = 2; i < Math.Sqrt( num ); i++)
				if (num % i == 0)		return ( false );

			return ( true ); 
		}

		private void btnGenerateNbrs_Click( object sender, EventArgs e )
		{
			int enteredNbr;

			if (int.TryParse(txtEnteredNbr.Text, out enteredNbr) && enteredNbr > 0)
			{
				var primeNbrs = generatePrimeNbrs( enteredNbr );
				displayPrimeNbrs( primeNbrs );

			}
			else
				MessageBox.Show( "Please enter a valid positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
		}

		private void displayPrimeNbrs( List<int> primes )
		{
			dgPrimeNbrs.Rows.Clear( ); // Clear previous rows

			// Add each prime number as a row in the DataGridView
			foreach (var nbr in primes)
			{
				// Adding each prime number to a new row
				dgPrimeNbrs.Rows.Add( nbr.ToString() );
			}
		}
	}
}
