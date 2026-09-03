<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="js1.aspx.cs" Inherits="Jaavascript.js1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Js1.js"></script>
    
    <script type="text/javascript">
        document.write("<br>");
        document.write("inside the head" + ": Hello World");
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <script type="text/javascript">
                document.write("Inside the body" + ":  World Hello");
            </script>
        </div>
    </form>
</body>
</html>
