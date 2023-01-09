import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Partner, PartnerModel } from '../../../models/partner.model';
import { PartnersService } from '../../../services/partners.service';

@Component({
  selector: 'app-partners-list',
  templateUrl: './partners-list.component.html',
  styleUrls: ['./partners-list.component.css']
})
export class PartnersListComponent implements OnInit {
  isDesc: boolean = false;
  column: string = 'partnerID';
  searchText: any;
  partners: PartnerModel[] = [];
  totalLength: any;
  noOfRows = 5;
  page: number = 1;
  totalCount: any;
  

  constructor(private route: ActivatedRoute, private partnersService: PartnersService, private toastr: ToastrService, private router: Router) { }
  ngOnInit(): void {


    this.partnersService.getAllPartners()
      .subscribe({
        next: (partners) => {
          this.partners = partners;
          console.log(partners);
          this.totalCount = partners.length;
        },
        error: (response) => {
          console.log(response);
        }
      })


  }
  sort(property) {
    this.isDesc = !this.isDesc; //change the direction    
    this.column = property;
    let direction = this.isDesc ? 1 : -1;

    this.partners.sort(function (a, b) {
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

  updatePartner(partner: any) {
    console.log(partner);
    if (partner.partnerStatus == 0)
      partner.partnerStatus = 1;
    else
      partner.partnerStatus = 0;
    this.partnersService.updatePartner(partner.partnerID, partner).
      subscribe({
        next: (response) => {
          console.log(response);
         // this.success();
          this.router.navigate(['/partner'])
        }
      });
  }
  success(): void {
    this.toastr.success('Partner Updated Successfully!', 'Success');

  }
}
