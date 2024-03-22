export class Journey {
    origin: string;
    destination: string;
    price: number;
    flights: Flight[];

    constructor(
        origin: string, destination: string, price: number, flights: Flight[]
    ) {
        this.origin = origin;
        this.destination = destination;
        this.price = price;
        this.flights = flights;
    }
}

export class Flight {
    origin: string;
    destination: string;
    transport: Transport;
    price: number

    constructor(
        origin: string, destination: string, transport: Transport, price: number,
    ) {
        this.origin = origin;
        this.destination = destination;
        this.transport = transport;
        this.price = price;
    }
}

export class Transport {
    flightCarrier: string;
    flightNumber: string;

    constructor(flightCarrier: string, flightNumber: string) {
        this.flightCarrier = flightCarrier
        this.flightNumber = flightNumber
    }
}