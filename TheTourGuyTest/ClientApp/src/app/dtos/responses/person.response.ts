import { RelationResponse } from "./relation.response";

export class PersonResponse {
  public personId: number = 0;
  public name: string = '';
  public surname: string = '';
  public role: string = '';
  public team: string = '';
  public planet: string = '';
  public climate: string = '';
  public relations: RelationResponse[] = [];
}
