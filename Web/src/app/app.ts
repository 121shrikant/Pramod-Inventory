import { Component } from '@angular/core';
import { InevntoryService } from './Service/Inevntory.service';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected title = 'Web';
  constructor(private inevntoryService: InevntoryService) {
    // Initialization logic can go here if needed
  }
  ngOnInit() {
    this.inevntoryService.getGalaDetails().subscribe((data) => {
      console.log('getGalaDetails Data fetched successfully:', data);
    });

    this.inevntoryService.getQualityDetails().subscribe((data) => {
      console.log('getQualityDetails Data fetched successfully:', data);
    });
  }
  ngOnDestroy() {
    // This method is called when the component is about to be destroyed
    // You can perform any cleanup here if necessary
  }
}
