using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class getEmployees2 : System.Web.UI.Page
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
}