Feature: Sales
 Testing sales page 
	
    @Sales
Scenario: Verify message is displayed when user has not transactions
	Given Have opened SumUp url
	And Test user has logged in
    And Page "Dashboard" has loaded
    When Sales tab is selected
    And Page "Sales" has loaded
    Then Message "We couldn’t find anything that matches your search." is displayed 
 


