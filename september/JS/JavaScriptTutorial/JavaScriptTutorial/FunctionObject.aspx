<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FunctionObject.aspx.cs" Inherits="JavaScriptTutorial.FunctionObject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p id="demo"></p>
            <script>
                var add = new Function("num1", "num2", "return num1+num2");
                document.writeln(add(200, 500));
                //or
                var s = add(20, 30);
                document.writeln(s);
            </script>
        </div>
    </form>
</body>
</html>
