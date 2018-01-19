Feature: FunnyCar
	Funny cars use 14 units of fuel and require methanol

@FunnyCar
Scenario: Funny cars use 14 units of fuel 
	Given I have a new funny car
	Then its fuel type should be methanol
	And I drive it
	Then the tank should be empty