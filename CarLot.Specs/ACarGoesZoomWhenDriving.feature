Feature: ACarGoesZoomWhenDriving
	When a car drives it goes zoom

@mytag
Scenario: A car goes zoom when driving
	Given I have created a new carlot
	When I create a car
	And I drive it
	Then it should go zoom
