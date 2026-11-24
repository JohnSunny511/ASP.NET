'use client'

import { useRouter } from "next/navigation"

import { useState } from "react"

import { createUser } from "./lib/api"

export default function Home(){
  const router = useRouter()
  const [userData,setUserData] = useState({
    name:'',
    age:0,
    addr:'',
    email:'',
    uname:'',
    password:''
  })



const [selectedFile,setSelectedFile] = useState<File | null >(null)
const[regResponse,setRegResponse] = useState('')

const handleInputChange = (e:React.ChangeEvent<HTMLInputElement>) => {
  const{name,value} = e.target
  setUserData(prev => ({
    ...prev,
    [name]:name === 'age' ? parseInt(value) || 0 : value
  }))

}
  const handleFileChange = (e:React.ChangeEvent<HTMLInputElement>) => {
    if(e.target.files && e.target.files[0]) {
      setSelectedFile(e.target.files[0])
        setSelectedFile(e.target.files[0])
      }
    }

    const handleSubmit = async(e:React.SubmitEvent)=> {
      e.preventDefault()
      setRegResponse('')
      if(!selectedFile){
        setRegResponse('Please select a profile photo')
        return
      }
      try{
        const response = await createUser(userData,selectedFile)
        setRegResponse(response.message || 'User registered successfully!')

        setTimeout(()=>{
          setUserData({
          name: '',
          age: 0,
          addr: '',
          email: '',
          uname: '',
          password: ''
      })

      setSelectedFile(null)
      setRegResponse('')
    },3000)
  }
    catch (error) {
      console.error(error)
      setRegResponse('Registration failed. Please try again.')
    }
  }

  return(
  <div className="container">
    <h2>Register</h2>
    <form onSubmit={handleSubmit}>
      <label htmlFor="name">Name</label>
      <input
      type="text"
      id="name"
      name="name"
      value={userData.name}
      onChange={handleInputChange}
      required
      placeholder="Enter your name"/>

      <label htmlFor="age">Age</label>
      <input
      type="number"
      id="age"
      name="age"
      value={userData.age}
      onChange={handleInputChange}
      required
      placeholder="Enter your age"
      min="18"
      max="80"
      />


      <label htmlFor="addr">Address</label>
      <input
      type="text"
      id="addr"
      name="addr"
      value={userData.addr}
      onChange={handleInputChange}
      required
      placeholder="Enter your Address"/>


      <label htmlFor="email">Email</label>
      <input
      type="text"
      id="email"
      name="email"
      value={userData.email}
      onChange={handleInputChange}
      required
      placeholder="Enter your Email"/>

    <label htmlFor="profileph">Profile Photo</label>
      <input
      type="file"
      id="profileph"
      onChange={handleFileChange}
      accept="image/*"
      />

      <label htmlFor="uname">User Name</label>
      <input
      type="text"
      id="uname"
      name="uname"
      value={userData.uname}
      onChange={handleInputChange}
      required
      placeholder="Enter your UserName"/>

      <label htmlFor="email">Password</label>
      <input
      type="text"
      id="password"
      name="password"
      value={userData.password}
      onChange={handleInputChange}
      required
      placeholder="Enter your Password"/>

      <button type="submit">Register</button>
      <br/>
      {regResponse &&(
        <label className={regResponse.includes('success') ? 'text-success' : 'text-danger'}>
          {regResponse}
          </label>
      )}

    </form>
  </div>
)

}

