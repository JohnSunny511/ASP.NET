<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overriding.aspx.cs" Inherits="JavaScriptTutorial.Overriding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        class A {
            display() {                         //NO VIRTUAL KEYWORD REQUIRED
                document.write("class A");
            }
        }

        class B extends A {
            display() {
                document.write("class B");
            }
        }
        ob = new B();
        ob.display();         //NO NEED OF OVERRIDE KEYWORD, THE CHILD CLASS AUTOMATICALLY OVERRIDES THE BASE CLASS FUNCTION WITH SAME SIGNATURE
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
