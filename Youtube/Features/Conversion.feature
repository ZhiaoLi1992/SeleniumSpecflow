Feature: Conversion
	test how specflow support conversions

@mytag
Scenario: Get Transactions 
	Given I have entered customer name as "Test"
	And I have entered customer id as 4510
	And I  select sorting order as DESCENDING
	And I also select number of transactions to be displayed as 30
	Then I  should see my account transactions
