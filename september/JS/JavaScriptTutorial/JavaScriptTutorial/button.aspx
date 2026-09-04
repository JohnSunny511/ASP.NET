 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="button.aspx.cs" Inherits="JavaScriptTutorial.button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function Fun_alert() {
            alert("Hello, This is an Alert Box");
        }
        function fun_confirm() {
            var txt;
            if (confirm("Press a button!")) {
                txt = "You pressed OK";
            }
            else {
                txt = "You presses Cancel!";
            }
            document.getElementById("p1").innerHTML = txt;
        }
    </script>
</head>
<body>
    <div>
        <p id="p1">

        </p>
            
            <br />
            <input id="b2" type="submit" value="submit" onclick="fun_confirm();" />

        </div>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="Fun_alert();" />
    </form>
</body>
</html>
