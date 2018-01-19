Feature: CarDefaults
	By default cars;
	have 14 units of fuel
	use three units of fuel for driving
	cost 20000
	go on sale for 20% off

@Defaults
Scenario: Check Car Defaults
	Given I create a car of each type
	Then if the car doesn't have specific rules, it should follow these defaults
