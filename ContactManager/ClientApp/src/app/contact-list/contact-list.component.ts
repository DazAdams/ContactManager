import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contact } from '../../models/contact.type';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html'
})
export class ContactListComponent {

  public contacts: Contact[];
  public showLoading: Boolean = true;
 
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    // TODO: DA
    http.get<Contact[]>(baseUrl + 'api/contacts').subscribe(result => {
      this.contacts = result;
      this.showLoading = false;
    }, error => console.error(error));
  }
}

