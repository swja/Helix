using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se guardó correctamente');", true);
        //mesage para probar git
        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se guardó correctamente');", true);
        ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('El registro se guardó correctamente');", true);
    }
}