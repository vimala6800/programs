import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

import { RateCards } from 'src/app/models/ratecard.model';
import { RatecardsService } from 'src/app/services/ratecards.service';

@Component({
  selector: 'app-add-ratecard',
  templateUrl: './add-ratecard.component.html',
  styleUrls: ['./add-ratecard.component.scss']
})
export class AddRatecardComponent implements OnInit {
  myrateform!: FormGroup;
  rateCards: RateCards[] = []; 
  addratecard: RateCards = {
    skillID: '',
    minYrExperience: '',
    maxYrExperience: '',
    ratePerHrUSD: '',
    rateCardId: '',
  }
  rr: string=this.GetSess();
  addRatesRequest:RateCards={
    rateCardId: '',
    skillID: '',
    minYrExperience: '',
    maxYrExperience: '',
    ratePerHrUSD: '',
  }
  mass:any;
  addRatesRevisied:any;
  constructor(private ratecarservice: RatecardsService) { }
  ngOnInit(): void {
    this.myrateform = new FormGroup({
      "minimum": new FormControl(null, Validators.required),
      "maximum": new FormControl(null, Validators.required),
      "usd": new FormControl(null, Validators.required)
    })
  }

 

  addRatecard(): void {
    console.log(this.addRatesRevisied);
    console.log(this.addRatesRequest);
   // let isSkillExists = this.checkMinimumYear();
    // if(isSkillExists == true){
      
    //   this.ratecarservice.showSuccess("please enter correct data", "");
    // }
    // if(true){
      // if(this.checkMinimumYear()<Number(this.addRatesRequest.minYrExperience))
      // {
    if(this.addRatesRequest.minYrExperience<this.addRatesRequest.maxYrExperience)
    {
      
    this.ratecarservice.addRatecard({
      skillID: this.GetSess(),
      
      minYrExperience:this.addRatesRequest.minYrExperience,
      maxYrExperience:this.addRatesRequest.maxYrExperience,
      ratePerHrUSD:this.addRatesRequest.ratePerHrUSD
     

    }).subscribe({
      next: (rate) => {
        this.ratecarservice.showSuccess("RateCard Added Successfully", "");
        console.log(rate);
        window.location.reload();
      },
      error: (response) => {
        console.log(response);
        this.ratecarservice.showError("Unsuccessfull!", "");
      }
    })
    }
  else{
    
      this.ratecarservice.showError("Minimum year can not be greater than Maximum year!", "");
    
  }
// }else{
//   this.ratecarservice.showError("give corrrect value!", "");
// }
}
//}
// checkMinimumYear() {
//   let skillp = this.addRatesRevisied;
//   console.log(this.addRatesRevisied);
//   console.log(this.addRatesRequest);
//   let isSkillExists = 0;
//   this.mass =skillp.maxYrExperience[0];
//   for (let i = 1; i < skillp.length; i++) {
    
//     if (skillp[i].maxYrExperience > this.mass ) {
//       this.mass=skillp[i].maxYrExperience;
//       isSkillExists = this.mass;
//     }
//   }
//   return this.mass;
// }
    GetSession(){
      var s =sessionStorage.getItem('id');
    return sessionStorage.getItem('key');
  }
  GetSess(){
    return sessionStorage.getItem('id');
  }


}
