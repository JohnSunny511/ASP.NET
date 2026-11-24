import { Component } from '@angular/core';
import { ConserviceService,MVCWebApi } from '../conservice.service';
import { Router,ActivatedRoute } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-editdetails',
  imports: [FormsModule,CommonModule,RouterModule],
  templateUrl: './editdetails.component.html',
  styleUrl: './editdetails.component.css'
})
export class EditdetailsComponent {
  employee:MVCWebApi = {empId:0,empName:'',empAge:0,empSalary:0,empAddr:''}
  eid:number=0;
  constructor(public rest:ConserviceService,private route:ActivatedRoute,private router:Router) {}
  ngOnInit():void{
    var paramId = this.route.snapshot.paramMap.get("id");  //get id from query string or url
    if(paramId !== null && paramId != undefined){
      this.eid=parseInt(paramId);
    }
    this.rest.getWebApiEmpTabWithId(this.eid).subscribe(
      (data:MVCWebApi) => this.employee = data
    );
}

updateEmp(): void {
    this.rest.updateWebApiEmpTab(this.eid, this.employee).subscribe((result) => {
        this.router.navigate(['AllDetails/']);
    }, (err) => {
        console.log(err);
    });
  }
}
