<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3-Image.aspx.cs" Inherits="css.WebForm3_Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #img1{
            border: 2px solid red;
            border-radius:30px;
            padding:20px;
        }
        #img2{
            border:5px solid blue;
            border-radius:60px;
            padding:4px;
            width:900px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Thumbnail Image</h1>
            <img src="Screenshot 2026-02-19 200824.png" id="img1" />
            <h2>Circle Image</h2>
            <img src="Screenshot 2026-02-28 113731.png" id="img2" />
        </div>
    </form>
</body>
</html>
