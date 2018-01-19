Feature: ThreeFuelsAreAvailable
There should be three fuels available

@Fuel
Scenario: Three fuels are available
	Given I look at all fuels
	Then there should be a total of three
	And methanol, gas and diesel should be available
