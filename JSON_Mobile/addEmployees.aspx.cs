using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class addEmployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["OrtegaGoDaddy"].ConnectionString;
        DataAccess da = new DataAccess();
        da.insertEmployee(connectionstring, "INSERT INTO Ortega_Employees(employeeId, employeeFname, employeeLname) VALUES ('40', 'Doc', 'Brown')");

        lblMessage.Text = "Employee successfully added";
        lblMessage.Visible = true;
    }
}