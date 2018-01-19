Feature: CarLotMax
	The maxiumum number of cars a carlot can hold is 25

@AddingCars
Scenario: A carlot holds 25 cars
	Given I have a full carlot
	When I try to add a car
	Then the new car should not be added
