import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ProjectManager } from '../../models/projectmanager.model';
import { ProjectManagerAdd, ProjectManagerSkill, ProjectManagerSkillView } from '../../models/projectmanageradd.model';
import { ProjectmanagerService } from '../../services/projectmanager.service';
@Component({
  selector: 'app-projectmanagerdetails',
  templateUrl: './projectmanagerdetails.component.html',
  styleUrls: ['./projectmanagerdetails.component.scss']
})
export class ProjectmanagerdetailsComponent implements OnInit {
  

  employeeDetails: ProjectManager = {
    projectManagerID: '',
    projectManagerName: '',
    employeeID: '',
    joiningDate: '',
    pmEmailID: '',
    pmPhoneNumber: '',
    pmPhoto: '',
    pmStatus: 0,
    pmUserID: '',
    skillID: '',
    skillName:''

  }
  skillDetails: ProjectManagerAdd = {
    projectManagerID: '',
    projectManagerName: '',
    employeeID: '',
    joiningDate: undefined,
    pmEmailID: '',
    pmPhoneNumber: '',
    pmPhoto: '',
    pmStatus: 0,
    pmUserID: '',
    skillID: ''
  }
  skill: ProjectManagerSkillView = {
    skillID: '',
    skillName:''
  }
  proskills: ProjectManagerSkill[] = [];
  constructor(private router: Router, private route: ActivatedRoute, private toastr:ToastrService ,private projectmanagerService: ProjectmanagerService) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({



      next: (params) => {
        const id = params.get('projectManagerID');
        if (id) {
          
          this.projectmanagerService.getEmployee(id).subscribe({
            next: (response) => {
              
              this.employeeDetails = response;
              console.log(this.employeeDetails);
             
            }
          })
        }
      }
    })
    
  }
  
 

  deleteEmployee(id: string) {
    
    this.projectmanagerService.deleteEmployee(id).subscribe({
      next: (response) => {
        this.success();
        this.router.navigate(['projectmanagers'])
      }
    });
  }

  success(): void {
    this.toastr.success('ProjectManager Deleted Successfully', 'Success');
    this.router.navigate(['projectmanagers']);

  }
  

}
