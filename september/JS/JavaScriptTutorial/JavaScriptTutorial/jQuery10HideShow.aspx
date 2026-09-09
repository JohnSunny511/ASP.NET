<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQuery10HideShow.aspx.cs" Inherits="JavaScriptTutorial.jQuery10HideShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#hide").click(function () {
                $("p").hide();
            });
            $("#show").click(function () {
                $("p").show();
            });
        });
    </script>
</head>
<body>
    <p>If you click on the "Hide" button, I will disappear.</p>

    <button id="hide">Hide</button>
    <button id="show">Show</button>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
