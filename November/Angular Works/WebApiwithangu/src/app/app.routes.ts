import { Routes } from '@angular/router';
import { DisplayalltabComponent } from './displayalltab/displayalltab.component';
import { InserttabComponent } from './inserttab/inserttab.component';
import { DisplaydetailsComponent } from './displaydetails/displaydetails.component';
import { EditdetailsComponent } from './editdetails/editdetails.component';

export const routes: Routes = [
    {path:'',component:DisplayalltabComponent},
    {path:'insert',component:InserttabComponent},
    {path:'AllDetails',component:DisplayalltabComponent},
    {path:'selectDetails/:id',component:DisplaydetailsComponent},
    {path:'editdetails/:id',component:EditdetailsComponent}
];
