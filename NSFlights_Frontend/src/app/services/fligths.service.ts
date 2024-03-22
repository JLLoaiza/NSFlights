import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { APIResponse } from '../model/APIResponse';
import { Journey } from '../model/Journey';

@Injectable({
  providedIn: 'root'
})
export class FligthsService {

  private url = environment.flightsServiceURL;

  constructor(private http: HttpClient) { }

  fetchJourneyPath(origin: string, destination: string, maxFlights?: number) {
    let service = 'api/Flight/Journey';

    let params: HttpParams = new HttpParams()
      .set("origin", origin)
      .set("dest", destination)

    if (maxFlights) {
      params = params.set('maxFlights', maxFlights);
    }

    return this.http.get<APIResponse<Journey>>(`${this.url}/${service}`, { params });
  }
}
