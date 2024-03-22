import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { JourneyFormRoutingModule } from './journey-form-routing.module';
import { JourneyFormComponent } from './journey-form.component';


@NgModule({
  declarations: [
    JourneyFormComponent
  ],
  imports: [
    CommonModule,
    JourneyFormRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ],
  exports: [
    JourneyFormRoutingModule
  ]
})
export class JourneyFormModule { }
