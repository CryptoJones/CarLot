Feature: HybridEngineUsesTwoLessFuelUnits
	The hybrid version of a car should use two less units of fuel than the regular version
@Drive; @Hybrid
Scenario: A hybrid car uses two units less fuel
	Given I have created two versions of the same car
	And one is a hybrid
	When they drive
	Then the hybrid should have two more fuel units then the regular car
