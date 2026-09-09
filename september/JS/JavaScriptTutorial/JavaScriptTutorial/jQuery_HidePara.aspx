<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQuery_HidePara.aspx.cs" Inherits="JavaScriptTutorial.jQuery_HidePara" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("button").click(function () {
                $("p").hide();
            });
        });
    </script>
</head>
<body>
    <h2>This is a heading</h2>

    <p>This is a paragraph.</p>
    <p>This is another paragraph.</p>

    <button>Click me to hide paragraphs</button>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
