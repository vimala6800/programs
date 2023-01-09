import { Component, OnInit } from '@angular/core';
import { Bench } from 'src/app/models/bench.model';
import { AdminBenchService } from 'src/app/services/admin-bench.service';

@Component({
  selector: 'app-admin-bench-list',
  templateUrl: './admin-bench-list.component.html',
  styleUrls: ['./admin-bench-list.component.css']
})

export class AdminBenchListComponent implements OnInit {

  partnerList: any[] = [];

  benchs: any[] = [];

  partnerID: any;

  isDesc: boolean = false;
  column: string = 'noOfResource';

  sortIcons: string[] = ['', '↑', '↓'];
  sortIndex: number[] = [0, 0, 0, 0, 0];

  searchText: any;

  orderHeader: string = '';

  totalLength: any;

  page: number = 1;

  noOfRaws = 5;

  isDesOrder: boolean = true;

  //addBenchRevisied: any;

  revert: boolean = true;

  length: number = 10;

  deleteId: string = "";

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
    partnerName: "",
    noOfResources: "",
    skillSet: "",
    yearsOfExperience: "",
    ratePerHrUSD: ""
  };

  refresh() {
    window.location.reload();
  }


  constructor(private adminBenchService: AdminBenchService) { }

  ngOnInit(): void {
    this.adminBenchService.getAllBench()
      .subscribe({
        next: (bench) => {
          this.benchs = bench;
          console.log(this.benchs);
          var lastBench = this.benchs.pop();
          this.benchs.unshift(lastBench);
          this.benchs.forEach((bench, i) => {
            this.adminBenchService.getPartnerNameByPartnerId(bench.partnerID)
              .subscribe({
                next: (partner) => {
                  console.log(partner);
                  this.benchs[i].partnerName = partner.partnerName;
                },
                error: (response) => {
                  console.log(response);
                }
              })
          });
          console.log(this.benchs);
        },
        error: (response) => {
          console.log(response);
        }
      });
    console.log(this.benchs);
    this.adminBenchService.getAllPartner()
      .subscribe({
        next: (partners) => {
          this.partnerList = partners;
          console.log(this.partnerList);
        },
        error: (response) => {
          console.log(response);
        }
      });
  }


  //Adding 200 records for partner
  add200() {
    this.adminBenchService.addPartner();
  }

  //Add Bench
  addBench() {
    this.partnerNameValidator();
    this.noOfResourceValidator();
    this.skillSetValidator();
    this.yearsOfExperienceValidator();
    this.ratePerHrUSDValidator();
    console.log(this.addBenchRequest);
    this.adminBenchService.getAllPartner()
      .subscribe({
        next: (bench) => {
        console.log(bench);
        for (var i = 0; i < bench.length; i++)
        {
          if (bench[i].partnerName == this.addBenchRequest.partnerName)
          {
            this.addBenchRequest.partnerID = bench[i].partnerID;
            break;
          }
        }

        if (this.validator.partnerName == '' && this.validator.noOfResources == '' && this.validator.skillSet == ''
          && this.validator.yearsOfExperience == '' && this.validator.ratePerHrUSD == '')
        {

          this.adminBenchService.addBench({
            partnerID: this.addBenchRequest.partnerID,
            noOfResource: this.addBenchRequest.noOfResource,
            skillSet: this.addBenchRequest.skillSet,
            ratePerHrUSD: this.addBenchRequest.ratePerHrUSD,
            yearsOfExperience: this.addBenchRequest.yearsOfExperience
          }).subscribe({
            next: (bench) => {
              this.adminBenchService.showSuccess("Bench Added Successfully", "");
              console.log(bench);
              window.location.reload();
            },
            error: (response) => {
              console.log(response);
            }
          })
        }
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

  //Add Bench Validation

  partnerNameValidator()
  {
    console.log(this.addBenchRequest.partnerName);
    if (this.addBenchRequest.partnerName == '') {
      this.validator.partnerName = "select a partner";
    }
    else {
      this.validator.partnerName = '';
    }
  }

  noOfResourceValidator()
  {
    console.log(this.addBenchRequest);
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
  skillSetValidator()
  {
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
  yearsOfExperienceValidator()
  {
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

  ratePerHrUSDValidator()
  {
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

  updateBench() {
    this.sPartnerNameValidator();
    this.sNoOfResourceValidator();
    this.sSkillSetValidator();
    this.sYearsOfExperienceValidator();
    this.sRatePerHrUSDValidator();
    console.log(this.validator);
    this.adminBenchService.getAllPartner().subscribe({
      next: (bench) => {
        console.log(bench);
        for (var i = 0; i < bench.length; i++)
        {
          if (bench[i].partnerName == this.addBenchRequest.partnerName)
          {
            this.addBenchRequest.partnerID = bench[i].partnerID;
            break;
          }
        }
        if (this.validator.partnerName == '' && this.validator.noOfResources == '' && this.validator.skillSet == '' &&
          this.validator.yearsOfExperience == '' && this.validator.ratePerHrUSD == '')
        {
          console.log(this.selectedBench);
          this.adminBenchService.editBench({
            benchId: this.selectedBench.benchID,
            partnerId: this.selectedBench.partnerID,
            noOfResource: this.selectedBench.noOfResource,
            skillSet: this.selectedBench.skillSet,
            ratePerHrUSD: this.selectedBench.ratePerHrUSD,
            yearsOfExperience: this.selectedBench.yearsOfExperience
          },
          this.selectedBench.benchID).subscribe({
            next: (bench) => {
              console.log(bench);
              this.adminBenchService.showSuccess("Details Updated Successfully", "");
              window.location.reload();
            },
            error: (response) => {
              console.log(response);
            }
          })
        }
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

  //Edit Bench Validation

  sPartnerNameValidator() {
    if (this.selectedBench.partnerID == '') {
      this.validator.partnerName = "select a partner";
    }
    else {
      this.validator.partnerName = '';
    }
  }

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


    //Delete Bench

  setDeleteId(id: string) {
    this.deleteId = id;
  }

  deleteBench() {
    this.adminBenchService.deleteBenchById(this.deleteId).subscribe({
      next: (bench) => {
        this.adminBenchService.showSuccess("Bench Deleted Successfully", "");
        console.log(bench);
        window.location.reload();
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

  //Sorting
  sort(property, index)
  {
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
