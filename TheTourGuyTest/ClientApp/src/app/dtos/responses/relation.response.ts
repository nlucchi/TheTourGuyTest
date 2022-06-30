import { RelationTypeEnum } from "../../enums/relation-type.enum";

export class RelationResponse {
  public relationTypeId: RelationTypeEnum = 0;
  public relationTypeName: string = '';
  public objectName: string = '';
  public objectSurname: string = '';
}
