using System;
using System.Windows.Forms;

namespace Problem1_WinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent( );
			addDgColumns( ); // Add the columns first
			setColumnHeaderStyle( ); // Set column header styles
			SetRowHeaderStyle( ); // Set row header styles
		}

		private void setRowsLabels()
		{
			// Ensure RowHeadersWidth is set after adding rows and columns
			dgMultTableData.RowHeadersWidth = 50; // Adjust the width of the row header
			dgMultTableData.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgMultTableData.RowTemplate.Height = 40;  // Increase the height of each row (data cells)

			// Set row header values (1 to 10)
			for (int i = 0; i < 10; i++)
				dgMultTableData.Rows[i].HeaderCell.Value = ( i + 1 ).ToString( );

			// Force the DataGridView to refresh and recalculate layout
			dgMultTableData.Invalidate( );
			dgMultTableData.PerformLayout( ); // Trigger layout update
		}

		private void setColumnHeaderStyle()
		{
			dgMultTableData.ColumnHeadersDefaultCellStyle.Font = new Font( "Segoe UI", 11, FontStyle.Bold );
			dgMultTableData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		private void SetRowHeaderStyle()
		{
			// Set larger font size for row headers
			dgMultTableData.RowHeadersDefaultCellStyle.Font = new Font( "Segoe UI", 11, FontStyle.Bold );
			dgMultTableData.RowHeadersWidth = 50;  // Increase width of row headers
			dgMultTableData.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		private void addDgColumns()
		{
			// Add columns to the DataGridView
			for (int i = 1; i <= 10; i++)
				dgMultTableData.Columns.Add( "Column" + i, i.ToString( ) );
		}

		private void generateMultiplicationTable()
		{
			// Clear any existing rows
			dgMultTableData.Rows.Clear( );

			// Add rows dynamically (1 to 10)
			for (int row = 0; row < 10; row++)
			{
				dgMultTableData.Rows.Add( ); // Add a new row
				for (int col = 0; col < 10; col++)
					dgMultTableData.Rows[row].Cells[col].Value = ( row + 1 ) * ( col + 1 );
			}

			// Force a refresh after adding rows
			dgMultTableData.Invalidate( );
			dgMultTableData.PerformLayout( ); // Trigger layout update
		}

		private void resetTable()
		{
			dgMultTableData.Rows.Clear( );
		}

		private void btnReset_Click( object sender, EventArgs e )
		{
			resetTable( );
		}

		private void btnGenrateTable_Click( object sender, EventArgs e )
		{
			generateMultiplicationTable( );
			setRowsLabels( );
		}
	}
}
