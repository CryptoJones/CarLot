Feature: Pinto
Pintos go on sale for 75% off, and use gas.

@Pinto
Scenario: Pintos go on sale for 75% off and use gas
	Given I have created a new pinto
	And I fuel it up with gas
	Then the result should be the car is fueled
	And when I discount it
	Then the price should be 25 percent of the original price
