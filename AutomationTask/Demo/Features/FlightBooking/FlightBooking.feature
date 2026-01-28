Feature: FlightBooking
	#interface we use for another person to understand what we are testing and how.

@BookFlight
Scenario: Search for a flight
	Given The user navigates to this url 'https://go.fluege.de'	
	Then The user enter "frankfurt" departure airport name	
	Then The user enter "Palma de Mallorca" destination airport name
	When The user enter start Date "26" september and End Date "17" october
	Then The user enter the amount of passangers "2" of the flight
	Then The user starts the search of flights and clicks on "Fluege finden"
	Then The user click on the filter
	Then the user click on "alle löschen" to clear filter
	Then The user select "swiss" airline
	Then The user click on "Zahlungsmittel" filter
	Then The user clear filter by clicking on "Mastercard" and "Visa" and "Visa Electron" and "American Express" and "Lastschrifft" this leaves only Mastercard Gold selected
	Then The user selects a "flight" from the results
	Then The user enters her "gender" and "Vorname" and "Nachname" and "Geburtstag"
	Then The user enters address details the "street" and "haus number" and "PLZ" and "stadt" 
	Then The user enters contact information "email address" and "confirm email" and "telefon" and selects to be notified "per email"
	Then The user clicks on "weiter zu den Reisenden"
	Then The user enters erwachsener 1 personal data "genre" and "Vorname" and "Nachname" and "Geburtstag"
	Then The user enters personal data of erwachener 2 "genre" and "Vorname" and "Nachname" and "Geburtstag"