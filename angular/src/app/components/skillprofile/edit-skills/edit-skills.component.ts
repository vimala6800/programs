import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Skill } from '../../../models/skill.model';
import { SkillsService } from '../../../services/skills.service';


@Component({
  selector: 'app-edit-skills',
  templateUrl: './edit-skills.component.html',
  styleUrls: ['./edit-skills.component.scss']
})
export class EditSkillsComponent implements OnInit {
  SkillIDToBeDeleted: string = "";

  addSkillRequest: Skill = {

    skillID:'',
    skillName: ''
  }
  edit: any = {};
  constructor(private skillService: SkillsService, private router: Router) { }

  ngOnInit(): void {
    //this.skillService.getAllSkills()
    //  .subscribe(
    //    {
    //      next: (skill) => {
    //        this.skills = skill;
    //        console.log(skill);
    //      },
    //      error: (response) => { console.log(response) }
    //    }
    //  );
  }

  
  updateSkill(): void {

    console.log(this.edit);

    this.skillService.updateskill(this.edit, this.SkillIDToBeDeleted).subscribe({

      next: (skill) => { console.log(skill); }

    });
  }

 
}
