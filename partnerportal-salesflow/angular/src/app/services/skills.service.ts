import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Skill } from '../models/skill.model';


@Injectable({
  providedIn: 'root'
})
export class SkillsService {
 

  //base_url: string = "https://localhost:7184";
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient,private toastr: ToastrService) { }
  getAllSkills(): Observable<Skill[]> {
    return this.http.get<Skill[]>(this.baseApiUrl + '/api/Skills');
  }
  addSkill(addSkillRequest: any):Observable<any>{
    return this.http.post<any>(this.baseApiUrl+'/api/Skills', addSkillRequest);
  }
  updateskill(updateskillRequest: any, skillID: string): Observable<any> {

    console.log(updateskillRequest);

    updateskillRequest.skillID = skillID;

    return this.http.put<any>(this.baseApiUrl + '/api/Skills/' + skillID, updateskillRequest);

  }

  editSkill(addSkillRequest: any,id:string):Observable<any>{
    return this.http.put<any>(this.baseApiUrl +'/api/Skills/'+ id, addSkillRequest);
  }
  deleteSkillById(skillId:string):Observable<any>{

    return this.http.delete<any>(this.baseApiUrl +'/api/Skills/'+ skillId);

  }
  getSkillById(skillID:string):Observable<Skill>{

    return this.http.get<Skill>(this.baseApiUrl +'/api/Skills/'+ skillID);

  }

  showSuccess(message:any, title:any){

    this.toastr.success(message, title)

}
showInfo(message:any,title:any){
  this.toastr.info(message,title)
}

 

showError(message:any, title:any){

    this.toastr.error(message, title)

}
 

}
