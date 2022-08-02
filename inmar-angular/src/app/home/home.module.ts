import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { HomeService } from './home.service';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  exports: [
    HomeComponent
  ],
  providers: [
    HomeService
  ]
})
export class HomeModule { }
