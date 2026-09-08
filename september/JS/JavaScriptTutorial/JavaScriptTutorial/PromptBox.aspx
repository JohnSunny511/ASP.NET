<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PromptBox.aspx.cs" Inherits="JavaScriptTutorial.PromptBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
            <p id="p1"></p>
            <script>
                function Fun_Prompt() {
                    let text;
                    let name = prompt("Please enter your name:", "Edwin");
                    if (name == null || name == "") {
                        text = "User cancelled the prompt";
                    }
                    else {
                        text = "Hello" + name + "!How are you today?";
                    }
                    document.getElementById("p1").innerHTML = text;
                }
            </script>
            <br />
            <input id ="b2" type="submit" value="submit" onclick="Fun_Prompt();" />
        </div>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button"  OnClientClick="Fun_Prompt(); return false;"/>   <%--return false is kept so that the request doesnt go to server--%>
    </form>
</body>
</html>
