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
            <button type="button" class="btn">
                Default
            </button>
            <button type="button" class="btn btn-outline-primary btn-sm btn-block btn-block">primary</button>
            <button type="button" class="btn btn-info btn-lg">Information</button>

            <button type="button" class="btn btn-primary">
                <span class="spinner-border spinner-grow"></span>Loading
            </button>

            <button type="button" class="btn btn-primary" disabled>
                <span class="spinner-border spinner-border-sm"></span>Loading
            </button>


            <div class="btn-group btn-group-lg">
                <button type="button" class="btn btn-primary">Apple</button>
                <button type="button" class="btn btn-primary">Samsung</button>
                <button type="button" class="btn btn-primary">Sony</button>
            </div>

            <br />
            
            

            <div class="btn-group">
                <button type="button" class="btn btn-primary">Apple</button>
                <button type="button" class="btn btn-primary">Samsung</button>
                <div class="btn-group">
                    <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                        sony
                    </button>
                    <div class="dropdown-menu">
                        <a class="dropdown-item" href="#">Tablet</a>
                        <a class="dropdown-item" href="#">SmartPhone</a>
                    </div>
                </div>
            </div>


            <div class="btn-group">
                <button type="button" class="btn btn-primary">Apple</button>
                <button type="button" class="btn btn-primary">Samsung</button>
                <button type="button" class="btn btn-primary">Sony</button>
            </div>

            <div class="btn-group">
                <button type="button" class="btn btn-primary">BMW</button>
                <button type="button" class="btn btn-primary">Mercedes</button>
                <button type="button" class="btn btn-primary">Volvo</button>
            </div>


        </div>
    </form>
</body>
</html>
