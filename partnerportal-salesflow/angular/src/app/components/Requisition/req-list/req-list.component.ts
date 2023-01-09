import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Requisition } from 'src/app/models/requisition/req-list.model';
import { RequisitionService } from 'src/app/services/requisition.service';
import { RequisitionClient, RequisitionDto } from 'src/app/web-api-client';
import { saveAs } from 'file-saver';
import { PartnersService } from '../../../services/partners.service';

@Component({
  selector: 'app-req-list',
  templateUrl: './req-list.component.html',
  styleUrls: ['./req-list.component.scss']
})
export class ReqListComponent implements OnInit {
  searchText: any;
  searchtext: any;
  getPatner: any[] = [];
  selectedStatus: number = -1;
  totalLength: any;
  noOfRows = 10;
  page: number = 1;
  requisitions: Requisition[] = [];
  requisitionDetails: Requisition;
  lists: RequisitionDto[];
  selectedList: RequisitionDto;
  constructor(
    private listsClient: RequisitionClient, private route: ActivatedRoute, private partnerService: RequisitionService, private patnerService: PartnersService,  private router: Router) { }

  ngOnInit(): void {


   /* this.partnerService.getAllPartners()
      .subscribe({
        next: (patner) => {
          this.getPatner = patner;
          console.log(patner);
        }
      });*/

    this.listsClient.get().subscribe(
      result => {
        this.lists = result.lists;
        console.log(this.lists);
        if (this.lists.length) {
          this.selectedList = this.lists[0];
        }
      },
      error => console.error(error)
    );

  }

  downloadFile(id: string) {
    this.partnerService.getFile(id).subscribe((response) => {
      saveAs(response, 'Requisition.csv');
    });
  }
}
