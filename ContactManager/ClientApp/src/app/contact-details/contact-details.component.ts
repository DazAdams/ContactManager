import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contact } from '../../models/contact.type';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html'
})
export class ContactDetailsComponent implements OnInit {

  model: Contact = {contactid: 0, firstname: '', lastname: '', email: '', phone: '' };
  public isNew: Boolean = true;


  constructor(private _activatedroute: ActivatedRoute,
    private _router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  ngOnInit() {
    const routeParams = this._activatedroute.snapshot.paramMap;
    const contactId = routeParams.get('contactid');
    if (contactId != null) {
      this.http.get<Contact>(this.baseUrl + 'api/contacts/' + contactId).subscribe(result => {
        this.isNew = false;
        this.model = result;
      }, error => console.error(error));
    }
  }

  onSubmit() {
    console.log(this.baseUrl + 'api/contacts');
    console.log(JSON.stringify(this.model));
    this.http.post<Contact>(this.baseUrl + 'api/contacts', this.model).subscribe(result => {
      this._router.navigate(['/contacts']);
    }, error => console.error(error));
  }
}

