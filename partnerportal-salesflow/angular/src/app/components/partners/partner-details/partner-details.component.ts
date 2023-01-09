import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Partner, PartnerModel } from '../../../models/partner.model';
import { PartnersService } from '../../../services/partners.service';

@Component({
  selector: 'app-partner-details',
  templateUrl: './partner-details.component.html',
  styleUrls: ['./partner-details.component.css']
})
export class PartnerDetailsComponent implements OnInit {
  partnerDetails: Partner = {
    partnerID: '',
    partnerName: '',
    location: '',
    countryID: '',
    registeredDate: '',
    spocUserID: '',
    address1: '',
    billingAddress1: '',
    partnerImage: '',
    partnerStatus: 0,
    skillID: '',
    spocEmail: '',
    spocName:'',
  }

  constructor(private route: ActivatedRoute, private toastr: ToastrService, private partnerService: PartnersService, private router: Router) { }
    ngOnInit(): void {
      /*throw new Error('Method not implemented.');*/
      this.route.paramMap.subscribe({
        next: (params) => {
          const id = params.get('partnerID');
          if (id) {
            this.partnerService.getPartnerDetails(id).subscribe({
              next: (response) => {
               // var status=this.partnerDetails.partnerStatus;
                this.partnerDetails = response;
                console.log(this.partnerDetails)
                
              }
            })
          }
        }
      })
    }
  deletePartner(id: string) {
    this.partnerService.deletePartner(id).subscribe({
      next: (response) => {
        this.success();
        this.router.navigate(['/partner']);
      }
    })
  }
  success(): void {
    this.toastr.info('Partner Deleted Successfully!', 'Info');
    this.router.navigate(['partner']);

  }

}
