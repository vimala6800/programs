import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { CountryMaster, Partner, SkillMaster } from '../../../models/partner.model';
import { PartnersService } from '../../../services/partners.service';

@Component({
  selector: 'app-edit-partner',
  templateUrl: './edit-partner.component.html',
  styleUrls: ['./edit-partner.component.css']
})
export class EditPartnerComponent implements OnInit {
  myform!: FormGroup;
  url = './images/placeholder.jpg';
  countries: CountryMaster[];
  skills: SkillMaster[]
  addressCheckBox: boolean = false;
  
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

    this.myform = new FormGroup({
      "name": new FormControl(null, Validators.required),
      "location": new FormControl(null, Validators.required),
      "Country": new FormControl(null, Validators.required),
      "regdate": new FormControl(null, Validators.required),
      "spocname": new FormControl(null, Validators.required),
      "spocemail": new FormControl(null, [Validators.required,
      Validators.email
      ]),
      "status": new FormControl(null, Validators.required),
      "Skill": new FormControl(null, Validators.required),
      "address1": new FormControl(null, Validators.required),
      "billingAddress1": new FormControl(null, Validators.required)
    })
    this.route.paramMap.subscribe({

      next: (params) => {
        const id = params.get('partnerID');
        if (id) {
          //call api
          this.partnerService.getPartnerDetails(id).subscribe({
            next: (response) => {
              this.partnerDetails = response
              
            }
          })
        }
      }
    })
    //throw new Error('Method not implemented.');
    this.partnerService.GetAllCountry()
      .subscribe({
        next: (countries) => {
          this.countries = countries;
          console.log(countries);
        },
        error: (response) => {
          console.log(response);
        }
      })
    this.partnerService.GetAllSkills()
      .subscribe({
        next: (skills) => {
          this.skills = skills;
          console.log(skills);
        },
        error: (response) => {
          console.log(response);
        }
      })
  }
  async tick() {
    console.log(this.partnerDetails);
    if (this.addressCheckBox == true) {
      this.addressCheckBox = false;
      this.partnerDetails[0].billingAddress1 = '';
    }
    else {
      this.addressCheckBox = true;
      this.partnerDetails[0].billingAddress1 = await this.partnerDetails[0].address1;
    }
   }
  updatePartner() {
    
    this.partnerService.updatePartner(this.partnerDetails[0].partnerID, this.partnerDetails[0]).
      subscribe({
        next: (response) => {
          console.log(response);
          this.success();
          this.router.navigate(['/partner'])
        }
      });
  }
  success(): void {
    this.toastr.success('Partner Updated Successfully!', 'Success');
    this.router.navigate(['partners']);

  }
  cancel() {
    // Simply navigate back to reminders view
    this.router.navigate(['../'], { relativeTo: this.route }); // Go up to parent route     
  }
  onSelectFile(event) {
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();

      reader.readAsDataURL(event.target.files[0]); // read file as data url

      reader.onload = (event: any) => { // called once readAsDataURL is completed
        console.log(event);
        this.url = event.target.result;
      }
    }
  }
}
