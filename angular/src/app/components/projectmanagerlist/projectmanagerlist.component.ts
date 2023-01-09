import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxPaginationModule } from 'ngx-pagination';
import { ProjectManager, ProjectManagerlist } from 'src/app/models/projectmanager.model';
import { ProjectmanagerService } from '../../services/projectmanager.service';

@Component({
  selector: 'app-projectmanagerlist',
  templateUrl: './projectmanagerlist.component.html',
  styleUrls: ['./projectmanagerlist.component.scss'],
  
 
})
export class ProjectmanagerlistComponent implements OnInit {
  isDesc: boolean = false;
  column: string = 'employeeID';
  searchText: any;
  projectmanagers: ProjectManagerlist[] = [];
  totalLength: any;
  totalCount: any;
  noOfRows = 5;
  page: number = 1;
  constructor(private projectmanagerService: ProjectmanagerService,private router:Router) {
    
  }
  ngOnInit(): void {
    this.projectmanagerService.getProjectManagers()
      .subscribe({
        next: (projectmanagers) => {
          this.projectmanagers = projectmanagers;
          this.totalCount = projectmanagers.length;
          console.log(projectmanagers);
        },
        error: (response) => {
          console.log(response);
        }
      })
  }
 
  async updateEmployee(projectmanager: any) {
    console.log(projectmanager);
    if (projectmanager.pmStatus == 0)
      projectmanager.pmStatus = 1;
    else
      projectmanager.pmStatus = 0;
    await this.projectmanagerService.updateEmployee(projectmanager.projectManagerID, projectmanager).
      subscribe({
        next: (response) => {
          console.log(response);
          
          this.router.navigate(['projectmanagers'])
        }
      });
  }

  sort(property) {
    this.isDesc = !this.isDesc; //change the direction    
    this.column = property;
    let direction = this.isDesc ? 1 : -1;

    this.projectmanagers.sort(function (a, b) {
      if (a[property] < b[property]) {
        return -1 * direction;
      }
      else if (a[property] > b[property]) {
        return 1 * direction;
      }
      else {
        return 0;
      }
    });
  };


 
  

  


  


}
