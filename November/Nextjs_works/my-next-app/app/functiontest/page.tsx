"use client";

export default function funpage(){
    
    function greet(){
        alert("This is a client component");
    }

    function sum(a:any,b:any){
        return a+b;
    }

    function product(a:any,b:any){
        return a*b;
    }

    return(

        <div>
            <h1>Function Page</h1>
            <br></br>
            <button style={{backgroundColor: "#cc9527",color: "white"}} onClick={greet}>Click Me</button>
            <br></br>
            <button onClick={() => alert("sum of 5 and 3 is :"+ sum(5,3))}>Show Sum</button>
            <br></br>
            <button onClick={(p:any) => alert(p = product(5,3))}>Show Product</button>
            <br></br>
            <button onClick={(p:any) =>  {p = product(15,10);
                alert(p);
            }}>
                Show Product
            </button>


        </div>
    );
}