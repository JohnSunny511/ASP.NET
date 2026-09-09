<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQuery9DbleClick.aspx.cs" Inherits="JavaScriptTutorial.jQuery9DbleClick" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("p").dblclick(function () {
                $(this).hide();
            });
        });
    </script>
</head>
<body>
    <p>If you double-click on me, I will disappear.</p>
    <p>Click me away!</p>
    <p>Click me too!</p>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
