using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class SendMsg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nd = Request.Form["txtMessage"];
            if (nd == null) {
                Response.Write("Rỗng");
                Response.Redirect("PostMsg.html");
            }
            else
            {
                ArrayList arr = (ArrayList)Application["noidung"];
                Member member = (Member)Session["member"];
                string dt = DateTime.Now.ToShortTimeString();
                arr.Add(new Message(member.nickName, nd, dt,member.color));
                Response.Redirect("PostMsg.html");
            }
        }
    }
}