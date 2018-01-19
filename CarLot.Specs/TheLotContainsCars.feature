Feature: TheLotContainsCars
	Verify the lot can contain a car

@Cars
Scenario: TheLotContainsCarsWhenACarIsAdded
	Given I have car lot
	Then I can add a car
