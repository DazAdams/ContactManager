import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contact } from '../../models/contact.type';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-contacts-edit',
  templateUrl: './contacts-edit.component.html'
})
export class ContactAddComponent implements OnInit{

  public contact: Contact;


  constructor(private _Activatedroute: ActivatedRoute,
    private _router: Router,http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //// TODO: DA
    //http.get<Contacts[]>(baseUrl + 'contacts').subscribe(result => {
    //  this.contacts = result;
    //}, error => console.error(error));
  }

  ngOnInit() {
    
  }
}

