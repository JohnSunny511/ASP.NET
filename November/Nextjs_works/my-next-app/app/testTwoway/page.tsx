"use client";

import { useState } from "react";
export default function Home(){
    const[name,setName] = useState("");
    return(
        <div>
            <h2>Two Way binidng Example</h2>
            <input type="text" value={name} onChange={(e) => setName(e.target.value)} 
            placeholder="Enter your name"
            style={{
                width:"300px",
                padding:"10px",
                border:"1px solid #cc",
                borderRadius:"5px",
                fontSize:"16px",
                outline:"none"
            }}
            />

            <br></br>

            <h3>Welcome</h3>

            <br></br>

             <input type="text" value={name} onChange={(e) => setName(e.target.value)} 
            placeholder="Enter your name"
            style={{
                width:"300px",
                padding:"10px",
                border:"1px solid #cc",
                borderRadius:"5px",
                fontSize:"16px",
                outline:"none"
            }}
            />
        </div>
    )
}