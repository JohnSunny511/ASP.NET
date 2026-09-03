<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="js1.aspx.cs" Inherits="JavaScriptTutorial.js1" %>

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
                var flowers = ["rose", "lily", "hibsucus"];
                var nums = [2, 3, 99, 6, 85];
                /*nums.sort();*/
                for (i = 0; i < nums.length; i++) {
                    for (j = i + 1; j < nums.length; j++) {
                        if (nums[i] > nums[j]) {
                            temp = nums[j];
                            nums[j] = nums[i];
                            nums[i] = temp;
                        }
                    }
                }
                //document.getElementById("demo").innerHTML = nums;
                //document.getElementById("demo").innerHTML = flowers;
                //document.getElementById("demo").innerHTML = flowers.toString();
                //x =flowers.join();
                //x = flowers.join('*');
                //document.getElementById("demo").innerHTML = x;

                //flowers.pop();
                //flowers.push("jasmin");
                //flowers.splice()  //To add roemove elememt
                let prime_num = [2, 3, 5, 7,8,34,65,87];
                //prime_num.splice(1, 2, 100, 200);     //replace element at index 1 & 2 as 100 & 200
                //prime_num.splice(2, 1, 500);          //replace  (1) element at index 2 to 500
                //prime_num.splice(2, 0, 100);          //ADD   if 0 at middle It inserts number at index 2 by moving number from that to right side
                //prime_num.splice(2,3)                   //Remove   it removes 3 elements starting from position 2

                //x = prime_num.slice(2, 5);                  //Take elements from 2 to 5 indexes(excluding 5th positon)
                //x = prime_num.slice(2);                  //Take element from 2 to ending, since end is not given in the argument
                //x = prime_num.slice(2, -3);              -ve indexes start from the last without including the last selected index
                x = prime_num.slice(-4)                   //from -4 to end it takes values
                document.getElementById("demo").innerHTML = x;

                
            </script>
        </div>
    </form>
</body>
</html>
