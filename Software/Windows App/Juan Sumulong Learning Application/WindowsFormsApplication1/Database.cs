using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/// <summary>
/// A class to handle most MySQL transactions
/// </summary>
public class Database
{
    private MySqlConnection _con;
    private MySqlCommand _com;
    private MySqlDataReader _reader;

    /// <summary>
    /// A class to handle most MySQL transactions
    /// </summary>
    /// <param name="database">The database to be used</param>
    /// <param name="datasource">The datasource to connect</param>
    public Database(string database, string datasource)
    {
        while (true)
            try
            {
                _con = new MySqlConnection("datasource = " + datasource + "; user = root; database = " + database + ';');
                _con.Open();
                break;
            }
            catch (MySqlException ex)
            {
                DialogResult result = MessageBox.Show("Unable to reach server. Would you like to try connecting?.\r\nError code:\r\n" + ex.Message, "Connection error!", MessageBoxButtons.RetryCancel);
                if (result != DialogResult.Retry)
                {
                    Application.Exit();
                    return;
                }
            }
        _com = new MySqlCommand();
        _com.Connection = _con;
        _con.ChangeDatabase(database);
    }

    public void CloseConnection()
    {
        _con.Close();
    }

    /////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Scans the selected table and returns a jagged string array as a result.
    /// </summary>
    /// <param name="table">The table to be scanned.</param>
    /// <param name="columns">The specific columns to be returned.</param>
    /// <param name="condition">The condition to be applied for retrieving the result</param>
    /// <returns>The scanned records.</returns>
    public string[,] ScanRecords(string table, string[] columns, string condition)
    {
        string selectedColumns = columns[0];
        for (int i = 1; i < columns.Length; i++)
            selectedColumns += ", " + columns[i];

        _com.CommandText = "select " + selectedColumns + " from " + table + " where " + condition;
        _reader = _com.ExecuteReader();
        if (_reader.HasRows)
        {
            int cnt = 0;
            while (_reader.Read())
                cnt++;

            string[,] records = new string[cnt, _reader.FieldCount];
            _reader.Close();

            _reader = _com.ExecuteReader();
            int i = 0;
            while (_reader.Read())
            {
                for (int i2 = 0; i2 < _reader.FieldCount; i2++)
                    records[i, i2] = _reader[i2].GetType().Name != "DateTime" ? _reader[i2].ToString() : DateTime.Parse(_reader[i2].ToString()).ToString("yyyy-MM-d");
                i++;
            }
            _reader.Close();

            return records;
        }
        else
        {
            _reader.Close();
            return new string[0, 0];
        }
    }

    /// <summary>
    /// Scans the selected table and returns a jagged string array as a result.
    /// </summary>
    /// <param name="table">The table to be scanned.</param>
    /// <param name="columns">The specific columns to be returned.</param>
    /// <returns>The scanned records.</returns>
    public string[,] ScanRecords(string table, params string[] columns)
    {
        string selectedColumns = columns[0];
        for (int i = 1; i < columns.Length; i++)
            selectedColumns += ", " + columns[i];

        _com.CommandText = "select " + selectedColumns + " from " + table;
        _reader = _com.ExecuteReader();
        if (_reader.HasRows)
        {
            int cnt = 0;
            while (_reader.Read())
                cnt++;

            string[,] records = new string[cnt, _reader.FieldCount];
            _reader.Close();

            _reader = _com.ExecuteReader();
            int i = 0;
            while (_reader.Read())
            {
                for (int i2 = 0; i2 < _reader.FieldCount; i2++)
                    records[i, i2] = _reader[i2].ToString();
                i++;
            }
            _reader.Close();

            return records;
        }
        else
        {
            _reader.Close();
            return new string[0,0];
        }
    }

