Feature: RepositoryPersistence

Scenario: Repository persist aggregrates
	Given I have a repository
	When I save an aggregate
	Then the aggregate should be saved to the database
