using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class MsgList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arr = (ArrayList)Application["noidung"];
            if (arr == null) { }
            else
            {
                Member member = (Member)Session["member"];
                foreach (Message ar in arr)
                {
                    if (member.nickName.ToString() == ar.nickname.ToString())
                    {
                        Response.Write("<p style='color:" + ar.color + "; text-align: right;'><b>" + ar.nickname + ":&nbsp;" + ar.message + "&nbsp;(" + ar.timeStamp + ")</b></p>");
                    }
                    else
                    {
                        Response.Write("<p style='color:" + ar.color + "'>" + ar.nickname + ":&nbsp;" + ar.message + "&nbsp;(" + ar.timeStamp + ")</p>");
                    }
                }
            }
        }
    }
}