    /// <summary>
    /// Scans the selected table and returns a jagged string array as a result.
    /// </summary>
    /// <param name="table">The table to be scanned.</param>
    /// <returns>The scanned records.</returns>
    public string[,] ScanRecords(string table)
    {

        _com.CommandText = "select * from " + table + ";";
        _reader = _com.ExecuteReader();
        if (_reader.HasRows)
        {
            int cnt = 0;
            while (_reader.Read())
                cnt++;

            string[,] records = new string[cnt, _reader.FieldCount];
            _reader.Close();

            _reader = _com.ExecuteReader();
            int i = 0;
            while (_reader.Read())
            {
                for (int i2 = 0; i2 < _reader.FieldCount; i2++)
                    records[i, i2] = _reader[i2].ToString();
                i++;
            }
            _reader.Close();

            return records;
        }
        else
        {
            _reader.Close();
            return new string[0,0];
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Inserts a record to a specified table in the database.
    /// </summary>
    /// <example>insertRecord("tblUserAccounts", {"username", "password", "fullname"})</example>
    /// <param name="table">The table to be inserted.</param>
    /// <param name="columns">The columns where the records are to be inserted</param>
    /// <param name="values">The values of the record to be added.</param>
    public bool InsertRecord(string table, string[] columns, string[] values)
    {
        string command = "insert into " + table + "(";

        for (int i = 0; i < columns.Length; i++)
        {
            command += columns[i];
            if (i != columns.Length - 1)
                command += ", ";
        }
        command += ") values(";

        for (int i = 0; i < values.Length; i++)
        {
            command += values[i] != "null" ? "'" + values[i] + "'" : "null";
            if (i != values.Length - 1)
                command += ", ";
        }
        command += ");";


        _com.CommandText = command;
        try
        {
            _com.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Exception Occured!", ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Inserts a record to a specified table in the database.
    /// </summary>
    /// <example>insertRecord("tblUserAccounts", {"username", "password", "fullname"})</example>
    /// <param name="table">The table to be inserted.</param>
    /// <param name="values">The Values of the record to be added.</param>
    public bool InsertRecord(string table, params string[] values)
    {
        string command = "insert into " + table + " values(";
        for (int i = 0; i < values.Length; i++)
        {
            command += values[i] != "null" ? "'" + values[i] + "'" : "null";
            if (i != values.Length - 1)
                command += ", ";
        }
        command += ");";


        _com.CommandText = command;
        try
        {
            _com.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Exception Occured!", ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    /////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Updates a record from a specified table in the database.
    /// </summary>
    /// <param name="table">The table to be updated.</param>
    /// <param name="column">The specific column that contains the specific value of the record to be updated.</param>
    /// <param name="columnValue">A specific value of the record to be updated.</param>
    /// <param name="columns">The columns of the record to be updated.</param>
    /// <param name="values">The values of the record to be updated.</param>
    public bool UpdateRecord(string table, string column, string columnValue, string[] columns, string[] values)
    {
        string setFields = columns[0] + " = '" + values[0] + "'";
        for (int i = 1; i < columns.Length; i++)
            setFields += ", " + columns[i] + " = '" + values[i] + "'";

        _com.CommandText = "update " + table + " set " + setFields + " where " + column + " = '" + columnValue + "';";
        try
        {
            _com.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Exception Occured!", ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    /////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Deletes a record from a specified table in the database.
    /// </summary>
    /// <param name="table">The table to be updated.</param>
    /// <param name="column">The column that contains the specific value of the record to be deleted.</param>
    /// <param name="columnValue">A specific value of the record to be deleted.</param>
    public void DeleteRecord(string table, string column, string columnValue)
    {
        _com.CommandText = "delete from " + table + " where " + column + " = '" + columnValue + "';";
        _com.ExecuteNonQuery();
    }

    /////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Executes a non-query command.
    /// </summary>
    /// <param name="command">The command to execute</param>
    /// <returns>True if executed successfully</returns>
    public bool ExecuteNonQuery(string command)
    {
        _com.CommandText = command;
        try
        {
            _com.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.InnerException != null ? ex.InnerException.Message : "", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Executes a query command.
    /// </summary>
    /// <param name="command">The command to execute</param>
    /// <returns>A two-dimensional array of result from the query</returns>
    public string[,] ExecuteQuery(string command)
    {
        _com.CommandText = command;
        _reader = _com.ExecuteReader();
        if (_reader.HasRows)
        {
            int cnt = 0;
            while (_reader.Read())
                cnt++;

            string[,] records = new string[cnt, _reader.FieldCount];
            _reader.Close();

            _reader = _com.ExecuteReader();
            int i = 0;
            while (_reader.Read())
            {
                for (int i2 = 0; i2 < _reader.FieldCount; i2++)
                    records[i, i2] = _reader[i2].ToString();
                i++;
            }
            _reader.Close();

            return records;
        }
        else
        {
            _reader.Close();
            return new string[0, 0];
        }
    }
}
