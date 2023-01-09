import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { RateCards } from '../models/ratecard.model';

@Injectable({
  providedIn: 'root'
})
export class RatecardsService {
  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient,private toastr: ToastrService) { }
 
  GetRateCardBySkillID(id: string): Observable<RateCards> {
    return this.http.get<RateCards>(this.baseApiUrl + '/api/RateCards/'+id)
  }

  addRatecard(addRatecardRequest: any):Observable<any>{
    return this.http.post<any>(this.baseApiUrl+'/api/RateCards', addRatecardRequest);
  }
  deleterateById(rateCardId:string):Observable<any>{
    return this.http.delete<any>(this.baseApiUrl +'/api/RateCards/'+ rateCardId);
  }
 
  showSuccess(message:any, title:any){

    this.toastr.success(message, title)

}

 

showError(message:any, title:any){

    this.toastr.error(message, title)

}
  
}
