Feature: CarLot
	The car lot is the collection of cars
	It should have a max of 25 cars

@CarLot
Scenario: Car Lot can only hold 25 cars
	Given I have a car lot
	And I have 25 cars in the lot
	When I try to add another car
	Then There should be only 25 cars in the lot
