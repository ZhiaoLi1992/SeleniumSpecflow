@Important
Feature: SAT
	practice step argument transformation

@SAT
Scenario: Update User Password
    Given The original user was created over 10 days ago
    When I update the users password to "some password"
    Then I should see the following errors
        | ErrorCode         | ErrorDescription          |
        | 442               | Out of date user          |
        | 28                | Changes were not saved    |