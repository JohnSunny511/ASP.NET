import { Component } from '@angular/core';
import { ActivatedRoute,Router } from '@angular/router';
import { MyserviceService } from '../myservice.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-user-profile',
  imports: [CommonModule],
  templateUrl: './user-profile.component.html',
  styleUrl: './user-profile.component.css'
})
export class UserProfileComponent {
  profileImage:string='';
  userData = {uid:0,name:'',age:0,addr:'',email:'',photo:'',uname:'',password:''};
  constructor(public rest:MyserviceService,private route:ActivatedRoute,private router:Router){}
  ngOnInit(){
    const uId = this.route.snapshot.paramMap.get('id');
    if(uId != null && uId != undefined){
      this.rest.getProfile(uId).subscribe({
        next:(uData) => {
          this.userData = uData;
          this.profileImage = `data:image/jpeg;base64,${this.userData.photo}`;
        },
        error:(err) => {
          console.error('Error loading profile:',err);
        }
      });
    }
  }
}
