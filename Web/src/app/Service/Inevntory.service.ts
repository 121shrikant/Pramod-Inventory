import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GalaDetails, QualityDetails } from '../Model/InventoryModel';

@Injectable({
  providedIn: 'root'
})
export class InevntoryService {
  private apiUrl = 'http://localhost:5173/Inventory/'; // Replace with your API URL

  constructor(private http: HttpClient) {}

  getGalaDetails(): Observable<Array<GalaDetails>> {
    return this.http.get<Array<GalaDetails>>(this.apiUrl+'GetGalaDetails');
  }
  getQualityDetails(): Observable<Array<QualityDetails>> {
    return this.http.get<Array<QualityDetails>>(this.apiUrl+ 'GetQualityDetails');
  }
}