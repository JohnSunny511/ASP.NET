"use client"

import { useState,useEffect } from "react"

export default function Home(){
    const [time,setTime] = useState<Date | null > (null);

    useEffect(()=>{
            const timer = setInterval(() =>{
            setTime(new Date());
    },1000);
    return ()=>clearInterval(timer);
    },[]);

    return(
        <div>
            <h1>Digital Clock</h1>
            {time && (
                <h2>
                    {time.toLocaleDateString()}
                </h2>
            )}
        </div>
    );
}