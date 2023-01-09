import { ResponseCode } from "../../models/projectmanager/responsecode";



export class ResponseModel {
  public responseCode: ResponseCode = ResponseCode.NotSet;
  public responseMessage: string = "";
  public dateSet: any
}
