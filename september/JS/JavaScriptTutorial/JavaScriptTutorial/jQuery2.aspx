<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQuery2.aspx.cs" Inherits="JavaScriptTutorial.jQuery2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#intro").css("background-color", "yellow");
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to My Homepage</h1>

            <p id="intro">My name is Donald.</p>
            <p>I live in Duckburg.</p>
        </div>
    </form>
</body>
</html>
