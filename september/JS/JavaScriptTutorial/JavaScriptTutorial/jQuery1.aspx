<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jQuery1.aspx.cs" Inherits="JavaScriptTutorial.jQuery1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("*").css("background-color", "yellow");
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <body>


                <h1>Welcome to My Homepage</h1>

                <p class="intro">My name is Donald.</p>
                <p>I live in Duckburg.</p>
                <p>My best friend is Mickey.</p>

                <p>Who is your favourite:</p>

                <ul id="choose">
                    <li>Goofy</li>
                    <li>Mickey</li>
                    <li>Pluto</li>
                </ul>
        </div>
    </form>
</body>
</html>
