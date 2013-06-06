using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
    public DataAccess()
    {

    }

    //Get Employee using DataSet. Inclass Example
    public System.Data.DataSet getDataSet(string connectionstring, string sqlstatement)
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        conn.ConnectionString = connectionstring;
        System.Data.DataSet ds = new System.Data.DataSet();
        conn.Open();
        System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand(sqlstatement, conn);

        System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        da.SelectCommand = comm;

        da.Fill(ds);
        conn.Close();
        return ds;
    }

    public SqlDataReader getData(string connectionstring, string sqlstatement)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connectionstring;

        SqlDataReader dr;
        conn.Open();
        SqlCommand comm = new SqlCommand(sqlstatement, conn);

        dr = comm.ExecuteReader();

        return dr;
    }

    //Insert Employee using DataReader
    public void insertEmployee(string connectionstring, string sqlstatement)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connectionstring;
        conn.Open();
        SqlCommand comm = new SqlCommand(sqlstatement, conn);
        comm.ExecuteNonQuery();
        conn.Close();
    }

    //Insert employee using DataSet
    public System.Data.DataSet insertDataSet(string connectionstring, string sqlstatement)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connectionstring;
        conn.Open();
        SqlCommand comm = new SqlCommand(sqlstatement, conn);
        comm.ExecuteNonQuery();
        conn.Close();

        return null;
    }

    //Update Employee columns using DataReader
    public void updateEmployee(string connectionstring, string sqlstatement)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connectionstring;
        conn.Open();
        SqlCommand comm = new SqlCommand(sqlstatement, conn);
        comm.ExecuteNonQuery();
        conn.Close();
    }

    //Delete Employee columns using DataReader
    public void deleteEmployee(string connectionstring, string sqlstatement)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = connectionstring;
        conn.Open();
        SqlCommand comm = new SqlCommand(sqlstatement, conn);
        comm.ExecuteNonQuery();
        conn.Close();
    }
}