import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MyserviceService } from '../myservice.service';

@Component({
  selector: 'app-userregister',
  imports: [FormsModule],
  templateUrl: './userregister.component.html',
  styleUrl: './userregister.component.css'
})
export class UserregisterComponent {
  userData = {name:'',age:0,addr:'',email:'',uname:'',password:''};
  selectedFile: File | null = null;
  RegResponse: string = '';

  constructor(public rest:MyserviceService){}
  ngOnInit():void{
  }

  adduserdata(): void{
    if(this.selectedFile){
      this.rest.createUser(this.userData,this.selectedFile).subscribe({
        next:(response) => {
          this.RegResponse = response.message;
        },
        error:(err) => {
          console.error(err);
        }
      });
    }
  }
  onFileSelected(event:any):void{
    this.selectedFile = event.target.files[0];
  }

}
