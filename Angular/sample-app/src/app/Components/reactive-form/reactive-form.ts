import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  standalone: false,
  templateUrl: './reactive-form.html',
  styleUrl: './reactive-form.css'
})
export class ReactiveForm {

  title :string ="Reactive Forms"
  empForm= new FormGroup({
    id: new FormControl("0", [Validators.required, Validators.min(100),Validators.max(1000)]),
    name: new FormControl("",[Validators.required, Validators.minLength(4)]),
    address: new FormControl("",[Validators.required, Validators.minLength(4)]),
    salary: new FormControl(1000,[Validators.required, Validators.min(1000), Validators.max(10000)]),
  });

  onSubmit(){
    console.log(this.empForm.value);
  }

  get id() {
    return this.empForm.get('id');
  }

  get name() {
    return this.empForm.get('name');
  }

  get address() {
    return this.empForm.get('address');
  }

  get salary() {
    return this.empForm.get('salary');
  }

}
    

