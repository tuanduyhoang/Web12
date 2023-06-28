using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class All : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Form["txtUsername"];
            string color = Request.Form["txtColor"];
            if (name == null || color == null)
            {
                Response.Redirect("Login.html");
            }
            else
            {
                Member member = (Member)Session["member"];
                member.nickName = name;
                member.color = color;
                ArrayList arrSession = (ArrayList)Application["members"];
                arrSession.Add(new Member(name, color));
            }
        }
    }
}