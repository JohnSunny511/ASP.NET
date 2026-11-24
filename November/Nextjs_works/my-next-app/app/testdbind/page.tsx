"use client";
import { useState } from "react";

export default function testdataBind(){

    let uname = "john";
    const[count,setcount] = useState(0);
    const[name,setname] = useState("");

    const sytlecolor = "text-red-500";
    const isActive = false;
    const[active,setActive] = useState(true);

    return(
        <div>
            <h1>Data Bindings</h1>

            <br></br>
            <h2>Welcome, {uname}!</h2>
            <br></br>
            <h1>count:{count}</h1>
            <br></br>
            <button onClick={() => setcount(count+1)}>Increase the count</button>
            <br></br>
            <input style={style.tt} type="text" onChange={(e) => setname(e.target.value)}/>
            <h2>Helllo {name}</h2>


            <h1 className="stylecolor">hello Students</h1>
            <br></br>
            <h2 className={isActive? "text-green-500" : "text-red-500"}>Status Message</h2>
            <br></br>

            <button onClick={()=>setActive(false)}>Change Color</button>
            <h2 className={active? "text-green-500" : "text-red-500"}>
                Hello Students
            </h2>
        </div>
    )
}

const style={
    tt:{color:"blue",border:"2px solid black",padding:"5px",background:"white"}
}