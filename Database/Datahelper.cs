using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * In C#, the DataBindings property of a control allows you to bind
 * the control to a data source, enabling automatic updates between
 * the UI and the underlying data. This is especially useful for
 * forms that need to display 
 * and update data from a database or other data source.
 
 INotifyPropertyChanged: If you are binding to a class (like Person), 
make sure it implements INotifyPropertyChanged to ensure that UI updates 
are propagated when properties change.

Two-Way Binding: If you want changes in the TextBox to
update the currentPerson object automatically, use DataSourceUpdateMode.
OnPropertyChanged. Otherwise,
you can manually update the data when necessary.
 
 */

namespace ScheduleApp.Database
{
    //databindings ? 
    using System.Data;
    using System.Data.SqlClient;

    //commenting out while working on other things
    /*
    private void BindDataFromDatabase()
    {
        using (SqlConnection conn = new SqlConnection("your_connection_string"))
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, Name FROM People", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }


    private void GetDataFromDataBase()
    {
        dataGridCustomer.DataSource = dataGridView1; // Set the data source
    }
*/

    // end commenting out while working on other things

    /*Property Name: This is the property of your data source you want to bind to (like a column in a DataTable or a property in a model).

True (FormattingEnabled): This allows for automatic formatting. If you set this to true, the data binding will attempt to format the data as needed.

DataSourceUpdateMode: This specifies when the control will update the data source. Common options include:


OnPropertyChanged: The data source is updated as soon as the property changes (e.g., when the user types in a TextBox).
*/
}
