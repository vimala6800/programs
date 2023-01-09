export interface Partner {
  partnerID: string;
  partnerName: string;
  location: string;
  countryID: string;
  registeredDate: string;
  spocUserID: string;
  address1: string;
  billingAddress1: string;
  partnerImage: string;
  partnerStatus: number;
  skillID: string;
  spocEmail: string;
  spocName: string;
}

export interface CountryMaster {
  countryID: number;
  countryName: string;
}
export interface SkillMaster {
  skillID: number;
  skillName: string;
}

export interface PartnerModel {
  partnerID: string;
  partnerName: string;
  location: string;
  country: string;

  registeredDate: string;
  partnerStatus: number;
  address1: string;
  billingAddress1: string;
}


