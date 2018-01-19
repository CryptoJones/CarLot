Feature: SomeCarsHaveAHybridEngine
	Some cars can come in a hybrid option

@Hybrid
Scenario: SomeCarsHaveAHybridEngine
	Given I have a car lot
	And I add car with the hybrid option
	Then it should be a hybrid
