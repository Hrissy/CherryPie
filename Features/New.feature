Feature: Sales
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	

Scenario: Verify message is displayed when user has not transactions
	Given Have opened SumUp url
	And Test user has logged in
    And Page "Dashboard" has loaded
    When Sales tab is selected
    And Page "Sales" has loaded
    Then Message "We couldn’t find anything that matches your search." is displayed 
 


