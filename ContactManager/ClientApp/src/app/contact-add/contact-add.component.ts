import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contact } from '../../models/contact.type';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';


@Component({
  selector: 'app-contact-add',
  templateUrl: './contact-add.component.html'
})
export class ContactAddComponent implements OnInit {

  model: Contact = { id: 0, firstName: '', lastName: '', email: '', phone: '' };


  constructor(private _Activatedroute: ActivatedRoute,
    private _router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    //// TODO: DA
    //http.get<Contacts[]>(baseUrl + 'contacts').subscribe(result => {
    //  this.contacts = result;
    //}, error => console.error(error));
  }

  ngOnInit() {

  }

  onSubmit() {
    console.log(this.baseUrl + 'api/contacts');
    console.log(JSON.stringify(this.model));
    this.http.post<Contact>(this.baseUrl + 'api/contacts',this.model);
  }
}

