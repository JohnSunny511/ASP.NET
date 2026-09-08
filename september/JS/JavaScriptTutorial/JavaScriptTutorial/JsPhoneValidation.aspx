<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JsPhoneValidation.aspx.cs" Inherits="JavaScriptTutorial.JsPhoneValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    function ValidateMobileNumber() {
        var mobileNumber = document.getElementById("txtMobileNumber").value;
        var lblError = document.getElementById("lblError");
        lblError.innerHTML = "";
        var expr = /^(0|91)?[6-9][0-9]{9}$/;
        if (!expr.test(mobileNumber)) {
            lblError.innerHTML = "Invalid Mobile Number.";
        }
        else {
            lblError.innerHTML = "Valid Mobile Number.";
        }
    }
    </script>
    <style type="text/css">
			    body { font-family: Arial; font-size: 10pt; }
			    .error { color: Red; }
			</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Mobile Number:
			<input type="text" id="txtMobileNumber" />
			<span id="lblError" class="error"></span>
			<hr/>
			<input type="button" value="Submit" onclick="ValidateMobileNumber()" />
        </div>
    </form>
</body>
</html>