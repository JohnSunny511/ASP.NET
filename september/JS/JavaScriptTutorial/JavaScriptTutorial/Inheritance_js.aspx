<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inheritance_js.aspx.cs" Inherits="JavaScriptTutorial.Inheritance_js" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        class A {
            read() {
                this.x = 100;
                this.y = 200;
            }
        }

        class B extends A {
            sum() {
                this.s = this.x + this.y;
                document.writeln("sum is: ", this.s);
            }
        }
        class C extends A {
            avg() {
                document.writeln("Average :", (this.x + this.y) / 2);
            }
        }

        obj = new B();
        obj.read();
        obj.sum();

        obj = new C();
        obj.read();
        obj.avg();
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
