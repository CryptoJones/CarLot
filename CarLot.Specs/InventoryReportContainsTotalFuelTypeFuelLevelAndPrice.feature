Feature: InventoryReportContainsTotalFuelTypeFuelLevelAndPrice
An inventory reports should contain every car with fuel type, fuel level and price.

@InventoryReport
Scenario: An inventory report is generated
	Given I have created some cars
	When I generate an inventory report
	Then it should contain the car count, fuel type, fuel level and price
