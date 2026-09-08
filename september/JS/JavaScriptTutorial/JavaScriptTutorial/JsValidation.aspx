<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JsValidation.aspx.cs" Inherits="JavaScriptTutorial.JsValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function ValidateEmail() {
            var email = document.getElementById("txtEmail").value;
            var lblError = document.getElementById("lblError");
            lblError.innerHTML = "";
            var expr = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
            if (!expr.test(email)) {
                lblError.innerHTML = "Invalid email address.";
            }
        }
    </script>
</head>
<body>
    
    
    <form id="form1" runat="server">
        <div>
            <input type="text" id="txtEmail" />
    <span id="lblError" style="color:red"></span>
    <br /><br />
    <input type="button" id="btnValidate" value="Submit" onclick="ValidateEmail()" />
        </div>
    </form>
</body>
</html>
