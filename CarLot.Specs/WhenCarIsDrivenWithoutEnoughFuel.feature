Feature: WhenCarIsDrivenWithoutEnoughFuel
When a car is driven without enough fuel,
 its fuel level goes to zero, and the driver recieves a message

@Fuel
Scenario: Drive a Car to Empty Check its Fuel and Try to Drive Again
	Given I have a car with an empty tank
	And I try to drive it
	Then I will get an error message
	And The fuel level will be zero
