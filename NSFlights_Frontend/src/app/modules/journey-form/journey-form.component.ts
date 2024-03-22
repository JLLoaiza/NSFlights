import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-journey-form',
  templateUrl: './journey-form.component.html',
  styleUrls: ['./journey-form.component.scss']
})
export class JourneyFormComponent {
  destinationForm: FormGroup;
  submitted: boolean;

  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private route: ActivatedRoute
  ) {
    this.submitted = false;

    this.destinationForm = this.formBuilder.group({
      origin: ['', Validators.compose([Validators.required, Validators.maxLength(3), Validators.minLength(3)])],
      destination: ['', Validators.compose([Validators.required, Validators.maxLength(3), Validators.minLength(3)])],
    });
  }

  ngOnInit(): void {
    this.route.queryParamMap
      .subscribe((params) => {
        this.destinationForm.controls['origin'].setValue(String(params.get('origin') || ''));
        this.destinationForm.controls['destination'].setValue(String(params.get('destination') || ''));
      });
  }

  validateFormField(field: string) {
    let control = this.destinationForm.controls[field];
    return this.submitted && (control.invalid);
  }

  isNotSameOrigin() {
    return (
      this.destinationForm.value['destination'] != ''
      && this.destinationForm.value['origin'] != ''
    ) && this.destinationForm.value['destination'] != this.destinationForm.value['origin'];
  }

  errorsFromFormField(field: string) {
    let control = this.destinationForm.controls[field];
    return control.errors;
  }

  searchFlights() {
    this.submitted = true;
  }
}
