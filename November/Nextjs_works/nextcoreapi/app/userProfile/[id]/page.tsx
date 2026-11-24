"use client"

import { useParams } from "next/navigation"   //to get data from url
import { useEffect,useState } from "react"
import { getProfile, usertab } from "@/app/lib/api"

export default function UserProfilePage(){
    const params = useParams()
    const [userData, setUserData] = useState<usertab | null>(null)
    const [profileImage, setProfileImage] = useState<string>('')            //string type since it is reciving string type value from backend


    useEffect(() => {
        const fetchProfile = async () => {
            const uId = params?.id as string
            if(uId){
                try{
                    const data = await getProfile(uId)
                    setUserData(data)
                    if(data.photo){
                        setProfileImage(`data:image/jpeg;base64,${data.photo}`)
                    }
                }catch(error){
                        console.error('Error fetching profile:',error)
                    }
                }
            }
            fetchProfile()
        },[params?.id])
            if(!userData){
                return (
                    <div className="profile-container">
                    <p>User not found!</p>
                    </div>
                )
            }
            return(
                <div className="profile-container">
                    <h2 className="profile-heading">Welcome, {userData.name}</h2>
                    <table className="profile-table">
                        <thead>
                            <tr>
                                <th>Field</th>
                                <th>Details</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><b>Name</b></td>
                                <td>{userData.name}</td>
                            </tr>
                            <tr>
                                <td><b>Age</b></td>
                                <td>{userData.age}</td>
                            </tr>
                            <tr>
                                <td><b>Address</b></td>
                                <td>{userData.addr}</td>
                            </tr>
                            <tr>
                                <td><b>Email</b></td>
                                <td>{userData.email}</td>
                            </tr>
                            <tr>
                                <td><b>Profile Photo</b></td>
                                <td>
                                    {profileImage && (
                                        <img
                                        src={profileImage}
                                        alt="Profile Photo"
                                        className="profile-img"
                                        width="200"
                                        />
                                    )}
                                </td>
                            </tr>

                        </tbody>
                    </table>
                </div>
            )
    
}