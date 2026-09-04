<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Class_Tutorial.aspx.cs" Inherits="JavaScriptTutorial.Class_Tutorial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        //Declaring Class
        var Colour = class {            //when we give   var Color =   class Colour it is written as an expression
            //initializing an object
            constructor(id, name) {
                this.id = id;
                this.name = name;
            }
            //Declaring method
            display() {
                document.writeln(this.id + " " + this.name );
            }

        }
        //passing object to a variable
        var e1 = new Colour(1, "red");
        e1.display(); //calling method
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
