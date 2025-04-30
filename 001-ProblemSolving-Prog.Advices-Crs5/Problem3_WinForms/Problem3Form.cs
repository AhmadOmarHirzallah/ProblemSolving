namespace Problem3_WinForms
{
	public partial class Problem3Form : Form
	{
		public Problem3Form()
		{
			InitializeComponent( );
		}

		protected bool checkIsPerfectNbr(int nbr)
		{
			if (nbr == 1) return ( false );

			int sum = 1; // 1 is always a divisor of any number
			for (int i = 2; i < nbr; i++)
				if (nbr % i == 0)
					sum += i;
			return ( sum == nbr );

		}

		protected void btnCheckPerfectNumber_Click( object sender, EventArgs e )
		{
			int enteredNbr;
			bool isPerfect;

			if (int.TryParse( txtNbrInput.Text, out enteredNbr ) && ( enteredNbr > 0 ))
			{
				isPerfect = checkIsPerfectNbr( enteredNbr );
				lblResult.Text = isPerfect ? $"{enteredNbr}\nis a Perfect Number :)"
								: $"{enteredNbr}\nISN'T a Perfect Number :(";
			}
			else
				MessageBox.Show( "Please enter a valid positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error );

		}
	}
}
