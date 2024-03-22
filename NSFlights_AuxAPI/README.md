# Node.js - Express Aux API

This is an auxiliar API to replace the recruiting [API in maintenance](https://recruiting-api.newshore.es/api/flights)

There are the following airport options:

# Data

```
[
        {
            "DepartureStation": "MZL",
            "ArrivalStation": "JFK",
            "FlightCarrier": "AV",
            "FlightNumber": "8020",
            "Price": 1000.0
        },
        {
            "DepartureStation": "JFK",
            "ArrivalStation": "BCN",
            "FlightCarrier": "AV",
            "FlightNumber": "8040",
            "Price": 1000.0
        },
        {
            "DepartureStation": "BCN",
            "ArrivalStation": "LAX",
            "FlightCarrier": "AV",
            "FlightNumber": "8060",
            "Price": 1200.0
        },
        {
            "DepartureStation": "LAX",
            "ArrivalStation": "SYD",
            "FlightCarrier": "AV",
            "FlightNumber": "8080",
            "Price": 1500.0
        },
        {
            "DepartureStation": "SYD",
            "ArrivalStation": "NRT",
            "FlightCarrier": "AV",
            "FlightNumber": "8100",
            "Price": 1300.0
        },
        {
            "DepartureStation": "NRT",
            "ArrivalStation": "IST",
            "FlightCarrier": "AV",
            "FlightNumber": "8120",
            "Price": 1400.0
        },
        {
            "DepartureStation": "IST",
            "ArrivalStation": "DXB",
            "FlightCarrier": "AV",
            "FlightNumber": "8140",
            "Price": 1100.0
        },
        {
            "DepartureStation": "DXB",
            "ArrivalStation": "BKK",
            "FlightCarrier": "AV",
            "FlightNumber": "8160",
            "Price": 1200.0
        },
        {
            "DepartureStation": "BKK",
            "ArrivalStation": "SIN",
            "FlightCarrier": "AV",
            "FlightNumber": "8180",
            "Price": 1000.0
        },
        {
            "DepartureStation": "SIN",
            "ArrivalStation": "MNL",
            "FlightCarrier": "AV",
            "FlightNumber": "8200",
            "Price": 1100.0
        },
        {
            "DepartureStation": "MNL",
            "ArrivalStation": "HKG",
            "FlightCarrier": "AV",
            "FlightNumber": "8220",
            "Price": 1200.0
        },
        {
            "DepartureStation": "HKG",
            "ArrivalStation": "HND",
            "FlightCarrier": "AV",
            "FlightNumber": "8240",
            "Price": 1100.0
        },
        {
            "DepartureStation": "HND",
            "ArrivalStation": "LHR",
            "FlightCarrier": "AV",
            "FlightNumber": "8260",
            "Price": 1400.0
        },
        {
            "DepartureStation": "LHR",
            "ArrivalStation": "CDG",
            "FlightCarrier": "AV",
            "FlightNumber": "8280",
            "Price": 900.0
        },
        {
            "DepartureStation": "CDG",
            "ArrivalStation": "FRA",
            "FlightCarrier": "AV",
            "FlightNumber": "8300",
            "Price": 800.0
        },
        {
            "DepartureStation": "FRA",
            "ArrivalStation": "AMS",
            "FlightCarrier": "AV",
            "FlightNumber": "8320",
            "Price": 700.0
        },
        {
            "DepartureStation": "AMS",
            "ArrivalStation": "CPH",
            "FlightCarrier": "AV",
            "FlightNumber": "8340",
            "Price": 600.0
        },
        {
            "DepartureStation": "CPH",
            "ArrivalStation": "ARN",
            "FlightCarrier": "AV",
            "FlightNumber": "8360",
            "Price": 500.0
        },
        {
            "DepartureStation": "ARN",
            "ArrivalStation": "OSL",
            "FlightCarrier": "AV",
            "FlightNumber": "8380",
            "Price": 400.0
        },
        {
            "DepartureStation": "OSL",
            "ArrivalStation": "HEL",
            "FlightCarrier": "AV",
            "FlightNumber": "8400",
            "Price": 300.0
        }
    ]
```

# How to start

```sh
# install dependencies
npm install

# run on port 4000
node index.js
```