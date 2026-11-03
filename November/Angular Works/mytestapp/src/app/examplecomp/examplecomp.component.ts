import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-examplecomp',
  imports: [FormsModule,CommonModule],
  templateUrl: './examplecomp.component.html',
  styleUrl: './examplecomp.component.css'
})
export class ExamplecompComponent {

  name:string="";
  empna:string="John";
  msg:string="hello welcome"
  msg1:string="Good morning"
  msg2:string="Good evening"
  /* age:number=22;
  check:boolean=true;
  address="www"; */


  dclass = "danger";
  sclass = "success";

  display(){
    return "helo......"+this.empna;
  }

  bstatus = "Button not Clicked";

  check(){
    this.bstatus = "Button is clicked"
  }

  msg3="";



  /* for ng if */

  checked:boolean=true;

  Ischange(){
    this.checked=false;
  }

  slist=[
    {sid:1,sname:"Arun",sage:22},
    {sid:2,sname:"john",sage:23},
    {sid:3,sname:"jake",sage:24}
  ]

  today = new Date().getDay();     /* getday is used to get the count of the day sunday 0, monday 1 .toExponential.apply. */

}
