Feature: Changes are persisted to the database

Scenario: Persist the event raised by the command handler
	Given I have a command handler
	When I press pass it a command
	Then the resulting event should be persisted to the database
