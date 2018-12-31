Feature: AutotraderSearch
	In order to buy a car of my choice 
	As a customer
	I want to search for a car of my choice

Scenario Outline: Search for car of my choice
	Given I am on Autotrader homepage
	When I enter postcode as "<Postcode>"
	And I select distance from Postcode as "<Distance>"
	And I select the Car Make as "<Make>"
	And I select the Car Model as "<Model>"
	Then I click on the search for car button
	Then the result of car "<Make>" is displayed

Scenarios: 
| Postcode | Distance        | Make   | Model   |
| OL66BJ   | Within 10 miles | Audi   | A3      |
| M345JA   | Within 30 miles | Nissan | Qashqai |