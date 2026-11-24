import { Routes } from '@angular/router';
import { UserregisterComponent } from './userregister/userregister.component';
import { UserLoginComponent } from './user-login/user-login.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

export const routes: Routes = [
    {path:'',component:UserregisterComponent},
    {path:'login',component:UserLoginComponent},
    {path:'insertuser',component:UserregisterComponent},
    {path:'userprofile/:id',component:UserProfileComponent}
];
