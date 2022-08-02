import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

export type WeatherForecast = {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(private _httpClient: HttpClient) { }

  getWeather(): Observable<WeatherForecast[]> {
    return this._httpClient.get<WeatherForecast[]>('http://localhost:5188/weatherforecast');
  }
}
