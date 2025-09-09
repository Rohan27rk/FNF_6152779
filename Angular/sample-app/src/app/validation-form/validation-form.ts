import { Component, OnInit } from '@angular/core';
import { Employee } from '../Models/employee';

@Component({
  selector: 'app-validation-form',
  standalone: false,
  templateUrl: './validation-form.html',
  styleUrl: './validation-form.css'
})
export class ValidationForm implements OnInit {
  ngOnInit(): void {
    this.employee={
      empId:0,
      empName:"",
      empAddress:"",
      empSalary: 10000,
      empImg: "pic5.png"
    }
  }
  employee : Employee = {} as Employee;
 onSubmit(form: any) {
    if (form.valid) {
      console.log('Form Submitted Successfully!');
      console.log('Employee Data:', this.employee);
    } else {
      console.log('Form is invalid. Please check the inputs.');
    }
  }
}


