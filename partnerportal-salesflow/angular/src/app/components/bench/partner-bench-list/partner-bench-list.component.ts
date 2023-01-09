import { Component, OnInit } from '@angular/core';
import { Bench } from 'src/app/models/bench.model';
import { PartnerBenchService } from 'src/app/services/partner-bench.service';

@Component({
  selector: 'app-partner-bench-list',
  templateUrl: './partner-bench-list.component.html',
  styleUrls: ['./partner-bench-list.component.css']
})

export class PartnerBenchListComponent implements OnInit {

  isDesc: boolean = false;
  column: string = 'noOfResource';

  sortIcons: string[] = ['', '↑', '↓']
  sortIndex: number[] = [0, 0, 0, 0, 0];

  //after login pass the userID
  partnerID: any = 'BAF94F53-CCC2-4662-200C-08DAE26974DD';

  searchText: any;

  orderHeader: string = '';

  totalLength: any;

  page: number = 1;

  noOfRaws = 5;

  isDesOrder: boolean = true;

  benchs: any[] = [];



  selectedBench: Bench = {
    partnerName: "",
    benchID: "",
    partnerID: "",
    noOfResource: 0,
    skillSet: "",
    ratePerHrUSD: 0,
    yearsOfExperience: ""
  };

  addBenchRequest: Bench = {
    partnerName: "",
    benchID: "",
    partnerID: "",
    noOfResource: 0,
    skillSet: "",
    ratePerHrUSD: 0,
    yearsOfExperience: ""
  };

  validator: any = {
    noOfResources: "",
    skillSet: "",
    yearsOfExperience: "",
    ratePerHrUSD: ""
  };

  addBenchRevisied: any;

  revert: boolean = true;

  partnerList: any[] = [];

  length: number = 10;

  deleteId: string = "";

  refresh() {
    window.location.reload();
  }

  

  constructor(private partnerBenchService: PartnerBenchService) { }

  ngOnInit(): void {
    this.partnerBenchService.getBenchByPartnerID(this.partnerID)
      .subscribe({
        next: (bench) => {
          this.benchs = bench;
          console.log(this.benchs);
          var lastBench = this.benchs.pop();
          this.benchs.unshift(lastBench);
        },
        error: (response) => {
          console.log(response);
        }
      });

    console.log(this.benchs);
    //this.partnerBenchService.getAllPartner()
    //  .subscribe({
    //    next: (partners) => {
    //      this.partnerList = partners;
    //    },
    //    error: (response) => {
    //      console.log(response);
    //    }
    //  });
  }


  //Add Bench

  addBench()
  {

    this.noOfResourceValidator();
    this.skillSetValidator();
    this.yearsOfExperienceValidator();
    this.ratePerHrUSDValidator();
    console.log(this.addBenchRequest);
    if (this.validator.noOfResources == '' && this.validator.skillSet == ''
      && this.validator.yearsOfExperience == '' && this.validator.ratePerHrUSD == '')
    {
      this.partnerBenchService.addBench
        ({
          partnerID: this.partnerID,
          noOfResource: this.addBenchRequest.noOfResource,
          skillSet: this.addBenchRequest.skillSet,
          ratePerHrUSD: this.addBenchRequest.ratePerHrUSD,
          yearsOfExperience: this.addBenchRequest.yearsOfExperience
        }).subscribe
        ({
          next: (bench) => {
            this.partnerBenchService.showSuccess("Bench Added Successfully", "");
            console.log(bench);
            window.location.reload();
          },
          error: (response) => {
            console.log(response);
          }
        })
    }
  }

  //Add Bench Validation

  noOfResourceValidator() {
    if (this.addBenchRequest.noOfResource == 0) {
      this.validator.noOfResources = "No. of resource is required";
    }
    else if (this.addBenchRequest.noOfResource >= 200) {
      this.validator.noOfResources = "No of resource should be less than 200";
    }
    else if (this.addBenchRequest.noOfResource > 0 && this.addBenchRequest.noOfResource <= 200) {
      this.validator.noOfResources = '';
    }
    else if (this.addBenchRequest.noOfResource.toString() != '') {
      this.validator.noOfResources = "Enter numeric value";
    }

  }
  skillSetValidator() {
    if (this.addBenchRequest.skillSet == '') {
      this.validator.skillSet = "SkillSet is required";
    }
    else if (this.selectedBench.skillSet.length >= 100) {
      this.validator.skillSet = "SkillSet should not exceed 100 character";
    }
    else {
      this.validator.skillSet = '';
    }
  }

  yearsOfExperienceValidator() {
    if (this.addBenchRequest.yearsOfExperience == '') {
      this.validator.yearsOfExperience = "Experience is required";
    }
    else if (this.addBenchRequest.yearsOfExperience.length >= 300) {
      this.validator.yearsOfExperience = "Years of experience not exceed than 30 character"
    }
    else {
      this.validator.yearsOfExperience = '';
    }
  }

