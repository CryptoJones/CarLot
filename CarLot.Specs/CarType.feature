Feature: CarType


@CarTypes
Scenario: Three Car Types Are Available
	Given I have a lot
	When I create a car of each type
	Then I should have three types of cars
