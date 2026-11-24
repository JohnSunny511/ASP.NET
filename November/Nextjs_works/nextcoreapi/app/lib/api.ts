import { METHODS } from "http"

const apiUrl = 'http://localhost:5198/UserManagement/'

export interface usertab{                  //this is used for profile display
    uid:number
    name:string
    age:number
    addr:string
    email:string
    photo:string
    uname:string
    password:string
}

export interface UserCreateData{             //Used for login
    name:string
    age:number
    addr:string
    email:string
    uname:string
    password:string
}

export interface ApiResponse{              //to recieve reponse message from api
    message:string
}

export interface LoginCredentials{          //to pass login credentials
    uname:string
    password:string
}

export interface LoginResponse{          // to recieve reponse message from api
    userId?:number
    message:string
}



export async function createUser(user:UserCreateData,file:File): Promise<ApiResponse> {
    const url = apiUrl + 'inserttab'
    const formData = new FormData()

    formData.append('name',user.name)
    formData.append('age',user.age.toString())
    formData.append('addr',user.addr)
    formData.append('email',user.email)
    formData.append('uname',user.uname)
    formData.append('password',user.password)

    if(file){
        formData.append('path',file)
    }

    const response = await fetch(url,{
        method:'POST',
        body:formData,
    })

    if(!response.ok){
        throw new Error('Failed to create user')
    }

    return response.json()
}


export async function login(credentials: LoginCredentials): Promise<LoginResponse> {
    const url = apiUrl + 'logintab'
    const response = await fetch(url, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(credentials),
    })
    if (!response.ok) {
        throw new Error('Login failed')
    }
    return response.json()
}


export async function getProfile(id:string): Promise<usertab> {
    const url = apiUrl + 'gettabwithid/' + id
    const response = await fetch(url,{
        method:'GET',
    })
    if(!response.ok){
        throw new Error('Failed to fetch profile')
    }
    return response.json()
    
}