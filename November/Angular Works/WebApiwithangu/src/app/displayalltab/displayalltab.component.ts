import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {Router,RouterLink} from '@angular/router';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ConserviceService,MVCWebApi } from '../conservice.service';

@Component({
  selector: 'app-displayalltab',
  imports: [RouterLink,CommonModule,RouterModule,FormsModule],
  templateUrl: './displayalltab.component.html',
  styleUrl: './displayalltab.component.css'
})
export class DisplayalltabComponent {
  getEmpData:MVCWebApi[]=[];
  constructor(public service:ConserviceService,private router:Router){}

  ngOnInit():void{
    this.getAllEmps();
  }

  getAllEmps():void{
    this.service.getAllWebApiEmpTab().subscribe((resp:any) => {
      this.getEmpData = resp;
    });
  }

  deleteDetails(id:number):void{
    this.service.deleteWebApiEmpTab(id)
    .subscribe(()=>{
      this.getAllEmps();
    },(err) => {
      console.log(err);
    }
  );
}
};
  
