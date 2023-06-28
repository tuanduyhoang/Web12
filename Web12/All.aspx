<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All.aspx.cs" Inherits="Web12.All" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <frameset rows="75%,25%">
    <frameset cols="25%,75%">
        <frame name="left" src="Members.aspx" />
        <frame name="right" src="MsgList.aspx" />
        </frameset>
    <frameset cols="100%">
        <frame name="bottom" src="PostMsg.html" />
    </frameset>
</frameset>
<body></body>
</html>
