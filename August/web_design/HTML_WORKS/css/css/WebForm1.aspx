<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="css.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #id1{
            text-align:left;
            color:darkorange;
        }
        #id2{
            text-align:right;
            color:#00ff90;
            font-size:xx-large;
            font-family:'Times New Roman';
            font-style:normal;
        }
        #id3{
            text-align:center;
            color:rgb(131 105 105);
            font-size:77px;
            font-style:oblique;
        }
        #id4{
            text-align:justify;
            font-size:470%;
            font-style:italic;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="id1">Left</h1>
            <h1 id="id2">right</h1>
            <h1 id="id3">center</h1>
            <h1 id="id4">Justify</h1>
        </div>
    </form>
</body>
</html>
