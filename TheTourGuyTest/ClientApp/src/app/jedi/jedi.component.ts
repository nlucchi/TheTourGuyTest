import { Component, OnInit } from '@angular/core';
import { PersonResponse } from '../dtos/responses/person.response';
import { PersonsService } from '../services/persons.service';

@Component({
  selector: 'app-jedi-component',
  templateUrl: './jedi.component.html'
})
export class JediComponent implements OnInit {
  
  public persons: PersonResponse[] = [];

  constructor(private personsService: PersonsService) {

  }

  async ngOnInit(): Promise<any> {
    this.persons = await this.personsService.getPersonsAsync(1);
  }
}
