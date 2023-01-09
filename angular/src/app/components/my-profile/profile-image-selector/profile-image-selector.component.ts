import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { environment } from '../../../../environments/environment';

@Component({
  selector: 'app-profile-image-selector',
  templateUrl: './profile-image-selector.component.html',
  styleUrls: ['./profile-image-selector.component.css']
})
export class ProfileImageSelectorComponent {
  constructor(private http: HttpClient) { }
  userID: string = environment.userId;
  url: string = "";
  ngOnInit(): void {
    this.http.get<any>('https://localhost:7184/api/Profile/' + this.userID)
      .subscribe(
        {
          next: res => {
            console.log(res);
            if (res.imageUrl != "empty" && res.imageUrl != "\u0000\u0000\u0000\u0001")
              this.url = res.imageUrl;
            else {
              this.url = "https://www.pngarts.com/files/10/Default-Profile-Picture-PNG-Download-Image.png";
            }
          },
          error: (response) => { console.log(response) }
        }
      );
  }

  gotFile(event: any): void {
    console.log(event);
    var fd = new FormData();
    var file = event.target.files[0];
    fd.append("image", file, file.fileName);
    this.http.put<any>('https://localhost:7184/api/ProfileImage/' + this.userID, fd).subscribe(res => {
      console.log(res);
      if (res.imageUrl != "empty")
        this.url = res.imageUrl;
      else {
        this.url = "https://www.pngarts.com/files/10/Default-Profile-Picture-PNG-Download-Image.png";
      }
      //window.location.reload();
    })
  }
}
