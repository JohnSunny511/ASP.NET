<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lambdaFunction.aspx.cs" Inherits="JavaScriptTutorial.lambdaFunction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p id="demo"></p>
            <script>
                let num = [2, 4, 6, 8, 10, 9];
                //function to return the square of a number
                function square(number) {
                    return number * number;
                }

                //apply square() to each item of the numbers list
                let sq_nums = num.map(square);
                console.log(sq_nums);

                //fucntion to check even numbers
                function checkEven(numbers) {
                    if (numbers % 2 == 0) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
                let evenNums = num.filter(checkEven);
                console.log(evenNums);
            </script>
        </div>
    </form>
</body>
</html>
