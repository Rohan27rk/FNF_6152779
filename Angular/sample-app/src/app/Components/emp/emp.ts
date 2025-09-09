import { Component } from '@angular/core';

@Component({
  selector: 'app-emp',
  standalone: false,
  templateUrl: './emp.html',
  styleUrl: './emp.css'
})
export class Emp {
  empName = 'John Doe';
  empAddress = '123 Main St, Anytown, USA';
  empSalary = 50000;
  onClick(){
    alert('Button Clicked');
  }

}
