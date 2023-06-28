using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arrSession = (ArrayList)Application["members"];
            if (arrSession == null) { }
            else
            {
                Member memb = (Member)Session["member"];
                string str = "";
                foreach (Member mem in arrSession)
                {
                    if (memb.nickName == mem.nickName)
                    {
                        Response.Write("<p style='color:" + mem.color + "'><b><u>" + mem.nickName + "</u></b></p>");
                    }
                    else
                    {
                        Response.Write("<p style='color:" + mem.color + "'>" + mem.nickName + "</p>");
                    }
                }
                
            }
        }
    }
}