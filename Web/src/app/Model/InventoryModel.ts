export interface GalaDetails {
  id: number;
  galaNo: string;
  isActive: boolean;
  createDate: Date;
  updateDate: Date;
}

export interface QualityDetails {
  id: number;
  qualityType: string;
  isActive: boolean;
  createDate: Date;
  updateDate: Date;
}

export interface GalaQualitySerialNoTrack {
  id: number;
  galaNo: number;
  qualityType: number;
  serialNo: number;
  startDate: Date;
  endDate: Date;
  isActive: boolean;
  createDate: Date;
  updateDate: Date;
}

export interface GalaQualitySerialNoTrackHistory {
  id: number;
  galaNo: number;
  qualityType: number;
  serialNo: number;
  startDate: Date;
  endDate: Date;
  isActive: boolean;
  createDate: Date;
  updateDate: Date;
}

export interface Inventory {
  id: number;
  galaNo: number;
  qualityType: number;
  serialNo: number;
  loomNo: number;
  meter: number;
  netWeight: number;
  avg_NetWeight: number;
  isActive: boolean;
  createDate: Date;
  updateDate: Date;
}