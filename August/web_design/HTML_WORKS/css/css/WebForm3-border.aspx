<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3-border.aspx.cs" Inherits="css.WebForm3_border" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        p.dotted{
            border-style: dashed;
            border-width:medium;
            border-color:#ff6a00;
        }
        p.dashed{
            border-style:dashed;
            border-width:8px;
            border-color:red;
        }
        p.solid {border-style: solid;}
        p.double {border-style: double}
        p.groove {border-style: groove;border-width:15px;}
        p.ridge {border-style: ridge; border-width:15px;}
        p.inset {border-style: inset;border-width:15px;}
        p.outset {border-style: outset; border-width:15px;}
        p.hidden {border-style:hidden;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>hELLO HOW ARE YOIU</p>
        <p class="dashed">My name is john</p>
        <p class="dotted">Studying at lum</p>
        <p class="doubled">My name is john</p>
    </form>
</body>
</html>
