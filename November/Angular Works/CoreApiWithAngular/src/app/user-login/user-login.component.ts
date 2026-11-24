import { Component } from '@angular/core';
import { MyserviceService } from '../myservice.service';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-login',
  imports: [FormsModule],
  templateUrl: './user-login.component.html',
  styleUrl: './user-login.component.css'
})
export class UserLoginComponent {
  logData = {uname:'',password:''};
  loginResponse:string='';
  constructor(private ser:MyserviceService,private router:Router){}
  ngOnInit(): void{
  }

  
onLogin(): void {

  console.log("Login function called");
  console.log("Login Data:", this.logData);

  this.ser.login(this.logData).subscribe({

    next: (response) => {

      console.log("API Response:", response);

      const uid = response?.userId;

      if (uid == undefined || uid == null) {

        this.loginResponse =
          response?.message || 'Invalid username or password';

      }
      else {

        console.log("User ID:", uid);

        this.router.navigate(['/userprofile', uid]);

      }

    },

    error: (error) => {

      console.error("Login API Error:", error);

      this.loginResponse =
        error.error?.message || 'Something went wrong';

    }

  });

}

}
