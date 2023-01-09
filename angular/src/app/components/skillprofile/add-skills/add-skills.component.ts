import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Skill } from '../../../models/skill.model';
import { SkillsService } from '../../../services/skills.service';

@Component({
  selector: 'app-add-skills',
  templateUrl: './add-skills.component.html',
  styleUrls: ['./add-skills.component.scss']
})
export class AddSkillsComponent implements OnInit {
  myform!:FormGroup;
  addSkillRequest: Skill = {
   
    skillID:'',
    skillName:'',
  }
  addSkillsRevisied:any;
  constructor(private skillsService: SkillsService ) { }
  
  ngOnInit(): void {
    this.myform = new FormGroup({
      "skillname": new FormControl(null, Validators.required)
    })
    this.skillsService.getAllSkills().subscribe({
      next: (skilpp) => {
        this.addSkillsRevisied = skilpp;

 

        console.log(skilpp);
      },
      error: (response) => {
        console.log(response)
      }
    });
  }
   addSkill(): void {
    console.log(this.addSkillRequest);
    console.log(this.addSkillsRevisied);
    let isSkillExists = this.checkSkillExists();
    if(isSkillExists == true){
      //this.showMessage("Skill Exists")
      this.skillsService.showInfo("Skill is already exist", "");
    }else{
       this.skillsService.addSkill({
      
      skillName: this.addSkillRequest.skillName,
      

    }).subscribe({
      next: (skill) => {
        this.skillsService.showSuccess("Skill Added Successfully", "");
        console.log(skill);
        window.location.reload();
      },
      error: (response) => {
        console.log(response);
        this.skillsService.showError("Unsuccessfull!", "");
      }
    })
  }
    }
    checkSkillExists(): boolean {
      let skillp = this.addSkillsRevisied;
      console.log(this.addSkillsRevisied);
      console.log(this.addSkillRequest);
      let isSkillExists = false;
      for (let i = 0; i < skillp.length; i++) {
        if (skillp[i].skillName == this.addSkillRequest.skillName) {
          isSkillExists = true;
        }
      }
      return isSkillExists;
    }
    showMessage(msg) {
      alert(msg);
    }
}
