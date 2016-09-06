using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace new_JSLA
{
    class Database
    {
        private MySqlConnection _con;
        private MySqlCommand _com;
        private MySqlDataReader _reader;

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
                return new string[0, 0];
            }
        }


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
                return new string[0, 0];
            }
        }


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



        public void DeleteRecord(string table, string column, string columnValue)
        {
            _com.CommandText = "delete from " + table + " where " + column + " = '" + columnValue + "';";
            _com.ExecuteNonQuery();
        }


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
}
