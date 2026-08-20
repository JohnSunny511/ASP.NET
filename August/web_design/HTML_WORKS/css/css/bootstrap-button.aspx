<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bootstrap-button.aspx.cs" Inherits="css.bootstrap_button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.7.1/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <button type="button" class="btn">Default</button>
            <button type="button" class="btn btn-outline-primary btn-sm btn-block btn-block">primary</button>
            <button type="button" class="btn btn-info btn-lg">Information</button>
        </div>
    </form>
</body>
</html>