  ratePerHrUSDValidator() {
    if (this.addBenchRequest.ratePerHrUSD == 0) {
      this.validator.ratePerHrUSD = "Rate is required";
    }
    else if (this.addBenchRequest.ratePerHrUSD >= 200) {
      this.validator.ratePerHrUSD = "Rate should be less than 200";
    }
    else if (this.addBenchRequest.ratePerHrUSD > 0 && this.addBenchRequest.ratePerHrUSD <= 200) {
      this.validator.ratePerHrUSD = '';
    }
    else if (this.addBenchRequest.ratePerHrUSD.toString() != '') {
      this.validator.ratePerHrUSD = "Enter numeric value";
    }
  }

  //Edit Bench

  editBench(selected: any) {
    this.selectedBench = selected;
    console.log(this.selectedBench);
  }

  //Update Bench

  updateBench() {

    this.sNoOfResourceValidator();
    this.sSkillSetValidator();
    this.sYearsOfExperienceValidator();
    this.sRatePerHrUSDValidator();
    console.log(this.validator);

    if (this.validator.noOfResources == '' && this.validator.skillSet == '' &&
      this.validator.yearsOfExperience == '' && this.validator.ratePerHrUSD == '') {

      console.log(this.selectedBench);
      this.partnerBenchService.editBench({
        benchId: this.selectedBench.benchID,
        partnerId: this.selectedBench.partnerID,
        noOfResource: this.selectedBench.noOfResource,
        skillSet: this.selectedBench.skillSet,
        ratePerHrUSD: this.selectedBench.ratePerHrUSD,
        yearsOfExperience: this.selectedBench.yearsOfExperience
      }, this.selectedBench.benchID).subscribe({
        next: (bench) => {
          console.log(bench);
          this.partnerBenchService.showSuccess("Details Updated Successfully", "");
          window.location.reload();
        },
        error: (response) => {
          console.log(response);
        }
      })

    }
  }

  //Edit Bench Validation

  sNoOfResourceValidator() {
    console.log(this.selectedBench);
    if (this.selectedBench.noOfResource == 0) {
      this.validator.noOfResources = "No. of resource is required";
    }
    else if (this.selectedBench.noOfResource >= 200) {
      this.validator.noOfResources = "No of resource should be less than 200";
    }
    else if (this.selectedBench.noOfResource > 0 && this.selectedBench.noOfResource <= 200) {
      this.validator.noOfResources = '';
    }
    else if (this.selectedBench.noOfResource.toString() != '') {
      this.validator.noOfResources = "Enter numeric value";
    }

  }
  sSkillSetValidator() {
    if (this.selectedBench.skillSet == '') {
      this.validator.skillSet = "SkillSet is required";
    }
    else if (this.selectedBench.skillSet.length >= 100) {
      this.validator.skillSet = "SkillSet should not exceed 100 character";
    }
    else {
      this.validator.skillSet = '';
    }
  }
  sYearsOfExperienceValidator() {
    if (this.selectedBench.yearsOfExperience == '') {
      this.validator.yearsOfExperience = "Experience is required";
    }
    else if (this.selectedBench.yearsOfExperience.length >= 30) {
      this.validator.yearsOfExperience = "Years of experience should not exceed 30 character";
    }
    else {
      this.validator.yearsOfExperience = '';
    }
  }

  sRatePerHrUSDValidator() {
    if (this.selectedBench.ratePerHrUSD == 0) {
      this.validator.ratePerHrUSD = "Rate is required";
    }
    else if (this.selectedBench.ratePerHrUSD >= 200) {
      this.validator.ratePerHrUSD = "Rate should be less than 200";
    }
    else if (this.selectedBench.ratePerHrUSD > 0 && this.selectedBench.ratePerHrUSD <= 200) {
      this.validator.ratePerHrUSD = '';
    }
    else if (this.selectedBench.ratePerHrUSD.toString() != '') {
      this.validator.ratePerHrUSD = "Enter numeric value";
    }
  }

  setDeleteId(id: string) {
    this.deleteId = id;
  }
  deleteBench() {
    this.partnerBenchService.deleteBenchById(this.deleteId).subscribe({
      next: (bench) => {
        this.partnerBenchService.showSuccess("Bench Deleted Successfully", "");
        console.log(bench);
        window.location.reload();
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

  //Sorting

  sort(property, index) {
    this.sortIndex[index] = (this.sortIndex[index] + 1) % 3;
    this.isDesc = !this.isDesc; //change the direction    
    this.column = property;
    let direction = this.isDesc ? 1 : -1;
    console.log(this.benchs);
    this.benchs.sort(function (a, b) {
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
  }
}
