import { Component, OnInit, ViewChild } from '@angular/core';
import { Skill } from '../../../models/skill.model';
import { SkillsService } from '../../../services/skills.service';
import { NgModule } from '@angular/core';
import { RatecardComponent } from '../../ratecard/ratecard/ratecard.component';



@Component({
  selector: 'app-skill-list',
  templateUrl: './skill-list.component.html',
  styleUrls: ['./skill-list.component.scss']
})
export class SkillListComponent implements OnInit{
 
  isDesc: boolean = false;
  column: string = 'skillName';

  skillIDToBeDeleted: string = "";
  skills: Skill[] = [];
  addS: any = {
    skillName: ""
  };
  selectedSkill: Skill = {
    skillID: "",
    skillName:"",
   };
   addSkillRequest: Skill = {
   
    skillID:'',
    skillName:'',
  }
  addSkillsRevisied:any;

  edit: any = {};
  deleteId: string = "";
  searchText:any;
  orderHeader: String = '';
  //noOfRows = 5;
  
  totalLength:any;
  noOfRows  = 5;
  page:number=1;

  isDesOrder: boolean = true;
  constructor(private skillService: SkillsService) { }

  ngOnInit(): void {
    this.skillService.getAllSkills()
      .subscribe(
        {
          next: (skill) => {
            this.skills = skill;
            console.log(this.skills);
          },
          error: (response) => { console.log(response) }
        }
      );

  }

  setDeleteId(id: string) {
    this.deleteId = id;
  }
  deleteSkill() {
    this.skillService.deleteSkillById(this.deleteId).subscribe({
      next: (skill) => {
        this.skillService.showSuccess("Skill Deleted Successfully", "");
        console.log(skill);
        window.location.reload();
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

  editSkill(selected: any) {
    this.selectedSkill = selected;
    console.log(this.selectedSkill);
  }
  updateSkill() {
    console.log(this.selectedSkill);

    this.skillService.editSkill({
      skillID: this.selectedSkill.skillID,
      skillName: this.selectedSkill.skillName,
    }, this.selectedSkill.skillID)
    
    .subscribe({
      next: (skill) => {
        
     if(this.GetSession()!=this.selectedSkill.skillName ){
      let isSkillExists = this.checkSkillExists();
      if(isSkillExists != this.addSkillRequest.skillName)
      
      {
        this.skillService.showSuccess("Skill Updated Successfully", "");

     }}else{
      this.skillService.showInfo("Nothing changes have been made ", "");
     }
        console.log(skill);
        window.location.reload();
      },
      error: (response) => {
        console.log(response);
      }
    })
   
  }
  checkSkillExists(): string {
    let skillp = this.addSkillsRevisied;
    console.log(this.addSkillsRevisied);
    console.log(this.addSkillRequest);
    let isSkillExists = "";
    for (let i = 0; i < skillp.length; i++) {
      if (skillp[i].skillName == this.addSkillRequest.skillName) {
        isSkillExists = this.addSkillRequest.skillName;
      }
    }
    return isSkillExists;
  }
    SetSession(skillName,skillID){
      sessionStorage.setItem('key',skillName);
      sessionStorage.setItem('id',skillID);
    }
    Setskill (skillName){
       sessionStorage.setItem('key1',skillName);
    }
   GetSession(){
    return sessionStorage.getItem('key1');
   }
     
  sort(property) {
    this.isDesc = !this.isDesc; //change the direction    
    this.column = property;
    let direction = this.isDesc ? 1 : -1;

    this.skills.sort(function (a, b) {
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
