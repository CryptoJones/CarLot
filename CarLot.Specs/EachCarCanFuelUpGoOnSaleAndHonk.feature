Feature: EachCarCanFuelUpGoOnSaleAndHonk
	Each car can Drive, Fuel Up, go on sale, and honk

@mytag
Scenario: Test Each Car to Drive, FuelUp, Go on Sale and Honk
	Given I create a car for every car type
	And I loop through them
	Then each car should be able to honk, go on sale, drive and fuel up
