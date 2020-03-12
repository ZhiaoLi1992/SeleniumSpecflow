Feature: OnlineShoppingFeature
	Feature to test online shopping

@myTag
Scenario: Add any speaker to cart
	Given I have navigated to home page
	And I see home page fully loaded
	When I click Product
	Then I should see the speakers page shows up
	When I click first speaker in the page
	Then First speaker detail page shows up
	When I click Add to cart

