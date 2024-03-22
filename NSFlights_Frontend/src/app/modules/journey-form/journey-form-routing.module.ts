import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JourneyFormComponent } from './journey-form.component';

const routes: Routes = [{
  path: '',
  title: 'JourneyForm',
  component: JourneyFormComponent
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class JourneyFormRoutingModule { }
