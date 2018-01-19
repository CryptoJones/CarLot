Feature: CarsGoBeepWhenHonking
	Cars go beep when honking

@Actions
Scenario: A car Goes beep when honking
	Given I have a car
	And I honk it
	Then it should go beep
