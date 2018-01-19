Feature: SemiTruck
	Semi Trucks cost 50K, hold 50 units of fuel, and use Diesel

@SemiTruck
Scenario: SemiTruckCostAndFuel
	Given I have a new semitruck
	Then its cost should be 50K
	And its fuel tank should be 50 units
	And its fuel type should be diesel
