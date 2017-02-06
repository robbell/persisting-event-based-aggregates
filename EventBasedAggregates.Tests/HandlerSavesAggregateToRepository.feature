Feature: Handler saves aggregate to repository

Scenario: Persist the aggregate to the repository
	Given I have a command handler
	When I press pass it a command
	Then the resulting event should be persisted to the database
