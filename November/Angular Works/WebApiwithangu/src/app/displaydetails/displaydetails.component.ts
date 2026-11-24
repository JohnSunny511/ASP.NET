import { Component } from '@angular/core';
import { ConserviceService,MVCWebApi } from '../conservice.service';
import { ActivatedRoute } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-displaydetails',
  imports: [FormsModule,CommonModule,RouterModule],
  templateUrl: './displaydetails.component.html',
  styleUrl: './displaydetails.component.css'
})
export class DisplaydetailsComponent {
  employee:MVCWebApi | undefined;

  eid: number = 0;

  constructor(public rest: ConserviceService,private route:ActivatedRoute){}

  ngOnInit():void{
    var paramId = this.route.snapshot.paramMap.get("id");  //get id from query string or url
    if(paramId !== null && paramId != undefined){
      this.eid=parseInt(paramId);
    }
    this.rest.getWebApiEmpTabWithId(this.eid).subscribe(
      (data:MVCWebApi) => this.employee = data
    );
  }
}
