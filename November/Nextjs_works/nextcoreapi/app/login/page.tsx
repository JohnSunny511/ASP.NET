'use client'
import { useRouter } from "next/navigation"
import { useState } from "react"
import { login } from "../lib/api"

export default function LoginPage(){
    const router = useRouter()
    const [logData,setLogData] = useState({
        uname:'',
        password:''
    })

    const[loginResponse,setLoginResponse] = useState('')

    const handleInputChange = (e:React.ChangeEvent<HTMLInputElement>) => {             //HtmlInputElement used to call html foms
        const {name,value} = e.target
        setLogData(prev => ({
            ...prev,
            [name]: value
        }))

        
    }

    const handleSubmit = async(e:React.SubmitEvent) => {
            e.preventDefault()
            setLoginResponse('')
            try{
                const response = await login(logData)
                /* setLoginResponse(response.message || 'Login Succuessful') */
                
                const uid = response?.userId
                if(uid === undefined){
                    setLoginResponse(response.message || 'Login Failed')
                }else{
                    router.push(`/userProfile/${uid}`)
                }
            }
            catch(error:any){
                setLoginResponse(error.message || 'Login failed. Please try again.')
            }
        }


    return(
        <div className="container mx-auto max-w-md p-8 shadow-lg rounded-lg">
            <h2 className="text-2xl font-bold text-center mb-6">Login Form</h2>
            <form onSubmit={handleSubmit}>
                <label htmlFor="uname">user Name</label>
                <input
                    type="text"
                    id="uname"
                    name="uname"
                    value={logData.uname}
                    onChange={handleInputChange}
                    required
                    placeholder="Enter your UserName" 
                    />

                    <label htmlFor="uname">Password</label>
                <input
                    type="text"
                    id="password"
                    name="password"
                    value={logData.password}
                    onChange={handleInputChange}
                    required
                    placeholder="Enter your Password" 
                    />
                    

                    <button type="submit">Login</button>
                    <br></br>

                    {loginResponse && (
                        <label className="text-danger">{loginResponse}</label>
                    )}
            </form>
        </div>
    )


}