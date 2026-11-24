export default function testlooppage(){
    const buttons=[];
    for(let i = 1; i <= 5; i++){
        buttons.push(
        <button key={i} className="px-4 py-2 bg-black-600 text-white rounded">
            Button {i}
        </button>
        );

    }
    const users = [
            {id:1,name:"John",role:"Admin"},
            {id:2,name:"jeirn",role:"User"},
            {id:3,name:"Jeese",role:"User"}
        ]

    return(
        <div>
            <div style={{display:"flex",gap:"20px"}}>{buttons}</div>

            {users.map((user) => (
                <div key={user.id}>
                    <h2>Name:{user.name}</h2>
                    <p>Role:{user.role}</p>

                    {user.role == "Admin" ? (
                        <button className="px-4 py-2 bg-blue-600 text-white rounded">{user.name} is {user.role}</button>
                    ):
                    <button className="px-4 py-2 bg-green-600 text-white rounded">{user.name} is {user.role}</button>
                }
                </div>
            ))}
        </div>
    );
}