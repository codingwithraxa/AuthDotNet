using MySqlConnector;
using System;
using System.Data;

public class DBUser
{
    string ConnectionString = "server=localhost;user=root;password=aliraxa229;database=auth;";

    public DBUser()
    {
        
    }

    public int ExecuteQuery(string query)
    {
        MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
        MySqlCommand command = new MySqlCommand(query, mySqlConnection);
        mySqlConnection.Open();
        try
        {
            try
            {
                return command.ExecuteNonQuery();
            }
            finally
            {
                mySqlConnection.Close();
                command.Dispose();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public object ExecuteScalar(string query)
    {
        MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
        MySqlCommand command = new MySqlCommand(query, mySqlConnection);
        mySqlConnection.Open();
        try
        {
            try
            {
                return command.ExecuteScalar();
            }
            finally
            {
                mySqlConnection.Close();
                command.Dispose();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public DataTable GetData(string query)
    {
        DataTable dt = new DataTable();
        MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
        MySqlDataAdapter command = new MySqlDataAdapter(query, mySqlConnection);
        mySqlConnection.Open();
        try
        {
            try
            {
                command.Fill(dt);
            }
            finally
            {
                mySqlConnection.Close();
                command.Dispose();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return dt;
    }
}