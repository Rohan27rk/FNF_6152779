import { Component } from '@angular/core';

@Component({
  selector: 'calc',
  standalone: false,
  templateUrl: './calc.html',
  styleUrl: './calc.css'
})
export class Calc {
   fValue : number = 50
  sValue : number = 60.00
  option : string = "Add"
  result = 0.0;

 onProcess(){
    switch(this.option){
      case "Add" :  this.result = this.fValue + this.sValue; break; 
      case "Subtract" :  this.result = this.fValue - this.sValue; break; 
      case "Multiply" :  this.result = this.fValue * this.sValue; break; 
      case "Divide" :  this.result = this.fValue / this.sValue; break; 
    }
  }
}
