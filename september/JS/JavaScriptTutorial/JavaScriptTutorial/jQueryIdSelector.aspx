<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQueryIdSelector.aspx.cs" Inherits="JavaScriptTutorial.jQueryIdSelector" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
    src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("p:first").css("background-color", "yellow");
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>This is the second paragraph.</p>
            <p>This is the firs paragraph.</p>

            <p>This is the last paragraph.</p>
        </div>
    </form>
</body>
</html>
