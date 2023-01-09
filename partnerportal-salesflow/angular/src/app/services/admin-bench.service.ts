import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Bench } from '../models/bench.model';
import { partnerData } from 'src/bench';

@Injectable({
  providedIn: 'root'
})
export class AdminBenchService {

  baseApiUrl: string = environment.base_url;

  constructor(private http: HttpClient,private toastr: ToastrService) { }

  getAllBench(): Observable<Bench[]> {
    
    return this.http.get<Bench[]>(this.baseApiUrl + '/api/Bench');
  }

  addBench(addBenchRequest: any):Observable<any>{
    return this.http.post<any>(this.baseApiUrl+'/api/Bench', addBenchRequest);
  }

  addPartner() {
    for (let i = 0; i < partnerData.length; i++) {

      this.http.post<any>(this.baseApiUrl + '/api/Partner', { PartnerName: partnerData[i].CompanyName }).subscribe({
        next: (partner) => {
          console.log("done");

        },
        error: (response) => {
          console.log(response);
        }
      });
    }
  }

  editBench(addBenchRequest: any,id:string):Observable<any>{
    return this.http.put<any>(this.baseApiUrl+'/api/Bench/'+ id, addBenchRequest);
  }
  getBenchById(benchId:string):Observable<Bench>{

    return this.http.get<Bench>(this.baseApiUrl+'/api/Bench/'+ benchId);

  }
  deleteBenchById(benchId:string):Observable<any>{

    return this.http.delete<any>(this.baseApiUrl+'/api/Bench/'+ benchId);

  }
  getPartnerById(benchId:string):Observable<any>{

    return this.http.get<any>(this.baseApiUrl+'/api/Partners/'+ benchId);

  }

  getPartnerNameByPartnerId(partnerId:string){
    return this.http.get<any>(this.baseApiUrl+'/api/Partners/'+ partnerId);

  }

  getAllPartner(): Observable<any[]> {
    
    return this.http.get<any[]>(this.baseApiUrl + '/api/Partner');
  }

  updateBench(benchId:any, updateBenchRequest: Bench): Observable<Bench>{
    return this.http.put<Bench>(this.baseApiUrl + '/api/Bench/' + benchId, updateBenchRequest);
  }

  searchBench(value:string){
      return this.http.get<any>(this.baseApiUrl + '/api/Search/'+ value );
      
  }
  showSuccess(message:any, title:any){

    this.toastr.success(message, title)

}

 

showError(message:any, title:any){

    this.toastr.error(message, title)

}

 

showInfo(message:any, title:any){

    this.toastr.info(message, title)

}

 

showWarning(message:any, title:any){

    this.toastr.warning(message, title)

}
}
