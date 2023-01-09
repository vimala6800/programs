import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { environment } from '../../../environments/environment';
import { ProjectManagerAdd, ProjectManagerSkillView, UserAdd } from '../../models/projectmanageradd.model';
import { ProjectmanagerService } from '../../services/projectmanager.service';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { ResponseCode } from '../../models/projectmanager/responsecode';
import { ResponseModel } from '../../models/projectmanager/response';
import { User } from 'oidc-client';
@Component({
  selector: 'app-addprojectmanager',
  templateUrl: './addprojectmanager.component.html',
  styleUrls: ['./addprojectmanager.component.scss']
})

export class AddprojectmanagerComponent implements OnInit{
  baseApiUrl: string = environment.base_url;
 
  myform!: FormGroup;
  url = './images/placeholder.jpg';
  PMSkills: ProjectManagerSkillView[];
  addProjectManagerRequest: ProjectManagerAdd = {
    projectManagerID: '',
    projectManagerName: '',
    employeeID: '',
    joiningDate: undefined,
    pmEmailID: '',
    pmPhoneNumber: '',
    pmPhoto: '',
    pmStatus: 0,
    pmUserID: '',
    skillID:'',

  };
  addUserRequest: UserAdd = {
    id:'',
    userName:'',
    email:''
    }
  addskill:ProjectManagerSkillView ={
    skillID:'',
    skillName:''
  }
  constructor(private projectmanagerService: ProjectmanagerService,private toastr:ToastrService, private http: HttpClient,private route: ActivatedRoute, private router: Router) { }
  ngOnInit(): void {

    this.myform = new FormGroup({
      "Id": new FormControl(null, Validators.required),
      "name": new FormControl(null, Validators.required),
      "namee": new FormControl(null, Validators.required),
      "joindate": new FormControl(null, Validators.required),
      "pmemail": new FormControl(null, Validators.required),
      "email": new FormControl(null, [Validators.required,Validators.email]),
      "sta": new FormControl(null, Validators.required),
      "skill1": new FormControl(null, Validators.required),
      "mobile": new FormControl(null, Validators.required),
      
    })
    this.projectmanagerService.getpmskills().subscribe({
      next:(PMSkills)=>{
        this.PMSkills=PMSkills;
        console.log(PMSkills);
      }
    })
    
  }


 
  async addEmployee() {
     
    let users = await this.projectmanagerService.addUser(this.addUserRequest);
    
     this.addProjectManagerRequest.pmUserID = users?.message?.slice(13, 49);
     await this.projectmanagerService.addEmployee(this.addProjectManagerRequest);
     this.success();
     this.router.navigate(['projectmanagers']);
    
    
   
  }
  
  discard() {
    this.router.navigate(['projectmanagers']);
  }
 
  onSelectFile(event) {
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();



      reader.readAsDataURL(event.target.files[0]); // read file as data url



      reader.onload = (event: any) => { // called once readAsDataURL is completed
        console.log(event);
        this.url = event.target.result;
      }
    }
   
  }

  success(): void {
    this.toastr.success('ProjectManager Added Successfully', 'Success');
    this.router.navigate(['/projectmanagers']);

  }
  

}
