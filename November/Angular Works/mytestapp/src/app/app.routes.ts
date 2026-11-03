import { Routes } from '@angular/router';
import { ExamplecompComponent } from './examplecomp/examplecomp.component';
import { EmployeeComponent } from './employee/employee.component';
import { StudentComponent } from './student/student.component';

export const routes: Routes = [                          /* routes is object , Routes is Class */
    {path:'',component:ExamplecompComponent},
    {path:'stud',component:StudentComponent},
    {path:'emp',component:EmployeeComponent}
];           
