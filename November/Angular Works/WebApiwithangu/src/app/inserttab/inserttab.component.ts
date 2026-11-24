import { Component,Input } from '@angular/core';
import { ConserviceService } from '../conservice.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-inserttab',
  imports: [FormsModule,CommonModule],
  templateUrl: './inserttab.component.html',
  styleUrl: './inserttab.component.css'
})
export class InserttabComponent {
  @Input() empdata = {empName:'',empAge:0,empSalary:0,empAddr:''};

  constructor(private myservice: ConserviceService,private router:Router){}
  //pageLoad
  ngOnInit(): void{}
  InsertEmployee(): void{
    this.myservice.addWebApiEmpTab(this.empdata).subscribe(()=>{
      this.router.navigate(['/AllDetails']);
    },(err) => {
      console.log(err);
    });
  }
}
