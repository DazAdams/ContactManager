import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contact } from '../../models/contact.type';

@Component({
  selector: 'app-contacts-list',
  templateUrl: './contacts-list.component.html'
})
export class ContactListComponent {

  public contacts: Contact[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    // TODO: DA
    http.get<Contact[]>(baseUrl + 'contacts').subscribe(result => {
      this.contacts = result;
    }, error => console.error(error));
  }
}
