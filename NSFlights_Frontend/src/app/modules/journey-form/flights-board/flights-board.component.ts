import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Journey } from 'src/app/model/Journey';
import { FligthsService } from 'src/app/services/fligths.service';

@Component({
  selector: 'app-flights-board',
  templateUrl: './flights-board.component.html',
  styleUrls: ['./flights-board.component.scss']
})
export class FlightsBoardComponent implements OnInit {
  origin: string = '';
  destination: string = '';
  fetchingFlights: boolean = false;

  flights?: Journey;

  constructor(
    private route: ActivatedRoute,
    private flightsService: FligthsService,
    private router: Router,
  ) { }

  ngOnInit(): void {
    this.route.queryParamMap
      .subscribe((params) => {
        this.origin = String(params.get('origin'));
        this.destination = String(params.get('destination'));
        this.fetchPath();
      });
  }

  fetchPath() {
    this.fetchingFlights = true;

    if (!this.origin || !this.destination) {
      this.router.navigate(['..']);
    }

    this.flightsService.fetchJourneyPath(this.origin, this.destination)
      .subscribe(data => {
        this.fetchingFlights = false;

        console.log(data.value);
      });
  }
}