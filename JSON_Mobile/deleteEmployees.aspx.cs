using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deleteEmployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["OrtegaGoDaddy"].ConnectionString;
        DataAccess da = new DataAccess();
        da.deleteEmployee(connectionstring, "DELETE FROM Ortega_Employees WHERE employeefName ='Doc'");

        lblMessage.Text = "Employees successfully deleted";
        lblMessage.Visible = true;
    }
}