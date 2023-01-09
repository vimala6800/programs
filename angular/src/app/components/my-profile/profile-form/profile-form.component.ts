import { Component } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { RolesService } from '../../../services/roles.service';

@Component({
  selector: 'app-profile-form',
  templateUrl: './profile-form.component.html',
  styleUrls: ['./profile-form.component.css']
})
export class ProfileFormComponent {
  userID: string = environment.userId;
  focusB: string[] = ["addStyle", "addStyle", "addStyle", "addStyle", "addStyle", "addStyle", "addStyle", "addStyle"]
  user: any;
  disabledEmail: string;
  password: string = "";
  passwordConfirm: string = "";
  constructor(private dataService: RolesService) { }
  focus(index: number): void {
    this.focusB[index] = "";
    // console.log("inside "+index);
  }
  focusout(index: number): void {
    this.focusB[index] = "addStyle";
    // console.log("outside "+index);
  }

  ngOnInit(): void {
    this.dataService.getUser(this.userID)
      .subscribe(
        {
          next: (user) => {
            this.user = user;
            this.disabledEmail = this.user.email;
            console.log(user);
          },
          error: (response) => { console.log(response) }
        }
      );
  }
  updateUser(): void {
    if (this.password === this.passwordConfirm) {
      if (this.password != "")
        this.user.password = this.password;
      console.log(this.user);
      this.dataService.updateUser(this.user, this.userID).subscribe({
        next: (user) => {
          console.log(user);
          this.disabledEmail = this.user.email;
          this.dataService.showSuccess("Data updated successfully !!", "");
        }
      });
    }
    else {
      this.dataService.showError("Password Mismatch!", "");

    }
  }
}
