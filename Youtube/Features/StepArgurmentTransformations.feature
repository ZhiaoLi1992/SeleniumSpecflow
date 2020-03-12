Feature: Step Argurment Transformations

@mytag
Scenario: Convert timestamp to minutes - variant 1
 
Given I have entered 50 days into the timestamp to minute converter
When I press calculate
Then the result should be 72000.00 on the screen

Scenario: Convert timestamp to minutes - variant 2
 
Given I have entered 1 day, 2 hours, 3 minutes into the timestamp to minute converter 
When I press calculate
Then the result should be 1563.00 on the screen

Scenario: Convert timestamp to minutes - variant 3
 
Given I have entered 1 day, 1 hour, 1 minute, 30 seconds into the timestamp to minute converter
When I press calculate
Then the result should be 1501.50 on the screen

Scenario: Convert timestamp to minutes - variant 4
 
Given I have entered 4 days, 12 hours, 12 minutes, 30 seconds into the timestamp to minute converter
When I press calculate
Then the result should be 6492.50 on the screen

Scenario: Convert timestamp to minutes - variant 5
 
Given I have entered 12 minutes into the timestamp to minute converter
When I press calculate
Then the result should be 12.00 on the screen
