"use client";

import { HtmlContext } from "next/dist/server/route-modules/pages/vendored/contexts/entrypoints";
import { useState } from "react";

export default function Home(){
    const[name,setName] = useState("");
    const[email,setEmail] = useState("");
    const[password,setPassword] = useState("");
    const[course,setCourse] = useState("");
    const[error,setError] = useState("");
    //preventDefault() -- prevenet browsers default action/reload
    //react.SubmitEvent -- This specifies the event type.It tells  typscirpt that this function handles a form submission event
    //HTMLFormevent -- This specifies that the event is associated with an HTML form element.

    function handleSubmit(e: React.SubmitEvent<HTMLFormElement>){
        e.preventDefault();

        if(name == ""){
            setError("Please enter your name");
        }
        else if(email ===""){
            setError("Please enter your email");
        }
        else if(!email.includes("@")){
            setError("Enter a valid email");
        }
        else if(password.length < 6){
            setError("Passwrod must contain at least 6 characters");
        }
        else{
            setError("");
            alert("Registration Successful!");
        }
    }

    return(
        <div style={{width:"350px",margin:"50px auto"}}>
            <h2>Student Registration</h2>
            <form onSubmit={(handleSubmit)}>
                <label>Name:</label>
                <input
                    type="text"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                    placeholder="Enter Name"
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

                    <label>Email:</label>
                <input
                    type="text"
                    value={email}
                    onChange={(e) => setName(e.target.value)}
                    placeholder="Enter Email"
                    style={{
                        width:"300px",
                        padding:"10px",
                        border:"1px solid #cc",
                        borderRadius:"5px",
                        fontSize:"16px",
                        outline:"none"
                    }}
                    />


                    <label>Password:</label>
                <input
                    type="text"
                    value={password}
                    onChange={(e) => setName(e.target.value)}
                    placeholder="Enter password"
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

                    <h2>Select Course</h2>

                    <select
                        value={course}
                        onChange={(e) => setCourse(e.target.value)}
                        style={{
                            width:"300px",
                            padding:"10px",
                            border:"1px solid #cc",
                            borderRadius:"5px",
                            fontSize:"16px",
                            outline:"none"
                        }}>
                            <option value="">Select Value</option>
                            <option value={"React"}>React</option>
                            <option value={"Next.js"}>Next.js</option>
                            <option value={"Angular"}>Angular</option>
                            </select>
                            <h3>Selected Course:{course}</h3>
                            <br></br>

                            <button style={{
                                backgroundColor:"blue",
                                color:"white",
                                padding:"10px 20px",
                                border:"none",
                                borderRadius:"6px",
                                fontSize:"16px",
                                fontWeight:"bold",
                                cursor:"pointer",
                                width:"100%"
                            }}
                            type="submit">Register</button>
                            <p style={{color:"red"}}>{error}</p>
            </form>
        </div>
    )
}