import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Register } from '../../../models/register.model';
import { RegisterService } from '../../../services/register.service';

@Component({
  selector: 'app-update-users',
  templateUrl: './update-users.component.html',
  styleUrls: ['./update-users.component.scss']
})
export class UpdateUsersComponent implements OnInit {
  getUserRequest: Register = {
      id: '',
      userName: '',
      email: '',
      phoneNumber: ''
      
  }
  constructor(private router: Router, private registerService: RegisterService, private route: ActivatedRoute) { }
  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.registerService.getUser(id).subscribe({
            next: (response) => {
              this.getUserRequest = response;
            }
          })

        }
      }
    })

  }
  updateuser() {
    this.registerService.updateUser(this.getUserRequest.id, this.getUserRequest)
      .subscribe({
        next: (response) => {
          this.router.navigate(['UserAdminstration'])
        }
      });
  }
  deleteuser(id: String) {
    this.registerService.deleteUser(id).subscribe({
      next: (response) => {
        this.router.navigate(['/UserAdminstration'])
      }
    });
  }
}


