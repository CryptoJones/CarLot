Feature: EachCarHasAnIntegerValueForItsPrice
	Each car has an integer value for fuel

@Fuel
Scenario: Cars Must Hold an IntegerValue for Their Fuel Level
	Given I create a car of each type and loop through them
	Then each car should have an integer value with its price
