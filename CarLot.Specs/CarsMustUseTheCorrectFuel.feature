Feature: CarsMustUseTheCorrectFuel
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Cars must use the correct fuel
	Given I have created three different cars
	And I try to fuel them up with the wrong fuel
	Then they should be disabled
	And I should receive an error message
