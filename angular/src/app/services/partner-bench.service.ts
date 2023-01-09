import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Bench } from '../models/bench.model';
import { NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class PartnerBenchService {

  baseApiUrl: string = environment.base_url;

  constructor(private http: HttpClient, private toastr: ToastrService) { }
  getBench(page: number) {
    return this.http.get(this.baseApiUrl + '?page=' + page);
  }
  getAllBench(): Observable<Bench[]> {

    return this.http.get<Bench[]>(this.baseApiUrl + '/api/Bench');
  }

  getBenchByPartnerID(partnerId: string): Observable<Bench[]> {
    return this.http.get<Bench[]>(this.baseApiUrl + '/api/PartnerBench/' + partnerId)
  }

  addBench(addBenchRequest: any): Observable<any> {
    return this.http.post<any>(this.baseApiUrl + '/api/Bench', addBenchRequest);
  }

  editBench(addBenchRequest: any, id: string): Observable<any> {
    return this.http.put<any>(this.baseApiUrl + '/api/Bench/' + id, addBenchRequest);
  }
  getBenchById(benchId: string): Observable<Bench> {

    return this.http.get<Bench>(this.baseApiUrl + '/api/Bench/' + benchId);

  }
  deleteBenchById(benchId: string): Observable<any> {

    return this.http.delete<any>(this.baseApiUrl + '/api/Bench/' + benchId);

  }
  getPartnerById(benchId: string): Observable<any> {

    return this.http.get<any>(this.baseApiUrl + '/api/Partner/' + benchId);

  }

  getPartnerNameByPartnerId(partnerId: string) {
    return this.http.get<any>(this.baseApiUrl + '/api/Partner/' + partnerId);

  }

  getAllPartner(): Observable<any[]> {

    return this.http.get<any[]>(this.baseApiUrl + '/api/Partner');
  }

  updateBench(benchId: any, updateBenchRequest: Bench): Observable<Bench> {
    return this.http.put<Bench>(this.baseApiUrl + '/api/Bench/' + benchId, updateBenchRequest);
  }


  showSuccess(message: any, title: any) {

    this.toastr.success(message, title)

  }



  showError(message: any, title: any) {

    this.toastr.error(message, title)

  }



  showInfo(message: any, title: any) {

    this.toastr.info(message, title)

  }



  showWarning(message: any, title: any) {

    this.toastr.warning(message, title)

  }
}
