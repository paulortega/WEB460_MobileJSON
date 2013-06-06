﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class getEmployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("{\"employees\": [");
        string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["OrtegaGoDaddy"].ConnectionString;
        DataAccess da = new DataAccess();

        System.Data.DataSet ds = da.getDataSet(connectionstring, "select employeeId, employeeFname, employeeLname from Ortega_Employees");

        if (ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
        {
            Response.Write("{}");
        }
        else
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Response.Write("{\"employeeid\": \"" +
                    ds.Tables[0].Rows[i].ItemArray[0].ToString() + "\",\"firstname\":" + "\"" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "\"}");

                if (i < ds.Tables[0].Rows.Count - 1)
                {
                    Response.Write(",");
                }

            }
        }

        Response.Write("]}"); 
    }
    protected void btnExample_Click(object sender, EventArgs e)
    {
        Response.Write("{\"employees\": [");
        string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["OrtegaGoDaddy"].ConnectionString;
        DataAccess da = new DataAccess();
        System.Data.DataSet ds = da.getDataSet(connectionstring, "select employeeid, firstname, lastname from huber_employees");

        //System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
        //string sql = "select employeeid, firstname, lastname from huber_employees";

        //conn.ConnectionString = connectionstring;

        //System.Data.DataSet ds = new System.Data.DataSet();
        //conn.Open();
        //System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand(sql, conn);

        //System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        //da.SelectCommand = comm;

        //da.Fill(ds);

        //if there are no employees returned
        if (ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
        {
            Response.Write("{}");
        }
        else
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Response.Write("{\"employeeid\": \"" +
                    ds.Tables[0].Rows[i].ItemArray[0].ToString() + "\",\"firstname\":" + "\"" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "\"}");

                if (i < ds.Tables[0].Rows.Count - 1)
                {
                    Response.Write(",");
                }

            }
        }

        Response.Write("]}");
    }

    protected void btnEmployee_Click(object sender, EventArgs e)
    {
        Response.Write("{\"employees\": [");
        string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["OrtegaGoDaddy"].ConnectionString;
        DataAccess da = new DataAccess();

        System.Data.DataSet ds = da.getDataSet(connectionstring, "select employeeId, employeeFname, employeeLname from Ortega_Employees");

        if (ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
        {
            Response.Write("{}");
        }
        else
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Response.Write("{\"employeeid\": \"" +
                    ds.Tables[0].Rows[i].ItemArray[0].ToString() + "\",\"firstname\":" + "\"" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "\"}");

                if (i < ds.Tables[0].Rows.Count - 1)
                {
                    Response.Write(",");
                }

            }
        }

        Response.Write("]}");   


    }
    protected void btnCustomer_Click(object sender, EventArgs e)
    {

    }
    protected void btnWorkOrder_Click(object sender, EventArgs e)
    {

    }
}