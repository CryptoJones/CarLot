Feature: DifferentCarsTakeDifferentFuels
	Each car should take a different fuel

@mytag
Scenario: Different Cars Take Different Fuel Types
	Given I have created three cars of different types
	Then each car should take a different fuel