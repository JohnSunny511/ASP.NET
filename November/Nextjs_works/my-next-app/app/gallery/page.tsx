import Image from "next/image";

export default function gallerypage(){

    return(
        <div>
            <h1>Gallery Page</h1>
        

        <h1 className="text-3xl font-bold underline">Gallery Page!</h1>
        <Image src="/Screenshot 2026-11-10 155119.png" alt="Gallery Image" width={300} height={500} />
        <br></br>
        <img src="/Screenshot 2026-11-11 002548.png" alt="Gallery Image" width={500} height={600}/>

        </div>
    )
}