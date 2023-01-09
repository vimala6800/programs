import { bootstrapApplication, BrowserModule } from '@angular/platform-browser';
import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';

//import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';

import { ModalModule } from 'ngx-bootstrap/modal';
//import { ToastrModule } from 'ngx-toastr';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './weather/weather.component';

//Packages for google and microsoft login
import { SocialLoginModule, SocialAuthServiceConfig, GoogleLoginProvider } from '@abacritt/angularx-social-login';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ProjectmanagerlistComponent } from './components/projectmanagerlist/projectmanagerlist.component';
import { AddprojectmanagerComponent } from './components/addprojectmanager/addprojectmanager.component';
import { ProjectmanagerdetailsComponent } from './components/projectmanagerdetails/projectmanagerdetails.component';
import { EditprojectmanagerComponent } from './components/editprojectmanager/editprojectmanager.component';

import { AddPartnersComponent } from './components/partners/add-partners/add-partners.component';
import { PartnerDetailsComponent } from './components/partners/partner-details/partner-details.component';
import { EditPartnerComponent } from './components/partners/edit-partner/edit-partner.component';
import { PartnersListComponent } from './components/partners/partners-list/partners-list.component';
import {ReqListComponent} from './components/Requisition/req-list/req-list.component'
import {ReqDetailsComponent} from './components/Requisition/req-details/req-details.component'
import { LoginComponent } from './login/login.component';
import { ForgotpasswordComponent } from './forgotpassword/forgotpassword.component';
import { ResetpasswordComponent } from './resetpassword/resetpassword.component';
import { RouterModule } from '@angular/router';
import { TopbarComponent } from './components/navbar/topbar/topbar.component';
import { NavbarComponent } from './components/navbar/navbar/navbar.component';
import { ProfileComponent } from './components/my-profile/profile/profile.component';
import { ProfileImageSelectorComponent } from './components/my-profile/profile-image-selector/profile-image-selector.component';
import { ProfileFormComponent } from './components/my-profile/profile-form/profile-form.component';
import { RolesPermissionListComponent } from './components/roles/roles-permission-list/roles-permission-list.component';
import { RolesListComponent } from './components/roles/roles-list/roles-list.component';
import { MsalModule, MsalService, MSAL_INSTANCE } from '@azure/msal-angular';
import { IPublicClientApplication, PublicClientApplication } from '@azure/msal-browser';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AddReqComponent } from './components/Requisition/add-req/add-req.component';
import { UserListComponent } from './components/Register/user-list/user-list.component';
import { UserAdminstrationComponent } from './components/Register/user-adminstration/user-adminstration.component';
import { UpdateUsersComponent } from './components/Register/update-users/update-users.component';
import { SkillListComponent } from './components/skillprofile/skill-list/skill-list.component';
import { EditSkillsComponent } from './components/skillprofile/edit-skills/edit-skills.component';
import { AddSkillsComponent } from './components/skillprofile/add-skills/add-skills.component';
import { AddRatecardComponent } from './components/ratecard/add-ratecard/add-ratecard.component';


export function MSALInstanceFactory(): IPublicClientApplication {
  return new PublicClientApplication({
    auth: {
      clientId: 'c66729c8-7ced-43c7-afa4-abda8125f40d',
      redirectUri: 'https://localhost:4200'
    }
  });
}






import { AdminBenchListComponent } from './components/bench/admin-bench-list/admin-bench-list.component';
import { AdminNavBarComponent } from './components/admin-nav-bar/admin-nav-bar.component';
import { PartnerNavBarComponent } from './components/partner-nav-bar/partner-nav-bar.component';
import { PartnerBenchListComponent } from './components/bench/partner-bench-list/partner-bench-list.component';
import { OrderModule } from 'ngx-order-pipe';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgxPaginationModule } from 'ngx-pagination';




import { RatecardComponent } from './components/ratecard/ratecard/ratecard.component';
import { NgxWebstorageModule } from 'ngx-webstorage';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    ForgotpasswordComponent,
    ResetpasswordComponent,
    AddPartnersComponent,
    EditPartnerComponent,
    PartnerDetailsComponent,
    PartnersListComponent,
    ReqListComponent,
    AddReqComponent,
    RolesListComponent,
    TopbarComponent,
    NavbarComponent,
    ProfileComponent,
    ProfileImageSelectorComponent,
    ProfileFormComponent,
    ReqListComponent,
    ReqDetailsComponent,
    ProjectmanagerlistComponent,
    AddprojectmanagerComponent,
    ProjectmanagerdetailsComponent,
    EditprojectmanagerComponent,
    DashboardComponent,
    RolesListComponent,
    RolesPermissionListComponent,
    ProfileComponent,
    ProfileFormComponent,
    ProfileImageSelectorComponent,
    
    UserListComponent,
    UserAdminstrationComponent,
    UpdateUsersComponent,
    
    AdminBenchListComponent,
    PartnerBenchListComponent,
    AdminNavBarComponent,
    PartnerNavBarComponent,
    SkillListComponent,
    EditSkillsComponent,
    AddSkillsComponent,
    AddRatecardComponent,
    NavbarComponent,
    RatecardComponent,
    
    

  ],

  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    Ng2SearchPipeModule,
    AppRoutingModule,
    FormsModule,
    BrowserAnimationsModule,
    ModalModule.forRoot(),
    ReactiveFormsModule,
    RouterModule,
    ToastrModule.forRoot({
    positionClass : 'toast-top-right'
      }),
    MsalModule,
    SocialLoginModule,
    NgxPaginationModule,
    NgxWebstorageModule,
    OrderModule,
  ],
  providers: [
    //Google login
    {
      provide: 'SocialAuthServiceConfig',
      useValue: {
        autoLogin: false,
        providers: [
          {
            id: GoogleLoginProvider.PROVIDER_ID,
            provider: new GoogleLoginProvider(
              '231774703622-c02aafv7m5rfkd3a29clk91ap78nd880.apps.googleusercontent.com'
            )
          }

        ],
        onError: (err) => {
          console.error(err);
        }
      } as SocialAuthServiceConfig,
    },
   
   

    {
      provide: MSAL_INSTANCE,
      useFactory: MSALInstanceFactory
    },
    MsalService,
    Ng2SearchPipeModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }