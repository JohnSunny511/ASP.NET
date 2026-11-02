import { Component } from '@angular/core';

@Component({
  selector: 'app-examplecomp',
  imports: [],
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
}
