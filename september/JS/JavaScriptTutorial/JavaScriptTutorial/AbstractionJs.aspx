<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AbstractionJs.aspx.cs" Inherits="JavaScriptTutorial.AbstractionJs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        class A {
            constructor() {
                document.writeln("constructor");
            }
            check() {
                document.writeln("Non Abstract method");
            }
            display() {}
        }
        class B extends A {
            display() {
                document.writeln("Abstract method");
            }
        }

        ob = new B();
        ob.check();
        ob.display();
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
