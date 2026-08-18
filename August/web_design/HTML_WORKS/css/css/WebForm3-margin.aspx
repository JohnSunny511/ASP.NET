<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3-margin.aspx.cs" Inherits="css.WebForm3_margin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        p{
            background-color:pink;
        }
        p.ex{
            margin-top:50px;
            margin-left:30px;
            margin-right:50px;
            margin-bottom:12px;
        }
        p.ex1{
            margin:55px 30px 53px 22px;
        }
        p.ex2{
            margin:430px 65px 23px;
        }
        p.ex3{
            margin:4000px 6300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Jerin is a very talented student currently working as an intern at luminar technolab. Previously he worked at Seidoor , a renowed company</p>
        </div>
        <p class="ex">Jeese is a very talented student currently working as an intern at luminar technolab. Previously he worked at Caddayb , a renowed company</p>
    
        <p class="ex1">Jaken is a very talented student currently working as an intern at luminar technolab. Previously he worked at Seidoor , a renowed company</p>

        <p class="ex2">Joban is a very talented student currently working as an intern at luminar technolab. Previously he worked at Seidoor , a renowed company</p>

        <p class="ex3">christon is a very talented student currently working as an intern at luminar technolab. Previously he worked at Seidoor , a renowed company</p>
    </form>
</body>
</html>
