import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ProjectManager } from '../../models/projectmanager.model';
import { ProjectManagerAdd, ProjectManagerSkillView, UserAdd } from '../../models/projectmanageradd.model';
import { ProjectmanagerService } from '../../services/projectmanager.service';

@Component({
  selector: 'app-editprojectmanager',
  templateUrl: './editprojectmanager.component.html',
  styleUrls: ['./editprojectmanager.component.scss']
})
export class EditprojectmanagerComponent implements OnInit {
  myform!: FormGroup;
  skills: ProjectManagerSkillView[]
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
    skillName:'',

  }
  userDetails: UserAdd = {
      id: '',
      userName: '',
      email: ''
  }
  constructor(private router: Router, private route: ActivatedRoute, private toastr:ToastrService, private projectmanagerService: ProjectmanagerService) { }
  ngOnInit(): void {
    this.myform = new FormGroup({
      "Id": new FormControl(null, Validators.required),
      "name": new FormControl(null, Validators.required),

      "joindate": new FormControl(null, Validators.required),

      "email": new FormControl(null, [Validators.required, Validators.email]),
      "sta": new FormControl(null, Validators.required),
      "skill": new FormControl(null, Validators.required),
      "mobile": new FormControl(null, Validators.required)
    })
    this.route.paramMap.subscribe({



      next: (params) => {
        const id = params.get('projectManagerID');
        if (id) {
          //call api
          this.projectmanagerService.getEmployee(id).subscribe({
            next: (response) => {
              this.employeeDetails = response;
              console.log(this.employeeDetails[0].projectManagerID);
            }
          })
        }
      }
    })
    this.projectmanagerService.getpmskills().subscribe({

      next: (skills) => {
        this.skills = skills;
        console.log(skills);
      }
    })
    //throw new Error('Method not implemented.');
  }
  updateEmployee() {
    this.projectmanagerService.updateEmployee(this.employeeDetails[0].projectManagerID, this.employeeDetails[0]).
      subscribe({
        next: (response) => {
          console.log(response);
          this.success();
          this.router.navigate(['projectmanagers'])
        }
      });
    


  }
  
  
  success(): void {
    this.toastr.success('ProjectManager Updated Successfully', 'Success');
    this.router.navigate(['projectmanagers']);

  }


}



