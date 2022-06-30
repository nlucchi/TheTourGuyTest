import { HttpClient, HttpParams } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { PersonResponse } from "../dtos/responses/person.response";

@Injectable({
  providedIn: 'root'
})
export class PersonsService {
  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  async getPersonsAsync(teamId?: number): Promise<PersonResponse[]> {

    let httpParams = new HttpParams();
    if (teamId)
      httpParams = httpParams.set('teamId', teamId.toString());

    return (await this.httpClient.get<PersonResponse[]>(this.baseUrl + 'persons', { params: httpParams }).toPromise()) as PersonResponse[];
  }

}
