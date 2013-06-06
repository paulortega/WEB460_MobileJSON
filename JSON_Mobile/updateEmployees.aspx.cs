using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updateEmployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["OrtegaGoDaddy"].ConnectionString;
        DataAccess da = new DataAccess();
        da.updateEmployee(connectionstring, "UPDATE Ortega_Employees SET employeeFname = 'Ray' WHERE employeeId > '1'");

        lblMessage.Text = "Employee successfully updated";
        lblMessage.Visible = true;
    }
}