import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Currencies, Currency } from 'src/app/model/Currencies';
import { Journey } from 'src/app/model/Journey';
import { CurrenciesService } from 'src/app/services/currencies.service';
import { FligthsService } from 'src/app/services/fligths.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-flights-board',
  templateUrl: './flights-board.component.html',
  styleUrls: ['./flights-board.component.scss']
})
export class FlightsBoardComponent implements OnInit {
  origin: string = '';
  destination: string = '';
  fetchingFlights: boolean = false;

  actualCurrency: string = environment.actualCurrency;

  currencies: Currencies;
  exchangeCurrency: string;
  exchangeRate?: number;

  flights?: Journey;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private flightsService: FligthsService,
    private currencyService: CurrenciesService
  ) {
    this.actualCurrency = environment.actualCurrency;
    this.exchangeCurrency = environment.actualCurrency;
    this.currencies = [];
  }

  ngOnInit(): void {
    this.currencies = this.currencyService.getCurrencies().sort((a, b) => a.name.localeCompare(b.name));

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

        this.flights = data.value;
      });
  }

  exhangeCurrency(value: number) {
    if (!this.exchangeCurrency
      || this.exchangeCurrency == this.actualCurrency) return value;

    let rate = this.currencyService.getExchange(this.exchangeCurrency);

    return (value * rate).toFixed(2);
  }

  getISOCurrency() {
    return this.currencies.find(it => it.key == this.exchangeCurrency)!.key.toLocaleUpperCase();
  }
}