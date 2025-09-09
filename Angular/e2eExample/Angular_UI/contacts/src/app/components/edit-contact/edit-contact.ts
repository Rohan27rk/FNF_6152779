import { Component, OnInit } from '@angular/core';
import { contact } from '../../models/contact';
import { ActivatedRoute, Router } from '@angular/router';
import { Contact } from '../../Services/contact';


@Component({
  selector: 'app-edit-contact',
  templateUrl: './edit-contact.html',
  styleUrls: ['./edit-contact.css'], 
  standalone: false
})

export class EditContact implements OnInit {
  contact!: contact;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private service: Contact
  ) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    console.log('Route ID:', id);
    if (id) {
      this.service.getContact(id).subscribe((data: contact) => {
        console.log('Fetched contact:', data);
        this.contact = data;
      });
    }
  }

  updateContact(): void {
    this.service.updateContact(this.contact).subscribe(() => {
      alert('Contact updated successfully!');
      this.router.navigate(['/']);
    });
  }
}
