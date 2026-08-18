<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="externalcss.aspx.cs" Inherits="css.externalcss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        h1{
            color:darkgoldenrod;
            font-size:20px;
        }
        #id1{
            color:firebrick;
        }
        .c1{
            color:deeppink;
        }
        h1,h2,p,.c1{
            background-color:lightgreen
        }
        div h2{
            background-color:aqua;
        }
        div~h2{
            background-color:gold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="id1">Hello</h1>
            <h1>Hehehehehe</h1>
            <h2>World!</h2>
            <h1 class="c1">HOw</h1>
            <h2 class="c1">Are</h2>
        </div>
        <h2>Jerin X Jeese</h2>
        <div>
            <h2>Jeese & Jerin</h2>
        </div>
    </form>
</body>
</html>
