import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { ProjectManager, ProjectManagerlist } from '../models/projectmanager.model';
import { ProjectManagerAdd, ProjectManagerSkill, ProjectManagerSkillView, UserAdd } from '../models/projectmanageradd.model';

@Injectable({
  providedIn: 'root'
})

export class ProjectmanagerService {
  baseApiUrl: string = environment.base_url;
  constructor(private http: HttpClient) { }
  getProjectManagers(): Observable<ProjectManagerlist[]> {
    return this.http.get<ProjectManagerlist[]>(this.baseApiUrl + '/api/ProjectManager');
  }
  addUser(addUserRequest: UserAdd): any {
    addUserRequest.id = 'c70d820c-61be-4a2b-9b28-de8590192366';
    return this.http.post<UserAdd>(this.baseApiUrl + '/api/ProjectManager?role=projectmanager', addUserRequest).toPromise();

  }
  addEmployee(addProjectManagerRequest: ProjectManagerAdd): any {
    addProjectManagerRequest.projectManagerID = 'c80d820c-61be-4a2b-9b28-de8590192366';
/*    addProjectManagerRequest.pmPhoto = '9030';
*/    addProjectManagerRequest.pmUserID = 'c80d820c-61be-4a2b-9b28-de8589292366';



    return this.http.post<ProjectManagerAdd>(this.baseApiUrl + '/api/ProjectManager/AddPM', addProjectManagerRequest).toPromise();
  }
  getEmployee(id: string): Observable<ProjectManager> {
    return this.http.get<ProjectManager>(this.baseApiUrl + '/api/ProjectManager/' + id);
  }
  updateEmployee(id: string, updateEmployeeRequest: ProjectManager): Observable<ProjectManager> {
    return this.http.put<ProjectManager>(this.baseApiUrl + '/api/ProjectManager/' + id, updateEmployeeRequest);



  }
  updateUser(uid: string, updateuserRequest: UserAdd): any{
    return this.http.put<UserAdd>(this.baseApiUrl + '/api/Users/' + uid, updateuserRequest).toPromise();


  }
  //  getpmskills(): Observable<ProjectManagerSkillView[]>   
  //   {  
  //       return this.http.get<ProjectManagerSkillView[]>(this.baseApiUrl+'/api/ProjectManager/skill');
  //   } 
  public getpmskills = (): Observable<ProjectManagerSkillView[]> => {
    return this.http.get<ProjectManagerSkillView[]>(this.baseApiUrl + '/api/ProjectManager/skill');
  }

  public pmskills = (): Observable<ProjectManagerSkill[]> => {
    return this.http.get<ProjectManagerSkill[]>(this.baseApiUrl + '/api/ProjectManager/pmskills');
  }
  deleteEmployee(id: string): Observable<ProjectManager> {
    return this.http.delete<ProjectManager>(this.baseApiUrl + '/api/ProjectManager/' + id);
  }

}
