import { Component, OnInit } from '@angular/core';
import { HomeService, WeatherForecast } from './home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  public weatherForecasts: WeatherForecast[] = [];

  constructor(private _homeService: HomeService) { }

  ngOnInit(): void {
    this._homeService.getWeather().subscribe((forecasts: WeatherForecast[]) => {
      this.weatherForecasts = forecasts;
    })
  }

}
