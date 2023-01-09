import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RateCards } from 'src/app/models/ratecard.model';
import { Skill } from 'src/app/models/skill.model';
import { RatecardsService } from 'src/app/services/ratecards.service';



@Component({
  selector: 'app-ratecard',
  templateUrl: './ratecard.component.html',
  styleUrls: ['./ratecard.component.scss']
})
export class RatecardComponent implements OnInit {


 
  rateCards: RateCards[] = [];
 
  
  
  
 
  
  displaySkill: any = {
    skillID: "",
    
    rateCardID: '',
    
    minYrExperience: '',
    maxYrExperience: '',
    ratePerHrUSD: ''
  };
  deleteId: string = "";
  s: string = "";
  addratecardRevisied: any;
  constructor(private ratecardsService: RatecardsService,private router: Router, private route: ActivatedRoute) { }

 
  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('skillID');
        if (id) {
         
          this.ratecardsService.GetRateCardBySkillID(id).subscribe({
            next: (response) => {
              console.log(response);
              this.displaySkill = response;
            }
          })
        }
      }
    })
  }

  setDeleteId(id: string) {

    this.deleteId = id;

  }

  deleteRate() {
    this.ratecardsService.deleterateById(this.deleteId).subscribe({

      next: (ratecard) => {

        this.ratecardsService.showSuccess("Ratecard Deleted Successfully", "");

        console.log(ratecard);

        window.location.reload();

      },

      error: (response) => {

        console.log(response);

      }

    })

  }

  GetSession() {

    return sessionStorage.getItem('key');
  }
  Getsess() {
    return sessionStorage.getItem('id');

  }
}





