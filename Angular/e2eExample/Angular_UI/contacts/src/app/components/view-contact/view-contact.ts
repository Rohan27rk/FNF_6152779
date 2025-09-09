import { Component, OnInit, ChangeDetectorRef } from '@angular/core';

import { Contact } from '../../Services/contact';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { contact } from '../../models/contact';

@Component({
  selector: 'app-view-contact',
  standalone: false,
  templateUrl: './view-contact.html',
  styleUrl: './view-contact.css'
})
export class ContactView implements OnInit {
  contact: contact | null = null;
  id: string | null = null;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private service: Contact,
    private cdRef: ChangeDetectorRef
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe((param: ParamMap) => {
      this.id = param.get("id");
      if (this.id) {
        this.service.getContact(this.id).subscribe((data) => {
          this.contact = data;
          console.log("Fetched contact:", this.contact);
          this.cdRef.detectChanges(); // Force view update
        });
      }
    });
  }
}
