Feature: EachCarHasAnIntegerValueForFuelLevel
	Cars must hold an integer value representing their fuel level

@Fuel
Scenario: Cars must hold an interger value for their fuel level
	Given I loop through each car type
	Then an interger value should be present for each