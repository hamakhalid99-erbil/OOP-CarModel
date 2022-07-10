# OOP-CarModel
A console Application in C#

## Car Class
A Car class is modeled with the following characteristics:

Model (the car model name. Example: "Audi A4 Avant")

Year (the car model year. Example: 1995)

StartKm (it represents the kilometers at the beginning of a trip. Example: 250)

EndKm (it represents the kilometers at the end of a trip. Example: 447.9)

FuelConsumption (it represents the fuel spent, in liters, on a trip. Example: 220.23)

TravelTime (it represents the trip length in hours. Example: 4.52)

## Functionality
The Car also includes the following functionality:
GetTripLength: It returns the trip distance, in kilometers.

GetSpeed: It returns the average car speed during the trip.

GetFuelEfficiency: It returns the Liters per 100km fuel efficiency. Formula: FuelEfficiency = TripDistance / (FuelConsumption / 100)

ClassifyCar: it returns a message depending on how old a car is:

0 to 1.0 years: "New car, enjoy it!"

1.0 to 3.0 years: "Semi-used car, how is it going?"

3.0 to 5.0 years: "Used car, it's probably a good time to start looking for a new one."

More than 5.0 years: "Old car, please change it!"
